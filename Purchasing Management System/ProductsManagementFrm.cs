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
    public partial class ProductsManagementFrm : Form
    {
        public ProductsManagementFrm()
        {
            InitializeComponent();
        }

        ProductMgtDao dao = new ProductMgtDao();

        ClsCommon cmd = new ClsCommon();

        //reset textbox function
        public void resestBox()
        {
            txtProNo.Clear();
            txtProName.Clear();
            txtProDesc.Clear();
            txtProUom.Clear();
            txtProName.Focus();
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

        //Load all category in datagridview
        private void CategoryManagementFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            cboCategory.Items.Clear();
            cboFilterProductByCategory.Items.Clear();
            
            cboActiveProduct.SelectedIndex = 0;

            List<Dictionary<string, object>> data = dao.LoadAllProducts("","No");
            foreach (Dictionary<string, object> pro in data)
            {
                dataGridView1.Rows.Add(pro["Product_No"], pro["Product_Name"], pro["Product_Type"], pro["Product_Uom"], pro["Product_Description"] , pro["Category_Name"], pro["Category_No"], pro["Is_Deactivated"]);
            }

            LoadAllCategoryInCboCategory();
            cboFilterProductByCategory.SelectedIndex = 0;

            long countRows = dao.countRowsProduct("", "No"); //No is Active Category
            if (countRows > 0)
            {
                lblTotalRows.Text = countRows.ToString();
            }
        }
        public void refreshProductView()
        {
            CategoryManagementFrm_Load(null, null); //to refresh to the default category view
        }

        private void LoadAllCategoryInCboCategory()
        {
            List<Dictionary<string, object>> data = dao.LoadAllCategory();
            cboFilterProductByCategory.Items.Add("All Products");
            foreach (Dictionary<string, object> cat in data)
            {
                cboCategory.Items.Add(cat["Category_Name"].ToString());
                cboFilterProductByCategory.Items.Add(cat["Category_Name"].ToString());
            }
        }

        //add new
        TextBox txtCategory = new TextBox();
        TextBox txtTypesOfProduct = new TextBox();
        private void btnToolAdd_Click(object sender, EventArgs e)
        {
            txtCategory.Text = cboCategory.Text;
            txtTypesOfProduct.Text = cboTypeOfProduct.Text;
            //validate data before save
            if (cmd.isEmpty(txtProName, txtCategory, txtTypesOfProduct) == true) { return; }; //validate if empty

            //check dupplicate category
            if (dao.isDuplicate(txtProName.Text) == true)
            {
                MessageBox.Show("This product already exit!");
                txtProName.SelectAll();
                txtProName.Focus();
                return;  //in order to stop the code
            };

            //to search catNo to db that validate catName from txtCategory
            string catNo = dao.getCategoryId(cboCategory.Text);
            if (catNo.Length > 0)
            {
                //add record to db and datagridview
                long proId = dao.addProduct(txtProName.Text, cboTypeOfProduct.Text, txtProUom.Text, txtProDesc.Text, catNo);
                if (proId > 0)
                {
                    dao.updateProductNo(proId.ToString(), cboTypeOfProduct.Text); //add vendor_no to database
                    txtProNo.Text = "PD" + "-" + cboTypeOfProduct.Text + "-" + proId.ToString("0000");
                    if (cboFilterProductByCategory.SelectedText == cboCategory.Text || cboFilterProductByCategory.SelectedIndex==0 && cboActiveProduct.SelectedIndex==0)
                    {
                        dataGridView1.Rows.Add(txtProNo.Text, txtProName.Text, cboTypeOfProduct.Text, txtProUom.Text, txtProDesc.Text, cboCategory.Text, catNo, "No");
                    }
                    resestBox();
                }
                else
                {
                    MessageBox.Show("Add category failed!");
                }
                //do next
            }

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
            DialogResult rst = MessageBox.Show("Are you sure to delete this product?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rst == DialogResult.Yes)
            {
                //start delete
                //1st delete from table in db
                //2nd if success delete form db then delete form datagridview
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                try //validate when category was used for created product
                {
                    if (dao.deleteProduct(dr.Cells[0].Value.ToString()) == true)
                    {
                        dataGridView1.Rows.Remove(dr);
                        int editRow = Convert.ToInt32(lblTotalRows.Text) - 1;
                        lblTotalRows.Text = editRow.ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Cannot delete this product! Because it already used for another record, you can deactivate it.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    refreshProductView();
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

                txtProNo.Text = r.Cells[0].Value.ToString();
                txtProName.Text = r.Cells[1].Value.ToString();
                cboTypeOfProduct.Text = r.Cells[2].Value.ToString();
                txtProUom.Text = r.Cells[3].Value.ToString();
                txtProDesc.Text = r.Cells[4].Value.ToString();
                cboCategory.Text = r.Cells[5].Value.ToString();

                enableControl(false); //disable control Add Delete Search in form
                btnToolEdit.Text = "  Save Change";
            }
            else
            {
                txtCategory.Text = cboCategory.Text;
                txtTypesOfProduct.Text = cboTypeOfProduct.Text;
                if (cmd.isEmpty(txtProName, txtCategory, txtTypesOfProduct) == true) { return; }; //validate if empty
                if (txtProName.Text != r.Cells[1].Value.ToString())
                {
                    //check dupplicate product. check direct to database
                    if (dao.isDuplicate(txtProName.Text) == true)
                    {
                        MessageBox.Show("This product already exit!");
                        txtProName.SelectAll();
                        txtProName.Focus();
                        return;  //in order to stop the code
                    };
                }

                //to search catNo to db that validate catName from txtCategory
                string catNo = dao.getCategoryId(cboCategory.Text);
                if (catNo.Length > 0)
                {
                    if (dao.updateProduct(txtProNo.Text, txtProName.Text, cboTypeOfProduct.Text, txtProUom.Text, txtProDesc.Text, catNo))
                    {
                        refreshProductView();
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
        }

        //search
        private void btnToolSearch_Click_1(object sender, EventArgs e)
        {
            SearchFrm search = new SearchFrm();
            search.cboSearchField.Items.Add("-- Show All --");
            search.cboSearchField.Items.Add("Product No.");
            search.cboSearchField.Items.Add("Product Name");
            search.cboSearchField.SelectedIndex = 0;

            if (search.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Clear();
                if (cboFilterProductByCategory.SelectedItem != null)
                {
                    string cat = cboFilterProductByCategory.SelectedItem.ToString();
                    if (cat == "All Products")
                    {
                        cat = "";
                    }
                    if (cboActiveProduct.SelectedItem != null)
                    {
                        string proActive = cboActiveProduct.SelectedItem.ToString();
                        if (proActive == "Active Products")
                        {
                            proActive = "No";
                        }
                        else { proActive = "Yes"; }
                        if (search.cboSearchField.SelectedItem != null)
                        {
                            List<Dictionary<string, object>> loadPro;
                            long countRows;
                            string searchField = search.cboSearchField.SelectedItem.ToString();
                            if (searchField == "-- Show All --")
                            {
                                loadPro = dao.LoadAllProducts(cat, proActive);
                                countRows = dao.countRowsProduct(cat, proActive);
                            }
                            else if (searchField == "Product No.")
                            {
                                loadPro = dao.searchProductByNo(search.txtSearchValue.Text, cat, proActive);
                                countRows = dao.countRowsProductByNo(search.txtSearchValue.Text, cat, proActive);
                            }
                            else
                            {
                                loadPro = dao.searchProductByName(search.txtSearchValue.Text, cat, proActive);
                                countRows = dao.countRowsProductByName(search.txtSearchValue.Text, cat, proActive);
                            }
                            foreach (Dictionary<string, object> pro in loadPro)
                            {
                                dataGridView1.Rows.Add(pro["Product_No"], pro["Product_Name"], pro["Product_Type"], pro["Product_Uom"], pro["Product_Description"], pro["Category_Name"], pro["Category_No"], pro["Is_Deactivated"]);
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
            string proNo = r.Cells[0].Value.ToString();
            string deactivated = r.Cells[7].Value.ToString();

            if (deactivated == "No")
            {
                deactivated = "Yes";
                DialogResult rst = MessageBox.Show("Are you sure to Deactivate this product?", "Deactivate", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rst == DialogResult.Yes)
                {
                    //1st update to db
                    //2nd update to datagridview
                    if (dao.deactivateProduct(proNo, deactivated))
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
        private void btnToolActivate_Click(object sender, EventArgs e)
        {
            //validate if no record for select
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return; //if not return, code below will execute
            }

            //validate when user click button Edit
            DataGridViewRow r = dataGridView1.SelectedRows[0];
            string proNo = r.Cells[0].Value.ToString();
            string activated = r.Cells[7].Value.ToString();

            if (activated == "Yes")
            {
                activated = "No";
                DialogResult rst = MessageBox.Show("Are you sure to Activate this product?", "Activate", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rst == DialogResult.Yes)
                {
                    //1st update to db
                    //2nd update to datagridview
                    if (dao.deactivateProduct(proNo, activated))
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshProductView();
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

        private void cboFilterProductByCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            cboFilterProductByCategory.SelectedItem = Color.White;
            List<Dictionary<string, object>> data;
            if (cboFilterProductByCategory.SelectedItem != null)
            {
                string cat = cboFilterProductByCategory.SelectedItem.ToString();
                if (cat == "All Products")
                {
                    cat = "";
                }
                if (cboActiveProduct.SelectedItem != null)
                {
                    string proActive = cboActiveProduct.SelectedItem.ToString();
                    if (proActive == "Active Products")
                    {
                        proActive = "No";
                    }
                    else { proActive = "Yes"; }
                    data = dao.LoadAllProducts(cat, proActive); //No is Active Vendor
                    long countRow = dao.countRowsProduct(cat, proActive);
                    foreach (Dictionary<string, object> pro in data)
                    {
                        dataGridView1.Rows.Add(pro["Product_No"], pro["Product_Name"], pro["Product_Type"], pro["Product_Uom"], pro["Product_Description"], pro["Category_Name"], pro["Category_No"], pro["Is_Deactivated"]);
                    }
                    if (countRow > 0)
                    {
                        lblTotalRows.Text = countRow.ToString();
                    }
                    else { lblTotalRows.Text = "0"; }
                }
            }
        }

        private void cboActiveProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboActiveProduct.SelectedItem = Color.White;
            dataGridView1.Rows.Clear();

            List<Dictionary<string, object>> data;
            if (cboActiveProduct.SelectedItem != null)
            {
                string proActive = cboActiveProduct.SelectedItem.ToString();
                if (proActive == "Active Products")
                {
                    proActive = "No";
                }
                else { proActive = "Yes"; }

                if (cboFilterProductByCategory.SelectedItem != null)
                {
                    string cat = cboFilterProductByCategory.SelectedItem.ToString();
                    if (cat == "All Products")
                    {
                        cat = "";
                    }
                    data = dao.LoadAllProducts(cat, proActive); //No is Active Vendor
                    long countRow = dao.countRowsProduct(cat, proActive);
                    foreach (Dictionary<string, object> pro in data)
                    {
                        dataGridView1.Rows.Add(pro["Product_No"], pro["Product_Name"], pro["Product_Type"], pro["Product_Uom"], pro["Product_Description"], pro["Category_Name"], pro["Category_No"], pro["Is_Deactivated"]);
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
