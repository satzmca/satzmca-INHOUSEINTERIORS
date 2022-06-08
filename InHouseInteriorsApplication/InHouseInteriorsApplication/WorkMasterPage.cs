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
    public partial class WorkMasterPage : Form
    {
        ClassConfig cls = new ClassConfig();
        public WorkMasterPage()
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
                cls.WriteException("WorkMasterPage : PctClose_Click" + ex.ToString());
            }
        }      

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtWorkName.Text != "")
                {
                    
                    string res = "";

                    if(txtWork_id.Text !="")
                    {                        
                        var dict = JObject.Parse(@"{'WorkName':'" + txtWorkName.Text + "', 'Work_id':'" + txtWork_id.Text + "'}");
                        res = cls.InsertData(SpName: "USP_Work_Insert", ReqType: "UPDATE_WORK", dict: dict);
                    }
                    else
                    {
                        var dict = JObject.Parse(@"{'WorkName':'" + txtWorkName.Text + "'}");
                        res = cls.InsertData(SpName: "USP_Work_Insert", ReqType: "INSERT_WORK", dict: dict);
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
                cls.WriteException("WorkMasterPage : BtnSave_Click_1" + ex.ToString());
            }
        }

        private void WorkMasterPage_Load(object sender, EventArgs e)
        {
            try
            {
                bind();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkMasterPage : WorkMasterPage_Load" + ex.ToString());
            }
        }

        public void bind()
        {
            DataTable dt = new DataTable();
            dt = cls.FetchData(SpName: "USP_Work_Insert", ReqType: "SELECT_WORK");
            dgvWork.DataSource = dt;
        }

        private void DgvWork_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvWork.Rows[e.RowIndex];
                    txtWork_id.Text = row.Cells[0].Value.ToString();
                    txtWorkName.Text = row.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkMasterPage : DgvWork_CellClick" + ex.ToString());
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtWork_id.Text != "")
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete '" + txtWorkName.Text + "' ??", "Confirm!!", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        var dict = JObject.Parse(@"{'Description_id':'" + txtWork_id.Text + "'}");
                        string res = cls.InsertData(SpName: "USP_Work_Insert", ReqType: "DELETE_WORK", dict: dict);
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
                cls.WriteException("WorkMasterPage : BtnDelete_Click" + ex.ToString());
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
                cls.WriteException("WorkMasterPage : BtnReset_Click" + ex.ToString());
            }
        }

        public void Clear()
        {
            txtWorkName.Text = "";
            txtWork_id.Text = "";
        }
    }
}
