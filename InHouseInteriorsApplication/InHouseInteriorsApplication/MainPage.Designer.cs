namespace InHouseInteriorsApplication
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.descriptionMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partyMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workDetailMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblusername = new System.Windows.Forms.Label();
            this.picTime = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTime)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1503, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.logOutToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descriptionMasterToolStripMenuItem,
            this.workMasterToolStripMenuItem,
            this.partyMasterToolStripMenuItem,
            this.workDetailMasterToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(128, 24);
            this.toolStripMenuItem1.Text = "Master";
            // 
            // descriptionMasterToolStripMenuItem
            // 
            this.descriptionMasterToolStripMenuItem.Name = "descriptionMasterToolStripMenuItem";
            this.descriptionMasterToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.descriptionMasterToolStripMenuItem.Text = "Description Master";
            this.descriptionMasterToolStripMenuItem.Click += new System.EventHandler(this.DescriptionMasterToolStripMenuItem_Click);
            // 
            // workMasterToolStripMenuItem
            // 
            this.workMasterToolStripMenuItem.Name = "workMasterToolStripMenuItem";
            this.workMasterToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.workMasterToolStripMenuItem.Text = "Work Master";
            this.workMasterToolStripMenuItem.Click += new System.EventHandler(this.WorkMasterToolStripMenuItem_Click);
            // 
            // partyMasterToolStripMenuItem
            // 
            this.partyMasterToolStripMenuItem.Name = "partyMasterToolStripMenuItem";
            this.partyMasterToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.partyMasterToolStripMenuItem.Text = "Party Master";
            this.partyMasterToolStripMenuItem.Click += new System.EventHandler(this.PartyMasterToolStripMenuItem_Click);
            // 
            // workDetailMasterToolStripMenuItem
            // 
            this.workDetailMasterToolStripMenuItem.Name = "workDetailMasterToolStripMenuItem";
            this.workDetailMasterToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.workDetailMasterToolStripMenuItem.Text = "Work Detail Master";
            this.workDetailMasterToolStripMenuItem.Click += new System.EventHandler(this.WorkDetailMasterToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblusername.ForeColor = System.Drawing.Color.White;
            this.lblusername.Location = new System.Drawing.Point(1307, 37);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(158, 45);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "Welcome";
            this.lblusername.Click += new System.EventHandler(this.Lblusername_Click);
            // 
            // picTime
            // 
            this.picTime.BackColor = System.Drawing.Color.Transparent;
            this.picTime.Image = global::InHouseInteriorsApplication.Properties.Resources.time;
            this.picTime.Location = new System.Drawing.Point(1305, 85);
            this.picTime.Name = "picTime";
            this.picTime.Size = new System.Drawing.Size(70, 70);
            this.picTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTime.TabIndex = 9;
            this.picTime.TabStop = false;
            this.picTime.Click += new System.EventHandler(this.PicTime_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(1377, 123);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(62, 30);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date";
            this.lblDate.Click += new System.EventHandler(this.LblDate_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(1377, 88);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(64, 30);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Time";
            this.lblTime.Click += new System.EventHandler(this.LblTime_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InHouseInteriorsApplication.Properties.Resources.InHouseBackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1503, 796);
            this.Controls.Add(this.picTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem workMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descriptionMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partyMasterToolStripMenuItem;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.PictureBox picTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem workDetailMasterToolStripMenuItem;
    }
}