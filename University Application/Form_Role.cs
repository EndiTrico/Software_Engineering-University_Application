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

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (comboBoxRole.SelectedIndex == -1)
            {
                MessageBox.Show("You have not selected a role!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Form_Login formLog = new Form_Login(comboBoxRole.SelectedIndex);
                this.Hide();
                formLog.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}