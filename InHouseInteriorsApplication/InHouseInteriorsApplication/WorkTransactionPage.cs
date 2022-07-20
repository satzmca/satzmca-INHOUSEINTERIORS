using InHouseInteriorsApplication.Class;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace InHouseInteriorsApplication
{
    public partial class WorkTransactionPage : Form
    {
        ClassConfig cls = new ClassConfig();
        DataTable des_dt = new DataTable();
        DataTable desDetail_dt = new DataTable();
        DataTable Quotation_dt = new DataTable();

        bool isloadQuotation = false;

        DataTable formula_dt = new DataTable();
        int columIndex2 = 2, columIndex3 = 3, columIndex4 = 4, columIndex5 = 5,
                columIndex6 = 6, columIndex7 = 7, columIndex8 = 8, columIndex9 = 9,
                columIndex10 = 10, columIndex11 = 11, columIndex12 = 12, columIndex13 = 13,
                columIndex14 = 14, columIndex16 = 16, columIndex17 = 17, columIndex18 = 18,
                columIndex19 = 19, columIndex20 = 20, columIndex21 = 21, columIndex22 = 22,
                columIndex23 = 23;
        public WorkTransactionPage()
        {
            InitializeComponent();

            int style = ClassConfig.NativeWinAPI.GetWindowLong(this.Handle, ClassConfig.NativeWinAPI.GWL_EXSTYLE);
            style |= ClassConfig.NativeWinAPI.WS_EX_COMPOSITED;
            ClassConfig.NativeWinAPI.SetWindowLong(this.Handle, ClassConfig.NativeWinAPI.GWL_EXSTYLE, style);
        }

        private void PctClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransaction : PctClose_Click" + ex.ToString());
            }
        }

        private void WorkTransactionPage_Load(object sender, EventArgs e)
        {            
            //String math = "(460*700/92900)+(565*700/92900)*2+(565*460/92900)*2";
            //string value = new DataTable().Compute(math, null).ToString();

            //double r = Math.Round(Convert.ToDouble(value), 5);
            //double result = Math.Round(Evaluate(math), 5);            

            try
            {
                LoadTable();
                bindWork();
                DgvWork.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : PartyMasterPage_Load" + ex.ToString());
            }
        }

        public static double Evaluate(string expression)
        {
            var xsltExpression =
                string.Format("number({0})",
                    new Regex(@"([\+\-\*])").Replace(expression, " ${1} ")
                                            .Replace("/", " div ")
                                            .Replace("%", " mod "));

            // ReSharper disable PossibleNullReferenceException
            return (double)new XPathDocument
                (new StringReader("<r/>"))
                    .CreateNavigator()
                    .Evaluate(xsltExpression);
            // ReSharper restore PossibleNullReferenceException
        }

        public void bindWork()
        {
            DataTable workdt = new DataTable();

            cmbParty.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbParty.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbParty.MouseWheel -= new MouseEventHandler(ctl_MouseWheel);
            cmbParty.MouseWheel += new MouseEventHandler(ctl_MouseWheel);

            cmbWorkName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbWorkName.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbWorkName.MouseWheel -= new MouseEventHandler(ctl_MouseWheel);
            cmbWorkName.MouseWheel += new MouseEventHandler(ctl_MouseWheel);

            cmbRemarks.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbRemarks.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbRemarks.MouseWheel -= new MouseEventHandler(ctl_MouseWheel);
            cmbRemarks.MouseWheel += new MouseEventHandler(ctl_MouseWheel);

            var dict = JObject.Parse(@"{'IsWorkSelect':'Y'}");
            workdt = cls.FetchData(SpName: "USP_Work_Insert", ReqType: "SELECT_WORK", dict);
            cmbWorkName.DisplayMember = "WorkName";
            cmbWorkName.ValueMember = "Work_id";
            cmbWorkName.DataSource = workdt;

            DataTable part_dt = new DataTable();
            part_dt = cls.FetchData(SpName: "USP_Party_Insert", ReqType: "SELECT_PARTYDETAIL");
            cmbParty.DisplayMember = "PartyName";
            cmbParty.ValueMember = "Party_id";
            cmbParty.DataSource = part_dt;

            DataTable qdesc = new DataTable();
            qdesc = cls.FetchData(SpName: "USP_WorkDetail_Select", ReqType: "SELECT_QUOTATIONDESC");
            cmbQdesc.DataSource = qdesc;
            cmbQdesc.DisplayMember = "Q_Description";
            cmbQdesc.ValueMember = "QDesc_id";            

            var dict1 = JObject.Parse(@"{'IsDescriptionSelect':'Y'}");
            des_dt = cls.FetchData(SpName: "USP_Description_Insert", ReqType: "SELECT_DESCRIPTION", dict: dict1);
            DataGridViewComboBoxColumn DgvCbDescription = (DataGridViewComboBoxColumn)(DgvWork.Columns["DgvCbDescription"]);
            DgvCbDescription.DataSource = des_dt;
            DgvCbDescription.ValueMember = "Description_id";
            DgvCbDescription.DisplayMember = "Description";            
            
            DataGridViewImageColumn BtnRemove = (DataGridViewImageColumn)(DgvWork.Columns["BtnRemove"]);
            BtnRemove.Width = 35;
            BtnRemove.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageColumn GimageRemove = (DataGridViewImageColumn)(dgvQuotation.Columns["GimageRemove"]);
            GimageRemove.Width = 35;
            GimageRemove.ImageLayout = DataGridViewImageCellLayout.Zoom;


            formula_dt = cls.FetchData(SpName: "USP_FormulaTypeInsert", ReqType: "SELECT_FORMULA");

            bindquotation();
            //BtnRemove.Backg

        }

        public void bindquotation()
        {
            DataTable quo_dt = new DataTable();
            quo_dt = cls.FetchData(SpName: "USP_Quotation_Insert", ReqType: "SELECT_QUOTATION");
            cmbQuotation.DataSource = quo_dt;
            cmbQuotation.DisplayMember = "QNo";
            cmbQuotation.ValueMember = "Q_id";
        }

        private void CmbWorkName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bind();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : CmbWorkName_SelectedIndexChanged" + ex.ToString());
            }
        }

        public void bind()
        {
            DataTable dt = new DataTable();

            if(cmbWorkName.SelectedValue != null)
            {
                if (cmbWorkName.SelectedValue.ToString() != "0" && cmbWorkName.SelectedValue.ToString() != "")
                {
                    var dict = JObject.Parse(@"{'Work_id':'" + cmbWorkName.SelectedValue + "'}");
                    dt = cls.FetchData(SpName: "USP_WorkDetail_Select", ReqType: "SELECT_WORKDETAIL", dict: dict);

                    DgvWork.AutoGenerateColumns = false;
                    DgvWork.DataSource = dt;


                    desDetail_dt = cls.FetchData(SpName: "USP_WorkDetail_Select", ReqType: "SELECT_DETAILWORK", dict: dict);

                    DataBind();
                }
                else
                {
                    DgvWork.DataSource = null;
                }
            }            
        }

        private void TxtWidth_TextChanged(object sender, EventArgs e)
        {
            try
            {             
                if(txtWidth.Text != "" && txtHeight.Text != "")
                {
                    double BoxSqftVal = (Convert.ToDouble(txtWidth.Text) * Convert.ToDouble(txtHeight.Text)) / 92900;
                    txtBoxSqFt.Text = Math.Round(BoxSqftVal,5).ToString();

                    DataBind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : TxtWidth_TextChanged" + ex.ToString());
            }
        }

        private void TxtHeight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtWidth.Text != "" && txtHeight.Text != "")
                {
                    double BoxSqftVal = (Convert.ToDouble(txtWidth.Text) * Convert.ToDouble(txtHeight.Text)) / 92900;
                    txtBoxSqFt.Text = Math.Round(BoxSqftVal, 5).ToString();

                    DataBind();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : TxtHeight_TextChanged" + ex.ToString());
            }
        }

        private void TxtDepth_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDepth.Text != "")
                {
                    DataBind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : TxtDepth_TextChanged" + ex.ToString());
            }
        }

        private void TxtShelfQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtShelfQty.Text != "")
                {
                    DataBind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : TxtShelfQty_TextChanged" + ex.ToString());
            }
        }

        private void TxtShutterQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtShutterQty.Text != "")
                {
                    DataBind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : TxtShutterQty_TextChanged" + ex.ToString());
            }
        }

        private void DgvWork_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DgvWork_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            
        }

        private void DgvWork_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {                
                if (e.ColumnIndex == columIndex2 || e.ColumnIndex == columIndex5 || e.ColumnIndex == columIndex8 || e.ColumnIndex == columIndex12)
                {
                    DataBind();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : DgvWork_CellValueChanged" + ex.ToString());
            }
        }

        private void TxtBoxQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxQty.Text != "")
                {
                    DataBind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : TxtBoxQty_TextChanged" + ex.ToString());
            }
        }

        private void DgvWork_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.ColumnIndex == columIndex2 && dgvWork.CurrentCell.Value != null)
            //{
            //    foreach (DataGridViewRow row in this.dgvWork.Rows)
            //    {
            //        if (row.Index == this.dgvWork.CurrentCell.RowIndex)
            //        {
            //            continue;
            //        }

            //        if (this.dgvWork.CurrentCell.Value == null)
            //        {
            //            continue;
            //        }

            //        if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == dgvWork.CurrentCell.Value.ToString())
            //        {
            //            dgvWork.CurrentCell.Value = 0;
            //        }
            //    }
            //}
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (Validated())
            {
                if (DgvWork.Rows.Count > 0)
                {
                    Quotation_dt.Rows.Add(MakeNewAlldaysRow(Quotation_dt, QId: "0", QDetail_id: "0", QDesc_id: cmbQdesc.SelectedValue.ToString(), QDesc: cmbQdesc.Text.ToString(), Work_id: cmbWorkName.SelectedValue.ToString(),
                        WorkName: cmbWorkName.Text.ToString(), Remark: cmbRemarks.Text.ToString(), Width: txtWidth.Text.ToString(), Depth: txtDepth.Text.ToString(), Height: txtHeight.Text.ToString(),
                        TotalPlain: lbltotalplain1.Text.ToString(), TotalWood: lblwoodtotal1.Text.ToString(), Party_Id: cmbParty.SelectedValue.ToString(),
                        ShelfQty: txtShelfQty.Text.ToString(), ShutterQty: txtShutterQty.Text.ToString(), BoxQty: txtBoxQty.Text.ToString(), BoxSqFt: txtBoxSqFt.Text.ToString(), Remark_id: cmbRemarks.SelectedValue.ToString(),
                        TaxPer: txtOverallTaxPer.Text.ToString(), Transportation: txtTransportation.Text.ToString(), DescTaxPer: txtQdescTaxPer.Text.ToString()));
                    if (Quotation_dt.Rows.Count > 0)
                    {
                        dgvQuotation.AutoGenerateColumns = false;
                        dgvQuotation.DataSource = Quotation_dt;
                        dgvQuotation.Rows[Quotation_dt.Rows.Count - 1].Selected = true;
                        txt_QuotationRowIndex.Text = (Quotation_dt.Rows.Count - 1).ToString();


                        //txtWidth.Text = "0";
                        //txtDepth.Text = "0";
                        //txtHeight.Text = "0";
                        //txtShelfQty.Text = "0";
                        //txtShutterQty.Text = "0";
                        //txtBoxQty.Text = "0";
                        //txtBoxSqFt.Text = "0";

                        isloadQuotation = true;

                    }

                }
                else
                {
                    MessageBox.Show("Not Added");
                }
            }                   
        }

        public void LoadTable()
        {
            Quotation_dt.Columns.Add("Q_id", typeof(string));
            Quotation_dt.Columns.Add("QDetail_id", typeof(string));
            Quotation_dt.Columns.Add("QDesc_id", typeof(string));
            Quotation_dt.Columns.Add("QDesc", typeof(string));
            Quotation_dt.Columns.Add("GWork_id", typeof(string));
            Quotation_dt.Columns.Add("WorkName", typeof(string));
            Quotation_dt.Columns.Add("Remark", typeof(string));
            Quotation_dt.Columns.Add("Width", typeof(string));
            Quotation_dt.Columns.Add("Depth", typeof(string));
            Quotation_dt.Columns.Add("Height", typeof(string));
            Quotation_dt.Columns.Add("GTotalPlain", typeof(string));
            Quotation_dt.Columns.Add("GTotalWood", typeof(string));
            Quotation_dt.Columns.Add("Party_Id", typeof(string));
            Quotation_dt.Columns.Add("ShelfQty", typeof(string));
            Quotation_dt.Columns.Add("ShutterQty", typeof(string));
            Quotation_dt.Columns.Add("BoxQty", typeof(string));
            Quotation_dt.Columns.Add("BoxSqFt", typeof(string));
            Quotation_dt.Columns.Add("Remark_id", typeof(string));
            Quotation_dt.Columns.Add("TaxPer", typeof(string));
            Quotation_dt.Columns.Add("Transportation", typeof(string));
            Quotation_dt.Columns.Add("DescTaxPer", typeof(string));
        }

        static DataRow MakeNewAlldaysRow(DataTable table, string QId, string QDetail_id,  string QDesc_id, string QDesc, string Work_id, string WorkName, string Remark, string Width, string Depth, string Height, 
            string TotalPlain, string TotalWood, string Party_Id, string ShelfQty, string ShutterQty, string BoxQty, string BoxSqFt, string Remark_id, string TaxPer, string Transportation, string DescTaxPer)
        {
            DataRow row = table.NewRow();
            row["Q_id"] = QId;
            row["QDetail_id"] = QDetail_id;
            row["QDesc_id"] = QDesc_id;
            row["QDesc"] = QDesc;
            row["GWork_id"] = Work_id;
            row["WorkName"] = WorkName;
            row["Remark"] = Remark;
            row["Width"] = Width;
            row["Depth"] = Depth;
            row["Height"] = Height;
            row["GTotalPlain"] = TotalPlain;
            row["GTotalWood"] = TotalWood;
            row["Party_Id"] = Party_Id;
            row["ShelfQty"] = ShelfQty;
            row["ShutterQty"] = ShutterQty;
            row["BoxQty"] = BoxQty;
            row["BoxSqFt"] = BoxSqFt;
            row["Remark_id"] = Remark_id;
            row["TaxPer"] = TaxPer;
            row["Transportation"] = Transportation;
            row["DescTaxPer"] = DescTaxPer;
            return row;
        }

        private void DgvQuotation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 12)
                {
                    if (e.RowIndex < dgvQuotation.Rows.Count)
                    {
                        DataGridViewRow row = this.dgvQuotation.Rows[e.RowIndex];
                        string QDetail_id = row.Cells["QDetail_id"].Value.ToString();
                        if(QDetail_id == "0")
                        {
                            dgvQuotation.Rows.RemoveAt(e.RowIndex);
                        }
                        else
                        {
                            dgvQuotation.Rows.RemoveAt(e.RowIndex);

                            var dict = JObject.Parse(@"{'QDetail_id':'" + QDetail_id.ToString() + "'}");
                            string res = cls.InsertData(SpName: "USP_Quotation_Insert", ReqType: "DELETE_QUOTATION_DETAIL", dict: dict);
                            if (res == "1")
                            {
                                //Clear();
                                //bind();
                            }
                        }
                        
                    }
                        
                }
                else if(e.RowIndex >= 0 && dgvQuotation.Rows.Count > 0)
                {
                    isloadQuotation = false;
                    txt_QuotationRowIndex.Text = e.RowIndex.ToString();
                    DataGridViewRow row = this.dgvQuotation.Rows[e.RowIndex];
                    cmbQdesc.SelectedValue = row.Cells["QDesc_id"].Value.ToString();
                    cmbWorkName.SelectedValue = row.Cells["GWork_id"].Value.ToString();
                    //cmbParty.SelectedValue = row.Cells["Party_Id"].Value.ToString();
                    cmbRemarks.SelectedValue = row.Cells["Remark_id"].Value.ToString();
                    
                    //txtOverallTaxPer.Text = row.Cells["TaxPer"].Value.ToString();
                    //txtTransportation.Text = row.Cells["Transportation"].Value.ToString();
                    txtQdescTaxPer.Text = row.Cells["DescTaxPer"].Value.ToString();

                    txtWidth.Text = row.Cells["Width"].Value.ToString();
                    txtHeight.Text = row.Cells["Height"].Value.ToString();
                    txtDepth.Text = row.Cells["Depth"].Value.ToString();
                    txtShelfQty.Text = row.Cells["ShelfQty"].Value.ToString();
                    txtShutterQty.Text = row.Cells["ShutterQty"].Value.ToString();
                    txtBoxQty.Text = row.Cells["BoxQty"].Value.ToString();
                    txtBoxSqFt.Text = row.Cells["BoxSqFt"].Value.ToString();
                    isloadQuotation = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("DescriptionMasterPage : DgvDescription_CellClick" + ex.ToString());
            }            
        }


        public bool Validated()
        {
            if (cmbParty.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Pls Choose party");
                return false;
            }

            if (cmbQdesc.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Pls Choose Q.DESC");
                return false;
            }

            if (cmbWorkName.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Pls Choose WorkName");
                return false;
            }

            if (cmbRemarks.SelectedValue.ToString() == "0" || cmbRemarks.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                MessageBox.Show("Pls Choose Remark");
                return false;
            }

            if (txtWidth.Text == "")
            {
                MessageBox.Show("Pls Type Width");
                return false;
            }

            if (txtHeight.Text == "")
            {
                MessageBox.Show("Pls Type Height");
                return false;
            }

            if (txtDepth.Text == "")
            {
                MessageBox.Show("Pls Type Depth");
                return false;
            }

            return true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validated())
                {
                    if (dgvQuotation.Rows.Count > 0)
                    {
                        int res = 0;
                        if (txtQuotation_id.Text != "")
                        {
                            var dict = JObject.Parse(@"{'Party_Id':'" + cmbParty.SelectedValue.ToString() + "', 'Q_Id':'" + txtQuotation_id.Text.ToString() + "', 'TaxPer':'" + txtOverallTaxPer.Text.ToString() + "' , 'Transportation':'" + txtTransportation.Text.ToString() + "'}");
                            res = cls.InsertDataWithId(SpName: "USP_Quotation_Insert", ReqType: "UPDATE_QUOTATION", dict: dict);
                        }
                        else
                        {
                            var dict = JObject.Parse(@"{'Party_Id':'" + cmbParty.SelectedValue.ToString() + "', 'TaxPer':'" + txtOverallTaxPer.Text.ToString() + "' , 'Transportation':'" + txtTransportation.Text.ToString() + "'}");
                            res = cls.InsertDataWithId(SpName: "USP_Quotation_Insert", ReqType: "INSERT_QUOTATION", dict: dict);
                        }

                        if (res > 0)
                        {
                            foreach (DataGridViewRow row in dgvQuotation.Rows)
                            {
                                DataGridViewTextBoxCell Q_id = row.Cells["Q_id"] as DataGridViewTextBoxCell;
                                DataGridViewTextBoxCell QDetail_id = row.Cells["QDetail_id"] as DataGridViewTextBoxCell;
                                DataGridViewTextBoxCell QDesc_id = row.Cells["QDesc_id"] as DataGridViewTextBoxCell;
                                DataGridViewTextBoxCell QDesc = row.Cells["QDesc"] as DataGridViewTextBoxCell;
                                DataGridViewTextBoxCell GWork_id = row.Cells["GWork_id"] as DataGridViewTextBoxCell;
                                DataGridViewTextBoxCell WorkName = row.Cells["WorkName"] as DataGridViewTextBoxCell;
                                DataGridViewTextBoxCell Remark = row.Cells["Remark"] as DataGridViewTextBoxCell;
                                DataGridViewTextBoxCell Width = row.Cells["Width"] as DataGridViewTextBoxCell;
                                DataGridViewTextBoxCell Depth = row.Cells["Depth"] as DataGridViewTextBoxCell;
                                DataGridViewTextBoxCell Height = row.Cells["Height"] as DataGridViewTextBoxCell;
                                DataGridViewTextBoxCell GTotalPlain = row.Cells["GTotalPlain"] as DataGridViewTextBoxCell;
                                DataGridViewTextBoxCell GTotalWood = row.Cells["GTotalWood"] as DataGridViewTextBoxCell;

                                DataGridViewTextBoxCell ShelfQty = row.Cells["ShelfQty"] as DataGridViewTextBoxCell;
                                DataGridViewTextBoxCell ShutterQty = row.Cells["ShutterQty"] as DataGridViewTextBoxCell;
                                DataGridViewTextBoxCell BoxQty = row.Cells["BoxQty"] as DataGridViewTextBoxCell;
                                DataGridViewTextBoxCell BoxSqFt = row.Cells["BoxSqFt"] as DataGridViewTextBoxCell;
                                DataGridViewTextBoxCell Remark_id = row.Cells["Remark_id"] as DataGridViewTextBoxCell;

                                DataGridViewTextBoxCell TaxPer = row.Cells["TaxPer"] as DataGridViewTextBoxCell;
                                DataGridViewTextBoxCell Transportation = row.Cells["Transportation"] as DataGridViewTextBoxCell;
                                DataGridViewTextBoxCell DescTaxPer = row.Cells["DescTaxPer"] as DataGridViewTextBoxCell;


                                if (Q_id.Value != null && QDetail_id.Value != null)
                                {
                                    string _resdetail = "0";
                                    if (QDetail_id.Value.ToString() == "0")
                                    {
                                        var dict = JObject.Parse(@"{'Q_id':'" + res.ToString() + "', 'QDesc_id':'" + QDesc_id.Value.ToString() + "', 'Work_id':'" + GWork_id.Value.ToString() + "', 'Remark_id':'" + Remark_id.Value.ToString() + "', 'Width':'" + Width.Value.ToString() + "', 'Depth':'" + Depth.Value.ToString() + "', 'Height':'" + Height.Value.ToString() + "', 'TotalPlain':'" + GTotalPlain.Value.ToString() + "', 'TotalWood':'" + GTotalWood.Value.ToString() + "', 'ShelfQty':'" + ShelfQty.Value.ToString() + "', 'ShutterQty':'" + ShutterQty.Value.ToString() + "', 'BoxQty':'" + BoxQty.Value.ToString() + "', 'BoxSqFt':'" + BoxSqFt.Value.ToString() + "', 'DescTaxPer':'" + DescTaxPer.Value.ToString() + "'}");
                                        _resdetail = cls.InsertData(SpName: "USP_Quotation_Insert", ReqType: "INSERT_QUOTATION_DETAIL", dict: dict);
                                    }
                                    else
                                    {
                                        var dict = JObject.Parse(@"{'QDetail_id':'" + QDetail_id.Value.ToString() + "', 'QDesc_id':'" + QDesc_id.Value.ToString() + "', 'Work_id':'" + GWork_id.Value.ToString() + "', 'Remark_id':'" + Remark_id.Value.ToString() + "', 'Width':'" + Width.Value.ToString() + "', 'Depth':'" + Depth.Value.ToString() + "', 'Height':'" + Height.Value.ToString() + "', 'TotalPlain':'" + GTotalPlain.Value.ToString() + "', 'TotalWood':'" + GTotalWood.Value.ToString() + "', 'ShelfQty':'" + ShelfQty.Value.ToString() + "', 'ShutterQty':'" + ShutterQty.Value.ToString() + "', 'BoxQty':'" + BoxQty.Value.ToString() + "', 'BoxSqFt':'" + BoxSqFt.Value.ToString() + "', 'DescTaxPer':'" + DescTaxPer.Value.ToString() + "'}");
                                        _resdetail = cls.InsertData(SpName: "USP_Quotation_Insert", ReqType: "UPDATE_QUOTATION_DETAIL", dict: dict);
                                    }
                                }
                            }
                            Clear();
                            MessageBox.Show("Quotation Generate Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Error Geneate Quotation");
                        }

                    }
                    else
                    {
                        MessageBox.Show("atleast Add One Data in Quotation");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : BtnSave_Click" + ex.ToString());
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : BtnClear_Click" + ex.ToString());
            }
        }
        

        private void TxtBoxSqFt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxSqFt.Text != "")
                {
                    DataBind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : TxtBoxSqFt_TextChanged" + ex.ToString());
            }
        }

        private void CmbQuotation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbQuotation.SelectedValue.ToString() != "0" && cmbQuotation.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    isloadQuotation = false;
                    QuotationDetailBind();
                }
                else
                {
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : CmbQuotation_SelectedIndexChanged" + ex.ToString());
            }
        }

        public void QuotationDetailBind()
        {
            txtQuotation_id.Text = cmbQuotation.SelectedValue.ToString();
            var dict = JObject.Parse(@"{'Q_Id':'" + cmbQuotation.SelectedValue.ToString() + "'}");
            DataTable dt = new DataTable();
            dt = cls.FetchData(SpName: "USP_Quotation_Insert", ReqType: "SELECT_QUOTATIONDETAIL", dict: dict);
            dgvQuotation.DataSource = null;
            dgvQuotation.AutoGenerateColumns = false;
            Quotation_dt = dt;
            dgvQuotation.DataSource = Quotation_dt;

            if(dgvQuotation.Rows.Count > 0)
            {
                cmbParty.SelectedValue = Quotation_dt.Rows[0]["Party_Id"].ToString();
                cmbQdesc.SelectedValue = Quotation_dt.Rows[0]["QDesc_id"].ToString();
                cmbWorkName.SelectedValue = Quotation_dt.Rows[0]["GWork_id"].ToString();
                cmbRemarks.SelectedValue = Quotation_dt.Rows[0]["Remark_id"].ToString();

                txtOverallTaxPer.Text = Quotation_dt.Rows[0]["TaxPer"].ToString();
                txtTransportation.Text = Quotation_dt.Rows[0]["Transportation"].ToString();
                txtQdescTaxPer.Text = Quotation_dt.Rows[0]["DescTaxPer"].ToString();
                txt_QuotationRowIndex.Text = "0";               

                txtWidth.Text = Quotation_dt.Rows[0]["Width"].ToString();
                txtHeight.Text = Quotation_dt.Rows[0]["Height"].ToString();
                txtDepth.Text = Quotation_dt.Rows[0]["Depth"].ToString();
                txtShelfQty.Text = Quotation_dt.Rows[0]["ShelfQty"].ToString();
                txtShutterQty.Text = Quotation_dt.Rows[0]["ShutterQty"].ToString();
                txtBoxQty.Text = Quotation_dt.Rows[0]["BoxQty"].ToString();
                txtBoxSqFt.Text = Quotation_dt.Rows[0]["BoxSqFt"].ToString();
                isloadQuotation = true;

            }
        }

        private void CmbParty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void CmbQdesc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                if (cmbQdesc.SelectedValue.ToString() != "0" && cmbQdesc.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    DataTable qremark = new DataTable();
                    var dict = JObject.Parse(@"{'QDesc_id':'" + cmbQdesc.SelectedValue.ToString() + "', 'IsRemarkSelect':'Y'}");
                    qremark = cls.FetchData(SpName: "USP_Remarks_Insert", ReqType: "SELECT_REMARKS", dict: dict);
                    cmbRemarks.DataSource = qremark;
                    cmbRemarks.DisplayMember = "Remarks";
                    cmbRemarks.ValueMember = "Remarks_id";

                    quotation_update();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : CmbQdesc_SelectedIndexChanged" + ex.ToString());
            }
        }

        private void TxtQdescTaxPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (Regex.IsMatch(txtQdescTaxPer.Text, @"\.\d\d\d\d"))
            {
                e.Handled = true;
            }
        }

        private void TxtOverallTaxPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (Regex.IsMatch(txtOverallTaxPer.Text, @"\.\d\d\d\d"))
            {
                e.Handled = true;
            }
        }

        private void TxtTransportation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (Regex.IsMatch(txtTransportation.Text, @"\.\d\d\d\d"))
            {
                e.Handled = true;
            }
        }

        private void TxtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (Regex.IsMatch(txtWidth.Text, @"\.\d\d\d\d"))
            {
                e.Handled = true;
            }
        }

        private void CmbRemarks_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                quotation_update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : CmbRemarks_SelectedIndexChanged" + ex.ToString());
            }
        }

        private void TxtQdescTaxPer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                quotation_update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : TxtQdescTaxPer_TextChanged" + ex.ToString());
            }
        }

        private void BtnClone_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validated())
                {
                    var confirmResult = MessageBox.Show("Are you sure to Clone Quotation ??", "Confirm!!", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        if (dgvQuotation.Rows.Count > 0)
                        {
                            int res = 0;

                            var qdict = JObject.Parse(@"{'Party_Id':'" + cmbParty.SelectedValue.ToString() + "', 'TaxPer':'" + txtOverallTaxPer.Text.ToString() + "' , 'Transportation':'" + txtTransportation.Text.ToString() + "'}");
                            res = cls.InsertDataWithId(SpName: "USP_Quotation_Insert", ReqType: "INSERT_QUOTATION", dict: qdict);


                            if (res > 0)
                            {
                                foreach (DataGridViewRow row in dgvQuotation.Rows)
                                {
                                    DataGridViewTextBoxCell Q_id = row.Cells["Q_id"] as DataGridViewTextBoxCell;
                                    DataGridViewTextBoxCell QDetail_id = row.Cells["QDetail_id"] as DataGridViewTextBoxCell;
                                    DataGridViewTextBoxCell QDesc_id = row.Cells["QDesc_id"] as DataGridViewTextBoxCell;
                                    DataGridViewTextBoxCell QDesc = row.Cells["QDesc"] as DataGridViewTextBoxCell;
                                    DataGridViewTextBoxCell GWork_id = row.Cells["GWork_id"] as DataGridViewTextBoxCell;
                                    DataGridViewTextBoxCell WorkName = row.Cells["WorkName"] as DataGridViewTextBoxCell;
                                    DataGridViewTextBoxCell Remark = row.Cells["Remark"] as DataGridViewTextBoxCell;
                                    DataGridViewTextBoxCell Width = row.Cells["Width"] as DataGridViewTextBoxCell;
                                    DataGridViewTextBoxCell Depth = row.Cells["Depth"] as DataGridViewTextBoxCell;
                                    DataGridViewTextBoxCell Height = row.Cells["Height"] as DataGridViewTextBoxCell;
                                    DataGridViewTextBoxCell GTotalPlain = row.Cells["GTotalPlain"] as DataGridViewTextBoxCell;
                                    DataGridViewTextBoxCell GTotalWood = row.Cells["GTotalWood"] as DataGridViewTextBoxCell;

                                    DataGridViewTextBoxCell ShelfQty = row.Cells["ShelfQty"] as DataGridViewTextBoxCell;
                                    DataGridViewTextBoxCell ShutterQty = row.Cells["ShutterQty"] as DataGridViewTextBoxCell;
                                    DataGridViewTextBoxCell BoxQty = row.Cells["BoxQty"] as DataGridViewTextBoxCell;
                                    DataGridViewTextBoxCell BoxSqFt = row.Cells["BoxSqFt"] as DataGridViewTextBoxCell;
                                    DataGridViewTextBoxCell Remark_id = row.Cells["Remark_id"] as DataGridViewTextBoxCell;

                                    DataGridViewTextBoxCell TaxPer = row.Cells["TaxPer"] as DataGridViewTextBoxCell;
                                    DataGridViewTextBoxCell Transportation = row.Cells["Transportation"] as DataGridViewTextBoxCell;
                                    DataGridViewTextBoxCell DescTaxPer = row.Cells["DescTaxPer"] as DataGridViewTextBoxCell;


                                    if (Q_id.Value != null && QDetail_id.Value != null)
                                    {
                                        string _resdetail = "0";
                                        var dict = JObject.Parse(@"{'Q_id':'" + res.ToString() + "', 'QDesc_id':'" + QDesc_id.Value.ToString() + "', 'Work_id':'" + GWork_id.Value.ToString() + "', 'Remark_id':'" + Remark_id.Value.ToString() + "', 'Width':'" + Width.Value.ToString() + "', 'Depth':'" + Depth.Value.ToString() + "', 'Height':'" + Height.Value.ToString() + "', 'TotalPlain':'" + GTotalPlain.Value.ToString() + "', 'TotalWood':'" + GTotalWood.Value.ToString() + "', 'ShelfQty':'" + ShelfQty.Value.ToString() + "', 'ShutterQty':'" + ShutterQty.Value.ToString() + "', 'BoxQty':'" + BoxQty.Value.ToString() + "', 'BoxSqFt':'" + BoxSqFt.Value.ToString() + "', 'DescTaxPer':'" + DescTaxPer.Value.ToString() + "'}");
                                        _resdetail = cls.InsertData(SpName: "USP_Quotation_Insert", ReqType: "INSERT_QUOTATION_DETAIL", dict: dict);
                                    }
                                }
                                Clear();
                                MessageBox.Show("Quotation Clone Successfully");
                            }
                            else
                            {
                                MessageBox.Show("Error Geneate Quotation");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : BtnClone_Click" + ex.ToString());
            }
        }       

        private void TxtQdescTaxPer_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtQdescTaxPer.Text))
            {
                txtQdescTaxPer.SelectionStart = 0;
                txtQdescTaxPer.SelectionLength = txtQdescTaxPer.Text.Length;
            }
        }

        private void TxtOverallTaxPer_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtOverallTaxPer.Text))
            {
                txtOverallTaxPer.SelectionStart = 0;
                txtOverallTaxPer.SelectionLength = txtOverallTaxPer.Text.Length;
            }
        }

        private void TxtTransportation_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTransportation.Text))
            {
                txtTransportation.SelectionStart = 0;
                txtTransportation.SelectionLength = txtTransportation.Text.Length;
            }
        }

        private void TxtWidth_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtWidth.Text))
            {
                txtWidth.SelectionStart = 0;
                txtWidth.SelectionLength = txtWidth.Text.Length;
            }
        }

        private void TxtHeight_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtHeight.Text))
            {
                txtHeight.SelectionStart = 0;
                txtHeight.SelectionLength = txtHeight.Text.Length;
            }
        }

        private void TxtDepth_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDepth.Text))
            {
                txtDepth.SelectionStart = 0;
                txtDepth.SelectionLength = txtDepth.Text.Length;
            }
        }

        private void TxtShelfQty_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtShelfQty.Text))
            {
                txtShelfQty.SelectionStart = 0;
                txtShelfQty.SelectionLength = txtShelfQty.Text.Length;
            }
        }

        private void TxtShutterQty_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtShutterQty.Text))
            {
                txtShutterQty.SelectionStart = 0;
                txtShutterQty.SelectionLength = txtShutterQty.Text.Length;
            }
        }

        private void TxtBoxQty_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBoxQty.Text))
            {
                txtBoxQty.SelectionStart = 0;
                txtBoxQty.SelectionLength = txtBoxQty.Text.Length;
            }
        }

        private void TxtBoxSqFt_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBoxSqFt.Text))
            {
                txtBoxSqFt.SelectionStart = 0;
                txtBoxSqFt.SelectionLength = txtBoxSqFt.Text.Length;
            }
        }

        private void TxtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (Regex.IsMatch(txtHeight.Text, @"\.\d\d\d\d"))
            {
                e.Handled = true;
            }
        }

        private void TxtDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (Regex.IsMatch(txtDepth.Text, @"\.\d\d\d\d"))
            {
                e.Handled = true;
            }
        }

        private void TxtShelfQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (Regex.IsMatch(txtShelfQty.Text, @"\.\d\d\d\d"))
            {
                e.Handled = true;
            }
        }

        private void TxtShutterQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (Regex.IsMatch(txtShutterQty.Text, @"\.\d\d\d\d"))
            {
                e.Handled = true;
            }
        }

        private void TxtBoxQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (Regex.IsMatch(txtBoxQty.Text, @"\.\d\d\d\d"))
            {
                e.Handled = true;
            }
        }

        private void TxtBoxSqFt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (Regex.IsMatch(txtBoxSqFt.Text, @"\.\d\d\d\d"))
            {
                e.Handled = true;
            }
        }

        private void DgvWork_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }            
        }

        private void DgvWork_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Image deleteImg = Properties.Resources.delete;

            if (e.ColumnIndex == 15)
            {                
                e.Value = deleteImg;
            }
                
        }

        private void DgvWork_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 15)
            {
                if (e.RowIndex < DgvWork.Rows.Count - 1)
                {
                    DgvWork.Rows.RemoveAt(e.RowIndex);
                    DataBind();
                }
                    
            }

            //var editingControl = this.dgvWork.EditingControl as DataGridViewComboBoxEditingControl;
            //if (editingControl != null)
            //    editingControl.DroppedDown = true;
        }

        private void DgvWork_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (DgvWork.CurrentCell.ColumnIndex == 2 && e.Control is ComboBox)
            {
                ComboBox comboBox = e.Control as ComboBox;
                if (comboBox != null)
                {
                    
                    comboBox.SelectedIndexChanged -= LastColumnComboSelectionChanged;
                    comboBox.SelectedIndexChanged += LastColumnComboSelectionChanged;
                    //comboBox.Enter -= new EventHandler(ctl_Enter);
                    //comboBox.Enter += new EventHandler(ctl_Enter);


                    //comboBox.MouseWheel -= new MouseEventHandler();
                    //comboBox.MouseWheel += new MouseEventHandler(ctl_MouseWheel);
                    //comboBox.BackColor = Color.White;ctl_MouseWheel
                    //comboBox.ForeColor = Color.Black;
                    e.CellStyle.BackColor = this.DgvWork.DefaultCellStyle.BackColor;
                }
            }

            if (e.Control is TextBox)
            {
                TextBox TextBox = e.Control as TextBox;
                if (TextBox != null)
                {
                    TextBox.KeyPress -= LastKeyPressEvent;
                    TextBox.KeyPress += LastKeyPressEvent;
                }
            }
            
            //DataGridViewTextBoxCell weight_cel = (DataGridViewTextBoxCell)dgvWork.Rows[currentcell.Y].Cells[columIndex4];
            //DataGridViewTextBoxCell rate_cel = (DataGridViewTextBoxCell)dgvWork.Rows[currentcell.Y].Cells[columIndex5];
        }

        private void LastKeyPressEvent(object sender, KeyPressEventArgs e)
        {            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (Regex.IsMatch((sender as TextBox).Text, @"\.\d\d\d\d"))
            {
                e.Handled = true;
            }
        }

        private void LastColumnComboSelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var currentcell = DgvWork.CurrentCellAddress;
                var sendingCB = sender as DataGridViewComboBoxEditingControl;
                //sendingCB.ForeColor = Color.Black;
                //sendingCB.BackColor = Color.White;

                if (sendingCB.SelectedValue != null && cmbWorkName.SelectedValue != null &&  cmbWorkName.SelectedValue.ToString() !="0")
                {
                    if(sendingCB.SelectedValue.ToString() != "" && sendingCB.SelectedValue.ToString() != "System.Data.DataRowView")
                    {
                        //DataRow[] rslt = des_dt.Select("Description_id=" + sendingCB.SelectedValue.ToString());
                        //if (rslt.Length > 0)
                        //{
                        //    DataTable dt = rslt.CopyToDataTable();

                        //    if (dt.Rows.Count > 0)
                        //    {
                                


                                DataRow[] rslt2 = desDetail_dt.Select("Work_id=" + cmbWorkName.SelectedValue.ToString() + "And Description_id=" + sendingCB.SelectedValue.ToString());
                        if (rslt2.Length > 0)
                        {
                            DataTable dt_workdesc = rslt2.CopyToDataTable();
                            if (dt_workdesc.Rows.Count > 0)
                            {

                                DataGridViewTextBoxCell weight_cel = (DataGridViewTextBoxCell)DgvWork.Rows[currentcell.Y].Cells[columIndex4];
                                DataGridViewTextBoxCell rate_cel = (DataGridViewTextBoxCell)DgvWork.Rows[currentcell.Y].Cells[columIndex5];
                                DataGridViewTextBoxCell plainrate_cel = (DataGridViewTextBoxCell)DgvWork.Rows[currentcell.Y].Cells[columIndex8];
                                DataGridViewTextBoxCell woodrate_cel = (DataGridViewTextBoxCell)DgvWork.Rows[currentcell.Y].Cells[columIndex12];
                                weight_cel.Value = dt_workdesc.Rows[0]["Weight"].ToString();
                                rate_cel.Value = dt_workdesc.Rows[0]["Rate"].ToString();
                                plainrate_cel.Value = dt_workdesc.Rows[0]["PlainRate"].ToString();
                                woodrate_cel.Value = dt_workdesc.Rows[0]["WoodRate"].ToString();

                                DataGridViewTextBoxCell size_idcell = (DataGridViewTextBoxCell)DgvWork.Rows[currentcell.Y].Cells[columIndex16];
                                DataGridViewTextBoxCell total_idcell = (DataGridViewTextBoxCell)DgvWork.Rows[currentcell.Y].Cells[columIndex17];

                                DataGridViewTextBoxCell sqftPlainCoating_idcell = (DataGridViewTextBoxCell)DgvWork.Rows[currentcell.Y].Cells[columIndex18];
                                DataGridViewTextBoxCell totalPlainCoating_idcell = (DataGridViewTextBoxCell)DgvWork.Rows[currentcell.Y].Cells[columIndex19];
                                DataGridViewTextBoxCell totalPlain_idcell = (DataGridViewTextBoxCell)DgvWork.Rows[currentcell.Y].Cells[columIndex20];

                                DataGridViewTextBoxCell sqftWoodCoating_idcell = (DataGridViewTextBoxCell)DgvWork.Rows[currentcell.Y].Cells[columIndex21];
                                DataGridViewTextBoxCell totalWoodCoating_idcell = (DataGridViewTextBoxCell)DgvWork.Rows[currentcell.Y].Cells[columIndex22];
                                DataGridViewTextBoxCell totalWood_idcell = (DataGridViewTextBoxCell)DgvWork.Rows[currentcell.Y].Cells[columIndex23];


                                size_idcell.Value = dt_workdesc.Rows[0]["FSize_id"].ToString();
                                total_idcell.Value = dt_workdesc.Rows[0]["FTotal_id"].ToString();

                                sqftPlainCoating_idcell.Value = dt_workdesc.Rows[0]["FSqftPlainCoating_id"].ToString();
                                totalPlainCoating_idcell.Value = dt_workdesc.Rows[0]["FTotalPlainCoating_id"].ToString();
                                totalPlain_idcell.Value = dt_workdesc.Rows[0]["FTotalPlain_id"].ToString();

                                sqftWoodCoating_idcell.Value = dt_workdesc.Rows[0]["FSqftWoodCoating_id"].ToString();
                                totalWoodCoating_idcell.Value = dt_workdesc.Rows[0]["FTotalWoodCoating_id"].ToString();
                                totalWood_idcell.Value = dt_workdesc.Rows[0]["FTotalWood_id"].ToString();
                            }
                            //    }
                            //}
                        }
                    }                    
                }

                //DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : LastColumnComboSelectionChanged" + ex.ToString());
            }
        }

        private void ctl_Enter(object sender, EventArgs e)
        {
            DgvWork.BeginEdit(true);
            (sender as ComboBox).DroppedDown = true;
        }

        private void ctl_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void DgvWork_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //bool validClick = (e.RowIndex != -1 && e.ColumnIndex != -1); //Make sure the clicked row/column is valid.
            //var datagridview = sender as DataGridView;

            //// Check to make sure the cell clicked is the cell containing the combobox 
            //if (datagridview.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && validClick)
            //{
            //    //datagridview.BeginEdit(true);
            //    //((ComboBox)datagridview.EditingControl).DroppedDown = true;
            //    ((ComboBox)datagridview.EditingControl).ForeColor = Color.Black;
            //    ((ComboBox)datagridview.EditingControl).BackColor = Color.White;
            //}
        }

        private void DgvWork_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //dgvWork.CommitEdit(DataGridViewDataErrorContexts.Commit);
            if (DgvWork.IsCurrentCellDirty)
            {
                // This fires the cell value changed handler below
                DgvWork.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }



     
        public void DataBind()
        {
            
            foreach (DataGridViewRow row in DgvWork.Rows)
            {
                DataGridViewComboBoxCell DescriptionCell = row.Cells[columIndex2] as DataGridViewComboBoxCell;

                if(DescriptionCell.ColumnIndex == columIndex2 && DescriptionCell.Value != null)
                {
                    if(DescriptionCell.Value.ToString() != "" && DescriptionCell.Value.ToString() != "--Select--")
                    {
                        DataGridViewTextBoxCell sizecell = row.Cells[columIndex3] as DataGridViewTextBoxCell;
                        DataGridViewTextBoxCell weightcell = row.Cells[columIndex4] as DataGridViewTextBoxCell;
                        DataGridViewTextBoxCell ratecell = row.Cells[columIndex5] as DataGridViewTextBoxCell;
                        DataGridViewTextBoxCell totalcell = row.Cells[columIndex6] as DataGridViewTextBoxCell;


                        DataGridViewTextBoxCell sqftPlainCoatingCell = row.Cells[columIndex7] as DataGridViewTextBoxCell;
                        DataGridViewTextBoxCell ratePlainCoatingCell = row.Cells[columIndex8] as DataGridViewTextBoxCell;
                        DataGridViewTextBoxCell totalPlainCoatingCell = row.Cells[columIndex9] as DataGridViewTextBoxCell;
                        DataGridViewTextBoxCell totalPlainCell = row.Cells[columIndex10] as DataGridViewTextBoxCell;

                        DataGridViewTextBoxCell sqftWoodCoatingCell = row.Cells[columIndex11] as DataGridViewTextBoxCell;
                        DataGridViewTextBoxCell rateWoodCoatingCell = row.Cells[columIndex12] as DataGridViewTextBoxCell;
                        DataGridViewTextBoxCell totalWoodCoatingCell = row.Cells[columIndex13] as DataGridViewTextBoxCell;
                        DataGridViewTextBoxCell totalWoodCell = row.Cells[columIndex14] as DataGridViewTextBoxCell;

                        DataGridViewTextBoxCell size_idcell = row.Cells[columIndex16] as DataGridViewTextBoxCell;
                        DataGridViewTextBoxCell total_idcell = row.Cells[columIndex17] as DataGridViewTextBoxCell;

                        DataGridViewTextBoxCell sqftPlainCoating_idcell = row.Cells[columIndex18] as DataGridViewTextBoxCell;
                        DataGridViewTextBoxCell totalPlainCoating_idcell = row.Cells[columIndex19] as DataGridViewTextBoxCell;
                        DataGridViewTextBoxCell totalPlain_idcell = row.Cells[columIndex20] as DataGridViewTextBoxCell;

                        DataGridViewTextBoxCell sqftWoodCoating_idcell = row.Cells[columIndex21] as DataGridViewTextBoxCell;
                        DataGridViewTextBoxCell totalWoodCoating_idcell = row.Cells[columIndex22] as DataGridViewTextBoxCell;
                        DataGridViewTextBoxCell totalWood_idcell = row.Cells[columIndex23] as DataGridViewTextBoxCell;

                        if (sizecell.ColumnIndex == columIndex3)
                        {
                            if(txtWidth.Text !="" && txtHeight.Text != "")
                            {
                                sizecell.Value = getFormulaCalculation(formula_id: size_idcell.Value != null ? size_idcell.Value.ToString() : "0", 
                                    sizeval: sizecell.Value != null ? sizecell.Value.ToString() : "0", 
                                    weightval: weightcell.Value != null ? weightcell.Value.ToString() : "0", 
                                    rateval: ratecell.Value != null ? ratecell.Value.ToString() : "0",
                                    totalval: totalcell.Value != null ? totalcell.Value.ToString() : "0",
                                    sqftplaincoatingval: sqftPlainCoatingCell.Value != null ? sqftPlainCoatingCell.Value.ToString() : "0", 
                                    plainrateval: ratePlainCoatingCell.Value != null ? ratePlainCoatingCell.Value.ToString() : "0", 
                                    totalplaincoatingval: totalPlainCoatingCell.Value != null ? totalPlainCoatingCell.Value.ToString() : "0", 
                                    totalplainval: totalPlainCell.Value != null ? totalPlainCell.Value.ToString() : "0", 
                                    sqftwoodcoatingval: sqftWoodCoatingCell.Value != null ? sqftWoodCoatingCell.Value.ToString() : "0",
                                    woodrateval: rateWoodCoatingCell.Value !=null ? rateWoodCoatingCell.Value.ToString() : "0",
                                    totalwoodcoatingval: totalWoodCoatingCell.Value != null ? totalWoodCoatingCell.Value.ToString() : "0", 
                                    totalwoodval: totalWoodCell.Value != null ? totalWoodCell.Value.ToString() : "0").ToString();

                                totalcell.Value = getFormulaCalculation(formula_id: total_idcell.Value != null ? total_idcell.Value.ToString() : "0",
                                    sizeval: sizecell.Value != null ? sizecell.Value.ToString() : "0",
                                    weightval: weightcell.Value != null ? weightcell.Value.ToString() : "0",
                                    rateval: ratecell.Value != null ? ratecell.Value.ToString() : "0",
                                    totalval: totalcell.Value != null ? totalcell.Value.ToString() : "0",
                                    sqftplaincoatingval: sqftPlainCoatingCell.Value != null ? sqftPlainCoatingCell.Value.ToString() : "0",
                                    plainrateval: ratePlainCoatingCell.Value != null ? ratePlainCoatingCell.Value.ToString() : "0",
                                    totalplaincoatingval: totalPlainCoatingCell.Value != null ? totalPlainCoatingCell.Value.ToString() : "0",
                                    totalplainval: totalPlainCell.Value != null ? totalPlainCell.Value.ToString() : "0",
                                    sqftwoodcoatingval: sqftWoodCoatingCell.Value != null ? sqftWoodCoatingCell.Value.ToString() : "0",
                                    woodrateval: rateWoodCoatingCell.Value != null ? rateWoodCoatingCell.Value.ToString() : "0",
                                    totalwoodcoatingval: totalWoodCoatingCell.Value != null ? totalWoodCoatingCell.Value.ToString() : "0",
                                    totalwoodval: totalWoodCell.Value != null ? totalWoodCell.Value.ToString() : "0").ToString();
                                

                                sqftPlainCoatingCell.Value = getFormulaCalculation(formula_id: sqftPlainCoating_idcell.Value != null ? sqftPlainCoating_idcell.Value.ToString() : "0",
                                    sizeval: sizecell.Value != null ? sizecell.Value.ToString() : "0",
                                    weightval: weightcell.Value != null ? weightcell.Value.ToString() : "0",
                                    rateval: ratecell.Value != null ? ratecell.Value.ToString() : "0",
                                    totalval: totalcell.Value != null ? totalcell.Value.ToString() : "0",
                                    sqftplaincoatingval: sqftPlainCoatingCell.Value != null ? sqftPlainCoatingCell.Value.ToString() : "0",
                                    plainrateval: ratePlainCoatingCell.Value != null ? ratePlainCoatingCell.Value.ToString() : "0",
                                    totalplaincoatingval: totalPlainCoatingCell.Value != null ? totalPlainCoatingCell.Value.ToString() : "0",
                                    totalplainval: totalPlainCell.Value != null ? totalPlainCell.Value.ToString() : "0",
                                    sqftwoodcoatingval: sqftWoodCoatingCell.Value != null ? sqftWoodCoatingCell.Value.ToString() : "0",
                                    woodrateval: rateWoodCoatingCell.Value != null ? rateWoodCoatingCell.Value.ToString() : "0",
                                    totalwoodcoatingval: totalWoodCoatingCell.Value != null ? totalWoodCoatingCell.Value.ToString() : "0",
                                    totalwoodval: totalWoodCell.Value != null ? totalWoodCell.Value.ToString() : "0").ToString();

                                totalPlainCoatingCell.Value = getFormulaCalculation(formula_id: totalPlainCoating_idcell.Value != null ? totalPlainCoating_idcell.Value.ToString() : "0",
                                    sizeval: sizecell.Value != null ? sizecell.Value.ToString() : "0",
                                    weightval: weightcell.Value != null ? weightcell.Value.ToString() : "0",
                                    rateval: ratecell.Value != null ? ratecell.Value.ToString() : "0",
                                    totalval: totalcell.Value != null ? totalcell.Value.ToString() : "0",
                                    sqftplaincoatingval: sqftPlainCoatingCell.Value != null ? sqftPlainCoatingCell.Value.ToString() : "0",
                                    plainrateval: ratePlainCoatingCell.Value != null ? ratePlainCoatingCell.Value.ToString() : "0",
                                    totalplaincoatingval: totalPlainCoatingCell.Value != null ? totalPlainCoatingCell.Value.ToString() : "0",
                                    totalplainval: totalPlainCell.Value != null ? totalPlainCell.Value.ToString() : "0",
                                    sqftwoodcoatingval: sqftWoodCoatingCell.Value != null ? sqftWoodCoatingCell.Value.ToString() : "0",
                                    woodrateval: rateWoodCoatingCell.Value != null ? rateWoodCoatingCell.Value.ToString() : "0",
                                    totalwoodcoatingval: totalWoodCoatingCell.Value != null ? totalWoodCoatingCell.Value.ToString() : "0",
                                    totalwoodval: totalWoodCell.Value != null ? totalWoodCell.Value.ToString() : "0").ToString();


                                totalPlainCell.Value = getFormulaCalculation(formula_id: totalPlain_idcell.Value != null ? totalPlain_idcell.Value.ToString() : "0",
                                    sizeval: sizecell.Value != null ? sizecell.Value.ToString() : "0",
                                    weightval: weightcell.Value != null ? weightcell.Value.ToString() : "0",
                                    rateval: ratecell.Value != null ? ratecell.Value.ToString() : "0",
                                    totalval: totalcell.Value != null ? totalcell.Value.ToString() : "0",
                                    sqftplaincoatingval: sqftPlainCoatingCell.Value != null ? sqftPlainCoatingCell.Value.ToString() : "0",
                                    plainrateval: ratePlainCoatingCell.Value != null ? ratePlainCoatingCell.Value.ToString() : "0",
                                    totalplaincoatingval: totalPlainCoatingCell.Value != null ? totalPlainCoatingCell.Value.ToString() : "0",
                                    totalplainval: totalPlainCell.Value != null ? totalPlainCell.Value.ToString() : "0",
                                    sqftwoodcoatingval: sqftWoodCoatingCell.Value != null ? sqftWoodCoatingCell.Value.ToString() : "0",
                                    woodrateval: rateWoodCoatingCell.Value != null ? rateWoodCoatingCell.Value.ToString() : "0",
                                    totalwoodcoatingval: totalWoodCoatingCell.Value != null ? totalWoodCoatingCell.Value.ToString() : "0",
                                    totalwoodval: totalWoodCell.Value != null ? totalWoodCell.Value.ToString() : "0").ToString();

                                sqftWoodCoatingCell.Value = getFormulaCalculation(formula_id: sqftWoodCoating_idcell.Value != null ? sqftWoodCoating_idcell.Value.ToString() : "0",
                                    sizeval: sizecell.Value != null ? sizecell.Value.ToString() : "0",
                                    weightval: weightcell.Value != null ? weightcell.Value.ToString() : "0",
                                    rateval: ratecell.Value != null ? ratecell.Value.ToString() : "0",
                                    totalval: totalcell.Value != null ? totalcell.Value.ToString() : "0",
                                    sqftplaincoatingval: sqftPlainCoatingCell.Value != null ? sqftPlainCoatingCell.Value.ToString() : "0",
                                    plainrateval: ratePlainCoatingCell.Value != null ? ratePlainCoatingCell.Value.ToString() : "0",
                                    totalplaincoatingval: totalPlainCoatingCell.Value != null ? totalPlainCoatingCell.Value.ToString() : "0",
                                    totalplainval: totalPlainCell.Value != null ? totalPlainCell.Value.ToString() : "0",
                                    sqftwoodcoatingval: sqftWoodCoatingCell.Value != null ? sqftWoodCoatingCell.Value.ToString() : "0",
                                    woodrateval: rateWoodCoatingCell.Value != null ? rateWoodCoatingCell.Value.ToString() : "0",
                                    totalwoodcoatingval: totalWoodCoatingCell.Value != null ? totalWoodCoatingCell.Value.ToString() : "0",
                                    totalwoodval: totalWoodCell.Value != null ? totalWoodCell.Value.ToString() : "0").ToString();

                                totalWoodCoatingCell.Value = getFormulaCalculation(formula_id: totalWoodCoating_idcell.Value != null ? totalWoodCoating_idcell.Value.ToString() : "0",
                                    sizeval: sizecell.Value != null ? sizecell.Value.ToString() : "0",
                                    weightval: weightcell.Value != null ? weightcell.Value.ToString() : "0",
                                    rateval: ratecell.Value != null ? ratecell.Value.ToString() : "0",
                                    totalval: totalcell.Value != null ? totalcell.Value.ToString() : "0",
                                    sqftplaincoatingval: sqftPlainCoatingCell.Value != null ? sqftPlainCoatingCell.Value.ToString() : "0",
                                    plainrateval: ratePlainCoatingCell.Value != null ? ratePlainCoatingCell.Value.ToString() : "0",
                                    totalplaincoatingval: totalPlainCoatingCell.Value != null ? totalPlainCoatingCell.Value.ToString() : "0",
                                    totalplainval: totalPlainCell.Value != null ? totalPlainCell.Value.ToString() : "0",
                                    sqftwoodcoatingval: sqftWoodCoatingCell.Value != null ? sqftWoodCoatingCell.Value.ToString() : "0",
                                    woodrateval: rateWoodCoatingCell.Value != null ? rateWoodCoatingCell.Value.ToString() : "0",
                                    totalwoodcoatingval: totalWoodCoatingCell.Value != null ? totalWoodCoatingCell.Value.ToString() : "0",
                                    totalwoodval: totalWoodCell.Value != null ? totalWoodCell.Value.ToString() : "0").ToString();

                                totalWoodCell.Value = getFormulaCalculation(formula_id: totalWood_idcell.Value != null ? totalWood_idcell.Value.ToString() : "0",
                                    sizeval: sizecell.Value != null ? sizecell.Value.ToString() : "0",
                                    weightval: weightcell.Value != null ? weightcell.Value.ToString() : "0",
                                    rateval: ratecell.Value != null ? ratecell.Value.ToString() : "0",
                                    totalval: totalcell.Value != null ? totalcell.Value.ToString() : "0",
                                    sqftplaincoatingval: sqftPlainCoatingCell.Value != null ? sqftPlainCoatingCell.Value.ToString() : "0",
                                    plainrateval: ratePlainCoatingCell.Value != null ? ratePlainCoatingCell.Value.ToString() : "0",
                                    totalplaincoatingval: totalPlainCoatingCell.Value != null ? totalPlainCoatingCell.Value.ToString() : "0",
                                    totalplainval: totalPlainCell.Value != null ? totalPlainCell.Value.ToString() : "0",
                                    sqftwoodcoatingval: sqftWoodCoatingCell.Value != null ? sqftWoodCoatingCell.Value.ToString() : "0",
                                    woodrateval: rateWoodCoatingCell.Value != null ? rateWoodCoatingCell.Value.ToString() : "0",
                                    totalwoodcoatingval: totalWoodCoatingCell.Value != null ? totalWoodCoatingCell.Value.ToString() : "0",
                                    totalwoodval: totalWoodCell.Value != null ? totalWoodCell.Value.ToString() : "0").ToString();
                            }
                        }
                    }
                }                
            }


            double total = 0;
            double plaintotal = 0;
            double plaintotal1 = 0;
            double woodtotal = 0;
            double woodtotal1 = 0;

            for (int i = 0; i < DgvWork.Rows.Count; ++i)
            {
                total += Convert.ToDouble(DgvWork.Rows[i].Cells[columIndex6].Value);
                plaintotal += Convert.ToDouble(DgvWork.Rows[i].Cells[columIndex9].Value);
                plaintotal1 += Convert.ToDouble(DgvWork.Rows[i].Cells[columIndex10].Value);
                woodtotal += Convert.ToDouble(DgvWork.Rows[i].Cells[columIndex13].Value);
                woodtotal1 += Convert.ToDouble(DgvWork.Rows[i].Cells[columIndex14].Value);
            }

            lblTotal.Text = total.ToString();
            lbltotalplain.Text = plaintotal.ToString();
            lbltotalplain1.Text = plaintotal1.ToString();
            lblwoodtotal.Text = woodtotal.ToString();
            lblwoodtotal1.Text = woodtotal1.ToString();

            quotation_update();
        }

        public double getFormulaCalculation(string formula_id = null, string sizeval = null, string weightval = null, string rateval = null, string totalval=null, string sqftplaincoatingval = null, string plainrateval=null, string totalplaincoatingval = null, string totalplainval = null, string sqftwoodcoatingval = null, string woodrateval = null, string totalwoodcoatingval = null, string totalwoodval = null)
        {
            if(formula_id == "")
            {
                formula_id = "0";
            }

            DataRow[] rslt = formula_dt.Select("Formula_id=" + formula_id);
            if (rslt.Length > 0)
            {
                DataTable dt = rslt.CopyToDataTable();

                if (dt.Rows.Count > 0)
                {
                    string str = dt.Rows[0]["Formula"].ToString();
                    var arr = str.Split('_');

                    string combinedFormula = "";
                    foreach (string element in arr)
                    {
                        if (element == "Width")
                            combinedFormula += txtWidth.Text.ToString() == "" ? "0" : txtWidth.Text.ToString();
                        else if (element == "Height")
                            combinedFormula += txtHeight.Text.ToString() == "" ? "0" : txtHeight.Text.ToString();
                        else if (element == "Depth")
                            combinedFormula += txtDepth.Text.ToString() =="" ? "0" : txtDepth.Text.ToString();
                        else if (element == "ShelfQty")
                            combinedFormula += txtShelfQty.Text.ToString() == "" ? "0" : txtShelfQty.Text.ToString();
                        else if (element == "ShutterQty")
                            combinedFormula += txtShutterQty.Text.ToString() == "" ? "0" : txtShutterQty.Text.ToString();
                        else if (element == "BoxQty")
                            combinedFormula += txtBoxQty.Text.ToString() == "" ? "0" : txtBoxQty.Text.ToString();
                        else if (element == "BoxSqFt")
                            combinedFormula += txtBoxSqFt.Text.ToString() == "" ? "0" : txtBoxSqFt.Text.ToString();
                        else if (element == "Size")
                            combinedFormula += sizeval;
                        else if (element == "Weight")
                            combinedFormula += weightval;
                        else if (element == "Rate")
                            combinedFormula += rateval;
                        else if (element == "Total")
                            combinedFormula += totalval;
                        else if (element == "SqftPlainCoating")
                            combinedFormula += sqftplaincoatingval;
                        else if(element == "RatePlain")
                            combinedFormula += plainrateval;
                        else if (element == "TotalPlainCoating")
                            combinedFormula += totalplaincoatingval;
                        else if (element == "TotalPlain")
                            combinedFormula += totalplainval;
                        else if (element == "SqftWoodCoating")
                            combinedFormula += sqftwoodcoatingval;
                        else if (element == "RateWood")
                            combinedFormula += woodrateval;
                        else if (element == "TotalWoodCoating")
                            combinedFormula += totalwoodcoatingval;
                        else if (element == "TotalWood")
                            combinedFormula += totalwoodval;                       
                        else
                            combinedFormula += element;
                        // body of foreach loop
                    }

                    //string result = new DataTable().Compute(combinedFormula, null).ToString();

                    double result = Math.Round(Evaluate(combinedFormula), 2);
                    if(result.ToString() == "NaN")                   
                        return 0;                    
                    else                                        
                        return result;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }

            //string str = "(_Width_+_Height_)_*_2";            

        }

        public void Clear()
        {
            txtQuotation_id.Text = "";
            txt_QuotationRowIndex.Text = "";

            cmbQdesc.SelectedValue = 0;
            cmbWorkName.SelectedValue = 0;
            cmbParty.SelectedValue = 0;
            cmbRemarks.SelectedValue = 0;
            txtWidth.Text = "0";
            txtDepth.Text = "0";
            txtHeight.Text = "0";
            txtShelfQty.Text = "0";
            txtShutterQty.Text = "0";
            txtBoxQty.Text = "0";
            txtBoxSqFt.Text = "0";
            DgvWork.DataSource = null;
            dgvQuotation.DataSource = null;
            lblTotal.Text = "0";
            lbltotalplain.Text = "0";
            lbltotalplain1.Text = "0";
            lblwoodtotal.Text = "0";
            lblwoodtotal1.Text = "0";

            txtOverallTaxPer.Text = "0";
            txtTransportation.Text = "0";
            txtQdescTaxPer.Text = "0";

            DgvWork.DataSource = null;
            dgvQuotation.DataSource = null;

            Quotation_dt.Rows.Clear();
            desDetail_dt.Rows.Clear();


            bindquotation();
                       
        }

        public void quotation_update()
        {
            if(Quotation_dt.Rows.Count > 0 && txt_QuotationRowIndex.Text != "" && isloadQuotation)
            {
                int rowindex = Convert.ToInt32(txt_QuotationRowIndex.Text.ToString());

                Quotation_dt.Rows[rowindex]["QDesc_id"] = cmbQdesc.SelectedValue.ToString();
                Quotation_dt.Rows[rowindex]["QDesc"] = cmbQdesc.Text.ToString();

                Quotation_dt.Rows[rowindex]["GWork_id"] = cmbWorkName.SelectedValue.ToString();
                Quotation_dt.Rows[rowindex]["WorkName"] = cmbWorkName.Text.ToString();

                Quotation_dt.Rows[rowindex]["Remark_id"] = cmbRemarks.SelectedValue.ToString();
                Quotation_dt.Rows[rowindex]["Remark"] = cmbRemarks.Text.ToString();

                Quotation_dt.Rows[rowindex]["Width"] = txtWidth.Text.ToString();
                Quotation_dt.Rows[rowindex]["Depth"] = txtDepth.Text.ToString();
                Quotation_dt.Rows[rowindex]["Height"] = txtHeight.Text.ToString();
                Quotation_dt.Rows[rowindex]["ShelfQty"] = txtShelfQty.Text.ToString();
                Quotation_dt.Rows[rowindex]["ShutterQty"] = txtShutterQty.Text.ToString();
                Quotation_dt.Rows[rowindex]["BoxQty"] = txtBoxQty.Text.ToString();
                Quotation_dt.Rows[rowindex]["BoxSqFt"] = txtBoxSqFt.Text.ToString();

                Quotation_dt.Rows[rowindex]["GTotalPlain"] = lbltotalplain1.Text.ToString();
                Quotation_dt.Rows[rowindex]["GTotalWood"] = lblwoodtotal1.Text.ToString();

                Quotation_dt.Rows[rowindex]["DescTaxPer"] = txtQdescTaxPer.Text.ToString();                

            }
        }

    }
}
