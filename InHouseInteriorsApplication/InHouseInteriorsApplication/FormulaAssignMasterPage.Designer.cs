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
            this.txtFAssign_id = new System.Windows.Forms.TextBox();
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
            this.cmbSqftCoatingPlain = new System.Windows.Forms.ComboBox();
            this.lblSqftCoatingPlain = new System.Windows.Forms.Label();
            this.cmbTotalPlainCoating = new System.Windows.Forms.ComboBox();
            this.lblTotalPlainCoating = new System.Windows.Forms.Label();
            this.cmbTotalPlain = new System.Windows.Forms.ComboBox();
            this.lblTotalPlain = new System.Windows.Forms.Label();
            this.cmbSqftWoodCoating = new System.Windows.Forms.ComboBox();
            this.lblSqftWoodCoating = new System.Windows.Forms.Label();
            this.cmbTotalWoodCoating = new System.Windows.Forms.ComboBox();
            this.lblTotalWoodCoating = new System.Windows.Forms.Label();
            this.cmbTotalWood = new System.Windows.Forms.ComboBox();
            this.lblTotalWood = new System.Windows.Forms.Label();
            this.FAssign_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Work_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FSize_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FTotal_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FSqftPlainCoating_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FTotalPlainCoating_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FTotalPlain_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FSqftWoodCoating_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FTotalWoodCoating_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FTotalWood_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.grpDescription.Controls.Add(this.cmbTotalWood);
            this.grpDescription.Controls.Add(this.lblTotalWood);
            this.grpDescription.Controls.Add(this.cmbTotalWoodCoating);
            this.grpDescription.Controls.Add(this.lblTotalWoodCoating);
            this.grpDescription.Controls.Add(this.cmbSqftWoodCoating);
            this.grpDescription.Controls.Add(this.lblSqftWoodCoating);
            this.grpDescription.Controls.Add(this.cmbTotalPlain);
            this.grpDescription.Controls.Add(this.lblTotalPlain);
            this.grpDescription.Controls.Add(this.cmbTotalPlainCoating);
            this.grpDescription.Controls.Add(this.lblTotalPlainCoating);
            this.grpDescription.Controls.Add(this.cmbSqftCoatingPlain);
            this.grpDescription.Controls.Add(this.lblSqftCoatingPlain);
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
            this.grpDescription.Size = new System.Drawing.Size(1624, 828);
            this.grpDescription.TabIndex = 16;
            this.grpDescription.TabStop = false;
            this.grpDescription.Text = "Formula Assign Master";
            // 
            // txtFAssign_id
            // 
            this.txtFAssign_id.Location = new System.Drawing.Point(46, 48);
            this.txtFAssign_id.Name = "txtFAssign_id";
            this.txtFAssign_id.Size = new System.Drawing.Size(100, 31);
            this.txtFAssign_id.TabIndex = 28;
            this.txtFAssign_id.Visible = false;
            // 
            // cmbDescription
            // 
            this.cmbDescription.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDescription.FormattingEnabled = true;
            this.cmbDescription.Location = new System.Drawing.Point(413, 122);
            this.cmbDescription.Name = "cmbDescription";
            this.cmbDescription.Size = new System.Drawing.Size(350, 31);
            this.cmbDescription.TabIndex = 26;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(181, 124);
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
            this.cmbWorkName.Location = new System.Drawing.Point(413, 48);
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
            this.lblWorkName.Location = new System.Drawing.Point(181, 48);
            this.lblWorkName.Name = "lblWorkName";
            this.lblWorkName.Size = new System.Drawing.Size(128, 23);
            this.lblWorkName.TabIndex = 24;
            this.lblWorkName.Text = "WorkName";
            // 
            // cmbTotalFormula
            // 
            this.cmbTotalFormula.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTotalFormula.FormattingEnabled = true;
            this.cmbTotalFormula.Location = new System.Drawing.Point(413, 270);
            this.cmbTotalFormula.Name = "cmbTotalFormula";
            this.cmbTotalFormula.Size = new System.Drawing.Size(350, 31);
            this.cmbTotalFormula.TabIndex = 22;
            // 
            // lblTotalFormula
            // 
            this.lblTotalFormula.AutoSize = true;
            this.lblTotalFormula.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFormula.ForeColor = System.Drawing.Color.White;
            this.lblTotalFormula.Location = new System.Drawing.Point(181, 276);
            this.lblTotalFormula.Name = "lblTotalFormula";
            this.lblTotalFormula.Size = new System.Drawing.Size(160, 23);
            this.lblTotalFormula.TabIndex = 21;
            this.lblTotalFormula.Text = "Total Formula";
            // 
            // cmbSizeFormula
            // 
            this.cmbSizeFormula.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSizeFormula.FormattingEnabled = true;
            this.cmbSizeFormula.Location = new System.Drawing.Point(413, 196);
            this.cmbSizeFormula.Name = "cmbSizeFormula";
            this.cmbSizeFormula.Size = new System.Drawing.Size(350, 31);
            this.cmbSizeFormula.TabIndex = 20;
            // 
            // lblSizeFormula
            // 
            this.lblSizeFormula.AutoSize = true;
            this.lblSizeFormula.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeFormula.ForeColor = System.Drawing.Color.White;
            this.lblSizeFormula.Location = new System.Drawing.Point(181, 200);
            this.lblSizeFormula.Name = "lblSizeFormula";
            this.lblSizeFormula.Size = new System.Drawing.Size(150, 23);
            this.lblSizeFormula.TabIndex = 19;
            this.lblSizeFormula.Text = "Size Formula";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(920, 420);
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
            this.btnDelete.Location = new System.Drawing.Point(749, 420);
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
            this.FTotal_id,
            this.FSqftPlainCoating_id,
            this.FTotalPlainCoating_id,
            this.FTotalPlain_id,
            this.FSqftWoodCoating_id,
            this.FTotalWoodCoating_id,
            this.FTotalWood_id});
            this.dgvFormulaAssign.Location = new System.Drawing.Point(6, 481);
            this.dgvFormulaAssign.Name = "dgvFormulaAssign";
            this.dgvFormulaAssign.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFormulaAssign.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvFormulaAssign.Size = new System.Drawing.Size(1614, 341);
            this.dgvFormulaAssign.TabIndex = 15;
            this.dgvFormulaAssign.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFormulaAssign_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(580, 420);
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
            // cmbSqftCoatingPlain
            // 
            this.cmbSqftCoatingPlain.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSqftCoatingPlain.FormattingEnabled = true;
            this.cmbSqftCoatingPlain.Location = new System.Drawing.Point(413, 344);
            this.cmbSqftCoatingPlain.Name = "cmbSqftCoatingPlain";
            this.cmbSqftCoatingPlain.Size = new System.Drawing.Size(350, 31);
            this.cmbSqftCoatingPlain.TabIndex = 30;
            // 
            // lblSqftCoatingPlain
            // 
            this.lblSqftCoatingPlain.AutoSize = true;
            this.lblSqftCoatingPlain.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSqftCoatingPlain.ForeColor = System.Drawing.Color.White;
            this.lblSqftCoatingPlain.Location = new System.Drawing.Point(181, 352);
            this.lblSqftCoatingPlain.Name = "lblSqftCoatingPlain";
            this.lblSqftCoatingPlain.Size = new System.Drawing.Size(219, 23);
            this.lblSqftCoatingPlain.TabIndex = 29;
            this.lblSqftCoatingPlain.Text = "Sqft(Plain Coating)";
            // 
            // cmbTotalPlainCoating
            // 
            this.cmbTotalPlainCoating.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTotalPlainCoating.FormattingEnabled = true;
            this.cmbTotalPlainCoating.Location = new System.Drawing.Point(1028, 48);
            this.cmbTotalPlainCoating.Name = "cmbTotalPlainCoating";
            this.cmbTotalPlainCoating.Size = new System.Drawing.Size(350, 31);
            this.cmbTotalPlainCoating.TabIndex = 32;
            // 
            // lblTotalPlainCoating
            // 
            this.lblTotalPlainCoating.AutoSize = true;
            this.lblTotalPlainCoating.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPlainCoating.ForeColor = System.Drawing.Color.White;
            this.lblTotalPlainCoating.Location = new System.Drawing.Point(792, 51);
            this.lblTotalPlainCoating.Name = "lblTotalPlainCoating";
            this.lblTotalPlainCoating.Size = new System.Drawing.Size(230, 23);
            this.lblTotalPlainCoating.TabIndex = 31;
            this.lblTotalPlainCoating.Text = "Total(Plain Coating)";
            // 
            // cmbTotalPlain
            // 
            this.cmbTotalPlain.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTotalPlain.FormattingEnabled = true;
            this.cmbTotalPlain.Location = new System.Drawing.Point(1028, 122);
            this.cmbTotalPlain.Name = "cmbTotalPlain";
            this.cmbTotalPlain.Size = new System.Drawing.Size(350, 31);
            this.cmbTotalPlain.TabIndex = 34;
            // 
            // lblTotalPlain
            // 
            this.lblTotalPlain.AutoSize = true;
            this.lblTotalPlain.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPlain.ForeColor = System.Drawing.Color.White;
            this.lblTotalPlain.Location = new System.Drawing.Point(792, 124);
            this.lblTotalPlain.Name = "lblTotalPlain";
            this.lblTotalPlain.Size = new System.Drawing.Size(127, 23);
            this.lblTotalPlain.TabIndex = 33;
            this.lblTotalPlain.Text = "Total Plain";
            // 
            // cmbSqftWoodCoating
            // 
            this.cmbSqftWoodCoating.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSqftWoodCoating.FormattingEnabled = true;
            this.cmbSqftWoodCoating.Location = new System.Drawing.Point(1028, 196);
            this.cmbSqftWoodCoating.Name = "cmbSqftWoodCoating";
            this.cmbSqftWoodCoating.Size = new System.Drawing.Size(350, 31);
            this.cmbSqftWoodCoating.TabIndex = 36;
            // 
            // lblSqftWoodCoating
            // 
            this.lblSqftWoodCoating.AutoSize = true;
            this.lblSqftWoodCoating.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSqftWoodCoating.ForeColor = System.Drawing.Color.White;
            this.lblSqftWoodCoating.Location = new System.Drawing.Point(792, 200);
            this.lblSqftWoodCoating.Name = "lblSqftWoodCoating";
            this.lblSqftWoodCoating.Size = new System.Drawing.Size(224, 23);
            this.lblSqftWoodCoating.TabIndex = 35;
            this.lblSqftWoodCoating.Text = "Sqft(Wood Coating)";
            // 
            // cmbTotalWoodCoating
            // 
            this.cmbTotalWoodCoating.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTotalWoodCoating.FormattingEnabled = true;
            this.cmbTotalWoodCoating.Location = new System.Drawing.Point(1028, 270);
            this.cmbTotalWoodCoating.Name = "cmbTotalWoodCoating";
            this.cmbTotalWoodCoating.Size = new System.Drawing.Size(350, 31);
            this.cmbTotalWoodCoating.TabIndex = 38;
            // 
            // lblTotalWoodCoating
            // 
            this.lblTotalWoodCoating.AutoSize = true;
            this.lblTotalWoodCoating.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWoodCoating.ForeColor = System.Drawing.Color.White;
            this.lblTotalWoodCoating.Location = new System.Drawing.Point(792, 276);
            this.lblTotalWoodCoating.Name = "lblTotalWoodCoating";
            this.lblTotalWoodCoating.Size = new System.Drawing.Size(235, 23);
            this.lblTotalWoodCoating.TabIndex = 37;
            this.lblTotalWoodCoating.Text = "Total(Wood Coating)";
            // 
            // cmbTotalWood
            // 
            this.cmbTotalWood.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTotalWood.FormattingEnabled = true;
            this.cmbTotalWood.Location = new System.Drawing.Point(1028, 344);
            this.cmbTotalWood.Name = "cmbTotalWood";
            this.cmbTotalWood.Size = new System.Drawing.Size(350, 31);
            this.cmbTotalWood.TabIndex = 40;
            // 
            // lblTotalWood
            // 
            this.lblTotalWood.AutoSize = true;
            this.lblTotalWood.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWood.ForeColor = System.Drawing.Color.White;
            this.lblTotalWood.Location = new System.Drawing.Point(792, 352);
            this.lblTotalWood.Name = "lblTotalWood";
            this.lblTotalWood.Size = new System.Drawing.Size(132, 23);
            this.lblTotalWood.TabIndex = 39;
            this.lblTotalWood.Text = "Total Wood";
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
            this.WorkName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.WorkName.DataPropertyName = "WorkName";
            this.WorkName.FillWeight = 89.54314F;
            this.WorkName.HeaderText = "WorkName";
            this.WorkName.Name = "WorkName";
            this.WorkName.Width = 300;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Description.DataPropertyName = "Description";
            this.Description.FillWeight = 89.54314F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 300;
            // 
            // FSize_id
            // 
            this.FSize_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FSize_id.DataPropertyName = "FSize_id";
            this.FSize_id.HeaderText = "Size";
            this.FSize_id.Name = "FSize_id";
            this.FSize_id.Width = 80;
            // 
            // FTotal_id
            // 
            this.FTotal_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FTotal_id.DataPropertyName = "FTotal_id";
            this.FTotal_id.FillWeight = 89.54314F;
            this.FTotal_id.HeaderText = "Total";
            this.FTotal_id.Name = "FTotal_id";
            this.FTotal_id.Width = 80;
            // 
            // FSqftPlainCoating_id
            // 
            this.FSqftPlainCoating_id.DataPropertyName = "FSqftPlainCoating_id";
            this.FSqftPlainCoating_id.HeaderText = "SqftPlain";
            this.FSqftPlainCoating_id.Name = "FSqftPlainCoating_id";
            // 
            // FTotalPlainCoating_id
            // 
            this.FTotalPlainCoating_id.DataPropertyName = "FTotalPlainCoating_id";
            this.FTotalPlainCoating_id.HeaderText = "TotalPlain";
            this.FTotalPlainCoating_id.Name = "FTotalPlainCoating_id";
            // 
            // FTotalPlain_id
            // 
            this.FTotalPlain_id.DataPropertyName = "FTotalPlain_id";
            this.FTotalPlain_id.HeaderText = "Total";
            this.FTotalPlain_id.Name = "FTotalPlain_id";
            // 
            // FSqftWoodCoating_id
            // 
            this.FSqftWoodCoating_id.DataPropertyName = "FSqftWoodCoating_id";
            this.FSqftWoodCoating_id.HeaderText = "SqftWood";
            this.FSqftWoodCoating_id.Name = "FSqftWoodCoating_id";
            // 
            // FTotalWoodCoating_id
            // 
            this.FTotalWoodCoating_id.DataPropertyName = "FTotalWoodCoating_id";
            this.FTotalWoodCoating_id.HeaderText = "TotalWood";
            this.FTotalWoodCoating_id.Name = "FTotalWoodCoating_id";
            // 
            // FTotalWood_id
            // 
            this.FTotalWood_id.DataPropertyName = "FTotalWood_id";
            this.FTotalWood_id.HeaderText = "Total";
            this.FTotalWood_id.Name = "FTotalWood_id";
            // 
            // FormulaAssignMasterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1648, 880);
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
        private System.Windows.Forms.ComboBox cmbTotalWood;
        private System.Windows.Forms.Label lblTotalWood;
        private System.Windows.Forms.ComboBox cmbTotalWoodCoating;
        private System.Windows.Forms.Label lblTotalWoodCoating;
        private System.Windows.Forms.ComboBox cmbSqftWoodCoating;
        private System.Windows.Forms.Label lblSqftWoodCoating;
        private System.Windows.Forms.ComboBox cmbTotalPlain;
        private System.Windows.Forms.Label lblTotalPlain;
        private System.Windows.Forms.ComboBox cmbTotalPlainCoating;
        private System.Windows.Forms.Label lblTotalPlainCoating;
        private System.Windows.Forms.ComboBox cmbSqftCoatingPlain;
        private System.Windows.Forms.Label lblSqftCoatingPlain;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAssign_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Work_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn FSize_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FTotal_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FSqftPlainCoating_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FTotalPlainCoating_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FTotalPlain_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FSqftWoodCoating_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FTotalWoodCoating_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FTotalWood_id;
    }
}