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
using System.Xml.Linq;

namespace Purchasing_Management_System
{
    public partial class VendorManagementFrm : Form
    {
        public VendorManagementFrm()
        {
            InitializeComponent();
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
            txtVenName.Enabled = val;
            txtVenNameKH.Enabled = val;
            txtVenClass.Enabled = val;
            txtVenAddress.Enabled = val;
            txtVenEmail.Enabled = val;
            txtVenMobile.Enabled = val;
            txtTaxNo.Enabled = val;
            cboIsTax.Enabled = val;
        }
        public void resetBox()
        {
            txtVenId.Clear();
            txtVenNo.Clear();
            txtVenName.Clear();
            txtVenNameKH.Clear();
            txtVenClass.Clear();
            txtVenAddress.Clear();
            txtVenEmail.Clear();
            txtVenMobile.Clear();
            txtTaxNo.Clear();
            cboIsTax.SelectedItem= null;
            lblVendorName.ResetText();
        }
        public void saveStatus(String val)
        {
            lblSaveStatus.Text = val;
        }

        ClsCommon cmd = new ClsCommon();
        VendorMgtDao dao = new VendorMgtDao();
        DatagridviewVendorFrm data = new DatagridviewVendorFrm();

        TextBox txtIsTax = new TextBox();
        private void btnSave_Click(object sender, EventArgs e)
        {
            //validate data before save
            txtIsTax.Text = cboIsTax.Text;
            if (cmd.isEmpty(txtVenName, txtVenClass, txtVenAddress, txtVenMobile, txtIsTax) == true) { return; }; //validate if empty

            if (btnSave.Text == " Save")
            {

                //check dupplicate vender_phoneNumber
                if (dao.isDuplicate(txtVenMobile.Text) == true)
                {
                    MessageBox.Show("This vendor already exit!");
                    txtVenName.SelectAll();
                    txtVenName.Focus();
                    return;  //in order to stop the code
                };

                //add record to db and datagridview
                long venId = dao.addVendor(txtVenName.Text, txtVenNameKH.Text , txtVenClass.Text, txtVenAddress.Text, txtVenEmail.Text, txtVenMobile.Text, txtTaxNo.Text, cboIsTax.Text);
                if (venId > 0)
                {
                    dao.updateVendorNo(venId.ToString()); //add vendor_no to database
                    txtVenId.Text = venId.ToString();
                    txtVenNo.Text = "VENDOR " + venId.ToString("000");
                    enableBox(false);
                    btnSave.Enabled = false;
                    saveStatus("Saved");
                }
                else
                {
                    MessageBox.Show("Add vendor failed!");
                }
            }
            else
            {
                if (txtVenMobile.Text != Program.vendor_phoneNumber)
                {
                    //check dupplicate vendor_name
                    if (dao.isDuplicate(txtVenMobile.Text) == true)
                    {
                        MessageBox.Show("This vendor already exit!");
                        txtVenName.SelectAll();
                        txtVenName.Focus();
                        return;  //in order to stop the code
                    };
                } 

                if (dao.updateVendor(txtVenId.Text, txtVenName.Text,txtVenNameKH.Text, txtVenClass.Text, txtVenAddress.Text, txtVenEmail.Text, txtVenMobile.Text, txtTaxNo.Text, cboIsTax.Text))
                {
                    enableBox(false);
                    btnSave.Text = "  Save";
                    btnSave.Enabled = false;
                    saveStatus("Saved");
                    
                }
                else
                {
                    MessageBox.Show("Update failed!");
                }

            }
            btnSaveCloses.Enabled = false;
            lblVendorName.Text = txtVenName.Text;

            //Set controlButton to null value
            Program.mainFrm.nullValueForControlButton();

        }

        private void btnSaveCloses_Click(object sender, EventArgs e)
        {
            //validate data before save
            if (cmd.isEmpty(txtVenName, txtVenClass, txtVenAddress, txtVenMobile, txtIsTax) == true) { return; }; //validate if empty

            //check dupplicate vendor_name
            if (dao.isDuplicate(txtVenMobile.Text) == true)
            {
                MessageBox.Show("This vendor already exit!");
                txtVenName.SelectAll();
                txtVenName.Focus();
                return;  //in order to stop the code
            };

            //add record to db and datagridview
            long venId = dao.addVendor(txtVenName.Text, txtVenNameKH.Text, txtVenClass.Text, txtVenAddress.Text, txtVenEmail.Text, txtVenMobile.Text, txtTaxNo.Text, cboIsTax.Text);
            if (venId > 0)
            {
                //data.dataGridView1.Rows.Add(venId, txtVenName.Text, txtVenClass.Text, txtVenAddress.Text, txtVenEmail.Text, txtVenMobile.Text); //=>Not Execute
                dao.updateVendorNo(venId.ToString()); //add vendor_no to database
                this.Close();
                saveStatus("Saved");
            }
            else
            {
                MessageBox.Show("Add vendor failed!");
            }

            Program.mainFrm.nullValueForControlButton();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if(btnSave.Enabled == true)
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
                    resetBox();
                    txtVenName.Focus();
                    saveStatus("Unsaved");

                    //Program.mainFrm.btnHome.Enabled = false;
                    Program.mainFrm.setValueForControlButton();

                }
            }
            else
            {
                btnSave.Enabled = true;
                btnSaveCloses.Enabled= true;
                enableBox(true);
                resetBox();
                txtVenName.Focus();
                saveStatus("Unsaved");

                Program.mainFrm.setValueForControlButton();

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(btnSave.Enabled == false)
            {
                btnSave.Enabled = true;
                btnSave.Text = " Save Change";
                btnSaveCloses.Enabled = false;
                enableBox(true);
                saveStatus("Unsaved");

                Program.mainFrm.setValueForControlButton();

            }
            else { return; }
            
        }

        private void VendorManagementFrm_Load(object sender, EventArgs e)
        {
            Program.mainFrm.setValueForControlButton();
        }

        private void cboIsTax_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboIsTax.SelectedIndex == 1)
            {
                txtTaxNo.Enabled = false;
            }
            else { txtTaxNo.Enabled = true; }            
        }
    }
}
