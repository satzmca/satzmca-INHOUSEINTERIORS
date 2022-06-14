using InHouseInteriorsApplication.Class;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace InHouseInteriorsApplication
{
    public partial class LoginPage : Form
    {
        ClassConfig cls = new ClassConfig();
        
        public LoginPage()
        {
            InitializeComponent();
            int style = ClassConfig.NativeWinAPI.GetWindowLong(this.Handle, ClassConfig.NativeWinAPI.GWL_EXSTYLE);
            style |= ClassConfig.NativeWinAPI.WS_EX_COMPOSITED;
            ClassConfig.NativeWinAPI.SetWindowLong(this.Handle, ClassConfig.NativeWinAPI.GWL_EXSTYLE, style);
        }
      
        private void LoginPage_Load(object sender, EventArgs e)
        {
            //String math = "(10+4)*2";
            //string value = new DataTable().Compute(math, null).ToString();

            //double r = Math.Round(Convert.ToDouble(value),5);
            //double result = Math.Round(Evaluate(math),5);

            timer1.Start();
            //var dict = JObject.Parse(@"{'UserName':'"+txtUserName.Text+"'}");            
            ClassConfig.UserTable = cls.FetchData(SpName: "USP_UsersSelect", ReqType: "SELECT_USER");
        }

        //public static double Evaluate(string expression)
        //{
        //    var xsltExpression =
        //        string.Format("number({0})",
        //            new Regex(@"([\+\-\*])").Replace(expression, " ${1} ")
        //                                    .Replace("/", " div ")
        //                                    .Replace("%", " mod "));

        //    // ReSharper disable PossibleNullReferenceException
        //    return (double)new XPathDocument
        //        (new StringReader("<r/>"))
        //            .CreateNavigator()
        //            .Evaluate(xsltExpression);
        //    // ReSharper restore PossibleNullReferenceException
        //}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtUserName.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Invalid Username & Password");
                }
                else
                {
                    DataRow[] rslt = ClassConfig.UserTable.Select("UserName='" + txtUserName.Text + "' AND Password = '" + txtPassword.Text + "'");
                    if (rslt.Length > 0)
                    {
                        DataTable dt = rslt.CopyToDataTable();

                        if (dt.Rows.Count > 0)
                        {
                            ClassConfig.UserName = dt.Rows[0]["LoginName"].ToString();
                            MainPage mainpage = new MainPage();
                            mainpage.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username & Password");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("Login Page : btnLogin_Click" + ex.ToString());
            }


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }        

        private void PctClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("Login Page : PctClose_Click" + ex.ToString());
            }
            
        }

        private void PicLogin_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("Login Page : PicLogin_Click" + ex.ToString());
            }
        }
    }
}
