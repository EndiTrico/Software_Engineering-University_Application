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

        private void checkedListBox_Admin_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choiceIndex = checkedListBox_Admin.SelectedIndex;
            int count = checkedListBox_Admin.Items.Count;

            for (var i = 0; i < count; i++)
            {
                if (choiceIndex != i)
                    checkedListBox_Admin.SetItemChecked(i, false);
            }
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            if (checkedListBox_Admin.SelectedItem.Equals("Add professor"))
            {
                Form_Admin2 child1 = new Form_Admin2(1, ref admin);
                //child1.MdiParent = this;

                child1.Show();
            }
            if (checkedListBox_Admin.SelectedItem.Equals("Add student"))
            {
                Form_Admin2 child1 = new Form_Admin2(2, ref admin);
                //child1.MdiParent = this;


                child1.Show();
            }
            if (checkedListBox_Admin.SelectedItem.Equals("Add course"))
            {
                Form_Admin2 child1 = new Form_Admin2(3, ref admin);
                //child1.MdiParent = this;

                child1.Show();
            }
            if (checkedListBox_Admin.SelectedItem.Equals("Remove professor"))
            {
                Form_Admin3 child1 = new Form_Admin3(4, ref admin);
                //child1.MdiParent = this;

                child1.Show();
            }
            if (checkedListBox_Admin.SelectedItem.Equals("Remove student"))
            {
                Form_Admin3 child1 = new Form_Admin3(5, ref admin);
                //child1.MdiParent = this;

                child1.Show();
            }
            if (checkedListBox_Admin.SelectedItem.Equals("Remove course"))
            {
                Form_Admin3 child1 = new Form_Admin3(6, ref admin);
                //child1.MdiParent = this;

                child1.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_Admin_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Back_Click_1(object sender, EventArgs e)
        {
            Form_Login login = new Form_Login();
            this.Close();
            login.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void button_Back_Click(object sender, EventArgs e)
        {
            Form_Role role = new Form_Role();
            this.Hide();
            role.Show();
        }
    }
}