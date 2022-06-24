namespace InHouseInteriorsApplication
{
    partial class WorkDetailMaster
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
            this.grpWorkDetail = new System.Windows.Forms.GroupBox();
            this.dgvWorkDetail = new System.Windows.Forms.DataGridView();
            this.cmbWorkName = new System.Windows.Forms.ComboBox();
            this.lblWorkName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pctClose = new System.Windows.Forms.PictureBox();
            this.IsCheckDescription = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.WorkDetail_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpWorkDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(695, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 45);
            this.label1.TabIndex = 16;
            this.label1.Text = "In-House Interiors";
            // 
            // grpWorkDetail
            // 
            this.grpWorkDetail.Controls.Add(this.dgvWorkDetail);
            this.grpWorkDetail.Controls.Add(this.cmbWorkName);
            this.grpWorkDetail.Controls.Add(this.lblWorkName);
            this.grpWorkDetail.Controls.Add(this.btnSave);
            this.grpWorkDetail.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.grpWorkDetail.ForeColor = System.Drawing.Color.White;
            this.grpWorkDetail.Location = new System.Drawing.Point(14, 56);
            this.grpWorkDetail.Name = "grpWorkDetail";
            this.grpWorkDetail.Size = new System.Drawing.Size(1588, 634);
            this.grpWorkDetail.TabIndex = 15;
            this.grpWorkDetail.TabStop = false;
            this.grpWorkDetail.Text = "Work Detail Master";
            // 
            // dgvWorkDetail
            // 
            this.dgvWorkDetail.AllowUserToAddRows = false;
            this.dgvWorkDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWorkDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvWorkDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvWorkDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsCheckDescription,
            this.WorkDetail_id,
            this.Description_id,
            this.Description,
            this.Weight,
            this.Rate});
            this.dgvWorkDetail.Location = new System.Drawing.Point(23, 80);
            this.dgvWorkDetail.Name = "dgvWorkDetail";
            this.dgvWorkDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvWorkDetail.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvWorkDetail.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvWorkDetail.Size = new System.Drawing.Size(1551, 473);
            this.dgvWorkDetail.TabIndex = 26;
            this.dgvWorkDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvWorkDetail_CellClick);
            this.dgvWorkDetail.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvWorkDetail_CellFormatting);
            // 
            // cmbWorkName
            // 
            this.cmbWorkName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWorkName.FormattingEnabled = true;
            this.cmbWorkName.Items.AddRange(new object[] {
            "--Select--"});
            this.cmbWorkName.Location = new System.Drawing.Point(689, 30);
            this.cmbWorkName.Name = "cmbWorkName";
            this.cmbWorkName.Size = new System.Drawing.Size(350, 31);
            this.cmbWorkName.TabIndex = 11;
            this.cmbWorkName.SelectedIndexChanged += new System.EventHandler(this.CmbWorkName_SelectedIndexChanged);
            // 
            // lblWorkName
            // 
            this.lblWorkName.AutoSize = true;
            this.lblWorkName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblWorkName.ForeColor = System.Drawing.Color.White;
            this.lblWorkName.Location = new System.Drawing.Point(551, 33);
            this.lblWorkName.Name = "lblWorkName";
            this.lblWorkName.Size = new System.Drawing.Size(128, 23);
            this.lblWorkName.TabIndex = 21;
            this.lblWorkName.Text = "WorkName";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(555, 574);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(504, 54);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // pctClose
            // 
            this.pctClose.Image = global::InHouseInteriorsApplication.Properties.Resources.close2;
            this.pctClose.Location = new System.Drawing.Point(1560, 2);
            this.pctClose.Name = "pctClose";
            this.pctClose.Size = new System.Drawing.Size(50, 50);
            this.pctClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctClose.TabIndex = 14;
            this.pctClose.TabStop = false;
            this.pctClose.Click += new System.EventHandler(this.PctClose_Click);
            // 
            // IsCheckDescription
            // 
            this.IsCheckDescription.DataPropertyName = "IsCheckDescription";
            this.IsCheckDescription.HeaderText = "Choose";
            this.IsCheckDescription.Name = "IsCheckDescription";
            // 
            // WorkDetail_id
            // 
            this.WorkDetail_id.DataPropertyName = "WorkDetail_id";
            this.WorkDetail_id.HeaderText = "WorkDetail_id";
            this.WorkDetail_id.Name = "WorkDetail_id";
            this.WorkDetail_id.Visible = false;
            // 
            // Description_id
            // 
            this.Description_id.DataPropertyName = "Description_id";
            this.Description_id.HeaderText = "Description_id";
            this.Description_id.Name = "Description_id";
            this.Description_id.Visible = false;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Rate
            // 
            this.Rate.DataPropertyName = "Rate";
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // WorkDetailMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1612, 700);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpWorkDetail);
            this.Controls.Add(this.pctClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkDetailMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkDetailMaster";
            this.Load += new System.EventHandler(this.WorkDetailMaster_Load);
            this.grpWorkDetail.ResumeLayout(false);
            this.grpWorkDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpWorkDetail;
        private System.Windows.Forms.DataGridView dgvWorkDetail;
        private System.Windows.Forms.ComboBox cmbWorkName;
        private System.Windows.Forms.Label lblWorkName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pctClose;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsCheckDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkDetail_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
    }
}