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
                MessageBox.Show("DescriptionMaster" + ex.ToString());
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
                MessageBox.Show("WorkMasterPage" + ex.ToString());
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
                MessageBox.Show("PartyMasterPage" + ex.ToString());
            }
        }

        
    }
}
