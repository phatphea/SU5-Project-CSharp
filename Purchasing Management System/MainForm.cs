using Purchasing_Management_System.Common;
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
                        break;
                    case "Enable Vendor":
                        vendorFrm();
                        break;
                    case "Enable ARF":
                        vendorFrm();
                        break;
                    case "Enable PO":
                        vendorFrm();
                        break;
                    case "Enable GRN":
                        vendorFrm();
                        break;
                    case "Enable PR":
                        vendorFrm();
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
            
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm_Load(null, null);
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagementFrm frm = new UserManagementFrm();
            frm.ShowDialog();
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
            }
        }
        
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (cmd.checkTaskUnsaved("Enable Home") == true)
            {
                enableButton("Enable Home");
            }
            else
            {
                vendorFrm();
            }
        }
    }
}
