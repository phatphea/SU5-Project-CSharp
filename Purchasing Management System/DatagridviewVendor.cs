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
    public partial class DatagridviewVendorFrm : Form
    {
        public DatagridviewVendorFrm()
        {
            InitializeComponent();
        }

        VendorMgtDao dao = new VendorMgtDao();


        public void DatagridviewVendorFrm_Load(object sender, EventArgs e)
        {
            cboActiveVendor.SelectedIndex = 0; // 0 is No

            dataGridView1.Rows.Clear();
            List<Dictionary<string, object>> data = dao.LoadAllVendors("No"); //No is Active Vendor
            foreach (Dictionary<string, object> usr in data)
            {
                dataGridView1.Rows.Add(usr["Vendor_Id"], usr["Vendor_No"], usr["Vendor_Name"], usr["Vendor_NameKH"], usr["Vendor_Class"], usr["Address"], usr["Email"], usr["Phone_Number"], usr["Vattin_No"], usr["Is_Taxable"], usr["Is_Deactivated"]);
            }
            long countRows = dao.countRowsVendorByActiveOrInactive("No"); //No is Active Vendor
            if (countRows > 0)
            {
                lblTotalRows.Text = countRows.ToString();
            }

        }
        public void refreshVendorView()
        {
            DatagridviewVendorFrm_Load(null, null); //to refresh to the default venderView
        }

        //public MainForm mfrm;

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            VendorManagementFrm vfrm = new VendorManagementFrm();
            vfrm.TopLevel = false;
            Program.mainFrm.splitContainer1.Panel2.Controls.Add(vfrm);
            vfrm.BringToFront();
            vfrm.Show();

            vfrm.saveStatus("Unsaved");
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
            if (row == null)
            {
                MessageBox.Show("The selected row contains null values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if the row or required cells are null
            }

            // Check if any cell values in the row are null before accessing them
            foreach (DataGridViewCell cell in row.Cells)
            {   
                if (cell.Value == null)
                { 
                    MessageBox.Show("The selected row contains null values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if any required cells are null
                }
            }

            VendorManagementFrm vfrm = new VendorManagementFrm();

            vfrm.lblVendorName.Text = row.Cells[2].Value.ToString();
            vfrm.txtVenId.Text = row.Cells[0].Value.ToString();
            vfrm.txtVenNo.Text = row.Cells[1].Value.ToString();
            vfrm.txtVenName.Text = row.Cells[2].Value.ToString();
            vfrm.txtVenNameKH.Text = row.Cells[3].Value.ToString();
            vfrm.txtVenClass.Text = row.Cells[4].Value.ToString();
            vfrm.txtVenAddress.Text = row.Cells[5].Value.ToString();
            vfrm.txtVenEmail.Text = row.Cells[6].Value.ToString();
            vfrm.txtVenMobile.Text = row.Cells[7].Value.ToString();
            vfrm.txtTaxNo.Text = row.Cells[8].Value.ToString();
            vfrm.cboIsTax.Text = row.Cells[9].Value.ToString();

            Program.vendor_phoneNumber = row.Cells[7].Value.ToString();//give value to program class in order to validate when saveChange

            vfrm.enableBox(false);
            vfrm.btnSave.Enabled = false;
            vfrm.saveStatus("Saved");
            vfrm.btnSaveCloses.Enabled = false;
            vfrm.TopLevel = false;
            Program.mainFrm.splitContainer1.Panel2.Controls.Add(vfrm);
            vfrm.BringToFront();
            vfrm.Show();

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
            DialogResult rst = MessageBox.Show("Are you sure to delete this vendor?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rst == DialogResult.Yes)
            {
                //start delete
                //1st delete from table in db
                //2nd if success delete form db then delete form datagridview
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                try //validate when category was used for created product
                {
                    if (dao.deleteVendor(dr.Cells[0].Value.ToString()) == true)
                    {
                        dataGridView1.Rows.Remove(dr);
                    }
                }
                catch
                {
                    MessageBox.Show("Cannot delete this vendor! Because it already used, you can deactivate it.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    refreshVendorView();
                    return;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchFrm search = new SearchFrm();
            search.cboSearchField.Items.Add("-- Show All --");
            search.cboSearchField.Items.Add("Vendor No.");
            search.cboSearchField.Items.Add("Vendor Name");
            search.cboSearchField.SelectedIndex = 0;

            if (search.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Clear();
                if (cboActiveVendor.SelectedItem != null)
                {
                    string activeOrInactive = cboActiveVendor.SelectedItem.ToString();
                    if(activeOrInactive=="Active Vendor")
                    {
                        activeOrInactive = "No";
                    }
                    else { activeOrInactive = "Yes"; }
                    if (search.cboSearchField.SelectedItem != null)
                    {
                        List<Dictionary<string, object>> data;
                        long countRows;
                        string searchField = search.cboSearchField.SelectedItem.ToString();
                        if (searchField== "-- Show All --")
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
            }
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
            string id = r.Cells[0].Value.ToString();
            string deactivated = r.Cells[10].Value.ToString();

            if (deactivated == "No")
            {
                deactivated = "Yes";
                DialogResult rst = MessageBox.Show("Are you sure to Deactivate this vendor?", "Deactivate", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rst == DialogResult.Yes)
                {
                    //1st update to db
                    //2nd update to datagridview
                    if (dao.deactivateUser(id, deactivated))
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
                var cellValue = dataGridView1.SelectedRows[0].Cells[10].Value;

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
            string id = r.Cells[0].Value.ToString();
            string deactivated = r.Cells[10].Value.ToString();

            if (deactivated == "Yes")
            {
                deactivated = "No";
                DialogResult rst = MessageBox.Show("Are you sure to Activate this vendor?", "Activate", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rst == DialogResult.Yes)
                {
                    //1st update to db
                    //2nd update to datagridview
                    if (dao.deactivateUser(id, deactivated))
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

        private void cboActiveVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboActiveVendor.SelectedItem = Color.White;

            dataGridView1.Rows.Clear();
            List<Dictionary<string, object>> data;
            long countRows;
            if (cboActiveVendor.SelectedIndex == 0)
            {
                data = dao.LoadAllVendors("No"); //No is Active Vendor
                countRows = dao.countRowsVendorByActiveOrInactive("No"); //No is Active Vendor
            }
            else
            {
                data = dao.LoadAllVendors("Yes"); //Yes is Inactive Vendor
                countRows = dao.countRowsVendorByActiveOrInactive("Yes"); //No is Active Vendor
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
}
