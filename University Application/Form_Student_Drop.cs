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

        public Form_Student_Drop()
        {
            InitializeComponent();
            Student stud = new Student();

            foreach (string s in stud.showStudentCourses())
            {
                comboBox1.Items.Add(s);
            }

        }

        public Form_Student_Drop(string name, string surname, string username, string password, string studentID, string major, List<string> courses)
        {
            InitializeComponent();
            this.Name = name;
            this.Surname = surname;
            this.Username = username;
            this.Password = password;
            this.StudentID = studentID;
            this.Major = major;
            this.Courses = courses;

            foreach (string s in new Student(name, surname, username, password, studentID, major, courses).showStudentCourses())
            {
                comboBox1.Items.Add(s);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Form_Student student = new Form_Student(name, surname, username, password, studentID, major, courses);
            this.Hide();
            student.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stud = new Student();

            if (comboBox1.SelectedIndex == -1)
            {

                MessageBox.Show("You need to select a course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("The course is dropped successfully.", "Done ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Student(name, surname, username, password, studentID, major, courses).drop(comboBox1.Text, StudentID);
                Form_Student student = new Form_Student(username, password);
                this.Hide();
                student.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.WhiteSmoke,
                                                                       Color.WhiteSmoke,
                                                                       135F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void Form_Student_Drop_Load(object sender, EventArgs e)
        {

        }
    }
}