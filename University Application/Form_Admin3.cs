using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using University_Application;

namespace University_Application
{
    public partial class Form_Admin3 : Form
    {
        int index;
        Admin admin;
        public Form_Admin3(int index, ref Admin admin)
        {
            InitializeComponent();
            this.index = index;
            this.admin = admin;

            if (index == 4)
            {
                this.label1.Text = "Select professor to remove: ";
                for (int i = 0; i < admin.professorList.Count; i++)
                {
                    comboBox1.Items.Add(admin.professorList.ElementAt(i).Name + " " + admin.professorList.ElementAt(i).Surname);
                }
            }

            if (index == 5)
            {
                this.label1.Text = "Select student to remove: ";
                for (int i = 0; i < admin.studentList.Count; i++)
                {
                    comboBox1.Items.Add(admin.studentList.ElementAt(i).Name + " " + admin.studentList.ElementAt(i).Surname);
                }
            }

            if (index == 6)
            {
                this.label1.Text = "Select course to remove: ";
                for (int i = 0; i < admin.coursesList.Count; i++)
                {
                    comboBox1.Items.Add(admin.coursesList.ElementAt(i).CourseName);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index == 4)
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Select a professor!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    admin.removeProfessor(admin.professorList.ElementAt(comboBox1.SelectedIndex));
                    MessageBox.Show("Professor removed successfully!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
            if (index == 5)
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Select a Student!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    admin.removeStudent(admin.studentList.ElementAt(comboBox1.SelectedIndex));
                    MessageBox.Show("Student removed successfully!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
            if (index == 6)
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Select a Course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    admin.removeCourse(admin.coursesList.ElementAt(comboBox1.SelectedIndex));
                    MessageBox.Show("Course removed successfully!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}