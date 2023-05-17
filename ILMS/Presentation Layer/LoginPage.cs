using ILMS.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ILMS.Presentation_Layer
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked == true)
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void regLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentUserReg userReg = new StudentUserReg();
            userReg.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (studentIdTextBox.Text == "")
            {
                MessageBox.Show("Student ID cannot be empty");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
            else
            {
                UserDataAccess userDataAccess = new UserDataAccess();
                int flag = userDataAccess.UserVerification(studentIdTextBox.Text, passwordTextBox.Text);
                if (flag == 0)
                {
                    MessageBox.Show("Incorrect ID or Password\nPlease try again with correct ID & Password","Error");
                }
                else if (flag == 1)
                {
                    //AdminDashboard adminDashboard = new AdminDashboard();
                    new AdminDashboard().Show();
                    //adminDashboard.Show();
                    this.Hide();
                }
                
            }
        }
    }
}
