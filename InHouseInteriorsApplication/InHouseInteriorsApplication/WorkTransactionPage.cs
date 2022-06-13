using InHouseInteriorsApplication.Class;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InHouseInteriorsApplication
{
    public partial class WorkTransactionPage : Form
    {
        ClassConfig cls = new ClassConfig();
        DataTable des_dt = new DataTable();

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
            try
            {
                bindWork();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : PartyMasterPage_Load" + ex.ToString());
            }
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
            //DataRow dr = workdt.NewRow();
            //dr["Work_id"] = 0;
            //dr["WorkName"] = "--Select--";
            //workdt.Rows.Add(dr);
            cmbWorkName.DisplayMember = "WorkName";
            cmbWorkName.ValueMember = "Work_id";
            cmbWorkName.DataSource = workdt;


            var dict1 = JObject.Parse(@"{'IsDescriptionSelect':'Y'}");
            des_dt = cls.FetchData(SpName: "USP_Description_Insert", ReqType: "SELECT_DESCRIPTION", dict: dict1);
            DataGridViewComboBoxColumn DgvCbDescription = (DataGridViewComboBoxColumn)(dgvWork.Columns["DgvCbDescription"]);
            DgvCbDescription.DataSource = des_dt;
            DgvCbDescription.ValueMember = "Description_id";
            DgvCbDescription.DisplayMember = "Description";


            DataGridViewImageColumn BtnRemove = (DataGridViewImageColumn)(dgvWork.Columns["BtnRemove"]);
            BtnRemove.Width = 35;
            BtnRemove.ImageLayout = DataGridViewImageCellLayout.Zoom;            

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

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : TxtShutterQty_TextChanged" + ex.ToString());
            }
        }

        private void TxtBoxQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxQty.Text != "")
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                cls.WriteException("WorkTransactionPage : TxtBoxQty_TextChanged" + ex.ToString());
            }
        }

        private void TxtBoxSqFt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxSqFt.Text != "")
                {

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
                    comboBox.Enter -= new EventHandler(ctl_Enter);
                    comboBox.Enter += new EventHandler(ctl_Enter);
                    //comboBox.MouseWheel -= new MouseEventHandler(ctl_MouseWheel);
                    //comboBox.MouseWheel += new MouseEventHandler(ctl_MouseWheel);
                    //comboBox.BackColor = Color.White;
                    //comboBox.ForeColor = Color.Black;
                    e.CellStyle.BackColor = this.dgvWork.DefaultCellStyle.BackColor;
                }
            }
        }

        private void LastColumnComboSelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var currentcell = dgvWork.CurrentCellAddress;
                var sendingCB = sender as DataGridViewComboBoxEditingControl;
                sendingCB.ForeColor = Color.Black;
                sendingCB.BackColor = Color.White;

                if (sendingCB.SelectedValue != null)
                {
                    if(sendingCB.SelectedValue.ToString() != "" && sendingCB.SelectedValue.ToString() != "System.Data.DataRowView")
                    {
                        DataRow[] rslt = des_dt.Select("Description_id=" + sendingCB.SelectedValue.ToString());
                        if (rslt.Length > 0)
                        {
                            DataTable dt = rslt.CopyToDataTable();

                            if (dt.Rows.Count > 0)
                            {
                                DataGridViewTextBoxCell weight_cel = (DataGridViewTextBoxCell)dgvWork.Rows[currentcell.Y].Cells[4];
                                DataGridViewTextBoxCell rate_cel = (DataGridViewTextBoxCell)dgvWork.Rows[currentcell.Y].Cells[5];
                                weight_cel.Value = dt.Rows[0]["Weight"].ToString();
                                rate_cel.Value = dt.Rows[0]["Rate"].ToString();
                            }
                        }
                    }                    
                }
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
        }

        public void DataBind()
        {
            int columIndex2 = 2;
            int columIndex3 = 3;

            foreach (DataGridViewRow row in dgvWork.Rows)
            {
                DataGridViewComboBoxCell DescriptionCell = row.Cells[columIndex2] as DataGridViewComboBoxCell;

                if(DescriptionCell.ColumnIndex == columIndex2 && DescriptionCell.Value != null)
                {
                    if(DescriptionCell.Value.ToString() != "" && DescriptionCell.Value.ToString() != "--Select--")
                    {
                        DataGridViewTextBoxCell cell = row.Cells[columIndex3] as DataGridViewTextBoxCell;
                        if (cell.ColumnIndex == columIndex3)
                        {
                            if(txtWidth.Text !="" && txtHeight.Text != "")
                            {
                                double sizeVal = (Convert.ToDouble(txtWidth.Text) + Convert.ToDouble(txtHeight.Text)) * 2;
                                cell.Value = Math.Round(sizeVal, 2);
                            }
                        }
                    }
                }

                
            }
        }
    }
}
