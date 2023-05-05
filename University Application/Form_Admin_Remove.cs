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
    public partial class Form_Admin_Remove : Form
    {
        int index;
        Admin admin;
        public Form_Admin_Remove(int index, ref Admin admin)
        {
            InitializeComponent();
            this.index = index;
            this.admin = admin;

            if (index == 4)
            {
                this.lblRemove.Text = "Remove Professor";
                comboBoxRemove.Text = "Select a Professor to Remove";
                for (int i = 0; i < admin.professorList.Count; i++)
                {
                    comboBoxRemove.Items.Add(admin.professorList.ElementAt(i).Name + " " + admin.professorList.ElementAt(i).Surname);
                }
            }

            if (index == 5)
            {
                this.lblRemove.Text = "Remove Student";
                comboBoxRemove.Text = "Select a Professor to Remove";
                for (int i = 0; i < admin.studentList.Count; i++)
                {
                    comboBoxRemove.Items.Add(admin.studentList.ElementAt(i).Name + " " + admin.studentList.ElementAt(i).Surname);
                }
            }

            if (index == 6)
            {
                this.lblRemove.Text = "Remove Course";
                comboBoxRemove.Text = "Select a Professor to Remove";
                for (int i = 0; i < admin.coursesList.Count; i++)
                {
                    comboBoxRemove.Items.Add(admin.coursesList.ElementAt(i).CourseName);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (index == 4)
            {
                if (comboBoxRemove.SelectedItem == null)
                {
                    MessageBox.Show("Select a Professor!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    admin.removeProfessor(admin.professorList.ElementAt(comboBoxRemove.SelectedIndex));
                    MessageBox.Show("Professor Removed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Form_Admin admin_Form = new Form_Admin();
                    this.Close();
                    admin_Form.Show();
                }
            }
            if (index == 5)
            {
                if (comboBoxRemove.SelectedItem == null)
                {
                    MessageBox.Show("Select a Student!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    admin.removeStudent(admin.studentList.ElementAt(comboBoxRemove.SelectedIndex));
                    MessageBox.Show("Student Removed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Form_Admin admin_Form = new Form_Admin();
                    this.Close();
                    admin_Form.Show();
                }
            }
            if (index == 6)
            {
                if (comboBoxRemove.SelectedItem == null)
                {
                    MessageBox.Show("Select a Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    admin.removeCourse(admin.coursesList.ElementAt(comboBoxRemove.SelectedIndex));
                    MessageBox.Show("Course Removed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Form_Admin admin_Form = new Form_Admin();
                    this.Close();
                    admin_Form.Show();
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
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