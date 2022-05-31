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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.descriptionMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partyMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
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
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.logOutToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descriptionMasterToolStripMenuItem,
            this.workMasterToolStripMenuItem,
            this.partyMasterToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.toolStripMenuItem1.Text = "Master";
            // 
            // descriptionMasterToolStripMenuItem
            // 
            this.descriptionMasterToolStripMenuItem.Name = "descriptionMasterToolStripMenuItem";
            this.descriptionMasterToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.descriptionMasterToolStripMenuItem.Text = "Description Master";
            this.descriptionMasterToolStripMenuItem.Click += new System.EventHandler(this.DescriptionMasterToolStripMenuItem_Click);
            // 
            // workMasterToolStripMenuItem
            // 
            this.workMasterToolStripMenuItem.Name = "workMasterToolStripMenuItem";
            this.workMasterToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.workMasterToolStripMenuItem.Text = "Work Master";
            this.workMasterToolStripMenuItem.Click += new System.EventHandler(this.WorkMasterToolStripMenuItem_Click);
            // 
            // partyMasterToolStripMenuItem
            // 
            this.partyMasterToolStripMenuItem.Name = "partyMasterToolStripMenuItem";
            this.partyMasterToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.partyMasterToolStripMenuItem.Text = "Party Master";
            this.partyMasterToolStripMenuItem.Click += new System.EventHandler(this.PartyMasterToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InHouseInteriorsApplication.Properties.Resources.InHouseBackGround;
            this.ClientSize = new System.Drawing.Size(1503, 796);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}