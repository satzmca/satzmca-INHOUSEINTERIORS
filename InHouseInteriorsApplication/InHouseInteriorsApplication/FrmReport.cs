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
        public FrmReport()
        {
            InitializeComponent();

           // this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            //this.reportViewer1.RefreshReport();
            RptQuotation r = new RptQuotation();
            this.reportViewer1.ReportSource = r;
            this.reportViewer1.RefreshReport();
        }
    }
}
