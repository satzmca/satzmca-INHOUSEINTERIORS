namespace InHouseInteriorsApplication.Report
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for RptQuotation.
    /// </summary>
    public partial class RptQuotation : Telerik.Reporting.Report
    {
        public RptQuotation()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void pictureBox1_ItemDataBinding(object sender, EventArgs e)
        {

        }
    }
}