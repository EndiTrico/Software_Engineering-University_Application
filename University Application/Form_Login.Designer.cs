
namespace University_Application
{
    partial class Form_Login
    {
        /// <summary>
        ///  Required designer varia ble.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.button_Continue = new System.Windows.Forms.Button();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.CheckBox_Show = new System.Windows.Forms.CheckBox();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.button_Back = new System.Windows.Forms.Button();
            this.label_Role = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.BackColor = System.Drawing.Color.Transparent;
            this.label_Login.Font = new System.Drawing.Font("Corbel", 25F, System.Drawing.FontStyle.Bold);
            this.label_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(140)))));
            this.label_Login.Location = new System.Drawing.Point(57, 8);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(140, 41);
            this.label_Login.TabIndex = 0;
            this.label_Login.Text = "Login as";
            this.label_Login.Click += new System.EventHandler(this.label_Login_Click);
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.BackColor = System.Drawing.Color.Transparent;
            this.label_Username.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(140)))));
            this.label_Username.Location = new System.Drawing.Point(10, 66);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(101, 23);
            this.label_Username.TabIndex = 1;
            this.label_Username.Text = "Username:";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(140)))));
            this.label_Password.Location = new System.Drawing.Point(10, 102);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(96, 23);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Password:";
            // 
            // button_Continue
            // 
            this.button_Continue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(140)))));
            this.button_Continue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Continue.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.button_Continue.ForeColor = System.Drawing.Color.Snow;
            this.button_Continue.Location = new System.Drawing.Point(137, 142);
            this.button_Continue.Name = "button_Continue";
            this.button_Continue.Size = new System.Drawing.Size(114, 35);
            this.button_Continue.TabIndex = 6;
            this.button_Continue.Text = "LogIn";
            this.button_Continue.UseVisualStyleBackColor = false;
            this.button_Continue.Click += new System.EventHandler(this.button_Continue_Click);
            // 
            // textBox_Username
            // 
            this.textBox_Username.AllowDrop = true;
            this.textBox_Username.BackColor = System.Drawing.Color.White;
            this.textBox_Username.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.textBox_Username.Location = new System.Drawing.Point(99, 66);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(153, 23);
            this.textBox_Username.TabIndex = 10;
            // 
            // CheckBox_Show
            // 
            this.CheckBox_Show.AutoSize = true;
            this.CheckBox_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBox_Show.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.CheckBox_Show.Location = new System.Drawing.Point(256, 102);
            this.CheckBox_Show.Name = "CheckBox_Show";
            this.CheckBox_Show.Size = new System.Drawing.Size(61, 23);
            this.CheckBox_Show.TabIndex = 15;
            this.CheckBox_Show.Text = "Show";
            this.CheckBox_Show.UseVisualStyleBackColor = true;
            this.CheckBox_Show.CheckedChanged += new System.EventHandler(this.CheckBox_Show_CheckedChanged);
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.AllowDrop = true;
            this.textBox_Pass.BackColor = System.Drawing.Color.White;
            this.textBox_Pass.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.textBox_Pass.Location = new System.Drawing.Point(99, 102);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(153, 23);
            this.textBox_Pass.TabIndex = 16;
            this.textBox_Pass.UseSystemPasswordChar = true;
            // 
            // button_Back
            // 
            this.button_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Back.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_Back.FlatAppearance.BorderSize = 0;
            this.button_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Back.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.button_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(140)))));
            this.button_Back.Location = new System.Drawing.Point(0, -2);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(33, 32);
            this.button_Back.TabIndex = 20;
            this.button_Back.Text = "<";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // label_Role
            // 
            this.label_Role.AutoSize = true;
            this.label_Role.BackColor = System.Drawing.Color.Transparent;
            this.label_Role.Font = new System.Drawing.Font("Corbel", 24.75F, System.Drawing.FontStyle.Bold);
            this.label_Role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(140)))));
            this.label_Role.Location = new System.Drawing.Point(169, 8);
            this.label_Role.Name = "label_Role";
            this.label_Role.Size = new System.Drawing.Size(80, 40);
            this.label_Role.TabIndex = 21;
            this.label_Role.Text = "Role";
            this.label_Role.Click += new System.EventHandler(this.label_Role_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(140)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::University_Application.Properties.Resources.Webp_net_resizeimage__3_;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(308, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 231);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonExit
            // 
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.buttonExit.ForeColor = System.Drawing.Color.Snow;
            this.buttonExit.Location = new System.Drawing.Point(178, 1);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 29);
            this.buttonExit.TabIndex = 23;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // Form_Login
            // 
            this.AcceptButton = this.button_Continue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(525, 200);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_Role);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.textBox_Pass);
            this.Controls.Add(this.CheckBox_Show);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.button_Continue);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.label_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Button button_Continue;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.CheckBox CheckBox_Show;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Label label_Role;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExit;
    }
}
