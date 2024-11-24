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

        // set for last clicked button
        public Button lastClickedButton = null;
        public void myBtnClickStyle(object sender, EventArgs e)
        {
            // Reset last clicked button
            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.Black;
            }

            // Set new clicked button
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                clickedButton.ForeColor = Color.Blue;
                lastClickedButton = clickedButton;
            }
        }
        //set color for btn while mouse hover
        public void button_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null && button != lastClickedButton)
            {
                button.ForeColor = Color.DodgerBlue; // Change to desired hover color
            }
        }

        //set color for btn while leave mouse hover
        public void button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null && button != lastClickedButton)
            {
                button.ForeColor = SystemColors.ControlText; // Reset to default color
            }
        }

        // Method to assign all event handlers of changing color to a button
        // This method combined between method myBtnClickStyle, button_MouseEnter, button_MouseLeave
        public void AssignHandlersButtonStyle(Button button)
        {
            button.Click += new EventHandler(myBtnClickStyle);
            button.MouseEnter += new EventHandler(button_MouseEnter);
            button.MouseLeave += new EventHandler(button_MouseLeave);
        }

        //method for display search result in new form and in listbox below textbox
        public void ShowFormBelowTextBox(TextBox txtSearchValue, Panel panelContainer, Form formToShow, Form mainForm)
        {
            // Check if the form is already added to the panel
            foreach (Control ctrl in panelContainer.Controls)
            {
                if (ctrl == formToShow)
                {
                    ctrl.BringToFront();
                    if (!formToShow.Visible)
                    {
                        formToShow.Show(); // Show the form if it was hidden
                    }
                    return;
                }
            }

            // Configure the form
            formToShow.TopLevel = false;
            formToShow.Location = new System.Drawing.Point(txtSearchValue.Left, txtSearchValue.Bottom);
            formToShow.Width = txtSearchValue.Width;
            formToShow.Height = panelContainer.Height - (txtSearchValue.Bottom + 20);

            // Handle panel resize to adjust form size
            panelContainer.SizeChanged += (s, args) =>
            {
                formToShow.Width = txtSearchValue.Width;
                formToShow.Height = panelContainer.Height - (txtSearchValue.Bottom + 20);
            };

            // Add the form to the panel
            panelContainer.Controls.Add(formToShow);
            formToShow.BringToFront();
            formToShow.Show();

            // Handle click outside to disable form
            AttachGlobalClickHandler(formToShow, mainForm);
        }

        //method for display search result in new form and in listbox above textbox
        public void ShowFormAboveTextBox(TextBox txtSearchValue, Panel panelContainer, Form formToShow, Form mainForm)
        {
            // Check if the form is already added to the panel
            foreach (Control ctrl in panelContainer.Controls)
            {
                if (ctrl == formToShow)
                {
                    ctrl.BringToFront();
                    if (!formToShow.Visible)
                    {
                        formToShow.Show(); // Show the form if it was hidden
                    }
                    return;
                }
            }

            // Configure the form
            formToShow.TopLevel = false;
            formToShow.Location = new System.Drawing.Point(txtSearchValue.Left, txtSearchValue.Top - formToShow.Height); // Adjust position to be above the TextBox
            formToShow.Width = txtSearchValue.Width;

            // Ensure the form's height doesn't exceed available space
            int availableHeight = txtSearchValue.Top - 10;
            if (availableHeight < formToShow.Height)
            {
                formToShow.Height = availableHeight;
            }

            // Handle panel resize to adjust form size
            panelContainer.SizeChanged += (s, args) =>
            {
                formToShow.Width = txtSearchValue.Width;
                int newAvailableHeight = txtSearchValue.Top - 10;
                if (newAvailableHeight < formToShow.Height)
                {
                    formToShow.Height = newAvailableHeight;
                }
                formToShow.Location = new System.Drawing.Point(txtSearchValue.Left, txtSearchValue.Top - formToShow.Height - 10);
            };

            // Add the form to the panel
            panelContainer.Controls.Add(formToShow);
            formToShow.BringToFront();
            formToShow.Show();

            // Handle click outside to disable form
            AttachGlobalClickHandler(formToShow, mainForm);
        }

        //method for click outsite the form of listbox to close the form
        //1st method
        private void AttachGlobalClickHandler(Form formToShow, Form mainForm)
        {
            // Attach event handler to the main form
            mainForm.Click += (s, e) => CheckClickOutside(formToShow, mainForm);
            AttachClickHandlerToAllControls(mainForm, formToShow);
        }

        //2nd method
        private void AttachClickHandlerToAllControls(Control parent, Form formToShow)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl != formToShow)
                {
                    ctrl.Click += (s, e) => CheckClickOutside(formToShow, parent);
                    if (ctrl.HasChildren)
                    {
                        AttachClickHandlerToAllControls(ctrl, formToShow);
                    }
                }
            }
        }

        //3rd method
        private void CheckClickOutside(Form formToShow, Control parent)
        {
            if (formToShow.Visible && !formToShow.Bounds.Contains(parent.PointToClient(Control.MousePosition)))
            {
                formToShow.Hide();
            }
        }

    }
}
