﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University_Application;

namespace University_Application
{
    public partial class Form_Student : Form
    {
        private string name;
        private string surname;
        private string username;
        private string password;
        private string studentID;
        private string major;
        private List<string> courses;

        public new string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string StudentID { get => studentID; set => studentID = value; }
        public string Major { get => major; set => major = value; }
        public List<string> Courses { get => courses; set => courses = value; }

        public Form_Student()
        {
            InitializeComponent();
        }

        public Form_Student(string username, string password)
        {
            InitializeComponent();

            Student stud = new Student(username, password);
            this.Name = stud.Name;
            this.Surname = stud.Surname;
            this.Username = stud.Username;
            this.Password = stud.Password;
            this.StudentID = stud.StudentID;
            this.Major = stud.Major;
            this.Courses = stud.Courses;
            label1.Text = Name + " " + Surname;

        }

        public Form_Student(string name, string surname, string username, string password, string studentID, string major, List<string> courses)
        {
            InitializeComponent();
            this.Name = name;
            this.Surname = surname;
            this.Username = username;
            this.Password = password;
            this.StudentID = studentID;
            this.Major = major;
            this.Courses = courses;
            label1.Text = Name + " " + Surname;
        }

        private void Form_Student_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Student_Enroll form = new Form_Student_Enroll(name, surname, username, password, studentID, major, courses);
            this.Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Student_Drop form = new Form_Student_Drop(name, surname, username, password, studentID, major, courses);
            this.Hide();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Form_Role role = new Form_Role();
            this.Hide();
            role.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            List<string> myCourses = new Student(name, surname, username, password, studentID, major, courses).showStudentCourses();

            if (myCourses.Count != 0)
            {
                richTextBox1.AppendText("The Courses That I Am Taking Are: " + Environment.NewLine);

                foreach (string courses in myCourses)
                {
                    richTextBox1.AppendText(courses + Environment.NewLine);
                }
            }
            else
                MessageBox.Show("You are not registered in any course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            List<string> grades = new Student(name, surname, username, password, studentID, major, courses).showGrades();

            if (grades.Count != 0)
            {
                richTextBox1.AppendText("The Grades of My Courses Are: " + Environment.NewLine);

                foreach (string grade in grades)
                {
                    richTextBox1.AppendText(grade + Environment.NewLine);
                }
            }
            else
                MessageBox.Show("You do not have any grade in the system!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            List<string> allCourses = new Student(name, surname, username, password, studentID, major, courses).showAllCourses();

            if (allCourses.Count != 0)
            {
                richTextBox1.AppendText("The Courses in the University Are: " + Environment.NewLine);

                foreach (string course in allCourses)
                {
                    richTextBox1.AppendText(course + Environment.NewLine);
                }
            }
            else
                MessageBox.Show("The university does not have any course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            List<string> allCourses = new Student(name, surname, username, password, studentID, major, courses).showAllCredits();

            if (allCourses.Count != 0)
            {
                richTextBox1.AppendText("Credits of All the Courses are: " + Environment.NewLine);

                foreach (string course in allCourses)
                {
                    richTextBox1.AppendText(course + Environment.NewLine);
                }
            }
            else
                MessageBox.Show("The university does not have any course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            List<string> myCoursesCredits = new Student(name, surname, username, password, studentID, major, courses).showStudentCredits();

            if (myCoursesCredits.Count != 0)
            {
                richTextBox1.AppendText("Credits of My Courses are: " + Environment.NewLine);

                foreach (string credit in myCoursesCredits)
                {
                    richTextBox1.AppendText(credit + Environment.NewLine);
                }
            }
            else
                MessageBox.Show("The student is not enrolled in any course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();


            if (new Student(name, surname, username, password, studentID, major, courses).showGPA().Equals("No GPA"))
            {
                MessageBox.Show("There is not any grade to calculate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                richTextBox1.AppendText(new Student(name, surname, username, password, studentID, major, courses).showGPA() + Environment.NewLine);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}