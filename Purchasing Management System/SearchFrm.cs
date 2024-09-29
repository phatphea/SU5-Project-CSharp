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
    public partial class SearchFrm : Form
    {
        public SearchFrm()
        {
            InitializeComponent();
        }

        ClsCommon cmd = new ClsCommon();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            //validate if searchValue empty
            if (cboSearchField.SelectedIndex == 1 || cboSearchField.SelectedIndex == 2)
            {
                if (cmd.isEmptyOneField(txtSearchValue) == true) { return; };
            }

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void cboSearchField_SelectedIndexChanged(object sender, EventArgs e)
        {
            //enable and disble txtSearchValue
            if (cboSearchField.SelectedIndex == 0)
            {
                txtSearchValue.Enabled = false;
            }
            else
            {
                txtSearchValue.Enabled = true;
                txtSearchValue.Focus();
            }
        }

        public string activeOrInactive { get; set; }
    }
}
