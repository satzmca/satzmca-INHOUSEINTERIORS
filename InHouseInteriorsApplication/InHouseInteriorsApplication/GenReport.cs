using InHouseInteriorsApplication.Class;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace InHouseInteriorsApplication
{
    public partial class GenReport : Form
    {
        ClassConfig cls = new ClassConfig();

        DataSet ds = new DataSet();

        public SqlConnection _conn = new SqlConnection();

        string _con = ConfigurationManager.ConnectionStrings["InHouseInteriorsApplication.Properties.Settings.InHouseInteriors"].ToString();

      
        public GenReport()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            _conn.ConnectionString = _con;
            LoadJORecords();
        }


        private void LoadJORecords()
        {
            using (SqlConnection con = new SqlConnection(_con))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                DataTable dtjo = new DataTable();
                SqlCommand _cmd = new SqlCommand("USP_Quotation_Insert", con);
                _cmd.CommandType = CommandType.StoredProcedure; 

                _cmd.Parameters.AddWithValue("@ReqType", "SELECT_QUOTATION");
                SqlDataAdapter adOP = new SqlDataAdapter(_cmd);
                adOP.Fill(dtjo);

                cmbJobOrderNo.DataSource = dtjo;
                cmbJobOrderNo.DisplayMember = "QNo";
                cmbJobOrderNo.ValueMember = "Q_Id";

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }
        }


        private void btnPdf_Click(object sender, EventArgs e)
        {
            DataTable dtjo = new DataTable();
            dtjo.Columns.Add("ReqType");
            dtjo.Columns.Add("Q_Id");

            dtjo.Rows.Add("Quotation", cmbJobOrderNo.SelectedValue);


            Form frm = Application.OpenForms["FrmReport"];
            if (frm == null)
            {
                FrmReport frmr = new FrmReport();
                frmr.dtRepParam = dtjo;
                frmr.Show();

            }
            else
            {
                frm.Hide();
                FrmReport frmr = new FrmReport();
                frmr.dtRepParam = dtjo;
                frmr.Show();
            }
        }
}
}
