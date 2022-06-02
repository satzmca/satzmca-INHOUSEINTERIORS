﻿using InHouseInteriorsApplication.Class;
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

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
