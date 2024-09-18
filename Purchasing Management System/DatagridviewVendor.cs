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

            dataGridView1.Rows.Clear();
            List<Dictionary<string, object>> data = dao.LoadAllVendors();
            foreach (Dictionary<string, object> usr in data)
            {
                dataGridView1.Rows.Add(usr["Vendor_Id"], usr["Vendor_No"], usr["Vendor_Name"], usr["Vendor_NameKH"], usr["Vendor_Class"], usr["Address"], usr["Email"], usr["Phone_Number"], usr["Vattin_No"], usr["Is_Taxable"], usr["Is_Deactivated"]);
            }
            long countRows=dao.countRowsVendor();
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
            VendorManagementFrm vfrm = new VendorManagementFrm();

            vfrm.lblVendorName.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            vfrm.txtVenId.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            vfrm.txtVenNo.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            vfrm.txtVenName.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            vfrm.txtVenNameKH.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            vfrm.txtVenClass.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            vfrm.txtVenAddress.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            vfrm.txtVenEmail.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            vfrm.txtVenMobile.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            vfrm.txtTaxNo.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            vfrm.cboIsTax.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();

            Program.vendor_phoneNumber = this.dataGridView1.CurrentRow.Cells[7].Value.ToString(); //give value to program class in order to validate when saveChange

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
                if (dao.deleteVendor(dr.Cells[0].Value.ToString()) == true)
                {
                    dataGridView1.Rows.Remove(dr);
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchFrm search = new SearchFrm();
            search.cboSearchField.Items.Add("-- Show All --");
            search.cboSearchField.Items.Add("Vendor ID");
            search.cboSearchField.Items.Add("Vendor Name");
            search.cboSearchField.SelectedIndex = 0;

            try //using try catch to prevent the error while user input the txtSearchValue of ID is string (Example abcd...)
            {
                if (search.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.Rows.Clear();
                    switch (search.cboSearchField.Text)
                    {
                        case "-- Show All --":
                            refreshVendorView();
                            break;

                        case "Vendor ID":
                            List<Dictionary<string, object>> searchID = dao.searchVendorByID(search.txtSearchValue.Text);
                            foreach (Dictionary<string, object> usr in searchID)
                            {
                                dataGridView1.Rows.Add(usr["Vendor_Id"], usr["Vendor_No"], usr["Vendor_Name"], usr["Vendor_NameKH"], usr["Vendor_Class"], usr["Address"], usr["Email"], usr["Phone_Number"], usr["Vattin_No"], usr["Is_Taxable"], usr["Is_Deactivated"]);
                            }
                            break;

                        case "Vendor Name":
                            List<Dictionary<string, object>> searchName = dao.searchVendorsByName(search.txtSearchValue.Text);
                            foreach (Dictionary<string, object> usr in searchName)
                            {
                                dataGridView1.Rows.Add(usr["Vendor_Id"], usr["Vendor_No"], usr["Vendor_Name"], usr["Vendor_NameKH"], usr["Vendor_Class"], usr["Address"], usr["Email"], usr["Phone_Number"], usr["Vattin_No"], usr["Is_Taxable"], usr["Is_Deactivated"]);
                            }
                            break;
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Invalid Inputted!","Warning!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                refreshVendorView();
                return;
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
            string deactivate = r.Cells[10].Value.ToString();

            if (deactivate == "No")
            {
                deactivate = "Yes";
                DialogResult rst = MessageBox.Show("Are you sure to Deactivate this user?", "Deactivate", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rst == DialogResult.Yes)
                {
                    //1st update to db
                    //2nd update to datagridview
                    if (dao.deactivateUser(id, deactivate))
                    {
                        r.Cells[10].Value = deactivate;
                    }
                }
            }
            else
            {
                deactivate = "No";
                DialogResult rst = MessageBox.Show("Are you sure to Activate this user?", "Deactivate", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rst == DialogResult.Yes)
                {
                    //1st update to db
                    //2nd update to datagridview
                    if (dao.deactivateUser(id, deactivate))
                    {
                        r.Cells[10].Value = deactivate;
                    }
                }
            }
        }
    }
}
