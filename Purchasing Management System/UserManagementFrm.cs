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
    public partial class UserManagementFrm : Form
    {
        public UserManagementFrm()
        {
            InitializeComponent();
        }

        UserMgtDao dao = new UserMgtDao();

        ClsCommon cmd = new ClsCommon();

        //reset textbox function
        public void resestBox()
        {
            txtUserID.Clear();
            txtName.Clear();
            txtPw.Clear();
            txtConfirm.Clear();
            txtPosition.Clear();
            radSubAdmin.Checked = false;
            radAdmin.Checked = false;
            radUser.Checked = false;
            txtName.Focus();
        }

        //Load all user in datagridview
        private void UserManagementFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            cboFilterBU.Items.Clear();
            cboBU.Items.Clear();
            
            cboActiveUser.SelectedIndex = 0;

            //Load all user
            List<Dictionary<string, object>> data = dao.LoadAllUsers("", "No");
            foreach (Dictionary<string, object> usr in data)
            {
                dataGridView1.Rows.Add(usr["uid"],usr["uNo"], usr["uname"], usr["upass"], usr["UserPosition"], usr["UserRole"], usr["BU_No"], usr["Is_Deactivated"]);
            }
            
            LoadAllBUinCboBU();
            cboFilterBU.SelectedIndex = 0;

            long countRows = dao.countRowsUser("", "No"); //No is Active Category
            if (countRows > 0)
            {
                lblTotalRows.Text = countRows.ToString();
            }
        }
        public void refreshUserView()
        {
            UserManagementFrm_Load(null, null);
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
        string role;
        private void radAdmin_CheckedChanged(object sender, EventArgs e)
        {
            role = "Admin";
        }

        //add new
        TextBox bu = new TextBox();
        private void btnToolAdd_Click(object sender, EventArgs e)
        {
            bu.Text=cboBU.Text;
            //validate data before save
            if (cmd.isEmpty(txtName, txtPw, txtConfirm, txtPosition, bu) == true) { return; }; //validate if empty
            if (cmd.isMatch(txtPw, txtConfirm) == false) { return; }; //validate if not match

            //check dupplicate username
            if (dao.isDuplicate(txtName.Text) == true)
            {
                MessageBox.Show("This user already exit!");
                txtName.SelectAll();
                txtName.Focus();
                return;  //in order to stop the code
            };

            //add record to db and datagridview
            long userID = dao.addUser(txtName.Text, txtConfirm.Text, txtPosition.Text, role, cboBU.Text);
            if (userID > 0)
            {
                dao.updateUserNo(userID.ToString());
                txtUserID.Text = "ID " + userID.ToString("00000");
                if (cboFilterBU.SelectedText == cboBU.Text || cboFilterBU.SelectedIndex == 0 && cboActiveUser.SelectedIndex == 0)
                {
                    dataGridView1.Rows.Add(userID, txtUserID.Text , txtName.Text, txtConfirm.Text, txtPosition.Text, role, cboBU.Text, "No");
                }
                resestBox();
            }
            else
            {
                MessageBox.Show("Add user failed!");
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
                if (dao.deleteUser(dr.Cells[0].Value.ToString()) == true)
                {
                    dataGridView1.Rows.Remove(dr);
                }

            }
        }

        //edit
        private void btnToolEdit_Click_1(object sender, EventArgs e)
        {
            bu.Text = cboBU.Text;
            //validate if no record for select
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return; //if not return, code below will execute
            }

            //validate when user click button Edit
            DataGridViewRow r = dataGridView1.SelectedRows[0];

            if (btnToolEdit.Text == "  Edit")
            {

                txtUserID.Text = r.Cells[1].Value.ToString();
                txtName.Text = r.Cells[2].Value.ToString();
                txtPw.Text = r.Cells[2].Value.ToString();
                txtConfirm.Text = r.Cells[2].Value.ToString();
                txtPosition.Text = r.Cells[4].Value.ToString();
                cboBU.Text = r.Cells[6].Value.ToString();
                if (r.Cells[5].Value.ToString() == "Admin")
                {
                    radAdmin.Checked = true;
                }
                else if(r.Cells[5].Value.ToString() == "Sub Admin")
                {
                    radSubAdmin.Checked = true;
                }
                else { radUser.Checked = true; }

                enableControl(false); //disable control Add Delete Search in form
                btnToolEdit.Text = "  Save Change";
            }
            else
            {
                if (cmd.isEmpty(txtName, txtPw, txtConfirm, txtPosition, bu) == true) { return; }; //validate if empty
                if (cmd.isMatch(txtPw, txtConfirm) == false) { return; }; //validate if not match
                if (txtName.Text != r.Cells[2].Value.ToString())
                {
                    //check dupplicate username. check direct to database
                    if (dao.isDuplicate(txtName.Text) == true)
                    {
                        MessageBox.Show("This user already exit!");
                        txtName.SelectAll();
                        txtName.Focus();
                        return;  //in order to stop the code
                    };
                }

                if (dao.updateUser(txtUserID.Text, txtName.Text, txtConfirm.Text, txtPosition.Text, role, cboBU.Text))
                {
                    r.Cells[2].Value = txtName.Text;
                    r.Cells[3].Value = txtConfirm.Text;
                    r.Cells[4].Value = txtPosition.Text;
                    r.Cells[5].Value = role;
                    r.Cells[6].Value = cboBU.Text;

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
            search.cboSearchField.Items.Add("User ID");
            search.cboSearchField.Items.Add("User Name");
            search.cboSearchField.SelectedIndex = 0;

            if (search.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Clear();
                if (cboFilterBU.SelectedItem != null)
                {
                    string bu = cboFilterBU.SelectedItem.ToString();
                    if (bu == "All BU")
                    {
                        bu = "";
                    }
                    if (cboActiveUser.SelectedItem != null)
                    {
                        string usrActive = cboActiveUser.SelectedItem.ToString();
                        if (usrActive == "Active User")
                        {
                            usrActive = "No";
                        }
                        else { usrActive = "Yes"; }

                        if (search.cboSearchField.SelectedItem != null)
                        {
                            List<Dictionary<string, object>> loadUser;
                            long countRows;
                            string searchField = search.cboSearchField.SelectedItem.ToString();
                            if (searchField == "-- Show All --")
                            {
                                loadUser = dao.LoadAllUsers("", "No");
                                countRows = dao.countRowsUser("", "No");
                            }
                            else if (searchField == "User ID")
                            {
                                loadUser = dao.searchUserByID(search.txtSearchValue.Text, bu, usrActive);
                                countRows = dao.countRowsUserByID(search.txtSearchValue.Text, bu, usrActive);
                            }
                            else
                            {
                                loadUser = dao.searchUsersByusrName(search.txtSearchValue.Text, bu, usrActive);
                                countRows = dao.countRowsUserByName(search.txtSearchValue.Text, bu, usrActive);
                            }
                            foreach (Dictionary<string, object> usr in loadUser)
                            {
                                dataGridView1.Rows.Add(usr["uid"], usr["uNo"], usr["uname"], usr["upass"], usr["UserPosition"], usr["UserRole"], usr["BU_No"], usr["Is_Deactivated"]);
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
        }

        private void radSubAdmin_CheckedChanged(object sender, EventArgs e)
        {
            role = "Sub Admin";
        }

        private void radUser_CheckedChanged(object sender, EventArgs e)
        {
            role = "User";
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
            string deactivate = r.Cells[7].Value.ToString();

            if (deactivate == "No")
            {
                deactivate = "Yes";
                DialogResult rst = MessageBox.Show("Are you sure to Deactivate this user?", "Deactivate", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(rst == DialogResult.Yes)
                {
                    //1st update to db
                    //2nd update to datagridview
                    if (dao.deactivateUser(id, deactivate))
                    {
                        //r.Cells[6].Value = deactivate;
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
            string activated = r.Cells[7].Value.ToString();

            if (activated == "Yes")
            {
                activated = "No";
                DialogResult rst = MessageBox.Show("Are you sure to Activate this user?", "Activate", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rst == DialogResult.Yes)
                {
                    //1st update to db
                    //2nd update to datagridview
                    if (dao.deactivateUser(id, activated))
                    {
                        //r.Cells[6].Value = activated;
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

        private void LoadAllBUinCboBU()
        {
            List<Dictionary<string, object>> data = dao.LoadAllBU();
            cboFilterBU.Items.Add("All BU");
            foreach (Dictionary<string, object> bu in data)
            {
                cboFilterBU.Items.Add(bu["BU_No"].ToString());
                cboBU.Items.Add(bu["BU_No"].ToString());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshUserView();
        }

        //selectionChanged on row of datagridvie to validate button Deactivate and Activate
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var cellValue = dataGridView1.SelectedRows[0].Cells[7].Value;

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

        private void cboFilterBU_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            cboFilterBU.SelectedItem = Color.White;
            List<Dictionary<string, object>> data;
            if (cboFilterBU.SelectedItem != null)
            {
                string bu = cboFilterBU.SelectedItem.ToString();
                if (bu == "All BU")
                {
                    bu = "";
                }
                if (cboActiveUser.SelectedItem != null)
                {
                    string usrActive = cboActiveUser.SelectedItem.ToString();
                    if (usrActive == "Active User")
                    {
                        usrActive = "No";
                    }
                    else { usrActive = "Yes"; }
                    data = dao.LoadAllUsers(bu, usrActive); //No is Active Vendor
                    long countRow = dao.countRowsUser(bu, usrActive);
                    foreach (Dictionary<string, object> usr in data)
                    {
                        dataGridView1.Rows.Add(usr["uid"], usr["uNo"], usr["uname"], usr["upass"], usr["UserPosition"], usr["UserRole"], usr["BU_No"], usr["Is_Deactivated"]);
                    }
                    if (countRow > 0)
                    {
                        lblTotalRows.Text = countRow.ToString();
                    }
                    else { lblTotalRows.Text = "0"; }
                }
            }
        }

        private void cboActiveUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboActiveUser.SelectedItem = Color.White;
            dataGridView1.Rows.Clear();

            List<Dictionary<string, object>> data;
            if (cboActiveUser.SelectedItem != null)
            {
                string usrActive = cboActiveUser.SelectedItem.ToString();
                if (usrActive == "Active User")
                {
                    usrActive = "No";
                }
                else { usrActive = "Yes"; }

                if (cboFilterBU.SelectedItem != null)
                {
                    string bu = cboFilterBU.SelectedItem.ToString();
                    if (bu == "All BU")
                    {
                        bu = "";
                    }
                    data = dao.LoadAllUsers(bu, usrActive); //No is Active Vendor
                    long countRow = dao.countRowsUser(bu, usrActive);
                    foreach (Dictionary<string, object> usr in data)
                    {
                        dataGridView1.Rows.Add(usr["uid"], usr["uNo"], usr["uname"], usr["upass"], usr["UserPosition"], usr["UserRole"], usr["BU_No"], usr["Is_Deactivated"]);
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
}
