using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InHouseInteriorsApplication.Class
{
    class ClassConfig
    {
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["INHOUSEINTERIORS"].ToString());
        public static DataTable UserTable;
        public static string UserName = null;


        internal static class NativeWinAPI
        {
            internal static readonly int GWL_EXSTYLE = -20;
            internal static readonly int WS_EX_COMPOSITED = 0x02000000;

            [DllImport("user32")]
            internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32")]
            internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        }
        public void opencon()
        {
            try
            {
                if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
                {
                    con.Open();
                }
            }
            catch(Exception ex)
            {
                con.Close();
                WriteException("ClassConfig : opencon" + ex.ToString());
            }
        }
        public void closecon()
        {
            if (con.State == ConnectionState.Open || con.State == ConnectionState.Connecting) { con.Close(); }
        }


        public DataTable FetchData(string SpName, string ReqType, JObject dict = null)
        {

            //var dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);            
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adr = new SqlDataAdapter();
            try
            {
                opencon();
                cmd = new SqlCommand(SpName, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReqType", ReqType);
                if(dict !=null)
                {
                    foreach (var kv in dict)
                    {
                        cmd.Parameters.AddWithValue("@" + kv.Key, kv.Value.ToString());
                    }
                }
                              
                adr = new SqlDataAdapter(cmd);
                adr.Fill(dt);
                closecon();
            }
            catch (Exception ex)
            {
                WriteException("ClassConfig : FetchData" + ex.ToString());
            }
            return dt;
        }

        public string InsertData(string SpName, string ReqType, JObject dict = null)
        {            
            try
            {
                string _res = "0";
                opencon();
                using (SqlCommand cmd = new SqlCommand(SpName, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ReqType", ReqType);
                    if (dict != null)
                    {
                        foreach (var kv in dict)
                        {
                            cmd.Parameters.AddWithValue("@" + kv.Key, kv.Value.ToString());
                        }
                    }
                    cmd.Parameters.Add("@OUTPUT", SqlDbType.Int, 10).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    int val = Convert.ToInt32(cmd.Parameters["@OUTPUT"].Value);
                    if (val > 0)
                        return "1";
                    else return _res;
                }
                closecon();
                return _res;
            }
            catch(Exception ex)
            {
                WriteException("ClassConfig : InsertData" + ex.ToString());
                return "0";
            }            
        }

        public void WriteException(string str)
        {
            try
            {
                if (!File.Exists("FILENAME.txt")) // If file does not exists
                {
                    File.Create("FILENAME.txt").Close(); // Create file
                    using (StreamWriter sw = File.AppendText("FILENAME.txt"))
                    {
                        sw.WriteLine(str); // Write text to .txt file
                    }
                }
                else // If file already exists
                {
                    // File.WriteAllText("FILENAME.txt", String.Empty); // Clear file
                    using (StreamWriter sw = File.AppendText("FILENAME.txt"))
                    {
                        sw.WriteLine(str); // Write text to .txt file
                    }
                }
            }
            catch(Exception e)
            {

            }
        }

    }
}
