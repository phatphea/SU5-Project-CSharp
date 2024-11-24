using Purchasing_Management_System.Common;
using Purchasing_Management_System.dao;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Purchasing_Management_System
{
    public partial class MainRequestManagementFrm : Form
    {
        ClsCommon cmd = new ClsCommon();
        RequestMgtDao dao = new RequestMgtDao();
        UserMgtDao usrDao = new UserMgtDao();

        public MainRequestManagementFrm()
        {
            InitializeComponent();
            cmd.AssignHandlersButtonStyle(btnSummary); //set color style for button when hover and click
            cmd.AssignHandlersButtonStyle(btnDetails);
        }

        public void btnGoBack_Click(object sender, EventArgs e)
        {
            //data.refreshVendorView(); =>not work
            if (btnSave.Enabled == true)
            {
                DialogResult rst = MessageBox.Show("Do you want to exit this form?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rst == DialogResult.Yes)
                {
                    this.Close();
                    Program.mainFrm.nullValueForControlButton();
                }
                else
                {
                    return;
                }
            }
            else
            {
                this.Close();
                Program.mainFrm.nullValueForControlButton();
            }
        }

        public void enableBox(Boolean val)
        {
            cboRequestType.Enabled = val;
            cboShippingSite.Enabled = val;
            dtCreatedDate.Enabled = val;
        }

        public void readOnlyBox(Boolean val)
        {
            txtRequestedBy.ReadOnly = val;
            txtRequestDesc.ReadOnly = val;
            txtEndorsedBy.ReadOnly = val;
            txtApprovedBy.ReadOnly = val;
            txtReason.ReadOnly = val;
            txtAddress.ReadOnly = val;
        }
        public void resetBox()
        {
            cboRequestType.SelectedItem = null;
            dtCreatedDate.Value = DateTime.Now;
            txtRequestDesc.Clear();
            txtRequestedBy.Clear();
            txtEndorsedBy.Clear();
            txtApprovedBy.Clear();
            txtReason.Clear();
            cboShippingSite.SelectedItem = null;
            txtAddress.Clear();
            txtTlAmtBeforeDiscount.Clear();
            txtTotalDiscount.Clear();
            txtTotalBaseAmount.Clear();
            txtTotalTax.Clear();
            txtTotalAmount.Clear();
        }
        public void saveStatus(String val)
        {
            lblSaveStatus.Text = val;
        }

        TextBox txtRequestType = new TextBox();
        TextBox createdDate = new TextBox();
        private void btnSave_Click(object sender, EventArgs e)
        {
            txtRequestType.Text = cboRequestType.Text;
            createdDate.Text = dtCreatedDate.Value.ToString("MM-dd-yyyy");

            //validate data before save
            if (cmd.isEmpty(txtRequestType, createdDate, txtRequestedBy) == true) { return; }; //validate if empty

            if (btnSave.Text == " Save")
            {
                // Extract year and month from DateTimePicker
                string currentYear = dtCreatedDate.Value.ToString("yyyy");
                string currentMonth = dtCreatedDate.Value.ToString("MM");
                string CreatedDate = dtCreatedDate.Value.ToString("yyyy/MM");// Ensuring correct format for LIKE pattern

                //get lastcode from database
                string lastCode = dao.GetLastCode(cboRequestType.Text, CreatedDate);
                int lastNumber = 0;

                if (!string.IsNullOrEmpty(lastCode))
                {
                    //Extract last number from last code
                    lastNumber = int.Parse(lastCode.Substring(lastCode.Length - 5)); //Extract last 5 characters
                }

                //Getnerate new number
                string nextNumber = (lastNumber + 1).ToString("D5");
                string newCode = $"PQ-{cboRequestType.Text}-{currentYear}/{currentMonth}-{nextNumber}";

                //check dupplicate 
                if (dao.isDuplicate(newCode) == true)
                {
                    MessageBox.Show("Duplicated!");
                    cboRequestType.SelectAll();
                    cboRequestType.Focus();
                    return;  //in order to stop the code
                };

                long usrId = dao.getUserID(txtRequestedBy.Text);
                if (usrId > 0)
                {
                    //add record to db and datagridview
                    if (dao.addMainRequest(newCode, cboRequestType.Text, dtCreatedDate.Text, txtRequestDesc.Text, usrId.ToString(), txtEndorsedBy.Text, txtApprovedBy.Text, txtReason.Text, cboShippingSite.Text, txtAddress.Text))
                    {
                        lblRequestNo.Text = newCode;
                        btnSave.Enabled = false;
                        readOnlyBox(true);
                        enableBox(false);
                        saveStatus("Saved");
                        Program.mainRequestNo = newCode;
                    }
                    else
                    {
                        MessageBox.Show("Add vendor failed!");
                    }
                }

            }
            else
            {
                if (lblRequestNo.Text != Program.mainRequestNo)
                {
                    //check dupplicate vendor_name
                    if (dao.isDuplicate(lblRequestNo.Text) == true)
                    {
                        MessageBox.Show("Duplicated!");
                        cboRequestType.SelectAll();
                        cboRequestType.Focus();
                        return;  //in order to stop the code
                    };
                }
                long usrId = dao.getUserID(txtRequestedBy.Text);
                if (usrId > 0)
                {
                    if (dao.updateMainRequest(lblRequestNo.Text, dtCreatedDate.Text, txtRequestDesc.Text, usrId.ToString(), txtEndorsedBy.Text, txtApprovedBy.Text, txtReason.Text, cboShippingSite.Text, txtAddress.Text))
                    {
                        enableBox(false);
                        readOnlyBox(true);
                        btnSave.Text = " Save";
                        btnSave.Enabled = false;
                        saveStatus("Saved");
                        Program.mainRequestNo = lblRequestNo.Text;
                    }
                    else
                    {
                        MessageBox.Show("Update failed!");
                    }
                }
            }
            btnSaveCloses.Enabled = false;

            //Set controlButton to null value
            Program.mainFrm.nullValueForControlButton();

        }

        private void btnSaveCloses_Click(object sender, EventArgs e)
        {
            txtRequestType.Text = cboRequestType.Text;
            createdDate.Text = dtCreatedDate.Value.ToString("MM-dd-yyyy");

            //validate data before save
            if (cmd.isEmpty(txtRequestType, createdDate, txtRequestedBy) == true) { return; }; //validate if empty

            // Extract year and month from DateTimePicker
            string currentYear = dtCreatedDate.Value.ToString("yyyy");
            string currentMonth = dtCreatedDate.Value.ToString("MM");
            string CreatedDate = dtCreatedDate.Value.ToString("yyyy/MM");// Ensuring correct format for LIKE pattern

            //get lastcode from database
            string lastCode = dao.GetLastCode(cboRequestType.Text, CreatedDate);
            int lastNumber = 0;

            if (!string.IsNullOrEmpty(lastCode))
            {
                //Extract last number from last code
                lastNumber = int.Parse(lastCode.Substring(lastCode.Length - 5)); //Extract last 5 characters
            }

            //Getnerate new number
            string nextNumber = (lastNumber + 1).ToString("D5");
            string newCode = $"PQ-{cboRequestType.Text}-{currentYear}/{currentMonth}-{nextNumber}";

            //check dupplicate 
            if (dao.isDuplicate(newCode) == true)
            {
                MessageBox.Show("Duplicated!");
                cboRequestType.SelectAll();
                cboRequestType.Focus();
                return;  //in order to stop the code
            };

            long usrId = dao.getUserID(txtRequestedBy.Text);
            if (usrId > 0)
            {
                //add record to db and datagridview
                if (dao.addMainRequest(newCode, cboRequestType.Text, dtCreatedDate.Text, txtRequestDesc.Text, usrId.ToString(), txtEndorsedBy.Text, txtApprovedBy.Text, txtReason.Text, cboShippingSite.Text, txtAddress.Text))
                {
                    this.Close();
                    saveStatus("Saved");
                    Program.mainRequestNo = newCode;
                }
                else
                {
                    MessageBox.Show("Add vendor failed!");
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnSave.Enabled == true)
            {
                //validate if task not yet save
                DialogResult rst = MessageBox.Show("Do you want to save your changes before leaving this page?", "Unsaved changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rst == DialogResult.Yes)
                {
                    MessageBox.Show("Please go to save!");
                    return;
                }
                else
                {
                    btnSave.Enabled = true;
                    btnSave.Text = " Save";
                    btnSaveCloses.Enabled = true;
                    enableBox(true);
                    readOnlyBox(false);
                    resetBox();
                    cboRequestType.Focus();
                    saveStatus("Unsaved");

                    Program.mainFrm.setValueForControlButton();

                }
            }
            else
            {
                btnSave.Enabled = true;
                btnSaveCloses.Enabled = true;
                enableBox(true);
                readOnlyBox(false);
                resetBox();
                cboRequestType.Focus();
                saveStatus("Unsaved");

                Program.mainFrm.setValueForControlButton();

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnSave.Enabled == false)
            {
                btnSave.Enabled = true;
                btnSave.Text = " Save Change";
                btnSaveCloses.Enabled = false;
                enableBox(true);
                readOnlyBox(false);
                saveStatus("Unsaved");
                cboRequestType.Enabled = false;

                Program.mainFrm.setValueForControlButton();

            }
            else { return; }

        }

        private void VendorManagementFrm_Load(object sender, EventArgs e)
        {
            Program.mainFrm.setValueForControlButton();
        }

        //set color for btn while mouse hover
        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null && button != lastClickedButton)
            {
                button.ForeColor = Color.DodgerBlue; // Change to desired hover color
            }
        }

        //set color for btn while leave mouse hover
        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null && button != lastClickedButton)
            {
                button.ForeColor = SystemColors.ControlText; // Reset to default color
            }
        }
        DatagridviewRequestDetails frm = new DatagridviewRequestDetails();
        private void btnDetails_Click(object sender, EventArgs e)
        {
            //myBtnSetting(btnDetails, null);

            paneltask1.Visible = false;
            panelTask2.Visible = false;
            panelTask3.Visible = false;

            List<Dictionary<string, object>> data = dao.LoadAllRequestDetails(lblRequestNo.Text);
            frm.dataGridViewDetail.Rows.Clear();
            foreach (Dictionary<string, object> req in data)
            {
                frm.dataGridViewDetail.Rows.Add(req["Purchase_Class"], req["DetailReq_No"], req["Site"], req["Product_No"], req["Product_Name"], req["Req_Desc"], req["Qty_Order"],
                    Convert.ToDecimal(req["Unit_Price"]).ToString("0.00"), Convert.ToDecimal(req["Amount_BefDiscount"]).ToString("0.00"), Convert.ToDecimal(req["Discount"]).ToString("0.00"),
                    Convert.ToDecimal(req["Base_Amount"]).ToString("0.00"), Convert.ToDecimal(req["Tax_Amount"]).ToString("0.00"), Convert.ToDecimal(req["Total_Amount"]).ToString("0.00"), req["Is_Deactivated"]);
            }

            frm.TopLevel = false;
            panelTask.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            //myBtnSetting(btnSummary, null);

            frm.Hide();

            paneltask1.Visible = true;
            panelTask2.Visible = true;
            panelTask3.Visible = true;
        }
        public void LoadAllBU()
        {
            List<Dictionary<string, object>> data = usrDao.LoadAllBU();
            foreach (Dictionary<string, object> bu in data)
            {
                cboRequestType.Items.Add(bu["BU_No"].ToString());
                cboShippingSite.Items.Add(bu["BU_No"].ToString());
            }
        }

        // set for last clicked button
        public Button lastClickedButton = null;

        //method for changing button color
        public void myBtnSetting(object sender, EventArgs e)
        {
            // Reset last clicked button
            if (lastClickedButton != null)
            {
                //lastClickedButton.BackColor = Color.White;
                lastClickedButton.ForeColor = Color.Black;
            }

            // Set new clicked button
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                //clickedButton.BackColor = Color.Blue;
                clickedButton.ForeColor = Color.Blue;
                lastClickedButton = clickedButton;
            }
        }

        private bool isUpdatingTextBox = false;

        //Method for show UserFrom
        private void ShowUserSelectionForm(TextBox targetTextBox, Panel panelContainer, bool showAbove, string filterUser = "")
        {
            // Create the LoadNameFrm instance
            LoadNameFrm frm = new LoadNameFrm();

            if (showAbove)
            {
                //Call the LoadNameFrm to show above textbox
                cmd.ShowFormAboveTextBox(targetTextBox, panelContainer, frm, this);
            }
            else
            {
                //Call the LoadNameFrm to show below textbox
                cmd.ShowFormBelowTextBox(targetTextBox, panelContainer, frm, this);
            }

            // Load user data into the form's ListBox
            LoadAllUsersIntoListBox(frm, filterUser);

            // Subscribe to the UserNameSelected event to update the TextBox
            frm.UserNameSelected += (sender, userName) =>
            {
                isUpdatingTextBox = true; // Set flag to true to ignore TextChanged event
                targetTextBox.Text = userName;
                isUpdatingTextBox = false;// Reset flag after updating
                frm.Visible = false;
            };
            //frm.Show();
            //frm.Visible = true;
        }

        //Load user into list box in LoadNameFrm
        private void LoadAllUsersIntoListBox(LoadNameFrm frm, String filterUser)
        {
            List<Dictionary<string, object>> data = usrDao.searchUsersByusrName(filterUser, "", "NO");
            frm.listBoxResult.Items.Clear();
            foreach (Dictionary<string, object> usr in data)
            {
                string userName = usr["uname"].ToString();

                // Ensure userName and filterUser are not null before calling Contains
                bool shouldAddUser = string.IsNullOrEmpty(filterUser) || (filterUser != null && userName != null && userName.IndexOf(filterUser, StringComparison.OrdinalIgnoreCase) >= 0);
                if (shouldAddUser)
                {
                    frm.listBoxResult.Items.Add(userName);
                }
            }
            // Make the ListBox visible if it has items
            frm.listBoxResult.Visible = frm.listBoxResult.Items.Count > 0;
        }

        private void btnShowAllRequestedByUserName_Click(object sender, EventArgs e)
        {
            // Call the reusable method to display the form below txtRequestedBy
            ShowUserSelectionForm(txtRequestedBy, paneltask1, false);
        }

        private void btnShowAllEndorsedByUserName_Click(object sender, EventArgs e)
        {
            // Call the reusable method to display the form below txtRequestedBy
            ShowUserSelectionForm(txtEndorsedBy, paneltask1, true);
        }

        private void btnShowAllApprovedByUserName_Click(object sender, EventArgs e)
        {
            // Call the reusable method to display the form below txtRequestedBy
            ShowUserSelectionForm(txtApprovedBy, paneltask1, true);
        }

        private void txtRequestedBy_TextChanged(object sender, EventArgs e)
        {
            if(!isUpdatingTextBox)
            {
                string usr = txtRequestedBy.Text;
                if (!string.IsNullOrEmpty(usr))
                {
                    ShowUserSelectionForm(txtRequestedBy, paneltask1, false, usr);
                }
            }   
        }
    }
}
