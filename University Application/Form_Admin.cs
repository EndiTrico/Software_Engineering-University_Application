using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University_Application;

namespace University_Application
{
    public partial class Form_Admin : Form
    {
        Admin admin;
        public Form_Admin()
        {
            InitializeComponent();
            admin = new Admin();
        }

        private void Form_Admin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form_Role role = new Form_Role();
            this.Hide();
            role.Show();
        }

        private void btnAddProfessor_Click(object sender, EventArgs e)
        {
            Form_Admin_Add child1 = new Form_Admin_Add(1, ref admin);
            //child1.MdiParent = this;

            child1.Show();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Form_Admin_Add child1 = new Form_Admin_Add(2, ref admin);
            //child1.MdiParent = this;

            child1.Show();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            Form_Admin_Add child1 = new Form_Admin_Add(3, ref admin);
            //child1.MdiParent = this;

            child1.Show();
        }

        private void btnRemoveProfessor_Click(object sender, EventArgs e)
        {
            Form_Admin_Remove child1 = new Form_Admin_Remove(4, ref admin);
            //child1.MdiParent = this;
            
            child1.Show();           
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            Form_Admin_Remove child1 = new Form_Admin_Remove(5, ref admin);
            //child1.MdiParent = this;

            child1.Show();
        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            Form_Admin_Remove child1 = new Form_Admin_Remove(6, ref admin);
            //child1.MdiParent = this;

            child1.Show();
        }
    }
}