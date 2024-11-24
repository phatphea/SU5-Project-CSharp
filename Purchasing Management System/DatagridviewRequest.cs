using Purchasing_Management_System.dao;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Purchasing_Management_System
{
    public partial class DatagridviewRequest : Form
    {
        public DatagridviewRequest()
        {
            InitializeComponent();
            txtFilter.GotFocus += RemoveText;
            txtFilter.LostFocus += AddText;
        }

        RequestMgtDao dao = new RequestMgtDao();
        UserMgtDao usrDao = new UserMgtDao();

        public void DatagridviewRequestFrm_Load(object sender, EventArgs e)
        {
            txtFilter.Text = "Filter by keyword";
            txtFilter.ForeColor = SystemColors.GrayText;

            cboActiveRequest.SelectedIndex = 0; // 0 is No

            dataGridView1.Rows.Clear();
            List<Dictionary<string, object>> data = dao.LoadAllRequest("No"); //No is Active Vendor
            foreach (Dictionary<string, object> req in data)
            {
                dataGridView1.Rows.Add(req["BU"], req["MainReq_No"], req["Status"], req["BU"] /*BU set for column Request Type*/, Convert.ToDateTime(req["Created_Date"]), req["Shipping_Site"], Double.Parse(req["Total_Amount"].ToString()), req["Requested_By"] ,req["Is_Deactivated"]);
            }

            long countRows = dao.countRowsRequestByActiveOrInactive("No"); //No is Active Vendor
            if (countRows > 0)
            {
                lblTotalRows.Text = countRows.ToString();
            }

        }
        public void refreshVendorView()
        {
            DatagridviewRequestFrm_Load(null, null); //to refresh to the default venderView
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            MainRequestManagementFrm frm = new MainRequestManagementFrm();
            frm.TopLevel = false;
            Program.mainFrm.splitContainer1.Panel2.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

            frm.LoadAllBU();
            frm.saveStatus("Unsaved");
            frm.cboRequestStatus.SelectedIndex = 0;
        }

        public void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the double-clicked row is valid
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return; //Exit if the clicked cell is not in the valid row or column
            }

            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            // Check if the row or the required cells are null
            if (row == null || row.Cells[1].Value == null || row.Cells[8].Value == null)
            { 
                MessageBox.Show("The selected row contains null values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if the row or required cells are null
            }

            MainRequestManagementFrm frm = new MainRequestManagementFrm();

            string mainRequestNo = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string activeOrInactive = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();

            frm.LoadAllBU();

            List<Dictionary<string, object>> data = dao.LoadAllRequestByNo(mainRequestNo, activeOrInactive);
            foreach (Dictionary<string, object> req in data)
            {
                frm.cboRequestStatus.Text = req["Status"].ToString();
                frm.lblRequestNo.Text = req["MainReq_No"].ToString();
                frm.cboRequestType.Text = req["BU"].ToString();
                frm.dtCreatedDate.Text = req["Created_Date"].ToString();
                frm.txtRequestDesc.Text = req["Req_Desc"].ToString();
                frm.txtRequestedBy.Text = req["Requested_By"].ToString();
                frm.txtEndorsedBy.Text = req["Endorsed_By"].ToString();
                frm.txtApprovedBy.Text = req["Approved_By"].ToString();
                frm.txtReason.Text = req["Reason"].ToString();
                frm.cboShippingSite.Text = req["Shipping_Site"].ToString();
                frm.txtAddress.Text = req["Shipping_Address"].ToString();
                frm.txtTlAmtBeforeDiscount.Text = Convert.ToDecimal(req["Amount_BefDiscount"]).ToString("0.00");
                frm.txtTotalDiscount.Text = Convert.ToDecimal(req["Discount"]).ToString("0.00");
                frm.txtTotalBaseAmount.Text = Convert.ToDecimal(req["Base_Amount"]).ToString("0.00");
                frm.txtTotalTax.Text = Convert.ToDecimal(req["Tax_Amount"]).ToString("0.00");
                frm.txtTotalAmount.Text = Convert.ToDecimal(req["Total_Amount"]).ToString("0.00");
            }

            Program.mainRequestNo = this.dataGridView1.CurrentRow.Cells[1].Value.ToString(); //give value to program class in order to validate when saveChange

            frm.enableBox(false);
            frm.readOnlyBox(true);
            frm.btnSave.Enabled = false;
            frm.saveStatus("Saved");
            frm.btnSaveCloses.Enabled = false;
            frm.TopLevel = false;
            Program.mainFrm.splitContainer1.Panel2.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

            Program.mainFrm.nullValueForControlButton();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshVendorView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //validate if no record for select
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("No record for deleting!");
                return; //if not return, code below will execute
            }
            DialogResult rst = MessageBox.Show("Are you sure to delete this transaction?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rst == DialogResult.Yes)
            {
                //start delete
                //1st delete from table in db
                //2nd if success delete form db then delete form datagridview
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                try //validate when category was used for created product
                {
                    if (dao.deleteRequest(dr.Cells[1].Value.ToString()) == true)
                    {
                        dataGridView1.Rows.Remove(dr);
                    }
                }
                catch
                {
                    refreshVendorView();
                    return;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            /*SearchFrm search = new SearchFrm();
            search.cboSearchField.Items.Add("-- Show All --");
            search.cboSearchField.Items.Add("Request No.");
            search.cboSearchField.Items.Add("");
            search.cboSearchField.SelectedIndex = 0;

            if (search.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Clear();
                if (cboActiveVendor.SelectedItem != null)
                {
                    string activeOrInactive = cboActiveVendor.SelectedItem.ToString();
                    if (activeOrInactive == "Active Vendor")
                    {
                        activeOrInactive = "No";
                    }
                    else { activeOrInactive = "Yes"; }
                    if (search.cboSearchField.SelectedItem != null)
                    {
                        List<Dictionary<string, object>> data;
                        long countRows;
                        string searchField = search.cboSearchField.SelectedItem.ToString();
                        if (searchField == "-- Show All --")
                        {
                            data = dao.LoadAllVendors(activeOrInactive);
                            countRows = dao.countRowsVendorByActiveOrInactive(activeOrInactive);
                        }
                        else if (searchField == "Vendor No.")
                        {
                            data = dao.searchVendorByNo(search.txtSearchValue.Text, activeOrInactive);
                            countRows = dao.countRowsVendorByNo(search.txtSearchValue.Text, activeOrInactive);
                        }
                        else
                        {
                            data = dao.searchVendorsByName(search.txtSearchValue.Text, activeOrInactive);
                            countRows = dao.countRowsVendorByName(search.txtSearchValue.Text, activeOrInactive);
                        }
                        foreach (Dictionary<string, object> usr in data)
                        {
                            dataGridView1.Rows.Add(usr["Vendor_Id"], usr["Vendor_No"], usr["Vendor_Name"], usr["Vendor_NameKH"], usr["Vendor_Class"], usr["Address"], usr["Email"], usr["Phone_Number"], usr["Vattin_No"], usr["Is_Taxable"], usr["Is_Deactivated"]);
                        }
                        if (countRows > 0)
                        {
                            lblTotalRows.Text = countRows.ToString();
                        }
                        else { lblTotalRows.Text = "0"; }
                    }
                }
            }*/
        }

        private void btnToolDeactivate_Click(object sender, EventArgs e)
        {
            //validate if no record for select
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return; //if not return, code below will execute
            }

            //validate when user click button Edit
            DataGridViewRow r = dataGridView1.SelectedRows[0];
            string reqNo = r.Cells[1].Value.ToString();
            string deactivated = r.Cells[8].Value.ToString();

            if (deactivated == "No")
            {
                deactivated = "Yes";
                DialogResult rst = MessageBox.Show("Are you sure to Deactivate this transaction?", "Deactivate", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rst == DialogResult.Yes)
                {
                    //1st update to db
                    //2nd update to datagridview
                    if (dao.deactivateRequest(reqNo, deactivated))
                    {
                        //r.Cells[10].Value = deactivated;
                        dataGridView1.Rows.Remove(r);
                        int editRow = Convert.ToInt32(lblTotalRows.Text) - 1;
                        lblTotalRows.Text = editRow.ToString();
                    }
                }
            }
            else
            {
                return;
            }
        }

        //selectionChanged on row of datagridvie to validate button Deactivate and Activate
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var cellValue = dataGridView1.SelectedRows[0].Cells[8].Value;

                if (cellValue != null)
                {
                    string deactivated = cellValue.ToString();
                    if (deactivated == "No")
                    {
                        btnToolDeactivate.Visible = true;
                        btnToolActivate.Visible = false;
                    }
                    else
                    {
                        btnToolDeactivate.Visible = false;
                        btnToolActivate.Visible = true;
                    }
                }
                else
                {
                    // Handle the case where the cell value is null
                    return;
                }
            }
        }

        private void btnToolActivate_Click(object sender, EventArgs e)
        {
            //validate if no record for select
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return; //if not return, code below will execute
            }

            //validate when user click button Edit
            DataGridViewRow r = dataGridView1.SelectedRows[0];
            string reqNo = r.Cells[1].Value.ToString();
            string deactivated = r.Cells[8].Value.ToString();

            if (deactivated == "Yes")
            {
                deactivated = "No";
                DialogResult rst = MessageBox.Show("Are you sure to Activate this transaction?", "Activate", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rst == DialogResult.Yes)
                {
                    //1st update to db
                    //2nd update to datagridview
                    if (dao.deactivateRequest(reqNo, deactivated))
                    {
                        //r.Cells[10].Value = deactivated;
                        dataGridView1.Rows.Remove(r);
                        int editRow = Convert.ToInt32(lblTotalRows.Text) - 1;
                        lblTotalRows.Text = editRow.ToString();
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void cboActiveRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboActiveRequest.SelectedItem = Color.White;

            dataGridView1.Rows.Clear();
            List<Dictionary<string, object>> data;
            long countRows;
            if (cboActiveRequest.SelectedIndex == 0)
            {
                data = dao.LoadAllRequest("No"); //No is Active Vendor
                countRows = dao.countRowsRequestByActiveOrInactive("No"); //No is Active Vendor
            }
            else
            {
                data = dao.LoadAllRequest("Yes"); //Yes is Inactive Vendor
                countRows = dao.countRowsRequestByActiveOrInactive("Yes"); //No is Active Vendor
            }
            foreach (Dictionary<string, object> req in data)
            {
                dataGridView1.Rows.Add(req["BU"], req["MainReq_No"], req["Status"], req["BU"], Convert.ToDateTime(req["Created_Date"]), req["Shipping_Site"], Double.Parse(req["Total_Amount"].ToString()), req["Requested_By"], req["Is_Deactivated"]);
            }

            if (countRows > 0)
            {
                lblTotalRows.Text = countRows.ToString();
            }
            else { lblTotalRows.Text = "0"; }
        }

        //Event keydown for textbox filter
        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplyFilter(txtFilter.Text.ToLower());
                e.SuppressKeyPress = true; // Prevent the 'ding' sound
            }
        }
        //method for filter all data in datagridview by all column
        void ApplyFilter(string filterText)
        {
            int matchedRowCount = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue; // Skip the new row

                bool visible = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(filterText))
                    {
                        visible = true;
                        break;
                    }
                }
                row.Visible = visible;
                if (visible) matchedRowCount++;
            }

            lblTotalRows.Text = matchedRowCount.ToString();
        }
        //remove text from cbofilter
        void RemoveText(object sender, EventArgs e)
        {
            if (txtFilter.Text== "Filter by keyword")
            {
                txtFilter.Text = "";
                txtFilter.ForeColor = SystemColors.WindowText;
            }
        }
        //add text to cbofilter
        void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                txtFilter.Text = "Filter by keyword";
                txtFilter.ForeColor = SystemColors.GrayText;
            }   
        }
    }
}
