using InHouseInteriorsApplication.Class;
using Newtonsoft.Json.Linq;
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
    public partial class FormulaAssignMasterPage : Form
    {
        ClassConfig cls = new ClassConfig();
        public FormulaAssignMasterPage()
        {
            InitializeComponent();
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
                cls.WriteException("FormulaAssignMasterPage : PctClose_Click" + ex.ToString());
            }
        }

        private void FormulaAssignMasterPage_Load(object sender, EventArgs e)
        {
            try
            {
                bind();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("FormulaAssignMasterPage : FormulaAssignMasterPage_Load" + ex.ToString());
            }
        }

        public void bind()
        {
            DataTable workdt = new DataTable();

            cmbWorkName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbWorkName.AutoCompleteSource = AutoCompleteSource.ListItems;
            var dict = JObject.Parse(@"{'IsWorkSelect':'Y'}");
            workdt = cls.FetchData(SpName: "USP_Work_Insert", ReqType: "SELECT_WORK", dict);            
            cmbWorkName.DisplayMember = "WorkName";
            cmbWorkName.ValueMember = "Work_id";
            cmbWorkName.DataSource = workdt;


            cmbDescription.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbDescription.AutoCompleteSource = AutoCompleteSource.ListItems;
            DataTable descdt = new DataTable();
            var dict1 = JObject.Parse(@"{'IsDescriptionSelect':'Y'}");
            descdt = cls.FetchData(SpName: "USP_Description_Insert", ReqType: "SELECT_DESCRIPTION", dict1);
            cmbDescription.DisplayMember = "Description";
            cmbDescription.ValueMember = "Description_id";
            cmbDescription.DataSource = descdt;

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

            bindwork();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbWorkName.SelectedValue != null && cmbWorkName.SelectedValue.ToString() != "0" && cmbDescription.SelectedValue != null && cmbDescription.SelectedValue.ToString() != "0")
                {
                    string res = "";
                    if (txtFAssign_id.Text != "")
                    {
                        var dict = JObject.Parse(@"{'Work_id':'" + cmbWorkName.SelectedValue.ToString() + "', 'Description_id':'" + cmbDescription.SelectedValue.ToString() + "', 'FSize_id':'" + cmbSizeFormula.SelectedValue.ToString() + "', 'FTotal_id':'" + cmbTotalFormula.SelectedValue.ToString() + "', 'FAssign_id':'" + txtFAssign_id.Text + "'}");
                        res = cls.InsertData(SpName: "USP_FormulaAssign_Insert", ReqType: "UPDATE_ASSIGNFORMULA", dict: dict);
                    }
                    else
                    {
                        var dict = JObject.Parse(@"{'Work_id':'" + cmbWorkName.SelectedValue.ToString() + "', 'Description_id':'" + cmbDescription.SelectedValue.ToString() + "', 'FSize_id':'" + cmbSizeFormula.SelectedValue.ToString() + "', 'FTotal_id':'" + cmbTotalFormula.SelectedValue.ToString() + "'}");
                        res = cls.InsertData(SpName: "USP_FormulaAssign_Insert", ReqType: "INSERT_ASSIGNFORMULA", dict: dict);
                    }

                    if (res == "1")
                    {
                        MessageBox.Show("Saved Successfully");
                        Clear();
                        bindwork();
                    }
                    else
                    {
                        MessageBox.Show("Already Exists");
                    }
                }
                else
                {
                    MessageBox.Show("Fill All The Work and Description");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("FormulaAssignMasterPage : BtnSave_Click" + ex.ToString());
            }
        }

        public void Clear()
        {
            txtFAssign_id.Text = "";
            //cmbWorkName.SelectedValue = 0;
            cmbDescription.SelectedValue = 0;
            cmbSizeFormula.SelectedValue = 0;
            cmbTotalFormula.SelectedValue = 0;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFAssign_id.Text != "")
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete ??", "Confirm!!", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        var dict = JObject.Parse(@"{'FAssign_id':'" + txtFAssign_id.Text + "'}");
                        string res = cls.InsertData(SpName: "USP_FormulaAssign_Insert", ReqType: "DELETE_ASSIGNFORMULA", dict: dict);
                        if (res == "1")
                        {
                            MessageBox.Show("Saved Successfully");
                            Clear();
                            bindwork();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("FormulaAssignMasterPage : BtnDelete_Click" + ex.ToString());
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("FormulaAssignMasterPage : BtnClear_Click" + ex.ToString());
            }
        }

        private void DgvFormulaAssign_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvFormulaAssign.Rows[e.RowIndex];
                    txtFAssign_id.Text = row.Cells[0].Value.ToString();
                    cmbWorkName.SelectedValue = row.Cells[1].Value.ToString();
                    cmbDescription.SelectedValue = row.Cells[2].Value.ToString();
                    cmbSizeFormula.SelectedValue = row.Cells[5].Value.ToString();
                    cmbTotalFormula.SelectedValue = row.Cells[6].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("FormulaAssignMasterPage : DgvFormulaAssign_CellClick" + ex.ToString());
            }
        }

        private void CmbWorkName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bindwork();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("FormulaAssignMasterPage : DgvFormulaAssign_CellClick" + ex.ToString());
            }            
        }

        public void bindwork()
        {
            if (cmbWorkName.SelectedValue != null && cmbWorkName.SelectedValue.ToString() != "" && cmbWorkName.SelectedValue.ToString() != "0")
            {
                DataTable dt = new DataTable();
                var dict = JObject.Parse(@"{'Work_id':'" + cmbWorkName.SelectedValue.ToString() + "'}");
                dt = cls.FetchData(SpName: "USP_FormulaAssign_Insert", ReqType: "SELECT_ASSIGNFORMULA", dict: dict);
                dgvFormulaAssign.AutoGenerateColumns = false;
                dgvFormulaAssign.DataSource = dt;
            }
        }
    }
}
