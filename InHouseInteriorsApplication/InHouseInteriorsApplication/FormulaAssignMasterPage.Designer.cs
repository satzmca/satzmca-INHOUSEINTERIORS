namespace InHouseInteriorsApplication
{
    partial class FormulaAssignMasterPage
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
            this.cmbDescription = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cmbWorkName = new System.Windows.Forms.ComboBox();
            this.lblWorkName = new System.Windows.Forms.Label();
            this.cmbTotalFormula = new System.Windows.Forms.ComboBox();
            this.lblTotalFormula = new System.Windows.Forms.Label();
            this.cmbSizeFormula = new System.Windows.Forms.ComboBox();
            this.lblSizeFormula = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvFormulaAssign = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.pctClose = new System.Windows.Forms.PictureBox();
            this.txtFAssign_id = new System.Windows.Forms.TextBox();
            this.FAssign_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Work_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FSize_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FTotal_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormulaAssign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(639, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 45);
            this.label1.TabIndex = 17;
            this.label1.Text = "In-House Interiors";
            // 
            // grpDescription
            // 
            this.grpDescription.Controls.Add(this.txtFAssign_id);
            this.grpDescription.Controls.Add(this.cmbDescription);
            this.grpDescription.Controls.Add(this.lblDescription);
            this.grpDescription.Controls.Add(this.cmbWorkName);
            this.grpDescription.Controls.Add(this.lblWorkName);
            this.grpDescription.Controls.Add(this.cmbTotalFormula);
            this.grpDescription.Controls.Add(this.lblTotalFormula);
            this.grpDescription.Controls.Add(this.cmbSizeFormula);
            this.grpDescription.Controls.Add(this.lblSizeFormula);
            this.grpDescription.Controls.Add(this.btnClear);
            this.grpDescription.Controls.Add(this.btnDelete);
            this.grpDescription.Controls.Add(this.dgvFormulaAssign);
            this.grpDescription.Controls.Add(this.btnSave);
            this.grpDescription.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDescription.ForeColor = System.Drawing.Color.White;
            this.grpDescription.Location = new System.Drawing.Point(12, 49);
            this.grpDescription.Name = "grpDescription";
            this.grpDescription.Size = new System.Drawing.Size(1624, 790);
            this.grpDescription.TabIndex = 16;
            this.grpDescription.TabStop = false;
            this.grpDescription.Text = "Formula Assign Master";
            // 
            // cmbDescription
            // 
            this.cmbDescription.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDescription.FormattingEnabled = true;
            this.cmbDescription.Location = new System.Drawing.Point(299, 126);
            this.cmbDescription.Name = "cmbDescription";
            this.cmbDescription.Size = new System.Drawing.Size(350, 31);
            this.cmbDescription.TabIndex = 26;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(121, 120);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(133, 23);
            this.lblDescription.TabIndex = 25;
            this.lblDescription.Text = "Description";
            // 
            // cmbWorkName
            // 
            this.cmbWorkName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWorkName.FormattingEnabled = true;
            this.cmbWorkName.Items.AddRange(new object[] {
            "--Select--"});
            this.cmbWorkName.Location = new System.Drawing.Point(299, 56);
            this.cmbWorkName.Name = "cmbWorkName";
            this.cmbWorkName.Size = new System.Drawing.Size(350, 31);
            this.cmbWorkName.TabIndex = 23;
            this.cmbWorkName.SelectedIndexChanged += new System.EventHandler(this.CmbWorkName_SelectedIndexChanged);
            // 
            // lblWorkName
            // 
            this.lblWorkName.AutoSize = true;
            this.lblWorkName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblWorkName.ForeColor = System.Drawing.Color.White;
            this.lblWorkName.Location = new System.Drawing.Point(121, 56);
            this.lblWorkName.Name = "lblWorkName";
            this.lblWorkName.Size = new System.Drawing.Size(128, 23);
            this.lblWorkName.TabIndex = 24;
            this.lblWorkName.Text = "WorkName";
            // 
            // cmbTotalFormula
            // 
            this.cmbTotalFormula.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTotalFormula.FormattingEnabled = true;
            this.cmbTotalFormula.Location = new System.Drawing.Point(299, 266);
            this.cmbTotalFormula.Name = "cmbTotalFormula";
            this.cmbTotalFormula.Size = new System.Drawing.Size(350, 31);
            this.cmbTotalFormula.TabIndex = 22;
            // 
            // lblTotalFormula
            // 
            this.lblTotalFormula.AutoSize = true;
            this.lblTotalFormula.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFormula.ForeColor = System.Drawing.Color.White;
            this.lblTotalFormula.Location = new System.Drawing.Point(121, 269);
            this.lblTotalFormula.Name = "lblTotalFormula";
            this.lblTotalFormula.Size = new System.Drawing.Size(160, 23);
            this.lblTotalFormula.TabIndex = 21;
            this.lblTotalFormula.Text = "Total Formula";
            // 
            // cmbSizeFormula
            // 
            this.cmbSizeFormula.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSizeFormula.FormattingEnabled = true;
            this.cmbSizeFormula.Location = new System.Drawing.Point(299, 196);
            this.cmbSizeFormula.Name = "cmbSizeFormula";
            this.cmbSizeFormula.Size = new System.Drawing.Size(350, 31);
            this.cmbSizeFormula.TabIndex = 20;
            // 
            // lblSizeFormula
            // 
            this.lblSizeFormula.AutoSize = true;
            this.lblSizeFormula.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeFormula.ForeColor = System.Drawing.Color.White;
            this.lblSizeFormula.Location = new System.Drawing.Point(121, 204);
            this.lblSizeFormula.Name = "lblSizeFormula";
            this.lblSizeFormula.Size = new System.Drawing.Size(150, 23);
            this.lblSizeFormula.TabIndex = 19;
            this.lblSizeFormula.Text = "Size Formula";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(499, 340);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 42);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(343, 340);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 42);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dgvFormulaAssign
            // 
            this.dgvFormulaAssign.AllowUserToAddRows = false;
            this.dgvFormulaAssign.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFormulaAssign.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvFormulaAssign.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFormulaAssign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormulaAssign.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FAssign_id,
            this.Work_id,
            this.Description_id,
            this.WorkName,
            this.Description,
            this.FSize_id,
            this.FTotal_id});
            this.dgvFormulaAssign.Location = new System.Drawing.Point(16, 424);
            this.dgvFormulaAssign.Name = "dgvFormulaAssign";
            this.dgvFormulaAssign.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFormulaAssign.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvFormulaAssign.Size = new System.Drawing.Size(1592, 341);
            this.dgvFormulaAssign.TabIndex = 15;
            this.dgvFormulaAssign.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFormulaAssign_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(187, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 42);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // pctClose
            // 
            this.pctClose.Image = global::InHouseInteriorsApplication.Properties.Resources.close2;
            this.pctClose.Location = new System.Drawing.Point(1596, 1);
            this.pctClose.Name = "pctClose";
            this.pctClose.Size = new System.Drawing.Size(50, 50);
            this.pctClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctClose.TabIndex = 15;
            this.pctClose.TabStop = false;
            this.pctClose.Click += new System.EventHandler(this.PctClose_Click);
            // 
            // txtFAssign_id
            // 
            this.txtFAssign_id.Location = new System.Drawing.Point(671, 56);
            this.txtFAssign_id.Name = "txtFAssign_id";
            this.txtFAssign_id.Size = new System.Drawing.Size(100, 31);
            this.txtFAssign_id.TabIndex = 28;
            this.txtFAssign_id.Visible = false;
            // 
            // FAssign_id
            // 
            this.FAssign_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FAssign_id.DataPropertyName = "FAssign_id";
            this.FAssign_id.FillWeight = 152.2843F;
            this.FAssign_id.HeaderText = "Id";
            this.FAssign_id.Name = "FAssign_id";
            this.FAssign_id.Width = 70;
            // 
            // Work_id
            // 
            this.Work_id.DataPropertyName = "Work_id";
            this.Work_id.FillWeight = 89.54314F;
            this.Work_id.HeaderText = "Work_id";
            this.Work_id.Name = "Work_id";
            this.Work_id.Visible = false;
            // 
            // Description_id
            // 
            this.Description_id.DataPropertyName = "Description_id";
            this.Description_id.FillWeight = 89.54314F;
            this.Description_id.HeaderText = "Description_id";
            this.Description_id.Name = "Description_id";
            this.Description_id.Visible = false;
            // 
            // WorkName
            // 
            this.WorkName.DataPropertyName = "WorkName";
            this.WorkName.FillWeight = 89.54314F;
            this.WorkName.HeaderText = "WorkName";
            this.WorkName.Name = "WorkName";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.FillWeight = 89.54314F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // FSize_id
            // 
            this.FSize_id.DataPropertyName = "FSize_id";
            this.FSize_id.HeaderText = "FSize_id";
            this.FSize_id.Name = "FSize_id";
            // 
            // FTotal_id
            // 
            this.FTotal_id.DataPropertyName = "FTotal_id";
            this.FTotal_id.FillWeight = 89.54314F;
            this.FTotal_id.HeaderText = "FTotal_id";
            this.FTotal_id.Name = "FTotal_id";
            // 
            // FormulaAssignMasterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1648, 848);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpDescription);
            this.Controls.Add(this.pctClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormulaAssignMasterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormulaAssignMasterPage";
            this.Load += new System.EventHandler(this.FormulaAssignMasterPage_Load);
            this.grpDescription.ResumeLayout(false);
            this.grpDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormulaAssign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDescription;
        private System.Windows.Forms.ComboBox cmbTotalFormula;
        private System.Windows.Forms.Label lblTotalFormula;
        private System.Windows.Forms.ComboBox cmbSizeFormula;
        private System.Windows.Forms.Label lblSizeFormula;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvFormulaAssign;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cmbWorkName;
        private System.Windows.Forms.Label lblWorkName;
        private System.Windows.Forms.TextBox txtFAssign_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAssign_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Work_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn FSize_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FTotal_id;
    }
}