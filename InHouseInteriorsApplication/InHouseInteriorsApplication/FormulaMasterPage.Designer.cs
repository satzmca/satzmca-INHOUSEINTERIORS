namespace InHouseInteriorsApplication
{
    partial class FormulaMasterPage
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
            this.grpDescription = new System.Windows.Forms.GroupBox();
            this.btnAdd3 = new System.Windows.Forms.Button();
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.txtFormula_id = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.cmbOperators = new System.Windows.Forms.ComboBox();
            this.cmbTypeName = new System.Windows.Forms.ComboBox();
            this.dgvFormula = new System.Windows.Forms.DataGridView();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.lbOperators = new System.Windows.Forms.Label();
            this.lblFType = new System.Windows.Forms.Label();
            this.Formula_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).BeginInit();
            this.grpDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormula)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(559, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 45);
            this.label1.TabIndex = 12;
            this.label1.Text = "In-House Interiors";
            // 
            // pctClose
            // 
            this.pctClose.Image = global::InHouseInteriorsApplication.Properties.Resources.close2;
            this.pctClose.Location = new System.Drawing.Point(1318, 0);
            this.pctClose.Name = "pctClose";
            this.pctClose.Size = new System.Drawing.Size(50, 50);
            this.pctClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctClose.TabIndex = 11;
            this.pctClose.TabStop = false;
            this.pctClose.Click += new System.EventHandler(this.PctClose_Click);
            // 
            // grpDescription
            // 
            this.grpDescription.Controls.Add(this.btnAdd3);
            this.grpDescription.Controls.Add(this.txtNumbers);
            this.grpDescription.Controls.Add(this.lblNumbers);
            this.grpDescription.Controls.Add(this.txtFormula_id);
            this.grpDescription.Controls.Add(this.btnDelete);
            this.grpDescription.Controls.Add(this.btnSave);
            this.grpDescription.Controls.Add(this.txtFormula);
            this.grpDescription.Controls.Add(this.btnClear);
            this.grpDescription.Controls.Add(this.btnAdd2);
            this.grpDescription.Controls.Add(this.cmbOperators);
            this.grpDescription.Controls.Add(this.cmbTypeName);
            this.grpDescription.Controls.Add(this.dgvFormula);
            this.grpDescription.Controls.Add(this.btnAdd1);
            this.grpDescription.Controls.Add(this.lbOperators);
            this.grpDescription.Controls.Add(this.lblFType);
            this.grpDescription.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDescription.ForeColor = System.Drawing.Color.White;
            this.grpDescription.Location = new System.Drawing.Point(12, 51);
            this.grpDescription.Name = "grpDescription";
            this.grpDescription.Size = new System.Drawing.Size(1345, 711);
            this.grpDescription.TabIndex = 13;
            this.grpDescription.TabStop = false;
            this.grpDescription.Text = "Formula Master";
            // 
            // btnAdd3
            // 
            this.btnAdd3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd3.ForeColor = System.Drawing.Color.Black;
            this.btnAdd3.Location = new System.Drawing.Point(891, 266);
            this.btnAdd3.Name = "btnAdd3";
            this.btnAdd3.Size = new System.Drawing.Size(39, 31);
            this.btnAdd3.TabIndex = 27;
            this.btnAdd3.Text = "+";
            this.btnAdd3.UseVisualStyleBackColor = true;
            this.btnAdd3.Click += new System.EventHandler(this.BtnAdd3_Click);
            // 
            // txtNumbers
            // 
            this.txtNumbers.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumbers.Location = new System.Drawing.Point(530, 266);
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.Size = new System.Drawing.Size(350, 31);
            this.txtNumbers.TabIndex = 26;
            this.txtNumbers.TextChanged += new System.EventHandler(this.TxtNumbers_TextChanged);
            this.txtNumbers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumbers_KeyPress);
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNumbers.ForeColor = System.Drawing.Color.White;
            this.lblNumbers.Location = new System.Drawing.Point(378, 270);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(106, 23);
            this.lblNumbers.TabIndex = 25;
            this.lblNumbers.Text = "Numbers";
            // 
            // txtFormula_id
            // 
            this.txtFormula_id.Location = new System.Drawing.Point(1064, 56);
            this.txtFormula_id.Name = "txtFormula_id";
            this.txtFormula_id.Size = new System.Drawing.Size(100, 31);
            this.txtFormula_id.TabIndex = 24;
            this.txtFormula_id.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(613, 331);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 42);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(451, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 42);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtFormula
            // 
            this.txtFormula.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormula.Location = new System.Drawing.Point(188, 56);
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.Size = new System.Drawing.Size(861, 31);
            this.txtFormula.TabIndex = 21;
            this.txtFormula.TextChanged += new System.EventHandler(this.TxtDescription_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(775, 331);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 42);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnAdd2
            // 
            this.btnAdd2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd2.ForeColor = System.Drawing.Color.Black;
            this.btnAdd2.Location = new System.Drawing.Point(891, 191);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(39, 31);
            this.btnAdd2.TabIndex = 18;
            this.btnAdd2.Text = "+";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.BtnAdd2_Click);
            // 
            // cmbOperators
            // 
            this.cmbOperators.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperators.FormattingEnabled = true;
            this.cmbOperators.Items.AddRange(new object[] {
            "--Select--",
            "+",
            "-",
            "*",
            "/",
            "(",
            ")"});
            this.cmbOperators.Location = new System.Drawing.Point(530, 195);
            this.cmbOperators.Name = "cmbOperators";
            this.cmbOperators.Size = new System.Drawing.Size(350, 31);
            this.cmbOperators.TabIndex = 17;
            // 
            // cmbTypeName
            // 
            this.cmbTypeName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTypeName.FormattingEnabled = true;
            this.cmbTypeName.Location = new System.Drawing.Point(530, 124);
            this.cmbTypeName.Name = "cmbTypeName";
            this.cmbTypeName.Size = new System.Drawing.Size(350, 31);
            this.cmbTypeName.TabIndex = 16;
            // 
            // dgvFormula
            // 
            this.dgvFormula.AllowUserToAddRows = false;
            this.dgvFormula.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFormula.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvFormula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFormula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormula.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Formula_id,
            this.Formula});
            this.dgvFormula.Location = new System.Drawing.Point(210, 404);
            this.dgvFormula.Name = "dgvFormula";
            this.dgvFormula.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFormula.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvFormula.Size = new System.Drawing.Size(945, 281);
            this.dgvFormula.TabIndex = 15;
            this.dgvFormula.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDescription_CellClick);
            // 
            // btnAdd1
            // 
            this.btnAdd1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd1.ForeColor = System.Drawing.Color.Black;
            this.btnAdd1.Location = new System.Drawing.Point(891, 124);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(39, 31);
            this.btnAdd1.TabIndex = 12;
            this.btnAdd1.Text = "+";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.BtnAdd1_Click);
            // 
            // lbOperators
            // 
            this.lbOperators.AutoSize = true;
            this.lbOperators.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbOperators.ForeColor = System.Drawing.Color.White;
            this.lbOperators.Location = new System.Drawing.Point(378, 191);
            this.lbOperators.Name = "lbOperators";
            this.lbOperators.Size = new System.Drawing.Size(116, 23);
            this.lbOperators.TabIndex = 9;
            this.lbOperators.Text = "Operators";
            // 
            // lblFType
            // 
            this.lblFType.AutoSize = true;
            this.lblFType.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFType.ForeColor = System.Drawing.Color.White;
            this.lblFType.Location = new System.Drawing.Point(378, 124);
            this.lblFType.Name = "lblFType";
            this.lblFType.Size = new System.Drawing.Size(149, 23);
            this.lblFType.TabIndex = 8;
            this.lblFType.Text = "FormulaType";
            // 
            // Formula_id
            // 
            this.Formula_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Formula_id.DataPropertyName = "Formula_id";
            this.Formula_id.FillWeight = 101.5228F;
            this.Formula_id.HeaderText = "Formula_id";
            this.Formula_id.Name = "Formula_id";
            this.Formula_id.Width = 150;
            // 
            // Formula
            // 
            this.Formula.DataPropertyName = "Formula";
            this.Formula.FillWeight = 98.47716F;
            this.Formula.HeaderText = "Formula";
            this.Formula.Name = "Formula";
            // 
            // FormulaMasterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1369, 774);
            this.Controls.Add(this.grpDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormulaMasterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormulaMasterPage";
            this.Load += new System.EventHandler(this.FormulaMasterPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).EndInit();
            this.grpDescription.ResumeLayout(false);
            this.grpDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctClose;
        private System.Windows.Forms.GroupBox grpDescription;
        private System.Windows.Forms.DataGridView dgvFormula;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Label lbOperators;
        private System.Windows.Forms.Label lblFType;
        private System.Windows.Forms.ComboBox cmbTypeName;
        private System.Windows.Forms.ComboBox cmbOperators;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtFormula;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFormula_id;
        private System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Button btnAdd3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formula_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formula;
    }
}