
namespace University_Application
{
    partial class Form_Admin
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.checkedListBox_Admin = new System.Windows.Forms.CheckedListBox();
            this.button_select = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 13F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Welcome Admin !";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Controls.Add(this.checkedListBox_Admin);
            this.panel2.Controls.Add(this.button_select);
            this.panel2.Location = new System.Drawing.Point(169, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 281);
            this.panel2.TabIndex = 25;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 13.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(140, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "_";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Lucida Console", 12.75F, System.Drawing.FontStyle.Bold);
            this.buttonExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonExit.Location = new System.Drawing.Point(182, 0);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(49, 40);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // checkedListBox_Admin
            // 
            this.checkedListBox_Admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.checkedListBox_Admin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_Admin.CheckOnClick = true;
            this.checkedListBox_Admin.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.checkedListBox_Admin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkedListBox_Admin.FormattingEnabled = true;
            this.checkedListBox_Admin.Items.AddRange(new object[] {
            "Add professor",
            "Add student",
            "Add course",
            "Remove professor",
            "Remove student",
            "Remove course"});
            this.checkedListBox_Admin.Location = new System.Drawing.Point(18, 47);
            this.checkedListBox_Admin.Name = "checkedListBox_Admin";
            this.checkedListBox_Admin.Size = new System.Drawing.Size(191, 162);
            this.checkedListBox_Admin.TabIndex = 2;
            this.checkedListBox_Admin.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_Admin_SelectedIndexChanged);
            // 
            // button_select
            // 
            this.button_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.button_select.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_select.Location = new System.Drawing.Point(50, 215);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(114, 54);
            this.button_select.TabIndex = 4;
            this.button_select.Text = "Select";
            this.button_select.UseVisualStyleBackColor = false;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // button_Back
            // 
            this.button_Back.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_Back.FlatAppearance.BorderSize = 0;
            this.button_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Back.Font = new System.Drawing.Font("Lucida Console", 13F, System.Drawing.FontStyle.Bold);
            this.button_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.button_Back.Location = new System.Drawing.Point(-5, 0);
            this.button_Back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(45, 49);
            this.button_Back.TabIndex = 26;
            this.button_Back.Text = "<";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(406, 280);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Admin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Page ";
            this.Load += new System.EventHandler(this.Form_Admin_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox checkedListBox_Admin;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button button1;
    }
}