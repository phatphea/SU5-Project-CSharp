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
    public partial class CategoryManagementFrm : Form
    {
        public CategoryManagementFrm()
        {
            InitializeComponent();
        }

        CategoryMgtDao dao = new CategoryMgtDao();

        ClsCommon cmd = new ClsCommon();

        //reset textbox function
        public void resestBox()
        {
            txtCatNo.Clear();
            txtCatName.Clear();
            txtCatDesc.Clear(); 
            txtCatName.Focus();
        }

        //Load all category in datagridview
        private void CategoryManagementFrm_Load(object sender, EventArgs e)
        {
            cboFilterCategory.SelectedIndex = 0;
            cboActiveCategory.SelectedIndex = 0;

            dataGridView1.Rows.Clear();
            List<Dictionary<string, object>> data = dao.LoadAllCategory("","No");
            foreach (Dictionary<string, object> cat in data)
            {
                dataGridView1.Rows.Add(cat["Category_No"], cat["Category_Class"], cat["Category_Name"], cat["Category_Types"] , cat["Category_Desc"], cat["Is_Deactivated"]);
            }
            long countRows = dao.countRowsCatogory("","No"); //No is Active Category
            if (countRows > 0)
            {
                lblTotalRows.Text = countRows.ToString();
            }            
        }
        public void refreshCateogryView()
        {
            CategoryManagementFrm_Load(null, null); //to refresh to the default category view
        }
        private void enableControl(Boolean val)
        {
            btnToolAdd.Enabled = val;
            btnRefresh.Enabled = val;
            btnTools.Enabled = val;
            btnToolSearch.Enabled = val;
            btnToolDelete.Enabled = val;
            btnToolActivate.Enabled = val;
            btnToolDeactivate.Enabled = val;
            dataGridView1.Enabled = val;
        }

        //add new
        TextBox txtCatClass = new TextBox();
        TextBox txtCatTypes = new TextBox();
        private void btnToolAdd_Click(object sender, EventArgs e)
        {
            txtCatClass.Text = cboCatClass.Text;
            txtCatTypes.Text=cboTypeOfCategory.Text;
            //validate data before save
            if (cmd.isEmpty(txtCatClass, txtCatName, txtCatTypes) == true) { return; }; //validate if empty

            //check dupplicate category
            if (dao.isDuplicate(txtCatName.Text) == true)
            {
                MessageBox.Show("This category already exit!");
                txtCatName.SelectAll();
                txtCatName.Focus();
                return;  //in order to stop the code
            };

            //add record to db and datagridview
            long catId = dao.addCategory(cboCatClass.Text, txtCatName.Text, cboTypeOfCategory.Text, txtCatDesc.Text);
            if (catId > 0)
            {
                dao.updateCategoryNo(catId.ToString(), cboTypeOfCategory.Text); //add vendor_no to database
                txtCatNo.Text = "CAT" + "-" + cboTypeOfCategory.Text + "-" + catId.ToString("0000");
                if(cboFilterCategory.SelectedText == cboCatClass.Text || cboFilterCategory.SelectedIndex == 0 && cboActiveCategory.SelectedIndex == 0)
                {
                    dataGridView1.Rows.Add(txtCatNo.Text, txtCatClass.Text, txtCatName.Text, cboTypeOfCategory.Text, txtCatDesc.Text, "No");
                }
                resestBox();
            }
            else
            {
                MessageBox.Show("Add category failed!");
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
            DialogResult rst = MessageBox.Show("Are you sure to delete this category?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rst == DialogResult.Yes)
            {
                //start delete
                //1st delete from table in db
                //2nd if success delete form db then delete form datagridview
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                try //validate when category was used for created product
                {
                    if (dao.deleteCategory(dr.Cells[0].Value.ToString()) == true)
                    {
                        dataGridView1.Rows.Remove(dr);
                        int editRow = Convert.ToInt32(lblTotalRows.Text) - 1;
                        lblTotalRows.Text = editRow.ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Cannot delete this category! Because it already used for creating product, you can deactivate it.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    refreshCateogryView();
                    return;
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

                txtCatNo.Text = r.Cells[0].Value.ToString();
                cboCatClass.Text = r.Cells[1].Value.ToString();
                txtCatName.Text = r.Cells[2].Value.ToString();
                cboTypeOfCategory.Text = r.Cells[3].Value.ToString();
                txtCatDesc.Text = r.Cells[4].Value.ToString();
                enableControl(false); //disable control Add Delete Search in form
                btnToolEdit.Text = "  Save Change";
            }
            else
            {
                txtCatClass.Text = cboCatClass.Text;
                txtCatTypes.Text = cboTypeOfCategory.Text;
                if (cmd.isEmpty(txtCatClass, txtCatName, txtCatTypes, txtCatClass ) == true) { return; }; //validate if empty
                if (txtCatName.Text != r.Cells[2].Value.ToString())
                {
                    //check dupplicate username. check direct to database
                    if (dao.isDuplicate(txtCatName.Text) == true)
                    {
                        MessageBox.Show("This category already exit!");
                        txtCatName.SelectAll();
                        txtCatName.Focus();
                        return;  //in order to stop the code
                    };
                }

                if (dao.updateCategory(txtCatNo.Text, txtCatClass.Text, txtCatName.Text, cboTypeOfCategory.Text, txtCatDesc.Text))
                {
                    refreshCateogryView();
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
            search.cboSearchField.Items.Add("Category No.");
            search.cboSearchField.Items.Add("Category Name");
            search.cboSearchField.SelectedIndex = 0;

            if (search.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Clear();
                if (cboFilterCategory.SelectedItem != null)
                {
                    string catClass = cboFilterCategory.SelectedItem.ToString();
                    if (catClass == "All Category")
                    {
                        catClass = "";
                    }
                    if (cboActiveCategory.SelectedItem != null)
                    {
                        string catActive=cboActiveCategory.SelectedItem.ToString();
                        if (catActive == "Active Category")
                        {
                            catActive = "No";
                        }
                        else { catActive = "Yes"; }
                        
                        if (search.cboSearchField.SelectedItem != null)
                        {
                            List<Dictionary<string, object>> loadCat;
                            long countRows;
                            string searchField=search.cboSearchField.SelectedItem.ToString();
                            if (searchField== "-- Show All --")
                            {
                                loadCat = dao.LoadAllCategory("", "No");
                                countRows = dao.countRowsCatogory("", "No");
                            }
                            else if (searchField== "Category No.")
                            {
                                loadCat = dao.searchCategoryByNo(search.txtSearchValue.Text, catClass, catActive);
                                countRows = dao.countRowsCategoryByNo(search.txtSearchValue.Text, catClass, catActive);
                            }
                            else
                            {
                                loadCat = dao.searchCategoryByName(search.txtSearchValue.Text, catClass, catActive);
                                countRows = dao.countRowsCatogoryByName(search.txtSearchValue.Text, catClass, catActive);
                            }
                            foreach (Dictionary<string, object> cat in loadCat)
                            {
                                dataGridView1.Rows.Add(cat["Category_No"], cat["Category_Class"], cat["Category_Name"], cat["Category_Types"], cat["Category_Desc"], cat["Is_Deactivated"]);
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

        private void btnToolDeactivate_Click(object sender, EventArgs e)
        {
            //validate if no record for select
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return; //if not return, code below will execute
            }

            //validate when user click button Edit
            DataGridViewRow r = dataGridView1.SelectedRows[0];
            string catNo = r.Cells[0].Value.ToString();
            string deactivated = r.Cells[5].Value.ToString();

            if (deactivated == "No")
            {
                deactivated = "Yes";
                DialogResult rst = MessageBox.Show("Are you sure to Deactivate this category?", "Deactivate", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rst == DialogResult.Yes)
                {
                    //1st update to db
                    //2nd update to datagridview
                    if (dao.deactivateCategory(catNo, deactivated))
                    {
                        //r.Cells[5].Value = deactivated;
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
        private void btnToolActivate_Click(object sender, EventArgs e)
        {
            //validate if no record for select
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return; //if not return, code below will execute
            }

            //validate when user click button Edit
            DataGridViewRow r = dataGridView1.SelectedRows[0];
            string catNo = r.Cells[0].Value.ToString();
            string activated = r.Cells[5].Value.ToString();

            if (activated == "Yes")
            {
                activated = "No";
                DialogResult rst = MessageBox.Show("Are you sure to Activate this category?", "Activate", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rst == DialogResult.Yes)
                {
                    //1st update to db
                    //2nd update to datagridview
                    if (dao.deactivateCategory(catNo, activated))
                    {
                        //r.Cells[5].Value = activated;
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

        private void cboFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            cboFilterCategory.SelectedItem = Color.White;
            List<Dictionary<string, object>> data;
            if (cboFilterCategory.SelectedItem != null)
            {
                string catClass = cboFilterCategory.SelectedItem.ToString();
                if (catClass == "All Category")
                {
                    catClass = "";
                }
                if (cboActiveCategory.SelectedItem != null)
                {
                    string catActive = cboActiveCategory.SelectedItem.ToString();
                    if (catActive == "Active Category")
                    {
                        catActive = "No";
                    }
                    else { catActive = "Yes"; }
                    data = dao.LoadAllCategory(catClass, catActive); //No is Active Vendor
                    long countRow = dao.countRowsCatogory(catClass, catActive);
                    foreach (Dictionary<string, object> cat in data)
                    {
                        dataGridView1.Rows.Add(cat["Category_No"], cat["Category_Class"], cat["Category_Name"], cat["Category_Types"], cat["Category_Desc"], cat["Is_Deactivated"]);
                    }
                    if (countRow > 0)
                    {
                        lblTotalRows.Text = countRow.ToString();
                    }
                    else { lblTotalRows.Text = "0"; }
                } 
            }   
        }

        private void cboActiveCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboActiveCategory.SelectedItem = Color.White;
            dataGridView1.Rows.Clear();

            List<Dictionary<string, object>> data;
            if (cboActiveCategory.SelectedItem != null)
            {
                string catActive = cboActiveCategory.SelectedItem.ToString();
                if(catActive=="Active Category")
                {
                    catActive = "No";
                }
                else { catActive = "Yes"; }

                if (cboFilterCategory.SelectedItem != null)
                {
                    string catClass = cboFilterCategory.SelectedItem.ToString();
                    if (catClass == "All Category")
                    {
                        catClass = "";
                    }
                    data = dao.LoadAllCategory(catClass, catActive); //No is Active Vendor
                    long countRow = dao.countRowsCatogory(catClass, catActive);
                    foreach (Dictionary<string, object> cat in data)
                    {
                        dataGridView1.Rows.Add(cat["Category_No"], cat["Category_Class"], cat["Category_Name"], cat["Category_Types"], cat["Category_Desc"], cat["Is_Deactivated"]);
                    }
                    if (countRow > 0)
                    {
                        lblTotalRows.Text = countRow.ToString();
                    }
                    else { lblTotalRows.Text = "0"; }
                }
                
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshCateogryView();
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

    }
}
