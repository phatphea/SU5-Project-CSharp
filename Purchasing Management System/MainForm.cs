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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        UserMgtDao dao = new UserMgtDao();
        public void setValueForControlButton()
        {
            string[] setValueToControlButton = { "Enable Home", "Enable Vendor", "Enable ARF", "Enable PO", "Enable GRN", "Enable PR" };
            Program.controlButton = setValueToControlButton;
        }
        public void nullValueForControlButton()
        {
            Program.controlButton = null;
        }

        public void enableButton(String val)
        {
            VendorManagementFrm vfrm = new VendorManagementFrm();

            //validate if task not yet save
            DialogResult rst = MessageBox.Show("Do you want to save your changes before leaving this page?", "Unsaved changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rst == DialogResult.No)
            {
                switch (val)
                {
                    case "Enable Home":
                        vendorFrm();
                        myBtnSetting(btnVendor, null);
                        break;
                    case "Enable Vendor":
                        vendorFrm();
                        myBtnSetting(btnVendor, null);
                        break;
                    case "Enable ARF":
                        requestFrm();
                        myBtnSetting(btnRequest, null);
                        break;
                    case "Enable PO":
                        vendorFrm();
                        myBtnSetting(btnPO, null);
                        break;
                    case "Enable GRN":
                        vendorFrm();
                        myBtnSetting(btnGR, null);
                        break;
                    case "Enable PR":
                        vendorFrm();
                        myBtnSetting(btnPayment, null);
                        break;
                }

            }
            else
            {
                MessageBox.Show("Please go to save");
                setValueForControlButton();
                return;
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginFrm frm = new LoginFrm();
            frm.ShowDialog();

            //display user name
            if (Program.userLogin.Length > 0)
            {
                userNameToolStripMenuItem.Text = Program.userLogin;
            }

            //Refresh vendor view
            vendorFrm();
            myBtnSetting(btnVendor, null);
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //splitContainer1.Panel2.Controls.Clear(); // to remove view on splitContainer.panel2 when click logout
            MainForm_Load(null, null);
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagementFrm frm = new UserManagementFrm();
            if (Program.userLogin.Length > 0)
            {
                string usr = dao.searchUserRole(Program.userLogin);
                if (usr == "Admin")
                {
                    frm.ShowDialog();
                }
                else { MessageBox.Show("You do not have permission to access this form. Please contact to your admin", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }

        }

        //display datagridviewVendofrm
        public void vendorFrm()
        {
            nullValueForControlButton(); //to make controlButton value is null

            DatagridviewVendorFrm vfrm = new DatagridviewVendorFrm();
            vfrm.TopLevel = false;
            if (splitContainer1.Panel2.Controls.Count > 0)
            {
                splitContainer1.Panel2.Controls.Clear();
            }
            splitContainer1.Panel2.Controls.Add(vfrm);
            vfrm.BringToFront();
            vfrm.Show();
        }
        //display datagridviewRequestFrm
        public void requestFrm()
        {
            nullValueForControlButton(); //to make controlButton value is null

            DatagridviewRequest rfrm = new DatagridviewRequest();
            rfrm.TopLevel = false;
            if (splitContainer1.Panel2.Controls.Count > 0)
            {
                splitContainer1.Panel2.Controls.Clear();
            }
            splitContainer1.Panel2.Controls.Add(rfrm);
            rfrm.BringToFront();
            rfrm.Show();
        }

        ClsCommon cmd = new ClsCommon();

        private void btnVendor_Click(object sender, EventArgs e)
        {
            //Refresh display datagridviewVendofrm
            if (cmd.checkTaskUnsaved("Enable Vendor") == true)
            {

                enableButton("Enable Vendor");
            }
            else
            {
                vendorFrm();
                myBtnSetting(btnVendor, null);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //Refresh display datagridviewVendofrm
            if (cmd.checkTaskUnsaved("Enable Home") == true)
            {
                enableButton("Enable Home");
            }
            else
            {
                vendorFrm();
                myBtnSetting(btnVendor, null);
            }
        }

        private void categoryInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryManagementFrm frm = new CategoryManagementFrm();
            if (Program.userLogin.Length > 0)
            {
                string usr = dao.searchUserRole(Program.userLogin);
                if (usr == "Admin")
                {
                    frm.ShowDialog();
                }
                else { MessageBox.Show("You do not have permission to access this form. Please contact to your admin", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        }

        private void groupManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BUManagementFrm frm = new BUManagementFrm();
            if (Program.userLogin.Length > 0)
            {
                string usr = dao.searchUserRole(Program.userLogin);
                if (usr == "Admin")
                {
                    frm.ShowDialog();
                }
                else { MessageBox.Show("You do not have permission to access this tool. Please contact to your admin!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        }

        private void productInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsManagementFrm frm = new ProductsManagementFrm();
            if (Program.userLogin.Length > 0)
            {
                string usr = dao.searchUserRole(Program.userLogin);
                if (usr == "Admin")
                {
                    frm.ShowDialog();
                }
                else { MessageBox.Show("You do not have permission to access this form. Please contact to your admin", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            //Refresh display datagridviewRequestfrm
            if (cmd.checkTaskUnsaved("Enable ARF") == true)
            {

                enableButton("Enable ARF");
            }
            else
            {
                requestFrm();
                myBtnSetting(btnRequest, null);
            }
        }

        public Button lastClickedButton = null; // set for last clicked button

        //method for changing button color
        public void myBtnSetting(object sender, EventArgs e)
        {
            // Reset last clicked button
            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = SystemColors.ControlLight;
                lastClickedButton.ForeColor = SystemColors.ControlText;
            }

            // Set new clicked button
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                clickedButton.BackColor = Color.WhiteSmoke;
                clickedButton.ForeColor = Color.Black;
                lastClickedButton = clickedButton;
            }
        }

    }
}
