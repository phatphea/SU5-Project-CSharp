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
            txtID.Clear();
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
            List<Dictionary<string, object>> data = dao.LoadAllUsers();
            foreach (Dictionary<string, object> usr in data)
            {
                dataGridView1.Rows.Add(usr["uid"], usr["uname"], usr["upass"], usr["UserPosition"], usr["UserRole"], usr["Is_Deactivated"]);
            }
        }
        private void enableControl(Boolean val)
        {
            btnToolAdd.Enabled = val;
            btnToolSearch.Enabled = val;
            btnToolDelete.Enabled = val;
            dataGridView1.Enabled = val;
        }
        string role;
        private void radAdmin_CheckedChanged(object sender, EventArgs e)
        {
            role = "Admin";
        }

        //add new
        private void btnToolAdd_Click(object sender, EventArgs e)
        {
            //validate data before save
            if (cmd.isEmpty(txtName, txtPw, txtConfirm, txtPosition) == true) { return; }; //validate if empty
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
            long userID = dao.addUser(txtName.Text, txtConfirm.Text, txtPosition.Text, role);
            if (userID > 0)
            {
                dataGridView1.Rows.Add(userID, txtName.Text, txtConfirm.Text, txtPosition.Text, role,"No");
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
            //validate if no record for select
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return; //if not return, code below will execute
            }

            //validate when user click button Edit
            DataGridViewRow r = dataGridView1.SelectedRows[0];

            if (btnToolEdit.Text == "  Edit")
            {

                txtID.Text = r.Cells[0].Value.ToString();
                txtName.Text = r.Cells[1].Value.ToString();
                txtPw.Text = r.Cells[2].Value.ToString();
                txtConfirm.Text = r.Cells[2].Value.ToString();
                txtPosition.Text = r.Cells[3].Value.ToString();
                if (r.Cells[4].Value.ToString() == "Admin")
                {
                    radAdmin.Checked = true;
                }
                else if(r.Cells[4].Value.ToString() == "Sub Admin")
                {
                    radSubAdmin.Checked = true;
                }
                else { radUser.Checked = true; }

                enableControl(false); //disable control Add Delete Search in form
                btnToolEdit.Text = "  Save Change";
            }
            else
            {
                if (cmd.isEmpty(txtName, txtPw, txtConfirm, txtPosition) == true) { return; }; //validate if empty
                if (cmd.isMatch(txtPw, txtConfirm) == false) { return; }; //validate if not match
                if (txtName.Text != r.Cells[1].Value.ToString())
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

                if (dao.updateUser(txtID.Text, txtName.Text, txtConfirm.Text, txtPosition.Text, role))
                {
                    r.Cells[1].Value = txtName.Text;
                    r.Cells[2].Value = txtConfirm.Text;
                    r.Cells[3].Value = txtPosition.Text;
                    r.Cells[4].Value = role;

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
            search.cboSearchField.Items.Add("ID");
            search.cboSearchField.Items.Add("Name");
            search.cboSearchField.SelectedIndex = 0;

            try //using try catch to prevent the error while user input the txtSearchValue of ID is string (Example abcd...)
            {
                if (search.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.Rows.Clear();
                    switch (search.cboSearchField.Text)
                    {
                        case "-- Show All --":
                            UserManagementFrm_Load(null, null);
                            break;

                        case "ID":
                            List<Dictionary<string, object>> searchID = dao.searchUserByID(search.txtSearchValue.Text);
                            foreach (Dictionary<string, object> usr in searchID)
                            {
                                dataGridView1.Rows.Add(usr["uid"], usr["uname"], usr["upass"], usr["UserPosition"], usr["UserRole"], usr["Is_Deactivated"]);
                            }
                            break;

                        case "Name":
                            List<Dictionary<string, object>> searchName = dao.searchUsersByusrName(search.txtSearchValue.Text);
                            foreach (Dictionary<string, object> usr in searchName)
                            {
                                dataGridView1.Rows.Add(usr["uid"], usr["uname"], usr["upass"], usr["UserPosition"], usr["UserRole"], usr["Is_Deactivated"]);
                            }
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid Inputted!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UserManagementFrm_Load(null, null);
                return;
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
            string deactivate = r.Cells[5].Value.ToString();

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
                        r.Cells[5].Value = deactivate;
                    }
                }    
            }
            else
            {
                deactivate = "No";
                DialogResult rst = MessageBox.Show("Are you sure to Activate this user?", "Activate", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rst == DialogResult.Yes)
                {
                    //1st update to db
                    //2nd update to datagridview
                    if (dao.deactivateUser(id, deactivate))
                    {
                        r.Cells[5].Value = deactivate;
                    }
                }
            }
        }
    }
}
