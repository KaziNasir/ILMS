using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ILMS.Data_Access_Layer;

namespace ILMS.Presentation_Layer
{
    public partial class StudentUserReg : Form
    {
        public StudentUserReg()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxTerms_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTerms.Checked)
            {
                buttonSubmit.Enabled = true;
            }
            else
            {
                buttonSubmit.Enabled = false;
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if (textBoxStudentID.Text == "")
            {
                MessageBox.Show("Student ID cannot be empty");
            }
            else if (textBoxEmail.Text == "")
            {
                MessageBox.Show("Email cannot be empty");
            }
            else if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
            else if (textBoxConfirmPassword.Text == "")
            {
                MessageBox.Show("Confirm Password cannot be empty");
            }
            else if (dateTimePickerDoB.Value.Date==System.DateTime.Now.Date)
            {
                MessageBox.Show("Enter valid date");
            }
            else if (radioButtonMale.Checked==false && radioButtonFemale.Checked==false)
            {
                MessageBox.Show("Select Gender");
            }
            else if (comboBoxBloodGroup.Text == "")
            {
                MessageBox.Show("Blood Group cannot be empty");
            }

            else
            {
                if (textBoxPassword.Text != textBoxConfirmPassword.Text)
                {
                    MessageBox.Show("Password does not Match");
                }
                else
                {
                    
                    User user = new User();
                    user.Name = textBoxName.Text;
                    user.StudentID = textBoxStudentID.Text;
                    user.Email = textBoxEmail.Text;
                    user.Password = textBoxPassword.Text;
                    user.DoB = dateTimePickerDoB.Text;
                    user.BloodGroup = comboBoxBloodGroup.Text;
                    if (radioButtonMale.Checked)
                    {
                        user.Gender = "Male";
                    }
                    else { user.Gender = "Female"; }
                    user.UserType = "student";

                    UserDataAccess userDataAccess = new UserDataAccess();
                    bool flag = userDataAccess.AddNewUser(user);
                    
                    if (flag == true)
                    {
                        MessageBox.Show("User added successfully");
                        LoginPage loginPage = new LoginPage();
                        loginPage.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Registration Failed");
                    }

                }
            }

        }
    }
}
