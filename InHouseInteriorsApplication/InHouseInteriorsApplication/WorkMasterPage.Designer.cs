namespace InHouseInteriorsApplication
{
    partial class WorkMasterPage
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
            this.grpWork = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtWork_id = new System.Windows.Forms.TextBox();
            this.dgvWork = new System.Windows.Forms.DataGridView();
            this.Work_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtWorkName = new System.Windows.Forms.TextBox();
            this.lblWorkName = new System.Windows.Forms.Label();
            this.pctClose = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpWork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(327, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 45);
            this.label1.TabIndex = 13;
            this.label1.Text = "In-House Interiors";
            // 
            // grpWork
            // 
            this.grpWork.Controls.Add(this.btnClear);
            this.grpWork.Controls.Add(this.btnDelete);
            this.grpWork.Controls.Add(this.txtWork_id);
            this.grpWork.Controls.Add(this.dgvWork);
            this.grpWork.Controls.Add(this.btnSave);
            this.grpWork.Controls.Add(this.txtWorkName);
            this.grpWork.Controls.Add(this.lblWorkName);
            this.grpWork.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.grpWork.ForeColor = System.Drawing.Color.White;
            this.grpWork.Location = new System.Drawing.Point(13, 50);
            this.grpWork.Name = "grpWork";
            this.grpWork.Size = new System.Drawing.Size(976, 519);
            this.grpWork.TabIndex = 12;
            this.grpWork.TabStop = false;
            this.grpWork.Text = "Work Master";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(468, 116);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 42);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // txtWork_id
            // 
            this.txtWork_id.Location = new System.Drawing.Point(715, 51);
            this.txtWork_id.Name = "txtWork_id";
            this.txtWork_id.Size = new System.Drawing.Size(100, 31);
            this.txtWork_id.TabIndex = 26;
            this.txtWork_id.Visible = false;
            // 
            // dgvWork
            // 
            this.dgvWork.AllowUserToAddRows = false;
            this.dgvWork.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvWork.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Work_id,
            this.Description});
            this.dgvWork.Location = new System.Drawing.Point(16, 183);
            this.dgvWork.Name = "dgvWork";
            this.dgvWork.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvWork.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvWork.Size = new System.Drawing.Size(945, 321);
            this.dgvWork.TabIndex = 25;
            this.dgvWork.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvWork_CellClick);
            // 
            // Work_id
            // 
            this.Work_id.DataPropertyName = "Work_id";
            this.Work_id.FillWeight = 101.5228F;
            this.Work_id.HeaderText = "SNo";
            this.Work_id.Name = "Work_id";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "WorkName";
            this.Description.FillWeight = 98.47716F;
            this.Description.HeaderText = "WorkName";
            this.Description.Name = "Description";
            this.Description.Width = 800;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(312, 116);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 42);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click_1);
            // 
            // txtWorkName
            // 
            this.txtWorkName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkName.Location = new System.Drawing.Point(388, 51);
            this.txtWorkName.Name = "txtWorkName";
            this.txtWorkName.Size = new System.Drawing.Size(321, 31);
            this.txtWorkName.TabIndex = 20;
            // 
            // lblWorkName
            // 
            this.lblWorkName.AutoSize = true;
            this.lblWorkName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkName.ForeColor = System.Drawing.Color.White;
            this.lblWorkName.Location = new System.Drawing.Point(244, 53);
            this.lblWorkName.Name = "lblWorkName";
            this.lblWorkName.Size = new System.Drawing.Size(135, 23);
            this.lblWorkName.TabIndex = 18;
            this.lblWorkName.Text = "Work Name";
            // 
            // pctClose
            // 
            this.pctClose.Image = global::InHouseInteriorsApplication.Properties.Resources.close2;
            this.pctClose.Location = new System.Drawing.Point(951, 2);
            this.pctClose.Name = "pctClose";
            this.pctClose.Size = new System.Drawing.Size(50, 50);
            this.pctClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctClose.TabIndex = 11;
            this.pctClose.TabStop = false;
            this.pctClose.Click += new System.EventHandler(this.PctClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(624, 116);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 42);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // WorkMasterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1000, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpWork);
            this.Controls.Add(this.pctClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkMasterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkMasterPage";
            this.Load += new System.EventHandler(this.WorkMasterPage_Load);
            this.grpWork.ResumeLayout(false);
            this.grpWork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpWork;
        private System.Windows.Forms.PictureBox pctClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtWork_id;
        private System.Windows.Forms.DataGridView dgvWork;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtWorkName;
        private System.Windows.Forms.Label lblWorkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Work_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Button btnClear;
    }
}