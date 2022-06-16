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
    public partial class FormulaMasterPage : Form
    {
        ClassConfig cls = new ClassConfig();
        public FormulaMasterPage()
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
                cls.WriteException("FormulaMasterPage : PctClose_Click" + ex.ToString());
            }
        }

        private void FormulaMasterPage_Load(object sender, EventArgs e)
        {
            try
            {
                txtFormula.Text = "";
                bind();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("FormulaMasterPage : FormulaMasterPage_Load" + ex.ToString());
            }
        }

        public void bind()
        {
            DataTable dt = new DataTable();
            dt = cls.FetchData(SpName: "USP_FormulaTypeInsert", ReqType: "SELECT_FORMULATYPE");
            cmbTypeName.DisplayMember = "FType";
            cmbTypeName.ValueMember = "FType_id";
            cmbTypeName.DataSource = dt;
            cmbTypeName.SelectedValue = 0;

            cmbOperators.SelectedIndex = 0;

            DataTable dt1 = new DataTable();
            dt1 = cls.FetchData(SpName: "USP_FormulaTypeInsert", ReqType: "SELECT_FORMULA");
            dgvFormula.AutoGenerateColumns = false;
            dgvFormula.DataSource = dt1;
        }

        private void BtnAdd1_Click(object sender, EventArgs e)
        {
            if (cmbTypeName.Text != "--Select--")
            {
                if (txtFormula.Text != "")
                    txtFormula.Text += "_" + cmbTypeName.Text.ToString();
                else
                    txtFormula.Text += cmbTypeName.Text.ToString();
            }
                
        }

        private void BtnAdd2_Click(object sender, EventArgs e)
        {
            if (cmbOperators.Text != "--Select--")
            {
                if (txtFormula.Text != "")
                    txtFormula.Text += "_" + cmbOperators.Text.ToString();
                else
                    txtFormula.Text += cmbOperators.Text.ToString();
            }
        }

        private void BtnAdd3_Click(object sender, EventArgs e)
        {
            if (txtNumbers.Text != "")
            {
                if (txtFormula.Text != "")
                    txtFormula.Text += "_" + txtNumbers.Text.ToString();
                else
                    txtFormula.Text += txtNumbers.Text.ToString();
            }
        }

        private void TxtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtFormula_id.Text = "";
            txtFormula.Text = "";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFormula.Text != "")
                {
                    string res = "";
                    if (txtFormula_id.Text != "")
                    {
                        var dict = JObject.Parse(@"{'Formula':'" + txtFormula.Text + "', 'Formula_id':'" + txtFormula_id.Text + "'}");
                        res = cls.InsertData(SpName: "USP_FormulaTypeInsert", ReqType: "UPDATE_FORMULA", dict: dict);
                    }
                    else
                    {
                        var dict = JObject.Parse(@"{'Formula':'" + txtFormula.Text + "'}");
                        res = cls.InsertData(SpName: "USP_FormulaTypeInsert", ReqType: "INSERT_FORMULA", dict: dict);
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
                cls.WriteException("FormulaMasterPage : BtnSave_Click" + ex.ToString());
            }
        }


        public void Clear()
        {
            txtFormula.Text = "";
            txtFormula_id.Text = "";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFormula_id.Text != "")
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete '" + txtFormula.Text + "' ??", "Confirm!!", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        var dict = JObject.Parse(@"{'Formula_id':'" + txtFormula_id.Text + "'}");
                        string res = cls.InsertData(SpName: "USP_FormulaTypeInsert", ReqType: "DELETE_FORMULA", dict: dict);
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
                cls.WriteException("FormulaMasterPage : BtnDelete_Click" + ex.ToString());
            }
        }

        private void DgvDescription_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvFormula.Rows[e.RowIndex];
                    txtFormula_id.Text = row.Cells[0].Value.ToString();
                    txtFormula.Text = row.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("FormulaMasterPage : DgvDescription_CellClick" + ex.ToString());
            }
        }

        private void TxtNumbers_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNumbers_KeyPress(object sender, KeyPressEventArgs e)
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

            if (Regex.IsMatch(txtNumbers.Text, @"\.\d\d\d\d"))
            {
                e.Handled = true;
            }
        }

        

        
    }
}
