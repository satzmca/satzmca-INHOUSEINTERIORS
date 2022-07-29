namespace InHouseInteriorsApplication
{
    partial class PartyMasterPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpDescription = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtParty_id = new System.Windows.Forms.TextBox();
            this.dgvParty = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbPartyType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMobileNo2 = new System.Windows.Forms.TextBox();
            this.lblMobileNo2 = new System.Windows.Forms.Label();
            this.txtMobileNo1 = new System.Windows.Forms.TextBox();
            this.lblMobileNo1 = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtPartyName = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblPartName = new System.Windows.Forms.Label();
            this.pctClose = new System.Windows.Forms.PictureBox();
            this.cmbRemark = new System.Windows.Forms.ComboBox();
            this.grpDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(658, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 45);
            this.label1.TabIndex = 13;
            this.label1.Text = "In-House Interiors";
            // 
            // grpDescription
            // 
            this.grpDescription.Controls.Add(this.cmbRemark);
            this.grpDescription.Controls.Add(this.btnClear);
            this.grpDescription.Controls.Add(this.txtParty_id);
            this.grpDescription.Controls.Add(this.dgvParty);
            this.grpDescription.Controls.Add(this.btnDelete);
            this.grpDescription.Controls.Add(this.cmbPartyType);
            this.grpDescription.Controls.Add(this.label2);
            this.grpDescription.Controls.Add(this.txtMobileNo2);
            this.grpDescription.Controls.Add(this.lblMobileNo2);
            this.grpDescription.Controls.Add(this.txtMobileNo1);
            this.grpDescription.Controls.Add(this.lblMobileNo1);
            this.grpDescription.Controls.Add(this.txtAddress2);
            this.grpDescription.Controls.Add(this.lblAddress2);
            this.grpDescription.Controls.Add(this.btnSave);
            this.grpDescription.Controls.Add(this.txtAddress1);
            this.grpDescription.Controls.Add(this.txtPartyName);
            this.grpDescription.Controls.Add(this.lblAddress1);
            this.grpDescription.Controls.Add(this.lblPartName);
            this.grpDescription.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.grpDescription.ForeColor = System.Drawing.Color.White;
            this.grpDescription.Location = new System.Drawing.Point(13, 50);
            this.grpDescription.Name = "grpDescription";
            this.grpDescription.Size = new System.Drawing.Size(1591, 634);
            this.grpDescription.TabIndex = 12;
            this.grpDescription.TabStop = false;
            this.grpDescription.Text = "Party Master";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(362, 561);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(151, 54);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // txtParty_id
            // 
            this.txtParty_id.Location = new System.Drawing.Point(414, 25);
            this.txtParty_id.Name = "txtParty_id";
            this.txtParty_id.Size = new System.Drawing.Size(100, 31);
            this.txtParty_id.TabIndex = 27;
            this.txtParty_id.Visible = false;
            // 
            // dgvParty
            // 
            this.dgvParty.AllowUserToAddRows = false;
            this.dgvParty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParty.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvParty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvParty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParty.Location = new System.Drawing.Point(532, 28);
            this.dgvParty.Name = "dgvParty";
            this.dgvParty.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvParty.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvParty.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvParty.Size = new System.Drawing.Size(1048, 591);
            this.dgvParty.TabIndex = 26;
            this.dgvParty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvParty_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(186, 561);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(151, 54);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // cmbPartyType
            // 
            this.cmbPartyType.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPartyType.FormattingEnabled = true;
            this.cmbPartyType.Items.AddRange(new object[] {
            "--Select--",
            "Vendor",
            "Supplier"});
            this.cmbPartyType.Location = new System.Drawing.Point(164, 122);
            this.cmbPartyType.Name = "cmbPartyType";
            this.cmbPartyType.Size = new System.Drawing.Size(350, 31);
            this.cmbPartyType.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "PartyType";
            // 
            // txtMobileNo2
            // 
            this.txtMobileNo2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo2.Location = new System.Drawing.Point(164, 498);
            this.txtMobileNo2.MaxLength = 12;
            this.txtMobileNo2.Name = "txtMobileNo2";
            this.txtMobileNo2.Size = new System.Drawing.Size(350, 31);
            this.txtMobileNo2.TabIndex = 15;
            this.txtMobileNo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMobileNo2_KeyPress);
            // 
            // lblMobileNo2
            // 
            this.lblMobileNo2.AutoSize = true;
            this.lblMobileNo2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblMobileNo2.ForeColor = System.Drawing.Color.White;
            this.lblMobileNo2.Location = new System.Drawing.Point(6, 498);
            this.lblMobileNo2.Name = "lblMobileNo2";
            this.lblMobileNo2.Size = new System.Drawing.Size(124, 23);
            this.lblMobileNo2.TabIndex = 19;
            this.lblMobileNo2.Text = "MobileNo2";
            // 
            // txtMobileNo1
            // 
            this.txtMobileNo1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo1.Location = new System.Drawing.Point(164, 438);
            this.txtMobileNo1.MaxLength = 12;
            this.txtMobileNo1.Name = "txtMobileNo1";
            this.txtMobileNo1.Size = new System.Drawing.Size(350, 31);
            this.txtMobileNo1.TabIndex = 14;
            this.txtMobileNo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMobileNo1_KeyPress);
            // 
            // lblMobileNo1
            // 
            this.lblMobileNo1.AutoSize = true;
            this.lblMobileNo1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblMobileNo1.ForeColor = System.Drawing.Color.White;
            this.lblMobileNo1.Location = new System.Drawing.Point(6, 438);
            this.lblMobileNo1.Name = "lblMobileNo1";
            this.lblMobileNo1.Size = new System.Drawing.Size(124, 23);
            this.lblMobileNo1.TabIndex = 17;
            this.lblMobileNo1.Text = "MobileNo1";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.Location = new System.Drawing.Point(164, 310);
            this.txtAddress2.Multiline = true;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(350, 99);
            this.txtAddress2.TabIndex = 13;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblAddress2.ForeColor = System.Drawing.Color.White;
            this.lblAddress2.Location = new System.Drawing.Point(6, 310);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(109, 23);
            this.lblAddress2.TabIndex = 15;
            this.lblAddress2.Text = "Address2";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(10, 561);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 54);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtAddress1
            // 
            this.txtAddress1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress1.Location = new System.Drawing.Point(164, 182);
            this.txtAddress1.Multiline = true;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(350, 99);
            this.txtAddress1.TabIndex = 12;
            // 
            // txtPartyName
            // 
            this.txtPartyName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartyName.Location = new System.Drawing.Point(164, 62);
            this.txtPartyName.Name = "txtPartyName";
            this.txtPartyName.Size = new System.Drawing.Size(350, 31);
            this.txtPartyName.TabIndex = 10;
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblAddress1.ForeColor = System.Drawing.Color.White;
            this.lblAddress1.Location = new System.Drawing.Point(6, 182);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(109, 23);
            this.lblAddress1.TabIndex = 9;
            this.lblAddress1.Text = "Address1";
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPartName.ForeColor = System.Drawing.Color.White;
            this.lblPartName.Location = new System.Drawing.Point(6, 62);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(129, 23);
            this.lblPartName.TabIndex = 8;
            this.lblPartName.Text = "PartyName";
            // 
            // pctClose
            // 
            this.pctClose.Image = global::InHouseInteriorsApplication.Properties.Resources.close2;
            this.pctClose.Location = new System.Drawing.Point(1566, 2);
            this.pctClose.Name = "pctClose";
            this.pctClose.Size = new System.Drawing.Size(50, 50);
            this.pctClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctClose.TabIndex = 11;
            this.pctClose.TabStop = false;
            this.pctClose.Click += new System.EventHandler(this.PctClose_Click);
            // 
            // cmbRemark
            // 
            this.cmbRemark.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRemark.FormattingEnabled = true;
            this.cmbRemark.Items.AddRange(new object[] {
            "Mr",
            "Mrs"});
            this.cmbRemark.Location = new System.Drawing.Point(164, 25);
            this.cmbRemark.Name = "cmbRemark";
            this.cmbRemark.Size = new System.Drawing.Size(244, 31);
            this.cmbRemark.TabIndex = 30;
            // 
            // PartyMasterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1616, 707);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpDescription);
            this.Controls.Add(this.pctClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PartyMasterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartyMasterPage";
            this.Load += new System.EventHandler(this.PartyMasterPage_Load);
            this.grpDescription.ResumeLayout(false);
            this.grpDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtPartyName;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblPartName;
        private System.Windows.Forms.PictureBox pctClose;
        private System.Windows.Forms.ComboBox cmbPartyType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMobileNo2;
        private System.Windows.Forms.Label lblMobileNo2;
        private System.Windows.Forms.TextBox txtMobileNo1;
        private System.Windows.Forms.Label lblMobileNo1;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvParty;
        private System.Windows.Forms.TextBox txtParty_id;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbRemark;
    }
}