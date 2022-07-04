using InHouseInteriorsApplication.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InHouseInteriorsApplication
{
    public partial class FrmReport : Form
    {
        public DataTable dtRepParam = new DataTable();

        public FrmReport()
        {
            InitializeComponent();

            // this.reportViewer1.RefreshReport();
        }

        //private void reportViewer1_Load(object sender, EventArgs e)
        //{
        //    //this.reportViewer1.RefreshReport();
        //    RptQuotation r = new RptQuotation();
        //    this.reportViewer1.ReportSource = r;
        //    this.reportViewer1.RefreshReport();
        //}

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

        }



    }
}
