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

        private void TxtWeight_KeyPress(object sender, KeyPressEventArgs e)
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

            if (Regex.IsMatch(txtWeight.Text, @"\.\d\d\d\d"))
            {
                e.Handled = true;
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
                    var dict = JObject.Parse(@"{'Description':'" + txtDescription.Text + "', 'Weight':'" + txtWeight.Text + "', 'Rate':'" + txtRate.Text + "'}");
                    string res = cls.InsertData(SpName: "USP_Description_insert", ReqType: "INSERT_DESCRIPTION", dict: dict);
                    if (res == "1")
                    {
                        MessageBox.Show("Saved Successfully");
                        txtDescription.Text = "";
                        txtWeight.Text = "";
                        txtRate.Text = "";

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
                cls.WriteException("DescriptionMasterPage : PartyMasterToolStripMenuItem_Click" + ex.ToString());
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
                cls.WriteException("DescriptionMasterPage : DescriptionMasterPage_Load" + ex.ToString());
            }
        }

        public void bind()
        {
            DataTable dt = new DataTable();
            dt = cls.FetchData(SpName: "USP_Description_insert", ReqType: "SELECT_DESCRIPTION");
            dgvDescription.DataSource = dt;            
        }
    }
}
