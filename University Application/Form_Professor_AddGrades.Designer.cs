
namespace University_Application
{
    partial class Form_Professor_AddGrades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Professor_AddGrades));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Grades";
            // 
            // textBox_Input
            // 
            this.textBox_Input.AcceptsReturn = true;
            this.textBox_Input.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.textBox_Input.ForeColor = System.Drawing.Color.Black;
            this.textBox_Input.Location = new System.Drawing.Point(20, 46);
            this.textBox_Input.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Input.Multiline = true;
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(215, 172);
            this.textBox_Input.TabIndex = 2;
            this.textBox_Input.TextChanged += new System.EventHandler(this.textBox_Input_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.button_Back);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.button_Add);
            this.panel1.Controls.Add(this.textBox_Input);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 274);
            this.panel1.TabIndex = 3;
            // 
            // buttonExit
            // 
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.buttonExit.ForeColor = System.Drawing.Color.Snow;
            this.buttonExit.Location = new System.Drawing.Point(320, 0);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 40);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.Snow;
            this.button_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Add.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_Add.FlatAppearance.BorderSize = 0;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Bold);
            this.button_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.button_Add.Location = new System.Drawing.Point(250, 186);
            this.button_Add.Margin = new System.Windows.Forms.Padding(2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(87, 32);
            this.button_Add.TabIndex = 4;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Back
            // 
            this.button_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.button_Back.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_Back.FlatAppearance.BorderSize = 0;
            this.button_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Back.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.button_Back.ForeColor = System.Drawing.Color.Snow;
            this.button_Back.Location = new System.Drawing.Point(0, 0);
            this.button_Back.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(40, 40);
            this.button_Back.TabIndex = 20;
            this.button_Back.Text = "<";
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::University_Application.Properties.Resources.SUNY_White_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(250, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 103);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // Form_Professor_AddGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(355, 248);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Professor_AddGrades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Professor_AddGrades";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}