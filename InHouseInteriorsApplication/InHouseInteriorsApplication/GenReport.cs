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

        public DataTable dtRepParam = new DataTable();

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
            dtRepParam = dtjo;


            var uriReportSource = new Telerik.Reporting.UriReportSource();

            //Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();

            if (dtRepParam.Rows.Count > 0)
            {
                if (dtRepParam.Rows[0]["ReqType"].ToString() == "Quotation")
                {
                    InHouseInteriorsApplication.Report.RptQuotation r = new InHouseInteriorsApplication.Report.RptQuotation();

                    r.Report.ReportParameters["ReqType"].Value = dtRepParam.Rows[0]["ReqType"].ToString();

                    if (dtRepParam.Rows[0]["Q_Id"].ToString() != "" && dtRepParam.Rows[0]["Q_Id"].ToString() != null)
                        r.Report.ReportParameters["Q_Id"].Value = dtRepParam.Rows[0]["Q_Id"].ToString();


                    this.reportViewer1.ReportSource = r;
                    this.reportViewer1.RefreshReport();
                }
            }

            //Form frm = Application.OpenForms["FrmReport"];
            //if (frm == null)
            //{
            //    FrmReport frmr = new FrmReport();
            //    frmr.dtRepParam = dtjo;
            //    frmr.Show();

            //}
            //else
            //{
            //    frm.Hide();
            //    FrmReport frmr = new FrmReport();
            //    frmr.dtRepParam = dtjo;
            //    frmr.Show();
            //}
        }

        private void PctClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("GenReport : PctClose_Click" + ex.ToString());
            }
        }
    }
}
