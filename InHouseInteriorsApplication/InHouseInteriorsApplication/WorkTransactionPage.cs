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
                bindWork();
                dgvWork.DataSource = null;
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

            
            cmbWorkName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbWorkName.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbWorkName.MouseWheel -= new MouseEventHandler(ctl_MouseWheel);
            cmbWorkName.MouseWheel += new MouseEventHandler(ctl_MouseWheel);

            var dict = JObject.Parse(@"{'IsWorkSelect':'Y'}");
            workdt = cls.FetchData(SpName: "USP_Work_Insert", ReqType: "SELECT_WORK", dict);
            cmbWorkName.DisplayMember = "WorkName";
            cmbWorkName.ValueMember = "Work_id";
            cmbWorkName.DataSource = workdt;


            DataTable qdesc = new DataTable();
            qdesc = cls.FetchData(SpName: "USP_WorkDetail_Select", ReqType: "SELECT_QUOTATIONDESC");
            cmbQdesc.DisplayMember = "Q_Description";
            cmbQdesc.ValueMember = "Q_id";
            cmbQdesc.DataSource = qdesc;


            var dict1 = JObject.Parse(@"{'IsDescriptionSelect':'Y'}");
            des_dt = cls.FetchData(SpName: "USP_Description_Insert", ReqType: "SELECT_DESCRIPTION", dict: dict1);
            DataGridViewComboBoxColumn DgvCbDescription = (DataGridViewComboBoxColumn)(dgvWork.Columns["DgvCbDescription"]);
            DgvCbDescription.DataSource = des_dt;
            DgvCbDescription.ValueMember = "Description_id";
            DgvCbDescription.DisplayMember = "Description";


            DataGridViewImageColumn BtnRemove = (DataGridViewImageColumn)(dgvWork.Columns["BtnRemove"]);
            BtnRemove.Width = 35;
            BtnRemove.ImageLayout = DataGridViewImageCellLayout.Zoom;

            
            formula_dt = cls.FetchData(SpName: "USP_FormulaTypeInsert", ReqType: "SELECT_FORMULA");

            //BtnRemove.Backg

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

                    dgvWork.AutoGenerateColumns = false;
                    dgvWork.DataSource = dt;


                    desDetail_dt = cls.FetchData(SpName: "USP_WorkDetail_Select", ReqType: "SELECT_DETAILWORK", dict: dict);

                    DataBind();
                }
                else
                {
                    dgvWork.DataSource = null;
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

        }

        static DataRow MakeNewAlldaysRow(DataTable table)
        {
            DataRow row = table.NewRow();
            row["Description_id"] = DBNull.Value;
            row["Description"] = "";
            row["Width"] = "";
            row["Depth"] = "";
            row["Height"] = "";

            return row;
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
                if (e.RowIndex < dgvWork.Rows.Count-1)
                    dgvWork.Rows.RemoveAt(e.RowIndex);
            }

            //var editingControl = this.dgvWork.EditingControl as DataGridViewComboBoxEditingControl;
            //if (editingControl != null)
            //    editingControl.DroppedDown = true;
        }

        private void DgvWork_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvWork.CurrentCell.ColumnIndex == 2 && e.Control is ComboBox)
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
                    e.CellStyle.BackColor = this.dgvWork.DefaultCellStyle.BackColor;
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
                var currentcell = dgvWork.CurrentCellAddress;
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

                                DataGridViewTextBoxCell weight_cel = (DataGridViewTextBoxCell)dgvWork.Rows[currentcell.Y].Cells[columIndex4];
                                DataGridViewTextBoxCell rate_cel = (DataGridViewTextBoxCell)dgvWork.Rows[currentcell.Y].Cells[columIndex5];
                                DataGridViewTextBoxCell plainrate_cel = (DataGridViewTextBoxCell)dgvWork.Rows[currentcell.Y].Cells[columIndex8];
                                DataGridViewTextBoxCell woodrate_cel = (DataGridViewTextBoxCell)dgvWork.Rows[currentcell.Y].Cells[columIndex12];
                                weight_cel.Value = dt_workdesc.Rows[0]["Weight"].ToString();
                                rate_cel.Value = dt_workdesc.Rows[0]["Rate"].ToString();
                                plainrate_cel.Value = dt_workdesc.Rows[0]["PlainRate"].ToString();
                                woodrate_cel.Value = dt_workdesc.Rows[0]["WoodRate"].ToString();

                                DataGridViewTextBoxCell size_idcell = (DataGridViewTextBoxCell)dgvWork.Rows[currentcell.Y].Cells[columIndex16];
                                DataGridViewTextBoxCell total_idcell = (DataGridViewTextBoxCell)dgvWork.Rows[currentcell.Y].Cells[columIndex17];

                                DataGridViewTextBoxCell sqftPlainCoating_idcell = (DataGridViewTextBoxCell)dgvWork.Rows[currentcell.Y].Cells[columIndex18];
                                DataGridViewTextBoxCell totalPlainCoating_idcell = (DataGridViewTextBoxCell)dgvWork.Rows[currentcell.Y].Cells[columIndex19];
                                DataGridViewTextBoxCell totalPlain_idcell = (DataGridViewTextBoxCell)dgvWork.Rows[currentcell.Y].Cells[columIndex20];

                                DataGridViewTextBoxCell sqftWoodCoating_idcell = (DataGridViewTextBoxCell)dgvWork.Rows[currentcell.Y].Cells[columIndex21];
                                DataGridViewTextBoxCell totalWoodCoating_idcell = (DataGridViewTextBoxCell)dgvWork.Rows[currentcell.Y].Cells[columIndex22];
                                DataGridViewTextBoxCell totalWood_idcell = (DataGridViewTextBoxCell)dgvWork.Rows[currentcell.Y].Cells[columIndex23];


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
            dgvWork.BeginEdit(true);
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
            if (dgvWork.IsCurrentCellDirty)
            {
                // This fires the cell value changed handler below
                dgvWork.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }



     
        public void DataBind()
        {
            
            foreach (DataGridViewRow row in dgvWork.Rows)
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

            for (int i = 0; i < dgvWork.Rows.Count; ++i)
            {
                total += Convert.ToDouble(dgvWork.Rows[i].Cells[columIndex6].Value);
                plaintotal += Convert.ToDouble(dgvWork.Rows[i].Cells[columIndex9].Value);
                plaintotal1 += Convert.ToDouble(dgvWork.Rows[i].Cells[columIndex10].Value);
                woodtotal += Convert.ToDouble(dgvWork.Rows[i].Cells[columIndex13].Value);
                woodtotal1 += Convert.ToDouble(dgvWork.Rows[i].Cells[columIndex14].Value);
            }

            lblTotal.Text = total.ToString();
            lbltotalplain.Text = plaintotal.ToString();
            lbltotalplain1.Text = plaintotal1.ToString();
            lblwoodtotal.Text = woodtotal.ToString();
            lblwoodtotal1.Text = woodtotal1.ToString();
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

    }
}
