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
           

            DataTable dt1 = new DataTable();
            dt1 = cls.FetchData(SpName: "USP_Description_Insert", ReqType: "SELECT_FORMULA");
            cmbSizeFormula.DisplayMember = "Formula";
            cmbSizeFormula.ValueMember = "Formula_id";
            cmbSizeFormula.DataSource = dt1;
            cmbSizeFormula.SelectedValue = 0;

            DataTable dt2 = dt1.Copy();            
            cmbTotalFormula.DisplayMember = "Formula";
            cmbTotalFormula.ValueMember = "Formula_id";
            cmbTotalFormula.DataSource = dt2;
            cmbTotalFormula.SelectedValue = 0;

            DataTable dt3 = dt1.Copy();            
            cmbSqftCoatingPlain.DisplayMember = "Formula";
            cmbSqftCoatingPlain.ValueMember = "Formula_id";
            cmbSqftCoatingPlain.DataSource = dt3;
            cmbSqftCoatingPlain.SelectedValue = 0;

            DataTable dt4 = dt1.Copy();
            cmbTotalPlainCoating.DisplayMember = "Formula";
            cmbTotalPlainCoating.ValueMember = "Formula_id";
            cmbTotalPlainCoating.DataSource = dt4;
            cmbTotalPlainCoating.SelectedValue = 0;

            DataTable dt5 = dt1.Copy();
            cmbTotalPlain.DisplayMember = "Formula";
            cmbTotalPlain.ValueMember = "Formula_id";
            cmbTotalPlain.DataSource = dt5;
            cmbTotalPlain.SelectedValue = 0;

            DataTable dt6 = dt1.Copy();
            cmbSqftWoodCoating.DisplayMember = "Formula";
            cmbSqftWoodCoating.ValueMember = "Formula_id";
            cmbSqftWoodCoating.DataSource = dt6;
            cmbSqftWoodCoating.SelectedValue = 0;

            DataTable dt7 = dt1.Copy();
            cmbTotalWoodCoating.DisplayMember = "Formula";
            cmbTotalWoodCoating.ValueMember = "Formula_id";
            cmbTotalWoodCoating.DataSource = dt7;
            cmbTotalWoodCoating.SelectedValue = 0;

            DataTable dt8 = dt1.Copy();
            cmbTotalWood.DisplayMember = "Formula";
            cmbTotalWood.ValueMember = "Formula_id";
            cmbTotalWood.DataSource = dt8;
            cmbTotalWood.SelectedValue = 0;

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
                        var dict = JObject.Parse(@"{'Work_id':'" + cmbWorkName.SelectedValue.ToString() + "', 'Description_id':'" + cmbDescription.SelectedValue.ToString() + "', 'FSize_id':'" + cmbSizeFormula.SelectedValue.ToString() + "', 'FTotal_id':'" + cmbTotalFormula.SelectedValue.ToString() + "', 'FSqftPlainCoating_id':'" + cmbSqftCoatingPlain.SelectedValue.ToString() + "', 'FTotalPlainCoating_id':'" + cmbTotalPlainCoating.SelectedValue.ToString() + "', 'FTotalPlain_id':'" + cmbTotalPlain.SelectedValue.ToString() + "', 'FSqftWoodCoating_id':'" + cmbSqftWoodCoating.SelectedValue.ToString() + "', 'FTotalWoodCoating_id':'" + cmbTotalWoodCoating.SelectedValue.ToString() + "', 'FTotalWood_id':'" + cmbTotalWood.SelectedValue.ToString() + "', 'FAssign_id':'" + txtFAssign_id.Text + "'}");
                        res = cls.InsertData(SpName: "USP_FormulaAssign_Insert", ReqType: "UPDATE_ASSIGNFORMULA", dict: dict);
                    }
                    else
                    {
                        var dict = JObject.Parse(@"{'Work_id':'" + cmbWorkName.SelectedValue.ToString() + "', 'Description_id':'" + cmbDescription.SelectedValue.ToString() + "', 'FSize_id':'" + cmbSizeFormula.SelectedValue.ToString() + "', 'FTotal_id':'" + cmbTotalFormula.SelectedValue.ToString() + "', 'FSqftPlainCoating_id':'" + cmbSqftCoatingPlain.SelectedValue.ToString() + "', 'FTotalPlainCoating_id':'" + cmbTotalPlainCoating.SelectedValue.ToString() + "', 'FTotalPlain_id':'" + cmbTotalPlain.SelectedValue.ToString() + "', 'FSqftWoodCoating_id':'" + cmbSqftWoodCoating.SelectedValue.ToString() + "', 'FTotalWoodCoating_id':'" + cmbTotalWoodCoating.SelectedValue.ToString() + "', 'FTotalWood_id':'" + cmbTotalWood.SelectedValue.ToString() + "'}");
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

            cmbSqftCoatingPlain.SelectedValue = 0;
            cmbTotalPlainCoating.SelectedValue = 0;
            cmbTotalPlain.SelectedValue = 0;

            cmbSqftWoodCoating.SelectedValue = 0;
            cmbTotalWoodCoating.SelectedValue = 0;
            cmbTotalWood.SelectedValue = 0;
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

                    cmbSqftCoatingPlain.SelectedValue = row.Cells[7].Value.ToString(); ;
                    cmbTotalPlainCoating.SelectedValue = row.Cells[8].Value.ToString(); ;
                    cmbTotalPlain.SelectedValue = row.Cells[9].Value.ToString(); ;

                    cmbSqftWoodCoating.SelectedValue = row.Cells[10].Value.ToString(); ;
                    cmbTotalWoodCoating.SelectedValue = row.Cells[11].Value.ToString(); ;
                    cmbTotalWood.SelectedValue = row.Cells[12].Value.ToString(); ;
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


                cmbDescription.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbDescription.AutoCompleteSource = AutoCompleteSource.ListItems;
                DataTable descdt = new DataTable();
                var dict1 = JObject.Parse(@"{'Work_id':'" + cmbWorkName.SelectedValue.ToString() + "'}");
                descdt = cls.FetchData(SpName: "USP_Description_Insert", ReqType: "SELECT_DESCRIPTIONBASEDWORK", dict1);
                cmbDescription.DisplayMember = "Description";
                cmbDescription.ValueMember = "Description_id";
                cmbDescription.DataSource = descdt;
            }
        }
    }
}
