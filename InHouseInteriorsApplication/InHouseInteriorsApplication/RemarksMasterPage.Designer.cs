namespace InHouseInteriorsApplication
{
    partial class RemarksMasterPage
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
            this.grpRemark = new System.Windows.Forms.GroupBox();
            this.cmbQdesc = new System.Windows.Forms.ComboBox();
            this.lblQdesc = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtRemarks_id = new System.Windows.Forms.TextBox();
            this.dgvRemark = new System.Windows.Forms.DataGridView();
            this.Work_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QDesc_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.pctClose = new System.Windows.Forms.PictureBox();
            this.grpRemark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(326, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 45);
            this.label1.TabIndex = 16;
            this.label1.Text = "In-House Interiors";
            // 
            // grpRemark
            // 
            this.grpRemark.Controls.Add(this.cmbQdesc);
            this.grpRemark.Controls.Add(this.lblQdesc);
            this.grpRemark.Controls.Add(this.btnClear);
            this.grpRemark.Controls.Add(this.btnDelete);
            this.grpRemark.Controls.Add(this.txtRemarks_id);
            this.grpRemark.Controls.Add(this.dgvRemark);
            this.grpRemark.Controls.Add(this.btnSave);
            this.grpRemark.Controls.Add(this.txtRemarks);
            this.grpRemark.Controls.Add(this.lblRemarks);
            this.grpRemark.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.grpRemark.ForeColor = System.Drawing.Color.White;
            this.grpRemark.Location = new System.Drawing.Point(12, 46);
            this.grpRemark.Name = "grpRemark";
            this.grpRemark.Size = new System.Drawing.Size(976, 570);
            this.grpRemark.TabIndex = 15;
            this.grpRemark.TabStop = false;
            this.grpRemark.Text = "Remarks Master";
            // 
            // cmbQdesc
            // 
            this.cmbQdesc.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQdesc.FormattingEnabled = true;
            this.cmbQdesc.Location = new System.Drawing.Point(301, 55);
            this.cmbQdesc.Name = "cmbQdesc";
            this.cmbQdesc.Size = new System.Drawing.Size(523, 31);
            this.cmbQdesc.TabIndex = 53;
            this.cmbQdesc.SelectedIndexChanged += new System.EventHandler(this.CmbQdesc_SelectedIndexChanged);
            // 
            // lblQdesc
            // 
            this.lblQdesc.AutoSize = true;
            this.lblQdesc.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblQdesc.ForeColor = System.Drawing.Color.White;
            this.lblQdesc.Location = new System.Drawing.Point(155, 58);
            this.lblQdesc.Name = "lblQdesc";
            this.lblQdesc.Size = new System.Drawing.Size(84, 23);
            this.lblQdesc.TabIndex = 54;
            this.lblQdesc.Text = "Q.Desc";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(612, 189);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 42);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(456, 189);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 42);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // txtRemarks_id
            // 
            this.txtRemarks_id.Location = new System.Drawing.Point(845, 120);
            this.txtRemarks_id.Name = "txtRemarks_id";
            this.txtRemarks_id.Size = new System.Drawing.Size(100, 31);
            this.txtRemarks_id.TabIndex = 26;
            this.txtRemarks_id.Visible = false;
            // 
            // dgvRemark
            // 
            this.dgvRemark.AllowUserToAddRows = false;
            this.dgvRemark.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvRemark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRemark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemark.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Work_id,
            this.QDesc_id,
            this.Remarks});
            this.dgvRemark.Location = new System.Drawing.Point(16, 260);
            this.dgvRemark.Name = "dgvRemark";
            this.dgvRemark.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRemark.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvRemark.Size = new System.Drawing.Size(945, 304);
            this.dgvRemark.TabIndex = 25;
            this.dgvRemark.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRemark_CellClick);
            // 
            // Work_id
            // 
            this.Work_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Work_id.DataPropertyName = "Remarks_id";
            this.Work_id.FillWeight = 101.5228F;
            this.Work_id.HeaderText = "SNo";
            this.Work_id.Name = "Work_id";
            // 
            // QDesc_id
            // 
            this.QDesc_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.QDesc_id.DataPropertyName = "QDesc_id";
            this.QDesc_id.HeaderText = "QDesc_id";
            this.QDesc_id.Name = "QDesc_id";
            this.QDesc_id.Width = 150;
            // 
            // Remarks
            // 
            this.Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.FillWeight = 98.47716F;
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.Width = 600;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(300, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 42);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(301, 120);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(523, 31);
            this.txtRemarks.TabIndex = 20;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.ForeColor = System.Drawing.Color.White;
            this.lblRemarks.Location = new System.Drawing.Point(157, 122);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(104, 23);
            this.lblRemarks.TabIndex = 18;
            this.lblRemarks.Text = "Remarks";
            // 
            // pctClose
            // 
            this.pctClose.Image = global::InHouseInteriorsApplication.Properties.Resources.close2;
            this.pctClose.Location = new System.Drawing.Point(950, -2);
            this.pctClose.Name = "pctClose";
            this.pctClose.Size = new System.Drawing.Size(50, 50);
            this.pctClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctClose.TabIndex = 14;
            this.pctClose.TabStop = false;
            this.pctClose.Click += new System.EventHandler(this.PctClose_Click);
            // 
            // RemarksMasterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1008, 628);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpRemark);
            this.Controls.Add(this.pctClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemarksMasterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemarksMasterPage";
            this.Load += new System.EventHandler(this.RemarksMasterPage_Load);
            this.grpRemark.ResumeLayout(false);
            this.grpRemark.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpRemark;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtRemarks_id;
        private System.Windows.Forms.DataGridView dgvRemark;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.PictureBox pctClose;
        private System.Windows.Forms.ComboBox cmbQdesc;
        private System.Windows.Forms.Label lblQdesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Work_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn QDesc_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
    }
}