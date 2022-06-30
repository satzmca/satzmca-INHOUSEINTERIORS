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

            int style = ClassConfig.NativeWinAPI.GetWindowLong(this.Handle, ClassConfig.NativeWinAPI.GWL_EXSTYLE);
            style |= ClassConfig.NativeWinAPI.WS_EX_COMPOSITED;
            ClassConfig.NativeWinAPI.SetWindowLong(this.Handle, ClassConfig.NativeWinAPI.GWL_EXSTYLE, style);
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

        private void WorkTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                WorkTransactionPage WorkTransaction = new WorkTransactionPage();
                WorkTransaction.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("MainPage : WorkTransactionToolStripMenuItem_Click" + ex.ToString());
            }
        }

        private void FormulaMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormulaMasterPage FormulaMasterPage = new FormulaMasterPage();
                FormulaMasterPage.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("MainPage : FormulaMasterToolStripMenuItem_Click" + ex.ToString());
            }
        }

        private void FormulaAssignMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormulaAssignMasterPage FormulaAssignMasterPage = new FormulaAssignMasterPage();
                FormulaAssignMasterPage.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("MainPage : FormulaAssignMasterToolStripMenuItem_Click" + ex.ToString());
            }
        }

        private void RemarksMasterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                RemarksMasterPage RemarksMasterPage = new RemarksMasterPage();
                RemarksMasterPage.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("MainPage : RemarksMasterToolStripMenuItem1_Click" + ex.ToString());
            }
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReport f = new FrmReport();
            f.Show();

        }
    }
}
