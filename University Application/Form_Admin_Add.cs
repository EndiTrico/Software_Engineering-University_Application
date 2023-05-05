using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using University_Application;

namespace University_Application
{
    public partial class Form_Admin_Add : Form
    {
        Admin admin;
        int index;

        public Form_Admin_Add(int index, ref Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.index = index;

            //fixing the display for different user choice
            if (index == 1)
            {
                lblWelcome.Text = "Add Professor";
                label6.Hide();
                comboBox1.Hide();
                lblFirstName.Text = "First Name:";
                lblLast_Name.Text = "Last Name:";
                lbl3.Text = "Username:";
                lbl4.Text = "Password:";
            }
            if (index == 2)
            {
                lblWelcome.Text = "Add Student";
                lblFirstName.Text = "First Name:";
                lblLast_Name.Text = "Last Name:";
                lbl3.Text = "Username:";
                lbl4.Text = "Password:";
                label6.Text = "Major:";
                comboBox1.Text = "Select a Major";

            }
            if (index == 3)
            {
                lblWelcome.Text = "Add Course";
                lblFirstName.Text = "Course Name:";
                lblLast_Name.Text = "Credits:";
                lbl3.Text = "Hours:";
                lbl4.Hide();
                label6.Text = "Professor:";
                textBox4.Hide();
                comboBox1.Items.Clear();
                comboBox1.Text = "Select a Professor";
                for (int i = 0; i < admin.professorList.Count; i++)
                {
                    comboBox1.Items.Add(admin.professorList.ElementAt(i).Username);
                }
            }
        }

        public void addProfessor()
        {
            Professor professor = new Professor(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            admin.addProfessor(professor);
        }
        public void addStudent()
        {
            Student student = new Student(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, comboBox1.SelectedItem.ToString());
            admin.addStudent(student);
        }
        public void addCourse()
        {
            Courses course = new Courses(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            admin.addCourse(course, comboBox1.SelectedItem.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (index == 1)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                    MessageBox.Show("Enter All Data!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    this.addProfessor();
                    MessageBox.Show("Professor Added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Form_Admin admin = new Form_Admin();
                    this.Close();
                    admin.Show();
                }
            }
            if (index == 2)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.SelectedItem == null)
                    MessageBox.Show("Enter All Data!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    this.addStudent();
                    MessageBox.Show("Student Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Form_Admin admin = new Form_Admin();
                    this.Close();
                    admin.Show();
                }
            }
            if (index == 3)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.SelectedItem == null)
                    MessageBox.Show("Enter All Data!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    this.addCourse();
                    MessageBox.Show("Course Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Form_Admin admin = new Form_Admin();
                    this.Close();
                    admin.Show();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form_Admin admin = new Form_Admin();
            this.Hide();
            admin.Show();
        }
    }
}
