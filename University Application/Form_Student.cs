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
using University_Application;

namespace University_Application
{
    public partial class Form_Student : Form
    {
        private string name;
        private string surname;
        private string username;
        private string password;
        private int studentID;
        private string major;
        private List<string> courses;

        public new string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int StudentID { get => studentID; set => studentID = value; }
        public string Major { get => major; set => major = value; }
        public List<string> Courses { get => courses; set => courses = value; }

        public Form_Student()
        {
            InitializeComponent();
        }

        public Form_Student(string username, string password)
        {
            InitializeComponent();

            Student student = new Student(username, password);
            this.Name = student.Name;
            this.Surname = student.Surname;
            this.Username = student.Username;
            this.Password = student.Password;
            this.StudentID = student.Id;
            this.Major = student.Major;
            this.Courses = student.Courses;
            lblMyName.Text = "Welcome " + Name + " " + Surname;

        }

        public Form_Student(int studentID, string name, string surname, string username, string password, string major, List<string> courses)
        {
            InitializeComponent();
            this.Name = name;
            this.Surname = surname;
            this.Username = username;
            this.Password = password;
            this.StudentID = studentID;
            this.Major = major;
            this.Courses = courses;
            lblMyName.Text = "Welcome " + Name + " " + Surname;
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            Form_Student_Enroll form = new Form_Student_Enroll(studentID, name, surname, username, password, major, courses);
            this.Hide();
            form.Show();
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            Form_Student_Drop form = new Form_Student_Drop(studentID, name, surname, username, password, major, courses);
            this.Hide();
            form.Show();
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

        private void btnShowMyCourses_Click(object sender, EventArgs e)
        {
            richTxtBoxResult.Clear();
            List<string> myCourses = new Student(studentID, name, surname, username, password, major, courses).showStudentCourses();

            if (myCourses.Count != 0)
            {
                richTxtBoxResult.AppendText("The Courses That I Am Taking Are: " + Environment.NewLine);

                foreach (string courses in myCourses)
                {
                    richTxtBoxResult.AppendText(courses + Environment.NewLine);
                }
            }
            else
                MessageBox.Show("You Are Not Registered in any Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnShowMyGrades_Click(object sender, EventArgs e)
        {
            richTxtBoxResult.Clear();
            List<string> grades = new Student(studentID, name, surname, username, password, major, courses).showGrades();

            if (grades.Count != 0)
            {
                richTxtBoxResult.AppendText("The Grades of My Courses Are: " + Environment.NewLine);

                foreach (string grade in grades)
                {
                    richTxtBoxResult.AppendText(grade + Environment.NewLine);
                }
            }
            else
                MessageBox.Show("You Do Not Have any Grade in the System!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnShowAllCourses_Click(object sender, EventArgs e)
        {
            richTxtBoxResult.Clear();

            List<string> allCourses = new Student(studentID, name, surname, username, password, major, courses).showAllCourses();

            if (allCourses.Count != 0)
            {
                richTxtBoxResult.AppendText("The Courses in the University Are: " + Environment.NewLine);

                foreach (string course in allCourses)
                {
                    richTxtBoxResult.AppendText(course + Environment.NewLine);
                }
            }
            else
                MessageBox.Show("The University Does Not Have any Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnShowCreditsOfAllCourses_Click(object sender, EventArgs e)
        {
            richTxtBoxResult.Clear();

            List<string> allCourses = new Student(studentID, name, surname, username, password, major, courses).showAllCredits();

            if (allCourses.Count != 0)
            {
                richTxtBoxResult.AppendText("Credits of All the Courses are: " + Environment.NewLine);

                foreach (string course in allCourses)
                {
                    richTxtBoxResult.AppendText(course + Environment.NewLine);
                }
            }
            else
                MessageBox.Show("The University Does Not Have any Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnShowMyCredits_Click(object sender, EventArgs e)
        {
            richTxtBoxResult.Clear();

            List<string> myCoursesCredits = new Student(studentID, name, surname, username, password, major, courses).showStudentCredits();

            if (myCoursesCredits.Count != 0)
            {
                richTxtBoxResult.AppendText("Credits of My Courses are: " + Environment.NewLine);

                foreach (string credit in myCoursesCredits)
                {
                    richTxtBoxResult.AppendText(credit + Environment.NewLine);
                }
            }
            else
                MessageBox.Show("The Student Is Not Enrolled in any Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnShowMyGPA_Click(object sender, EventArgs e)
        {
            richTxtBoxResult.Clear();

            if (new Student(studentID, name, surname, username, password, major, courses).showGPA() == -1)
            {
                MessageBox.Show("There Is Not Any Grade to Calculate!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                richTxtBoxResult.AppendText("My GPA is: " + new Student(studentID, name, surname, username, password, major, courses).showGPA() + Environment.NewLine);
        }

        private void Form_Student_Load(object sender, EventArgs e)
        {

        }
    }
}