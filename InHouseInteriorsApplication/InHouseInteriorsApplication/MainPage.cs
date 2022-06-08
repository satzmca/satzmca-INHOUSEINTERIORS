using InHouseInteriorsApplication.Class;
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
    public partial class MainPage : Form
    {
        ClassConfig cls = new ClassConfig();
        public MainPage()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DescriptionMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DescriptionMasterPage DescriptionMasterPage = new DescriptionMasterPage();
                DescriptionMasterPage.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("MainPage : DescriptionMasterToolStripMenuItem_Click" + ex.ToString());
            }
        }

        private void WorkMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                WorkMasterPage WorkMasterPage = new WorkMasterPage();
                WorkMasterPage.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("MainPage : WorkMasterToolStripMenuItem_Click" + ex.ToString());
            }
        }

        private void PartyMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PartyMasterPage PartyMasterPage = new PartyMasterPage();
                PartyMasterPage.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("MainPage : PartyMasterToolStripMenuItem_Click" + ex.ToString());
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblusername.Text = "Hi.. " + ClassConfig.UserName.ToString().ToLowerInvariant() + " Welcome";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void WorkDetailMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                WorkDetailMaster WorkDetailMaster = new WorkDetailMaster();
                WorkDetailMaster.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("MainPage : WorkDetailMasterToolStripMenuItem_Click" + ex.ToString());
            }
        }

        private void Lblusername_Click(object sender, EventArgs e)
        {

        }

        private void LblDate_Click(object sender, EventArgs e)
        {

        }

        private void LblTime_Click(object sender, EventArgs e)
        {

        }

        private void PicTime_Click(object sender, EventArgs e)
        {

        }
    }
}
