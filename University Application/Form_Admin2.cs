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
    public partial class Form_Admin2 : Form
    {
        Admin admin;
        int index;

        public Form_Admin2(int index, ref Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.index = index;

            //fixing the display for different user choice
            if (index == 1)
            {
                label6.Hide();
                comboBox1.Hide();
                label1.Text = "First Name: ";
                label2.Text = "Last Name: ";
                label3.Text = "Username: ";
                label4.Text = "Password: ";
            }
            if (index == 2)
            {
                label1.Text = "Name: ";
                label2.Text = "Surname: ";
                label3.Text = "Username: ";
                label4.Text = "Password: ";

                label6.Text = "Major: ";
            }
            if (index == 3)
            {
                label1.Text = "Course Name: ";
                label2.Text = "Credits: ";
                label3.Text = "Hours: ";
                label4.Hide();

                label6.Text = "Professor: ";
                textBox4.Hide();
                comboBox1.Items.Clear();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (index == 1)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                    MessageBox.Show("Input all data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    this.addProfessor();
                    MessageBox.Show("Professor added successfully!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
            if (index == 2)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.SelectedItem == null)
                    MessageBox.Show("Input all data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    this.addStudent();
                    MessageBox.Show("Student added successfully!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
            if (index == 3)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.SelectedItem == null)
                    MessageBox.Show("Input all data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    this.addCourse();
                    MessageBox.Show("Course added successfully!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Admin2_Load(object sender, EventArgs e)
        {

        }
    }
}
