using Purchasing_Management_System.Common;
using Purchasing_Management_System.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purchasing_Management_System
{
    public partial class BUManagementFrm : Form
    {
        public BUManagementFrm()
        {
            InitializeComponent();
        }

        BUMgtDao dao = new BUMgtDao();

        ClsCommon cmd = new ClsCommon();

        //reset textbox function
        public void resestBox()
        {
            txtBuName.Clear();
            txtBuNo.Clear();
            txtBuNameKH.Clear();
            txtBuName.Focus();
            txtBuDesc.Clear();
        }

        private void enableControl(Boolean val)
        {
            btnToolAdd.Enabled = val;
            btnToolSearch.Enabled = val;
            btnToolDelete.Enabled = val;
            btnRefresh.Enabled = val;
            btnTools.Enabled = val;
            btnToolActivate.Enabled = val;
            btnToolDeactivate.Enabled = val;
            dataGridView1.Enabled = val;
        }

        //Load all user in datagridview
        private void BUManagementFrm_Load(object sender, EventArgs e)
        {
            cboActiveBU.SelectedIndex = 0;
            dataGridView1.Rows.Clear();

            //Load all BU
            List<Dictionary<string, object>> data = dao.LoadAllBU("");
            foreach (Dictionary<string, object> bu in data)
            {
                dataGridView1.Rows.Add(bu["BU_Id"], bu["BU_No"], bu["BU_Name"], bu["BU_NameKH"], bu["BU_Description"], bu["Is_Deactivated"]);
            }

            long countRows = dao.countRowsBu(""); //No is Active Category
            if (countRows > 0)
            {
                lblTotalRows.Text = countRows.ToString();
            }
        }

        public void refreshUserView()
        {
            BUManagementFrm_Load(null, null);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshUserView();
        }

        //add new
        private void btnToolAdd_Click(object sender, EventArgs e)
        {
            //validate data before save
            if (cmd.isEmpty(txtBuName, txtBuNo) == true) { return; }; //validate if empty

            //check dupplicate bu
            if (dao.isDuplicate(txtBuName.Text) == true)
            {
                MessageBox.Show("This BU already exit!");
                txtBuName.SelectAll();
                txtBuName.Focus();
                return;  //in order to stop the code
            };

            //add record to db and datagridview
            long buId = dao.addBu(txtBuNo.Text, txtBuName.Text, txtBuNameKH.Text, txtBuDesc.Text);
            if (buId > 0)
            {
                if(cboActiveBU.SelectedIndex == 0)
                {
                    dataGridView1.Rows.Add(buId, txtBuNo.Text, txtBuName.Text, txtBuNameKH.Text, txtBuDesc.Text, "No");
                }
                resestBox();
            }
            else
            {
                MessageBox.Show("Add BU failed!");
            }
            //do next
        }

        //delete
        private void btnToolDelete_Click(object sender, EventArgs e)
        {
            //validate if no record for select
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("No record for deleting!");
                return; //if not return, code below will execute
            }
            DialogResult rst = MessageBox.Show("Are you sure to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rst == DialogResult.Yes)
            {
                //start delete
                //1st delete from table in db
                //2nd if success delete form db then delete form datagridview
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                if (dao.deleteBu(dr.Cells[0].Value.ToString()) == true)
                {
                    dataGridView1.Rows.Remove(dr);
                }
            }
        }

        //edit
        private void btnToolEdit_Click_1(object sender, EventArgs e)
        {
            //validate if no record for select
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return; //if not return, code below will execute
            }

            //validate when user click button Edit
            DataGridViewRow r = dataGridView1.SelectedRows[0];
            string id = "";
            if (btnToolEdit.Text == "  Edit")
            {
                txtBuNo.Text = r.Cells[1].Value.ToString();
                txtBuName.Text = r.Cells[2].Value.ToString();
                txtBuNameKH.Text = r.Cells[3].Value.ToString();
                txtBuDesc.Text = r.Cells[4].Value.ToString();

                enableControl(false); //disable control Add Delete Search in form
                btnToolEdit.Text = "  Save Change";
            }
            else
            {
                id = r.Cells[0].Value.ToString();
                if (cmd.isEmpty(txtBuName, txtBuNo) == true) { return; }; //validate if empty
                if (txtBuName.Text != r.Cells[2].Value.ToString())
                {
                    //check dupplicate username. check direct to database
                    if (dao.isDuplicate(txtBuName.Text) == true)
                    {
                        MessageBox.Show("This BU already exit!");
                        txtBuName.SelectAll();
                        txtBuName.Focus();
                        return;  //in order to stop the code
                    };
                }

                if (dao.updateBu(id, txtBuNo.Text, txtBuName.Text, txtBuNameKH.Text, txtBuDesc.Text))
                {
                    r.Cells[1].Value = txtBuNo.Text;
                    r.Cells[2].Value = txtBuName.Text;
                    r.Cells[3].Value = txtBuNameKH.Text;
                    r.Cells[4].Value = txtBuDesc.Text;

                    enableControl(true); //reopen control Add Delete Search in form
                    btnToolEdit.Text = "  Edit";
                    resestBox();
                }
                else
                {
                    MessageBox.Show("Update failed!");
                }
            }
        }

        //search
        private void btnToolSearch_Click_1(object sender, EventArgs e)
        {
            SearchFrm search = new SearchFrm();
            search.cboSearchField.Items.Add("-- Show All --");
            search.cboSearchField.Items.Add("BU No.");
            search.cboSearchField.Items.Add("BU Name");
            search.cboSearchField.SelectedIndex = 0;

            if (search.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Clear();
                if (cboActiveBU.SelectedItem != null)
                {
                    string buActive = cboActiveBU.SelectedItem.ToString();
                    if (buActive == "All BU")
                    {
                        buActive = "";
                    }
                    else if (buActive == "Active BU")
                    {
                        buActive = "No";
                    }
                    else { buActive = "Yes"; }
                    if (search.cboSearchField.SelectedItem != null)
                    {
                        List<Dictionary<string, object>> loadBU;
                        long countRows;
                        string searchField = search.cboSearchField.SelectedItem.ToString();
                        if (searchField == "-- Show All --")
                        {
                            loadBU = dao.LoadAllBU(buActive);
                            countRows = dao.countRowsBu(buActive);
                        }
                        else if (searchField == "BU No.")
                        {
                            loadBU = dao.searchUserByID(search.txtSearchValue.Text, buActive);
                            countRows = dao.countRowsBuByID(search.txtSearchValue.Text, buActive);
                        }
                        else
                        {
                            loadBU = dao.searchUsersByusrName(search.txtSearchValue.Text, buActive);
                            countRows = dao.countRowsBuByName(search.txtSearchValue.Text, buActive);
                        }
                        foreach (Dictionary<string, object> bu in loadBU)
                        {
                            dataGridView1.Rows.Add(bu["BU_Id"], bu["BU_No"], bu["BU_Name"], bu["BU_NameKH"], bu["BU_Description"], bu["Is_Deactivated"]);
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
            string deactivate = r.Cells[5].Value.ToString();

            if (deactivate == "No")
            {
                deactivate = "Yes";
                DialogResult rst = MessageBox.Show("Are you sure to Deactivate this BU?", "Deactivate", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rst == DialogResult.Yes)
                {
                    //1st update to db
                    //2nd update to datagridview
                    if (dao.deactivateBu(id, deactivate))
                    {
                        dataGridView1.Rows.Remove(r);
                        int editRow = Convert.ToInt32(lblTotalRows.Text) - 1;
                        lblTotalRows.Text = editRow.ToString();
                    }
                }
            }
            else { return; }
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
            string activated = r.Cells[5].Value.ToString();

            if (activated == "Yes")
            {
                activated = "No";
                DialogResult rst = MessageBox.Show("Are you sure to Activate this BU?", "Activate", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rst == DialogResult.Yes)
                {
                    //1st update to db
                    //2nd update to datagridview
                    if (dao.deactivateBu(id, activated))
                    {
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
                var cellValue = dataGridView1.SelectedRows[0].Cells[5].Value;

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

        private void cboActiveUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            cboActiveBU.SelectedItem = Color.White;
            List<Dictionary<string, object>> data;
            if (cboActiveBU.SelectedItem != null)
            {
                string buActive = cboActiveBU.SelectedItem.ToString();
                if (buActive == "All BU")
                {
                    buActive = "";
                }
                else if (buActive == "Active BU")
                {
                    buActive = "No";
                }
                else { buActive = "Yes"; }
                data = dao.LoadAllBU(buActive); //No is Active Vendor
                long countRow = dao.countRowsBu(buActive);
                foreach (Dictionary<string, object> bu in data)
                {
                    dataGridView1.Rows.Add(bu["BU_Id"], bu["BU_No"], bu["BU_Name"], bu["BU_NameKH"], bu["BU_Description"], bu["Is_Deactivated"]);
                }
                if (countRow > 0)
                {
                    lblTotalRows.Text = countRow.ToString();
                }
                else { lblTotalRows.Text = "0"; }
            }
        }
    }
}
