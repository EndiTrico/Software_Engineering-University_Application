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
    public partial class Form_Professor : Form
    {
        public Form_Professor()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Professor.LoggedProfessors.RemoveAt(Professor.LoggedProfessors.Count - 1);
            this.Close();
        }

        private void buttonLowestScore_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (comboBox_Course.SelectedIndex != -1)
            {
                List<int> scores = Professor.getRecentProfessor().getScores();
                List<Student> students = Professor.getRecentProfessor().getStudents();

                if (scores.Count == 0)
                {
                    MessageBox.Show("There Are No Grades in the System for This Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (students.Count == 0)
                {
                    MessageBox.Show("There Are No Students for This Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                richTextBox1.Text = $"The student with the lowest score is {Professor.getRecentProfessor().showLowestScoringStudent()}.\nThey have a score of {Professor.getRecentProfessor().showMinGrade()}.";
            }
            else
                MessageBox.Show("You Have Not Selected a Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button_HighestScore_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (comboBox_Course.SelectedIndex != -1)
            {

                List<int> scores = Professor.getRecentProfessor().getScores();
                List<Student> students = Professor.getRecentProfessor().getStudents();

                if (scores.Count == 0)
                {
                    MessageBox.Show("There Are No Grades in the System for This Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (students.Count == 0)
                {
                    MessageBox.Show("There Are No Students for This Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                richTextBox1.Text = $"The student with the highest score is {Professor.getRecentProfessor().showHighestScoringStudent()}.\nThey have a score of {Professor.getRecentProfessor().showMaxGrade()}.";
            }
            else
                MessageBox.Show("Select a Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Form_Role role = new Form_Role();
            this.Hide();
            role.Show();
        }

        private void comboBox_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            Professor.getRecentProfessor().ActiveCourse = (string)comboBox_Course.SelectedItem;
            Professor.getRecentProfessor().setActiveCourseId();
        }


        private void button_Grades_Click(object sender, EventArgs e)
        {
            if (comboBox_Course.SelectedIndex != -1)
            {
                Form_Professor_AddGrades form = new Form_Professor_AddGrades();
                this.Hide();
                form.Show();
            }
            else
                MessageBox.Show("Select a Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_Students_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (comboBox_Course.SelectedIndex != -1)
            {
                List<Student> students = Professor.getRecentProfessor().getStudents();

                if (students.Count == 0)
                {
                    MessageBox.Show("There Are No Students Enrolled for This Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (Student student in students)
                    richTextBox1.AppendText(student.Name + " " + student.Surname + "\n");
            }
            else
                MessageBox.Show("Select a Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Form_Professor_Load(object sender, EventArgs e)
        {
            label2.Text = $"{Professor.getRecentProfessor().Name}!";

            foreach (string course in Professor.getRecentProfessor().Courses)
                comboBox_Course.Items.Add(course);
        }

        private void button_Average_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (comboBox_Course.SelectedIndex != -1)
            {
                List<int> scores = Professor.getRecentProfessor().getScores();
                List<Student> students = Professor.getRecentProfessor().getStudents();

                if (scores.Count == 0)
                {
                    MessageBox.Show("There Are No Grades in the System for This Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (students.Count == 0)
                {
                    MessageBox.Show("There Are No Students for This Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                richTextBox1.AppendText($"The course score average is {Professor.getRecentProfessor().showAverage():F1}.");

            }
            else
                MessageBox.Show("You Have Not Selected a Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_PassingStudents_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (comboBox_Course.SelectedIndex != -1)
            {
                List<Student> students = Professor.getRecentProfessor().showPassingStudents();

                if (students.Count == 0)
                {
                    MessageBox.Show("There Are No Passing Students for This Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (Student student in students)
                    richTextBox1.AppendText(student.Name + " " + student.Surname + "\n");
            }
            else
                MessageBox.Show("You Have Not Selected a Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_FailingStudents_Click(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (comboBox_Course.SelectedIndex != -1)
            {
                List<Student> students = Professor.getRecentProfessor().showFailingStudents();

                if (students.Count == 0)
                {
                    MessageBox.Show("There Are No Failing Students for This Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (Student student in students)
                    richTextBox1.AppendText(student.Name + " " + student.Surname + "\n");
            }
            else
                MessageBox.Show("Select a Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}