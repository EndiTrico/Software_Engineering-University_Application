using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using University_Application;

namespace University_Application
{
    public partial class Form_Role : Form
    {
        public Form_Role()
        {
            InitializeComponent();
        }

        public int checkBox_Index()
        {
            if (comboBox1.SelectedIndex == 1)
                return 1;
            else if (comboBox1.SelectedIndex == 2)
                return 2;
            else if (comboBox1.SelectedIndex == 3)
                return 3;
            else
                return 0;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Login_Click(object sender, EventArgs e)
        {

        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.WhiteSmoke,
                                                                       Color.WhiteSmoke,
                                                                       90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("You have not selected a role!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Form_Login formLog = new Form_Login(comboBox1.SelectedIndex);
                this.Hide();
                formLog.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}