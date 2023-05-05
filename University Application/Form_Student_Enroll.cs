using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using University_Application;

namespace University_Application
{
    public partial class Form_Student_Enroll : Form
    {
        private int studentID;
        private string name;
        private string surname;
        private string username;
        private string password;
        private string major;
        private List<string> courses;

        public int StudentID { get => studentID; set => studentID = value; }
        public new string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Major { get => major; set => major = value; }
        public List<string> Courses { get => courses; set => courses = value; }


        public Form_Student_Enroll()
        {
            InitializeComponent();

            foreach (string s in new Student().allCoursesExcludingStudentCourses())
            {
                comboBoxChooseCourse.Items.Add(s);
            }

        }

        public Form_Student_Enroll(int studentID, string name, string surname, string username, string password, string major, List<string> courses)
        {
            InitializeComponent();
            this.StudentID = studentID;
            this.Name = name;
            this.Surname = surname;
            this.Username = username;
            this.Password = password;
            this.Major = major;
            this.Courses = courses;

            foreach (string s in new Student(studentID, name, surname, username, password, major, courses).allCoursesExcludingStudentCourses())
            {
                comboBoxChooseCourse.Items.Add(s);
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form_Student student = new Form_Student(studentID, name, surname, username, password, major, courses);
            this.Hide();
            student.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (comboBoxChooseCourse.SelectedIndex == -1)
            {
                MessageBox.Show("You need to select a course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                new Student(studentID, name, surname, username, password, major).enroll(comboBoxChooseCourse.Text, StudentID);
                MessageBox.Show("The course is added successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form_Student student = new Form_Student(username, password);
                this.Hide();
                student.Show();
            }
        }

        
        private void Form_Student_Enroll_Load(object sender, EventArgs e)
        {

        }

    }

}