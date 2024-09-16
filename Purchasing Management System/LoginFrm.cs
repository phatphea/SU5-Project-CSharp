using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purchasing_Management_System
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }
        private void LoginFrm_Load(object sender, EventArgs e)
        {
            //dissable username text box when user logout
            if (Program.userLogin.Length > 0)
            {
                txtUser.Enabled = false;
            }
            //read username form database and display in username text box
            if (System.IO.File.Exists("usr.txt"))
            {
                string usr = System.IO.File.ReadAllText("usr.txt");
                txtUser.Text = usr;
                txtPw.SelectAll();
                txtPw.Focus();
            }
        }

        OleDbCommand cmd = new OleDbCommand("", Program.con);

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            //query to find username whether exist in database or not
            cmd.CommandText = "select count(*) from [USER] where UserName='"+txtUser.Text+ "' and UserPassword='"+txtPw.Text+"' ";
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                //go to select Deactivated column
                // if No => go to system
                // else yes => message box (This user deactivated)
                cmd.CommandText = "select Is_Deactivated from [USER] where UserName='" + txtUser.Text + "' and UserPassword='" + txtPw.Text + "' ";
                string deac = Convert.ToString(cmd.ExecuteScalar());
                if (deac == "No")
                {
                    Program.userLogin = txtUser.Text;
                    System.IO.File.WriteAllText("usr.txt", txtUser.Text); //write username input to file .txt
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This user is deactivated", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void btbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkShowpass_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPw.UseSystemPasswordChar = !chkShowpass.Checked;
        }

        
    }
}
