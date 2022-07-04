
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
            this.SuspendLayout();
            // 
            // lblWorkName
            // 
            this.lblWorkName.AutoSize = true;
            this.lblWorkName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblWorkName.ForeColor = System.Drawing.Color.White;
            this.lblWorkName.Location = new System.Drawing.Point(12, 25);
            this.lblWorkName.Name = "lblWorkName";
            this.lblWorkName.Size = new System.Drawing.Size(154, 23);
            this.lblWorkName.TabIndex = 65;
            this.lblWorkName.Text = "Quotation No";
            // 
            // btnPdf
            // 
            this.btnPdf.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPdf.Location = new System.Drawing.Point(854, 12);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(188, 50);
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
            this.cmbJobOrderNo.Location = new System.Drawing.Point(188, 17);
            this.cmbJobOrderNo.Name = "cmbJobOrderNo";
            this.cmbJobOrderNo.Size = new System.Drawing.Size(250, 31);
            this.cmbJobOrderNo.TabIndex = 150;
            // 
            // GenReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1096, 622);
            this.Controls.Add(this.cmbJobOrderNo);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.lblWorkName);
            this.Name = "GenReport";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWorkName;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.ComboBox cmbJobOrderNo;
    }
}