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
    public partial class Form_Student_Drop : Form
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


        public Form_Student_Drop()
        {
            InitializeComponent();
            Student stud = new Student();

            foreach (string s in stud.showStudentCourses())
            {
                comboBoxChooseCourse.Items.Add(s);
            }

        }

        public Form_Student_Drop(int studentID, string name, string surname, string username, string password, string major, List<string> courses)
        {
            InitializeComponent();
            this.StudentID = studentID;
            this.Name = name;
            this.Surname = surname;
            this.Username = username;
            this.Password = password;
            this.Major = major;
            this.Courses = courses;

            foreach (string s in new Student(studentID, name, surname, username, password, major, courses).showStudentCourses())
            {
                comboBoxChooseCourse.Items.Add(s);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form_Student student = new Form_Student(studentID, name, surname, username, password, major, courses);
            this.Hide();
            student.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDrop_Click(object sender, EventArgs e)
        {

            if (comboBoxChooseCourse.SelectedIndex == -1)
            {
                MessageBox.Show("You Need to Select a Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("The Course is Dropped Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                new Student(studentID, name, surname, username, password, major).drop(comboBoxChooseCourse.Text, StudentID);
                Form_Student form_Student = new Form_Student(username, password);
                this.Close();
                form_Student.Show();
            }
        }

        private void Form_Student_Drop_Load(object sender, EventArgs e)
        {

        }
    }
}