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
    public partial class WorkDetailMaster : Form
    {
        ClassConfig cls = new ClassConfig();
        public WorkDetailMaster()
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
                cls.WriteException("WorkDetailMaster : PctClose_Click" + ex.ToString());
            }
        }

        private void WorkDetailMaster_Load(object sender, EventArgs e)
        {
            try
            {
                bindWork();                                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("PartyMasterPage : PartyMasterPage_Load" + ex.ToString());
            }
        }

        public void bindWork()
        {
            DataTable workdt = new DataTable();

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

        public void bind()
        {
            DataTable dt = new DataTable();
            
            if (cmbWorkName.SelectedValue.ToString() != "0" && cmbWorkName.SelectedValue.ToString() != "")
            {
                var dict = JObject.Parse(@"{'Work_id':'" + cmbWorkName.SelectedValue + "'}");
                dt = cls.FetchData(SpName: "USP_WorkDetail_Insert", ReqType: "SELECT_WORKDETAIL", dict: dict);
            }
            else
            {                
                dt = cls.FetchData(SpName: "USP_WorkDetail_Insert", ReqType: "SELECT_WORKDETAIL");
            }

            dgvWorkDetail.AutoGenerateColumns = false;
            dgvWorkDetail.DataSource = dt;

            foreach (DataGridViewRow row in dgvWorkDetail.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells[0] as DataGridViewCheckBoxCell;
                if (cell.ColumnIndex == 0)
                {
                    if (cell.Value != null && cell.Value.ToString() != "")
                    {
                        bool achecked = Convert.ToBoolean(cell.Value);
                        cell.Value = achecked;
                    }
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbWorkName.SelectedValue.ToString() != "0" && cmbWorkName.SelectedValue.ToString() != "")
                {
                    int incrementval = 0;
                    foreach (DataGridViewRow Myrow in dgvWorkDetail.Rows)
                    {            //Here 2 cell is target value and 1 cell is Volume
                        
                        bool achecked = Convert.ToBoolean(Myrow.Cells[0].Value);

                        if (achecked)
                        {
                            int WorkDetail_id = Convert.ToInt32(Myrow.Cells[1].Value);
                            int Description_id = Convert.ToInt32(Myrow.Cells[2].Value);

                            incrementval++;
                            string res = "";
                            var dict = JObject.Parse(@"{'Work_id':'" + cmbWorkName.SelectedValue + "', 'Description_id':'" + Description_id + "', 'WorkDetail_id':'" + WorkDetail_id + "'}");
                            res = cls.InsertData(SpName: "USP_WorkDetail_Insert", ReqType: "INSERT_WORKDETAIL", dict: dict);
                        }
                        else
                        {
                            int WorkDetail_id = Convert.ToInt32(Myrow.Cells[1].Value);
                            int Description_id = Convert.ToInt32(Myrow.Cells[2].Value);

                            if (WorkDetail_id > 0)
                            {
                                string res = "";
                                var dict = JObject.Parse(@"{'WorkDetail_id':'" + WorkDetail_id + "'}");
                                res = cls.InsertData(SpName: "USP_WorkDetail_Insert", ReqType: "DELETE_WORKDETAIL", dict: dict);
                            }                            
                        }
                    }

                    if (incrementval > 0)
                    {
                        MessageBox.Show(incrementval+" Records Updated Successfully");
                        bind();
                    }
                }
                else
                {
                    MessageBox.Show("Choose Work Name");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("PartyMasterPage : BtnSave_Click" + ex.ToString());
            }
        }

        private void DgvWorkDetail_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow Myrow in dgvWorkDetail.Rows)
                {            //Here 2 cell is target value and 1 cell is Volume
                    if (Myrow.Cells[0].Value.ToString() != null && Myrow.Cells[0].Value.ToString() != "")
                    {
                        if (Convert.ToInt32(Myrow.Cells[0].Value) == 0)// Or your condition 
                        {
                            Myrow.DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                            Myrow.DefaultCellStyle.ForeColor = Color.White;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("PartyMasterPage : DgvWorkDetail_CellFormatting" + ex.ToString());
            }
        }

        private void DgvWorkDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dgvWorkDetail.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    if (checkCell.Value != null && checkCell.Value.ToString() != "")
                    {
                        bool achecked = Convert.ToBoolean(checkCell.Value);
                        if (achecked)
                            checkCell.Value = false;
                        else
                            checkCell.Value = true;
                        dgvWorkDetail.EndEdit();

                    }                                                                                       
                }                                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("PartyMasterPage : DgvWorkDetail_CellClick" + ex.ToString());
            }
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
                cls.WriteException("PartyMasterPage : CmbWorkName_SelectedIndexChanged" + ex.ToString());
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
