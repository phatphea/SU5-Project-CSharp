using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purchasing_Management_System.Common
{
    internal class ClsCommon
    {
        //validate text box username

        //1st method by normal function
        public Boolean isEmpty(TextBox t)
        {
            //check if empty
            if (t.Text == "")
            {
                t.BackColor = Color.Red;
                MessageBox.Show("This box cannot empty!");
                t.BackColor = Color.White;
                t.Focus();
                return true;
            }
            return false;
        }

        //2nd method by array and link with 1st method
        public Boolean isEmpty(params TextBox[] txts)
        {
            foreach (TextBox t in txts)
            {
                if (isEmpty(t) == true)
                {
                    return true;
                }
            }
            return false;
        }

        public Boolean isMatch(TextBox t1, TextBox t2)
        {
            if (t1.Text != t2.Text)
            {
                t2.BackColor = Color.Red;
                MessageBox.Show("This box is not match!");
                t2.BackColor = Color.White;
                t2.Focus();
                return false;
            }
            return true;
        }
        public Boolean isEmptyOneField(TextBox t)
        {
            //check if empty
            if (t.Text == "")
            {
                t.BackColor = Color.Red;
                MessageBox.Show("This box cannot empty!");
                t.BackColor = Color.White;
                t.Focus();
                return true;
            }
            return false;
        }

        public Boolean checkTaskUnsaved(String val)
        {
            if (Program.controlButton != null)
            {
                val = Array.Find(Program.controlButton, element => element == val);
                return true;
            }
            return false;
            
        }

    }
}
