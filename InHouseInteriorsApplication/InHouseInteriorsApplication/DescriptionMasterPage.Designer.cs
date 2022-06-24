namespace InHouseInteriorsApplication
{
    partial class DescriptionMasterPage
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
            this.pctClose = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.dgvDescription = new System.Windows.Forms.DataGridView();
            this.txtDes_id = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpDescription = new System.Windows.Forms.GroupBox();
            this.txtplainRate = new System.Windows.Forms.TextBox();
            this.lblPlainRate = new System.Windows.Forms.Label();
            this.txtWoodRate = new System.Windows.Forms.TextBox();
            this.lblWoodRate = new System.Windows.Forms.Label();
            this.Description_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlainRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WoodRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescription)).BeginInit();
            this.grpDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(613, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "In-House Interiors";
            // 
            // pctClose
            // 
            this.pctClose.Image = global::InHouseInteriorsApplication.Properties.Resources.close2;
            this.pctClose.Location = new System.Drawing.Point(1490, 0);
            this.pctClose.Name = "pctClose";
            this.pctClose.Size = new System.Drawing.Size(50, 50);
            this.pctClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctClose.TabIndex = 8;
            this.pctClose.TabStop = false;
            this.pctClose.Click += new System.EventHandler(this.PctClose_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(488, 53);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(133, 23);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblWeight.ForeColor = System.Drawing.Color.White;
            this.lblWeight.Location = new System.Drawing.Point(488, 120);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(87, 23);
            this.lblWeight.TabIndex = 9;
            this.lblWeight.Text = "Weight";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(666, 53);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(321, 31);
            this.txtDescription.TabIndex = 1;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(666, 119);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(321, 31);
            this.txtWeight.TabIndex = 2;
            this.txtWeight.TextChanged += new System.EventHandler(this.TxtWeight_TextChanged);
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRate_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(497, 397);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 42);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRate.ForeColor = System.Drawing.Color.White;
            this.lblRate.Location = new System.Drawing.Point(488, 187);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(60, 23);
            this.lblRate.TabIndex = 13;
            this.lblRate.Text = "Rate";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(666, 185);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(321, 31);
            this.txtRate.TabIndex = 3;
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRate_KeyPress);
            // 
            // dgvDescription
            // 
            this.dgvDescription.AllowUserToAddRows = false;
            this.dgvDescription.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDescription.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description_id,
            this.Description,
            this.Weight,
            this.Rate,
            this.PlainRate,
            this.WoodRate});
            this.dgvDescription.Location = new System.Drawing.Point(10, 469);
            this.dgvDescription.Name = "dgvDescription";
            this.dgvDescription.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDescription.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDescription.Size = new System.Drawing.Size(1494, 377);
            this.dgvDescription.TabIndex = 7;
            this.dgvDescription.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDescription_CellClick);
            // 
            // txtDes_id
            // 
            this.txtDes_id.Location = new System.Drawing.Point(993, 53);
            this.txtDes_id.Name = "txtDes_id";
            this.txtDes_id.Size = new System.Drawing.Size(100, 31);
            this.txtDes_id.TabIndex = 16;
            this.txtDes_id.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(653, 397);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 42);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(809, 397);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 42);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // grpDescription
            // 
            this.grpDescription.Controls.Add(this.txtWoodRate);
            this.grpDescription.Controls.Add(this.lblWoodRate);
            this.grpDescription.Controls.Add(this.txtplainRate);
            this.grpDescription.Controls.Add(this.lblPlainRate);
            this.grpDescription.Controls.Add(this.btnClear);
            this.grpDescription.Controls.Add(this.btnDelete);
            this.grpDescription.Controls.Add(this.txtDes_id);
            this.grpDescription.Controls.Add(this.dgvDescription);
            this.grpDescription.Controls.Add(this.txtRate);
            this.grpDescription.Controls.Add(this.lblRate);
            this.grpDescription.Controls.Add(this.btnSave);
            this.grpDescription.Controls.Add(this.txtWeight);
            this.grpDescription.Controls.Add(this.txtDescription);
            this.grpDescription.Controls.Add(this.lblWeight);
            this.grpDescription.Controls.Add(this.lblDescription);
            this.grpDescription.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDescription.ForeColor = System.Drawing.Color.White;
            this.grpDescription.Location = new System.Drawing.Point(13, 50);
            this.grpDescription.Name = "grpDescription";
            this.grpDescription.Size = new System.Drawing.Size(1515, 852);
            this.grpDescription.TabIndex = 9;
            this.grpDescription.TabStop = false;
            this.grpDescription.Text = "Description Master";
            // 
            // txtplainRate
            // 
            this.txtplainRate.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplainRate.Location = new System.Drawing.Point(666, 251);
            this.txtplainRate.Name = "txtplainRate";
            this.txtplainRate.Size = new System.Drawing.Size(321, 31);
            this.txtplainRate.TabIndex = 17;
            this.txtplainRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtplainRate_KeyPress);
            // 
            // lblPlainRate
            // 
            this.lblPlainRate.AutoSize = true;
            this.lblPlainRate.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPlainRate.ForeColor = System.Drawing.Color.White;
            this.lblPlainRate.Location = new System.Drawing.Point(488, 249);
            this.lblPlainRate.Name = "lblPlainRate";
            this.lblPlainRate.Size = new System.Drawing.Size(115, 23);
            this.lblPlainRate.TabIndex = 18;
            this.lblPlainRate.Text = "PlainRate";
            // 
            // txtWoodRate
            // 
            this.txtWoodRate.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWoodRate.Location = new System.Drawing.Point(666, 317);
            this.txtWoodRate.Name = "txtWoodRate";
            this.txtWoodRate.Size = new System.Drawing.Size(321, 31);
            this.txtWoodRate.TabIndex = 19;
            this.txtWoodRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtWoodRate_KeyPress);
            // 
            // lblWoodRate
            // 
            this.lblWoodRate.AutoSize = true;
            this.lblWoodRate.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblWoodRate.ForeColor = System.Drawing.Color.White;
            this.lblWoodRate.Location = new System.Drawing.Point(488, 319);
            this.lblWoodRate.Name = "lblWoodRate";
            this.lblWoodRate.Size = new System.Drawing.Size(127, 23);
            this.lblWoodRate.TabIndex = 20;
            this.lblWoodRate.Text = "Wood Rate";
            // 
            // Description_id
            // 
            this.Description_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Description_id.DataPropertyName = "Description_id";
            this.Description_id.FillWeight = 152.2843F;
            this.Description_id.HeaderText = "SNo";
            this.Description_id.Name = "Description_id";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.FillWeight = 89.54314F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            this.Weight.FillWeight = 89.54314F;
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            // 
            // Rate
            // 
            this.Rate.DataPropertyName = "Rate";
            this.Rate.FillWeight = 89.54314F;
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            // 
            // PlainRate
            // 
            this.PlainRate.DataPropertyName = "PlainRate";
            this.PlainRate.HeaderText = "PlainRate";
            this.PlainRate.Name = "PlainRate";
            // 
            // WoodRate
            // 
            this.WoodRate.DataPropertyName = "WoodRate";
            this.WoodRate.HeaderText = "WoodRate";
            this.WoodRate.Name = "WoodRate";
            // 
            // DescriptionMasterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1540, 914);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpDescription);
            this.Controls.Add(this.pctClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DescriptionMasterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DescriptionMasterPage";
            this.Load += new System.EventHandler(this.DescriptionMasterPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescription)).EndInit();
            this.grpDescription.ResumeLayout(false);
            this.grpDescription.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.DataGridView dgvDescription;
        private System.Windows.Forms.TextBox txtDes_id;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpDescription;
        private System.Windows.Forms.TextBox txtWoodRate;
        private System.Windows.Forms.Label lblWoodRate;
        private System.Windows.Forms.TextBox txtplainRate;
        private System.Windows.Forms.Label lblPlainRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlainRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn WoodRate;
    }
}