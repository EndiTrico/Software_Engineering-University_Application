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

        private void checkBox_Show_Hide_ChangedChecked(Object sender, EventArgs e)
        {


        }


        private void button_Continue_Click(object sender, EventArgs e)
        {
            if (textBox_Pass.TextLength == 0 || textBox_Username.TextLength == 0)
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

                        if (admin.isUsernameAndPasswordValid(textBox_Username.Text, textBox_Pass.Text))
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
                        Professor prof = new Professor(textBox_Username.Text, textBox_Pass.Text);
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
                        Student student = new Student(textBox_Username.Text, textBox_Pass.Text);

                        Form_Student formStud = new Form_Student(textBox_Username.Text, textBox_Pass.Text);
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


        private void comboBox_Role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_Login_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox_Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox_Show_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_Show.Checked)
                textBox_Pass.UseSystemPasswordChar = false;
            else
                textBox_Pass.UseSystemPasswordChar = true;
        }

        private void textBox_Pass_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Form_Role role = new Form_Role();
            this.Hide();
            role.Show();
        }

        private void label_Role_Click(object sender, EventArgs e)
        {

        }

        private void label_Role_Name()
        {
            if (number == 0)
            {
                label_Role.Text = "Admin";
            }
            else if (number == 1)
            {
                label_Role.Text = "Professor";

            }
            else if (number == 2)
            {
                label_Role.Text = "Student";

            }
            else
                label_Role.Text = "Error";


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}