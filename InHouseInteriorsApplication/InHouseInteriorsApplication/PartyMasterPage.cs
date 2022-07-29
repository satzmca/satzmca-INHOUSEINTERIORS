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
    public partial class PartyMasterPage : Form
    {
        ClassConfig cls = new ClassConfig();
        public PartyMasterPage()
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
                cls.WriteException("PartyMasterPage : PctClose_Click" + ex.ToString());
            }
        }

        private void TxtMobileNo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }            
        }

        private void TxtMobileNo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPartyName.Text != "" && cmbPartyType.SelectedItem.ToString() != "--Select--" && txtAddress1.Text!="" && txtAddress2.Text !="")
                {

                    string res = "";

                    if (txtParty_id.Text != "")
                    {
                        var dict = JObject.Parse(@"{'Party_id':'" + txtParty_id.Text + "', 'PartyName':'" + txtPartyName.Text + "', 'NameHeader':'" + cmbRemark.SelectedItem + "', 'PartyType':'" + cmbPartyType.SelectedItem.ToString() + "','Address1':'" + txtAddress1.Text + "', 'Address2':'" + txtAddress2.Text + "', 'MobileNo1':'" + txtMobileNo1.Text + "', 'MobileNo2':'" + txtMobileNo2.Text + "' }");
                        res = cls.InsertData(SpName: "USP_Party_Insert", ReqType: "UPDATE_PARTY", dict: dict);
                    }
                    else
                    {
                        var dict = JObject.Parse(@"{'PartyName':'" + txtPartyName.Text + "', 'NameHeader':'" + cmbRemark.SelectedItem + "', 'PartyType':'" + cmbPartyType.SelectedItem + "','Address1':'" + txtAddress1.Text + "', 'Address2':'" + txtAddress2.Text + "', 'MobileNo1':'" + txtMobileNo1.Text + "', 'MobileNo2':'" + txtMobileNo2.Text + "' }");
                        res = cls.InsertData(SpName: "USP_Party_Insert", ReqType: "INSERT_PARTY", dict: dict);
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
                cls.WriteException("PartyMasterPage : BtnSave_Click_1" + ex.ToString());
            }
        }        

        private void PartyMasterPage_Load(object sender, EventArgs e)
        {
            try
            {
                bind();
                cmbPartyType.SelectedItem = "--Select--";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("PartyMasterPage : PartyMasterPage_Load" + ex.ToString());
            }
        }

        public void bind()
        {
            DataTable dt = new DataTable();
            dt = cls.FetchData(SpName: "USP_Party_Insert", ReqType: "SELECT_PARTY");
            dgvParty.DataSource = dt;
        }

        private void DgvParty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvParty.Rows[e.RowIndex];
                    txtParty_id.Text = row.Cells[0].Value.ToString();
                    cmbRemark.SelectedItem = row.Cells[1].Value.ToString();
                    txtPartyName.Text = row.Cells[2].Value.ToString();
                    cmbPartyType.SelectedItem = row.Cells[3].Value.ToString();
                    txtAddress1.Text = row.Cells[4].Value.ToString();
                    txtAddress2.Text = row.Cells[5].Value.ToString();
                    txtMobileNo1.Text = row.Cells[6].Value.ToString();
                    txtMobileNo2.Text = row.Cells[7].Value.ToString();
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("PartyMasterPage : DgvParty_CellClick" + ex.ToString());                
            }
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtParty_id.Text != "")
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete '" + txtPartyName.Text + "' ??", "Confirm!!", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        var dict = JObject.Parse(@"{'Party_id':'" + txtParty_id.Text + "'}");
                        string res = cls.InsertData(SpName: "USP_Party_Insert", ReqType: "DELETE_PARTY", dict: dict);
                        if (res == "1")
                        {
                            Clear();
                            bind();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("PartyMasterPage : BtnDelete_Click" + ex.ToString());
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
                cls.WriteException("PartyMasterPage : BtnReset_Click" + ex.ToString());
            }
        }

        public void Clear()
        {
            txtParty_id.Text = "";
            txtPartyName.Text = "";
            cmbPartyType.SelectedItem = "--Select--";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtMobileNo1.Text = "";
            txtMobileNo2.Text = "";
        }
    }
}
