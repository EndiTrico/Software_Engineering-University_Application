
namespace University_Application
{
    partial class Form_Role
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Role));
            this.lblSelectRole = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblEmpire = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectRole
            // 
            this.lblSelectRole.AutoSize = true;
            this.lblSelectRole.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectRole.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.lblSelectRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.lblSelectRole.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSelectRole.Location = new System.Drawing.Point(12, 129);
            this.lblSelectRole.Name = "lblSelectRole";
            this.lblSelectRole.Size = new System.Drawing.Size(131, 24);
            this.lblSelectRole.TabIndex = 7;
            this.lblSelectRole.Text = "Select a Role: ";
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.btnContinue.ForeColor = System.Drawing.Color.Snow;
            this.btnContinue.Location = new System.Drawing.Point(317, 160);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(160, 38);
            this.btnContinue.TabIndex = 8;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.BackColor = System.Drawing.Color.Snow;
            this.comboBoxRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRole.Font = new System.Drawing.Font("Corbel", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Admin",
            "Professor",
            "Student"});
            this.comboBoxRole.Location = new System.Drawing.Point(149, 127);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(133, 26);
            this.comboBoxRole.TabIndex = 3;
            this.comboBoxRole.Text = "Choose a Role";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Corbel", 24.75F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.Snow;
            this.lblWelcome.Location = new System.Drawing.Point(7, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(280, 40);
            this.lblWelcome.TabIndex = 10;
            this.lblWelcome.Text = "Welcome to SUNY";
            // 
            // lblEmpire
            // 
            this.lblEmpire.AutoSize = true;
            this.lblEmpire.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpire.Font = new System.Drawing.Font("Corbel", 24.75F, System.Drawing.FontStyle.Bold);
            this.lblEmpire.ForeColor = System.Drawing.Color.Snow;
            this.lblEmpire.Location = new System.Drawing.Point(7, 49);
            this.lblEmpire.Name = "lblEmpire";
            this.lblEmpire.Size = new System.Drawing.Size(315, 40);
            this.lblEmpire.TabIndex = 11;
            this.lblEmpire.Text = "Empire State College";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblEmpire);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 93);
            this.panel1.TabIndex = 12;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.Snow;
            this.btnExit.Location = new System.Drawing.Point(477, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(317, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(160, 113);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 9;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Form_Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(516, 226);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblSelectRole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(276, 91);
            this.Name = "Form_Role";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Select_Role";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSelectRole;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblEmpire;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
    }
}