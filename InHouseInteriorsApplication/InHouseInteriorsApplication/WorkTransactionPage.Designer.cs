namespace InHouseInteriorsApplication
{
    partial class WorkTransactionPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDescription = new System.Windows.Forms.GroupBox();
            this.dgvWork = new System.Windows.Forms.DataGridView();
            this.Work_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvCbDescription = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SqftCoatingPlain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatePlain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPlainCoating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPlain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SqftWoodCoating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RateWoodCoating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalWoodCoating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalWood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRemove = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpBoxSize = new System.Windows.Forms.GroupBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtBoxSqFt = new System.Windows.Forms.TextBox();
            this.lblShelfQty = new System.Windows.Forms.Label();
            this.txtBoxQty = new System.Windows.Forms.TextBox();
            this.lblBoxSqFt = new System.Windows.Forms.Label();
            this.txtShutterQty = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtShelfQty = new System.Windows.Forms.TextBox();
            this.lblShutterQty = new System.Windows.Forms.Label();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.lblBoxQty = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblDepth = new System.Windows.Forms.Label();
            this.cmbWorkName = new System.Windows.Forms.ComboBox();
            this.lblWorkName = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pctClose = new System.Windows.Forms.PictureBox();
            this.grpDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork)).BeginInit();
            this.grpBoxSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(720, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 45);
            this.label1.TabIndex = 13;
            this.label1.Text = "In-House Interiors";
            // 
            // grpDescription
            // 
            this.grpDescription.Controls.Add(this.dgvWork);
            this.grpDescription.Controls.Add(this.grpBoxSize);
            this.grpDescription.Controls.Add(this.cmbWorkName);
            this.grpDescription.Controls.Add(this.lblWorkName);
            this.grpDescription.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDescription.ForeColor = System.Drawing.Color.White;
            this.grpDescription.Location = new System.Drawing.Point(12, 49);
            this.grpDescription.Name = "grpDescription";
            this.grpDescription.Size = new System.Drawing.Size(1692, 853);
            this.grpDescription.TabIndex = 12;
            this.grpDescription.TabStop = false;
            this.grpDescription.Text = "Work Transaction";
            // 
            // dgvWork
            // 
            this.dgvWork.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvWork.BackgroundColor = System.Drawing.Color.White;
            this.dgvWork.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Work_id,
            this.dataGridViewTextBoxColumn1,
            this.DgvCbDescription,
            this.Size,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Total,
            this.SqftCoatingPlain,
            this.RatePlain,
            this.TotalPlainCoating,
            this.TotalPlain,
            this.SqftWoodCoating,
            this.RateWoodCoating,
            this.TotalWoodCoating,
            this.TotalWood,
            this.BtnRemove});
            this.dgvWork.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvWork.GridColor = System.Drawing.Color.Black;
            this.dgvWork.Location = new System.Drawing.Point(6, 241);
            this.dgvWork.MultiSelect = false;
            this.dgvWork.Name = "dgvWork";
            this.dgvWork.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvWork.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvWork.Size = new System.Drawing.Size(1678, 553);
            this.dgvWork.TabIndex = 39;
            this.dgvWork.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvWork_CellClick);
            this.dgvWork.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvWork_CellEnter);
            this.dgvWork.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvWork_CellFormatting);
            this.dgvWork.CurrentCellDirtyStateChanged += new System.EventHandler(this.DgvWork_CurrentCellDirtyStateChanged);
            this.dgvWork.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgvWork_EditingControlShowing);
            this.dgvWork.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvWork_RowPostPaint);
            // 
            // Work_id
            // 
            this.Work_id.DataPropertyName = "Work_id";
            this.Work_id.HeaderText = "Work_id";
            this.Work_id.Name = "Work_id";
            this.Work_id.Visible = false;
            this.Work_id.Width = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Description_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Description_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 5;
            // 
            // DgvCbDescription
            // 
            this.DgvCbDescription.DataPropertyName = "Description_id";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DgvCbDescription.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCbDescription.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.DgvCbDescription.HeaderText = "Description";
            this.DgvCbDescription.Name = "DgvCbDescription";
            this.DgvCbDescription.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCbDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DgvCbDescription.Width = 180;
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Weight";
            this.dataGridViewTextBoxColumn3.HeaderText = "Weight";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Rate";
            this.dataGridViewTextBoxColumn4.HeaderText = "Rate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // SqftCoatingPlain
            // 
            this.SqftCoatingPlain.HeaderText = "Sqft(Plain)";
            this.SqftCoatingPlain.Name = "SqftCoatingPlain";
            this.SqftCoatingPlain.Width = 130;
            // 
            // RatePlain
            // 
            this.RatePlain.HeaderText = "Rate(Plain)";
            this.RatePlain.Name = "RatePlain";
            this.RatePlain.Width = 130;
            // 
            // TotalPlainCoating
            // 
            this.TotalPlainCoating.HeaderText = "Total(Plain)";
            this.TotalPlainCoating.Name = "TotalPlainCoating";
            this.TotalPlainCoating.Width = 130;
            // 
            // TotalPlain
            // 
            this.TotalPlain.HeaderText = "Total";
            this.TotalPlain.Name = "TotalPlain";
            this.TotalPlain.Width = 120;
            // 
            // SqftWoodCoating
            // 
            this.SqftWoodCoating.HeaderText = "Sqft.(Wood)";
            this.SqftWoodCoating.Name = "SqftWoodCoating";
            this.SqftWoodCoating.Width = 130;
            // 
            // RateWoodCoating
            // 
            this.RateWoodCoating.HeaderText = "Rate(Wood)";
            this.RateWoodCoating.Name = "RateWoodCoating";
            this.RateWoodCoating.Width = 130;
            // 
            // TotalWoodCoating
            // 
            this.TotalWoodCoating.HeaderText = "Total(Wood)";
            this.TotalWoodCoating.Name = "TotalWoodCoating";
            this.TotalWoodCoating.Width = 130;
            // 
            // TotalWood
            // 
            this.TotalWood.HeaderText = "Total";
            this.TotalWood.Name = "TotalWood";
            // 
            // BtnRemove
            // 
            this.BtnRemove.HeaderText = "";
            this.BtnRemove.Image = global::InHouseInteriorsApplication.Properties.Resources.delete;
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BtnRemove.Width = 20;
            // 
            // grpBoxSize
            // 
            this.grpBoxSize.Controls.Add(this.txtWidth);
            this.grpBoxSize.Controls.Add(this.lblWidth);
            this.grpBoxSize.Controls.Add(this.txtBoxSqFt);
            this.grpBoxSize.Controls.Add(this.lblShelfQty);
            this.grpBoxSize.Controls.Add(this.txtBoxQty);
            this.grpBoxSize.Controls.Add(this.lblBoxSqFt);
            this.grpBoxSize.Controls.Add(this.txtShutterQty);
            this.grpBoxSize.Controls.Add(this.lblHeight);
            this.grpBoxSize.Controls.Add(this.txtShelfQty);
            this.grpBoxSize.Controls.Add(this.lblShutterQty);
            this.grpBoxSize.Controls.Add(this.txtDepth);
            this.grpBoxSize.Controls.Add(this.lblBoxQty);
            this.grpBoxSize.Controls.Add(this.txtHeight);
            this.grpBoxSize.Controls.Add(this.lblDepth);
            this.grpBoxSize.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxSize.ForeColor = System.Drawing.Color.White;
            this.grpBoxSize.Location = new System.Drawing.Point(6, 105);
            this.grpBoxSize.Name = "grpBoxSize";
            this.grpBoxSize.Size = new System.Drawing.Size(1680, 113);
            this.grpBoxSize.TabIndex = 38;
            this.grpBoxSize.TabStop = false;
            this.grpBoxSize.Text = "Box Size";
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(19, 66);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(214, 31);
            this.txtWidth.TabIndex = 2;
            this.txtWidth.Text = "0";
            this.txtWidth.TextChanged += new System.EventHandler(this.TxtWidth_TextChanged);
            this.txtWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtWidth_KeyPress);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblWidth.ForeColor = System.Drawing.Color.White;
            this.lblWidth.Location = new System.Drawing.Point(15, 40);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(74, 23);
            this.lblWidth.TabIndex = 24;
            this.lblWidth.Text = "Width";
            // 
            // txtBoxSqFt
            // 
            this.txtBoxSqFt.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSqFt.Location = new System.Drawing.Point(1447, 66);
            this.txtBoxSqFt.Name = "txtBoxSqFt";
            this.txtBoxSqFt.Size = new System.Drawing.Size(214, 31);
            this.txtBoxSqFt.TabIndex = 8;
            this.txtBoxSqFt.Text = "0";
            this.txtBoxSqFt.TextChanged += new System.EventHandler(this.TxtBoxSqFt_TextChanged);
            this.txtBoxSqFt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxSqFt_KeyPress);
            // 
            // lblShelfQty
            // 
            this.lblShelfQty.AutoSize = true;
            this.lblShelfQty.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblShelfQty.ForeColor = System.Drawing.Color.White;
            this.lblShelfQty.Location = new System.Drawing.Point(729, 40);
            this.lblShelfQty.Name = "lblShelfQty";
            this.lblShelfQty.Size = new System.Drawing.Size(110, 23);
            this.lblShelfQty.TabIndex = 30;
            this.lblShelfQty.Text = "Shelf Qty";
            // 
            // txtBoxQty
            // 
            this.txtBoxQty.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxQty.Location = new System.Drawing.Point(1209, 66);
            this.txtBoxQty.Name = "txtBoxQty";
            this.txtBoxQty.Size = new System.Drawing.Size(214, 31);
            this.txtBoxQty.TabIndex = 7;
            this.txtBoxQty.Text = "0";
            this.txtBoxQty.TextChanged += new System.EventHandler(this.TxtBoxQty_TextChanged);
            this.txtBoxQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxQty_KeyPress);
            // 
            // lblBoxSqFt
            // 
            this.lblBoxSqFt.AutoSize = true;
            this.lblBoxSqFt.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblBoxSqFt.ForeColor = System.Drawing.Color.White;
            this.lblBoxSqFt.Location = new System.Drawing.Point(1443, 40);
            this.lblBoxSqFt.Name = "lblBoxSqFt";
            this.lblBoxSqFt.Size = new System.Drawing.Size(108, 23);
            this.lblBoxSqFt.TabIndex = 36;
            this.lblBoxSqFt.Text = "Box Sq.ft";
            // 
            // txtShutterQty
            // 
            this.txtShutterQty.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShutterQty.Location = new System.Drawing.Point(971, 66);
            this.txtShutterQty.Name = "txtShutterQty";
            this.txtShutterQty.Size = new System.Drawing.Size(214, 31);
            this.txtShutterQty.TabIndex = 6;
            this.txtShutterQty.Text = "0";
            this.txtShutterQty.TextChanged += new System.EventHandler(this.TxtShutterQty_TextChanged);
            this.txtShutterQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtShutterQty_KeyPress);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblHeight.ForeColor = System.Drawing.Color.White;
            this.lblHeight.Location = new System.Drawing.Point(253, 40);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(82, 23);
            this.lblHeight.TabIndex = 26;
            this.lblHeight.Text = "Height";
            // 
            // txtShelfQty
            // 
            this.txtShelfQty.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShelfQty.Location = new System.Drawing.Point(733, 66);
            this.txtShelfQty.Name = "txtShelfQty";
            this.txtShelfQty.Size = new System.Drawing.Size(214, 31);
            this.txtShelfQty.TabIndex = 5;
            this.txtShelfQty.Text = "0";
            this.txtShelfQty.TextChanged += new System.EventHandler(this.TxtShelfQty_TextChanged);
            this.txtShelfQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtShelfQty_KeyPress);
            // 
            // lblShutterQty
            // 
            this.lblShutterQty.AutoSize = true;
            this.lblShutterQty.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblShutterQty.ForeColor = System.Drawing.Color.White;
            this.lblShutterQty.Location = new System.Drawing.Point(967, 40);
            this.lblShutterQty.Name = "lblShutterQty";
            this.lblShutterQty.Size = new System.Drawing.Size(136, 23);
            this.lblShutterQty.TabIndex = 32;
            this.lblShutterQty.Text = "Shutter Qty";
            // 
            // txtDepth
            // 
            this.txtDepth.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepth.Location = new System.Drawing.Point(495, 66);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(214, 31);
            this.txtDepth.TabIndex = 4;
            this.txtDepth.Text = "0";
            this.txtDepth.TextChanged += new System.EventHandler(this.TxtDepth_TextChanged);
            this.txtDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDepth_KeyPress);
            // 
            // lblBoxQty
            // 
            this.lblBoxQty.AutoSize = true;
            this.lblBoxQty.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblBoxQty.ForeColor = System.Drawing.Color.White;
            this.lblBoxQty.Location = new System.Drawing.Point(1205, 40);
            this.lblBoxQty.Name = "lblBoxQty";
            this.lblBoxQty.Size = new System.Drawing.Size(94, 23);
            this.lblBoxQty.TabIndex = 34;
            this.lblBoxQty.Text = "Box Qty";
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(257, 66);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(214, 31);
            this.txtHeight.TabIndex = 3;
            this.txtHeight.Text = "0";
            this.txtHeight.TextChanged += new System.EventHandler(this.TxtHeight_TextChanged);
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHeight_KeyPress);
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDepth.ForeColor = System.Drawing.Color.White;
            this.lblDepth.Location = new System.Drawing.Point(491, 40);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(75, 23);
            this.lblDepth.TabIndex = 28;
            this.lblDepth.Text = "Depth";
            // 
            // cmbWorkName
            // 
            this.cmbWorkName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWorkName.FormattingEnabled = true;
            this.cmbWorkName.Location = new System.Drawing.Point(583, 54);
            this.cmbWorkName.Name = "cmbWorkName";
            this.cmbWorkName.Size = new System.Drawing.Size(541, 31);
            this.cmbWorkName.TabIndex = 1;
            this.cmbWorkName.SelectedIndexChanged += new System.EventHandler(this.CmbWorkName_SelectedIndexChanged);
            // 
            // lblWorkName
            // 
            this.lblWorkName.AutoSize = true;
            this.lblWorkName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblWorkName.ForeColor = System.Drawing.Color.White;
            this.lblWorkName.Location = new System.Drawing.Point(794, 27);
            this.lblWorkName.Name = "lblWorkName";
            this.lblWorkName.Size = new System.Drawing.Size(128, 23);
            this.lblWorkName.TabIndex = 23;
            this.lblWorkName.Text = "WorkName";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::InHouseInteriorsApplication.Properties.Resources.delete;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 20;
            // 
            // pctClose
            // 
            this.pctClose.Image = global::InHouseInteriorsApplication.Properties.Resources.close2;
            this.pctClose.Location = new System.Drawing.Point(1661, 3);
            this.pctClose.Name = "pctClose";
            this.pctClose.Size = new System.Drawing.Size(50, 50);
            this.pctClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctClose.TabIndex = 11;
            this.pctClose.TabStop = false;
            this.pctClose.Click += new System.EventHandler(this.PctClose_Click);
            // 
            // WorkTransactionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1716, 914);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpDescription);
            this.Controls.Add(this.pctClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkTransactionPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkTransaction";
            this.Load += new System.EventHandler(this.WorkTransactionPage_Load);
            this.grpDescription.ResumeLayout(false);
            this.grpDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork)).EndInit();
            this.grpBoxSize.ResumeLayout(false);
            this.grpBoxSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctClose;
        private System.Windows.Forms.GroupBox grpDescription;
        private System.Windows.Forms.ComboBox cmbWorkName;
        private System.Windows.Forms.Label lblWorkName;
        private System.Windows.Forms.TextBox txtBoxSqFt;
        private System.Windows.Forms.Label lblBoxSqFt;
        private System.Windows.Forms.TextBox txtBoxQty;
        private System.Windows.Forms.Label lblBoxQty;
        private System.Windows.Forms.TextBox txtShutterQty;
        private System.Windows.Forms.Label lblShutterQty;
        private System.Windows.Forms.TextBox txtShelfQty;
        private System.Windows.Forms.Label lblShelfQty;
        private System.Windows.Forms.TextBox txtDepth;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.GroupBox grpBoxSize;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.DataGridView dgvWork;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Work_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn DgvCbDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn SqftCoatingPlain;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatePlain;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPlainCoating;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPlain;
        private System.Windows.Forms.DataGridViewTextBoxColumn SqftWoodCoating;
        private System.Windows.Forms.DataGridViewTextBoxColumn RateWoodCoating;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalWoodCoating;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalWood;
        private System.Windows.Forms.DataGridViewImageColumn BtnRemove;
    }
}