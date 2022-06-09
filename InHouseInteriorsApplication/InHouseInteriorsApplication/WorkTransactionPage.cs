using InHouseInteriorsApplication.Class;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InHouseInteriorsApplication
{
    public partial class WorkTransactionPage : Form
    {
        ClassConfig cls = new ClassConfig();
        public WorkTransactionPage()
        {
            InitializeComponent();

            int style = ClassConfig.NativeWinAPI.GetWindowLong(this.Handle, ClassConfig.NativeWinAPI.GWL_EXSTYLE);
            style |= ClassConfig.NativeWinAPI.WS_EX_COMPOSITED;
            ClassConfig.NativeWinAPI.SetWindowLong(this.Handle, ClassConfig.NativeWinAPI.GWL_EXSTYLE, style);
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
                cls.WriteException("WorkTransaction : PctClose_Click" + ex.ToString());
            }
        }

        private void WorkTransactionPage_Load(object sender, EventArgs e)
        {
            try
            {
                bindWork();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : PartyMasterPage_Load" + ex.ToString());
            }
        }

        public void bindWork()
        {
            DataTable workdt = new DataTable();


            cmbWorkName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbWorkName.AutoCompleteSource = AutoCompleteSource.ListItems;

            var dict = JObject.Parse(@"{'IsWorkSelect':'Y'}");
            workdt = cls.FetchData(SpName: "USP_Work_Insert", ReqType: "SELECT_WORK", dict);
            //DataRow dr = workdt.NewRow();
            //dr["Work_id"] = 0;
            //dr["WorkName"] = "--Select--";
            //workdt.Rows.Add(dr);
            cmbWorkName.DisplayMember = "WorkName";
            cmbWorkName.ValueMember = "Work_id";
            cmbWorkName.DataSource = workdt;

        }

        private void CmbWorkName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bind();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : CmbWorkName_SelectedIndexChanged" + ex.ToString());
            }
        }

        public void bind()
        {
            DataTable dt = new DataTable();

            if (cmbWorkName.SelectedValue.ToString() != "0" && cmbWorkName.SelectedValue.ToString() != "")
            {
                var dict = JObject.Parse(@"{'Work_id':'" + cmbWorkName.SelectedValue + "'}");
                dt = cls.FetchData(SpName: "USP_WorkDetail_Select", ReqType: "SELECT_WORKDETAIL", dict: dict);

                dgvWork.AutoGenerateColumns = false;
                dgvWork.DataSource = dt;

            }
        }

        private void TxtWidth_TextChanged(object sender, EventArgs e)
        {
            try
            {             
                if(txtWidth.Text != "" && txtHeight.Text != "")
                {
                    double BoxSqftVal = (Convert.ToDouble(txtWidth.Text) * Convert.ToDouble(txtHeight.Text)) / 92900;
                    txtBoxSqFt.Text = Math.Round(BoxSqftVal,5).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : TxtWidth_TextChanged" + ex.ToString());
            }
        }

        private void TxtHeight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtWidth.Text != "" && txtHeight.Text != "")
                {
                    double BoxSqftVal = (Convert.ToDouble(txtWidth.Text) * Convert.ToDouble(txtHeight.Text)) / 92900;
                    txtBoxSqFt.Text = Math.Round(BoxSqftVal, 5).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : TxtHeight_TextChanged" + ex.ToString());
            }
        }

        private void TxtDepth_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDepth.Text != "")
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : TxtDepth_TextChanged" + ex.ToString());
            }
        }

        private void TxtShelfQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtShelfQty.Text != "")
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : TxtShelfQty_TextChanged" + ex.ToString());
            }
        }

        private void TxtShutterQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtShutterQty.Text != "")
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : TxtShutterQty_TextChanged" + ex.ToString());
            }
        }

        private void TxtBoxQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxQty.Text != "")
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : TxtBoxQty_TextChanged" + ex.ToString());
            }
        }

        private void TxtBoxSqFt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxSqFt.Text != "")
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : TxtBoxSqFt_TextChanged" + ex.ToString());
            }
        }        

        private void TxtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (Regex.IsMatch(txtWidth.Text, @"\.\d\d\d\d"))
            {
                e.Handled = true;
            }
        }

        private void TxtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (Regex.IsMatch(txtHeight.Text, @"\.\d\d\d\d"))
            {
                e.Handled = true;
            }
        }

        private void TxtDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (Regex.IsMatch(txtDepth.Text, @"\.\d\d\d\d"))
            {
                e.Handled = true;
            }
        }

        private void TxtShelfQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (Regex.IsMatch(txtShelfQty.Text, @"\.\d\d\d\d"))
            {
                e.Handled = true;
            }
        }

        private void TxtShutterQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (Regex.IsMatch(txtShutterQty.Text, @"\.\d\d\d\d"))
            {
                e.Handled = true;
            }
        }

        private void TxtBoxQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (Regex.IsMatch(txtBoxQty.Text, @"\.\d\d\d\d"))
            {
                e.Handled = true;
            }
        }

        private void TxtBoxSqFt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (Regex.IsMatch(txtBoxSqFt.Text, @"\.\d\d\d\d"))
            {
                e.Handled = true;
            }
        }
    }
}
