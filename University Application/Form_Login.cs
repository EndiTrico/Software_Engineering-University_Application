using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University_Application;

namespace University_Application
{
    public partial class Form_Login : Form
    {
        int number;
        public Form_Login(int number)
        {
            this.number = number;
            InitializeComponent();
            this.label_Role_Name();
        }

        public Form_Login()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtBoxPassword.TextLength == 0 || txtBoxUsername.TextLength == 0)
            {
                MessageBox.Show("You did not enter the required credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                if (number == 0)
                {
                    try
                    {
                        Admin admin = new Admin();

                        if (admin.isUsernameAndPasswordValid(txtBoxUsername.Text, txtBoxPassword.Text))
                        {
                            Form_Admin formAdmin = new Form_Admin();
                            this.Hide();
                            formAdmin.Show();
                        }
                    }
                    catch (InvalidLoginInfoException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (number == 1)
                {
                    try
                    {
                        Professor prof = new Professor(txtBoxUsername.Text, txtBoxPassword.Text);
                        Professor.LoggedProfessors.Add(prof);
                        Form_Professor formProf = new Form_Professor();
                        this.Hide();
                        formProf.Show();
                    }
                    catch (InvalidLoginInfoException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (number == 2)
                {
                    try
                    {
                        Student student = new Student(txtBoxUsername.Text, txtBoxPassword.Text);

                        Form_Student formStud = new Form_Student(txtBoxUsername.Text, txtBoxPassword.Text);
                        this.Hide();
                        formStud.Show();
                    }
                    catch (InvalidLoginInfoException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                    MessageBox.Show("Something is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
                txtBoxPassword.UseSystemPasswordChar = false;
            else
                txtBoxPassword.UseSystemPasswordChar = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form_Role role = new Form_Role();
            this.Hide();
            role.Show();
        }

        private void label_Role_Name()
        {
            if (number == 0)
            {
                lblRole.Text = "Log In as Admin";
            }
            else if (number == 1)
            {
                lblRole.Text = "Log In as Professor";

            }
            else if (number == 2)
            {
                lblRole.Text = "Log In as Student";

            }
            else
                lblRole.Text = "Error";


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}