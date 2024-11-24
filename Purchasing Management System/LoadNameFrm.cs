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
    public partial class LoadNameFrm : Form
    {
        public event EventHandler<string> UserNameSelected;
        public LoadNameFrm()
        {
            InitializeComponent();
            listBoxResult.SelectedIndexChanged += listBoxResult_SelectedIndexChanged;
        }

        private void listBoxResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxResult.SelectedItem != null)
            {
                // Raise the UserNameSelected event with the selected item
                UserNameSelected?.Invoke(this, listBoxResult.SelectedItem.ToString());
                this.Close();
            }
        }
    }
}
