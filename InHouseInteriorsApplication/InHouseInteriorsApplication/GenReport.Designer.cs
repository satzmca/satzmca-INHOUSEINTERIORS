
using System;
namespace InHouseInteriorsApplication
{
    partial class GenReport
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
            this.lblWorkName = new System.Windows.Forms.Label();
            this.btnPdf = new System.Windows.Forms.Button();
            this.cmbJobOrderNo = new System.Windows.Forms.ComboBox();
            this.grpRemark = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.pctClose = new System.Windows.Forms.PictureBox();
            this.CmbQRequest = new System.Windows.Forms.ComboBox();
            this.grpRemark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWorkName
            // 
            this.lblWorkName.AutoSize = true;
            this.lblWorkName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblWorkName.ForeColor = System.Drawing.Color.White;
            this.lblWorkName.Location = new System.Drawing.Point(12, 17);
            this.lblWorkName.Name = "lblWorkName";
            this.lblWorkName.Size = new System.Drawing.Size(154, 23);
            this.lblWorkName.TabIndex = 65;
            this.lblWorkName.Text = "Quotation No";
            // 
            // btnPdf
            // 
            this.btnPdf.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.ForeColor = System.Drawing.Color.Black;
            this.btnPdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPdf.Location = new System.Drawing.Point(1512, 17);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(138, 39);
            this.btnPdf.TabIndex = 139;
            this.btnPdf.Text = "Genarate";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // cmbJobOrderNo
            // 
            this.cmbJobOrderNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbJobOrderNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbJobOrderNo.DropDownWidth = 150;
            this.cmbJobOrderNo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJobOrderNo.FormattingEnabled = true;
            this.cmbJobOrderNo.Items.AddRange(new object[] {
            "--Select--"});
            this.cmbJobOrderNo.Location = new System.Drawing.Point(172, 17);
            this.cmbJobOrderNo.Name = "cmbJobOrderNo";
            this.cmbJobOrderNo.Size = new System.Drawing.Size(250, 31);
            this.cmbJobOrderNo.TabIndex = 150;
            // 
            // grpRemark
            // 
            this.grpRemark.Controls.Add(this.reportViewer1);
            this.grpRemark.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.grpRemark.ForeColor = System.Drawing.Color.White;
            this.grpRemark.Location = new System.Drawing.Point(12, 52);
            this.grpRemark.Name = "grpRemark";
            this.grpRemark.Size = new System.Drawing.Size(1713, 824);
            this.grpRemark.TabIndex = 151;
            this.grpRemark.TabStop = false;
            this.grpRemark.Text = "Report";
            // 
            // reportViewer1
            // 
            this.reportViewer1.AccessibilityKeyMap = null;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(3, 27);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1707, 794);
            this.reportViewer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(662, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 45);
            this.label1.TabIndex = 152;
            this.label1.Text = "In-House Interiors";
            // 
            // pctClose
            // 
            this.pctClose.Image = global::InHouseInteriorsApplication.Properties.Resources.close2;
            this.pctClose.Location = new System.Drawing.Point(1684, 1);
            this.pctClose.Name = "pctClose";
            this.pctClose.Size = new System.Drawing.Size(50, 50);
            this.pctClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctClose.TabIndex = 151;
            this.pctClose.TabStop = false;
            this.pctClose.Click += new System.EventHandler(this.PctClose_Click);
            // 
            // CmbQRequest
            // 
            this.CmbQRequest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbQRequest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbQRequest.DropDownWidth = 150;
            this.CmbQRequest.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbQRequest.FormattingEnabled = true;
            this.CmbQRequest.Items.AddRange(new object[] {
            "--Select--",
            "CLASSIC",
            "CONTEMPORARY"});
            this.CmbQRequest.Location = new System.Drawing.Point(1201, 17);
            this.CmbQRequest.Name = "CmbQRequest";
            this.CmbQRequest.Size = new System.Drawing.Size(250, 31);
            this.CmbQRequest.TabIndex = 153;
            // 
            // GenReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1620, 883);
            this.Controls.Add(this.CmbQRequest);
            this.Controls.Add(this.cmbJobOrderNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWorkName);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.pctClose);
            this.Controls.Add(this.grpRemark);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.grpRemark.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWorkName;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.ComboBox cmbJobOrderNo;
        private System.Windows.Forms.GroupBox grpRemark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctClose;
        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox CmbQRequest;
    }
}