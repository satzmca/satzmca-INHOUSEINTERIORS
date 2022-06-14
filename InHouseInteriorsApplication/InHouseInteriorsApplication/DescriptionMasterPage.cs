using InHouseInteriorsApplication.Class;
using Newtonsoft.Json;
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
    public partial class DescriptionMasterPage : Form
    {
        ClassConfig cls = new ClassConfig();
        public DescriptionMasterPage()
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
                cls.WriteException("DescriptionMasterPage : PctClose_Click" + ex.ToString());
            }
        }

        private void TxtRate_KeyPress(object sender, KeyPressEventArgs e)
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

            if (Regex.IsMatch(txtRate.Text, @"\.\d\d\d\d"))
            {
                e.Handled = true;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescription.Text != "" && txtWeight.Text != "" && txtRate.Text != "")
                {
                    string res = "";
                    if (txtDes_id.Text !="")
                    {
                        var dict = JObject.Parse(@"{'Description':'" + txtDescription.Text + "', 'Weight':'" + txtWeight.Text + "', 'Rate':'" + txtRate.Text + "', 'Description_id':'" + txtDes_id.Text + "', 'Size_id':'" + cmbSizeFormula.SelectedValue + "', 'Total_id':'" + cmbTotalFormula.SelectedValue + "'}");
                        res = cls.InsertData(SpName: "USP_Description_Insert", ReqType: "UPDATE_DESCRIPTION", dict: dict);
                    }
                    else
                    {
                        var dict = JObject.Parse(@"{'Description':'" + txtDescription.Text + "', 'Weight':'" + txtWeight.Text + "', 'Rate':'" + txtRate.Text + "', Size_id':'" + cmbSizeFormula.SelectedValue + "', Total_id':'" + cmbTotalFormula.SelectedValue + "'}");
                        res = cls.InsertData(SpName: "USP_Description_Insert", ReqType: "INSERT_DESCRIPTION", dict: dict);
                    }
                   
                    if (res == "1")
                    {
                        MessageBox.Show("Saved Successfully");
                        Clear();
                        bind();
                    }
                    else
                    {
                        MessageBox.Show("Already Exists");
                    }
                }
                else
                {
                    MessageBox.Show("Fill All The Fields");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("DescriptionMasterPage : BtnSave_Click" + ex.ToString());
            }
        }

        private void DescriptionMasterPage_Load(object sender, EventArgs e)
        {
            try
            {
                bind();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("DescriptionMasterPage : DescriptionMasterPage_Load" + ex.ToString());
            }
        }

        public void bind()
        {
            DataTable dt = new DataTable();
            dt = cls.FetchData(SpName: "USP_Description_Insert", ReqType: "SELECT_DESCRIPTION");
            dgvDescription.AutoGenerateColumns = false;
            dgvDescription.DataSource = dt;


            DataTable dt1 = new DataTable();
            dt1 = cls.FetchData(SpName: "USP_Description_Insert", ReqType: "SELECT_FORMULA");
            cmbSizeFormula.DisplayMember = "Formula";
            cmbSizeFormula.ValueMember = "Formula_id";
            cmbSizeFormula.DataSource = dt1;
            cmbSizeFormula.SelectedValue = 0;

            DataTable dt2 = new DataTable();
            dt2 = cls.FetchData(SpName: "USP_Description_Insert", ReqType: "SELECT_FORMULA");
            cmbTotalFormula.DisplayMember = "Formula";
            cmbTotalFormula.ValueMember = "Formula_id";
            cmbTotalFormula.DataSource = dt2;
            cmbTotalFormula.SelectedValue = 0;
        }

        private void DgvDescription_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvDescription.Rows[e.RowIndex];
                    txtDes_id.Text = row.Cells[0].Value.ToString();
                    txtDescription.Text = row.Cells[1].Value.ToString();
                    txtWeight.Text = row.Cells[2].Value.ToString();
                    txtRate.Text = row.Cells[3].Value.ToString();
                    cmbSizeFormula.SelectedValue = row.Cells[4].Value;
                    cmbTotalFormula.SelectedValue = row.Cells[5].Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("DescriptionMasterPage : DgvDescription_CellClick" + ex.ToString());
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDes_id.Text != "")
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete '" + txtDescription.Text + "' ??", "Confirm!!", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        var dict = JObject.Parse(@"{'Description_id':'" + txtDes_id.Text + "'}");
                        string res = cls.InsertData(SpName: "USP_Description_Insert", ReqType: "DELETE_DESCRIPTION", dict: dict);
                        if (res == "1")
                        {
                            MessageBox.Show("Saved Successfully");
                            Clear();
                            bind();
                        }                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("DescriptionMasterPage : BtnDelete_Click" + ex.ToString());
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            try
            {                
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("DescriptionMasterPage : BtnReset_Click" + ex.ToString());
            }
        }

        public void Clear()
        {
            txtDescription.Text = "";
            txtWeight.Text = "";
            txtRate.Text = "";
            txtDes_id.Text = "";
            cmbSizeFormula.SelectedValue = 0;
            cmbTotalFormula.SelectedValue = 0;
        }

        private void TxtWeight_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
