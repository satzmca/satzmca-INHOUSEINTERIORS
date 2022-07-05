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
    public partial class RemarksMasterPage : Form
    {
        ClassConfig cls = new ClassConfig();
        public RemarksMasterPage()
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
                cls.WriteException("RemarksMasterPage : PctClose_Click" + ex.ToString());
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRemarks.Text != "" && cmbQdesc.SelectedValue.ToString()!="0")
                {

                    string res = "";

                    if (txtRemarks_id.Text != "")
                    {
                        var dict = JObject.Parse(@"{'QDesc_id':'" + cmbQdesc.SelectedValue.ToString() + "', 'Remarks':'" + txtRemarks.Text + "', 'Remarks_id':'" + txtRemarks_id.Text + "'}");
                        res = cls.InsertData(SpName: "USP_Remarks_Insert", ReqType: "UPDATE_REMARKS", dict: dict);
                    }
                    else
                    {
                        var dict = JObject.Parse(@"{'QDesc_id':'" + cmbQdesc.SelectedValue.ToString() + "', 'Remarks':'" + txtRemarks.Text + "'}");
                        res = cls.InsertData(SpName: "USP_Remarks_Insert", ReqType: "INSERT_REMARKS", dict: dict);
                    }

                    if (res == "1")
                    {
                        //MessageBox.Show("Saved Successfully");
                        Clear();
                        bindDetail();
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
                cls.WriteException("RemarksMasterPage : BtnSave_Click" + ex.ToString());
            }
        }

        private void RemarksMasterPage_Load(object sender, EventArgs e)
        {
            try
            {
                bind();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("RemarksMasterPage : WorkMasterPage_Load" + ex.ToString());
            }
        }

        public void bind()
        {
            DataTable qdesc = new DataTable();
            qdesc = cls.FetchData(SpName: "USP_WorkDetail_Select", ReqType: "SELECT_QUOTATIONDESC");
            cmbQdesc.DataSource = qdesc;
            cmbQdesc.DisplayMember = "Q_Description";
            cmbQdesc.ValueMember = "QDesc_id";            
        }

        private void DgvRemark_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvRemark.Rows[e.RowIndex];
                    txtRemarks_id.Text = row.Cells[0].Value.ToString();
                    cmbQdesc.SelectedValue = row.Cells[1].Value.ToString();
                    txtRemarks.Text = row.Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("RemarksMasterPage : DgvRemark_CellClick" + ex.ToString());
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRemarks_id.Text != "")
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete '" + txtRemarks.Text + "' ??", "Confirm!!", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        var dict = JObject.Parse(@"{'Remarks_id':'" + txtRemarks_id.Text + "'}");
                        string res = cls.InsertData(SpName: "USP_Remarks_Insert", ReqType: "DELETE_REMARKS", dict: dict);
                        if (res == "1")
                        {
                            bind();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("RemarksMasterPage : BtnDelete_Click" + ex.ToString());
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
                cls.WriteException("RemarksMasterPage : BtnClear_Click" + ex.ToString());
            }
        }

        public void Clear()
        {
            txtRemarks.Text = "";
            txtRemarks_id.Text = "";            
        }

        private void CmbQdesc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bindDetail();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("RemarksMasterPage : CmbQdesc_SelectedIndexChanged" + ex.ToString());
            }
        }

        public void bindDetail()
        {
            if (cmbQdesc.SelectedValue != null && cmbQdesc.SelectedValue.ToString() != "0" && cmbQdesc.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                DataTable dt = new DataTable();
                var dict = JObject.Parse(@"{'QDesc_id':'" + cmbQdesc.SelectedValue.ToString() + "'}");
                dt = cls.FetchData(SpName: "USP_Remarks_Insert", ReqType: "SELECT_REMARKS", dict: dict);
                dgvRemark.DataSource = dt;

                Clear();
            }
        }
    }
}
