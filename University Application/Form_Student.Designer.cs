
using System;

namespace University_Application
{
    partial class Form_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Student));
            this.lblMyName = new System.Windows.Forms.Label();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.btnDrop = new System.Windows.Forms.Button();
            this.btnShowMyCourses = new System.Windows.Forms.Button();
            this.btnShowMyGrades = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.richTxtBoxResult = new System.Windows.Forms.RichTextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnShowAllCourses = new System.Windows.Forms.Button();
            this.btnShowMyGPA = new System.Windows.Forms.Button();
            this.btnShowMyCredits = new System.Windows.Forms.Button();
            this.btnShowCreditsOfAllCourses = new System.Windows.Forms.Button();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelBlue.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMyName
            // 
            this.lblMyName.BackColor = System.Drawing.Color.Transparent;
            this.lblMyName.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Bold);
            this.lblMyName.ForeColor = System.Drawing.Color.Snow;
            this.lblMyName.Location = new System.Drawing.Point(46, 9);
            this.lblMyName.Name = "lblMyName";
            this.lblMyName.Size = new System.Drawing.Size(351, 33);
            this.lblMyName.TabIndex = 0;
            this.lblMyName.Text = "Student Menu";
            this.lblMyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnroll
            // 
            this.btnEnroll.BackColor = System.Drawing.Color.Snow;
            this.btnEnroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnroll.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnEnroll.FlatAppearance.BorderSize = 0;
            this.btnEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnroll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEnroll.ForeColor = System.Drawing.Color.Black;
            this.btnEnroll.Location = new System.Drawing.Point(10, 72);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(182, 35);
            this.btnEnroll.TabIndex = 2;
            this.btnEnroll.Text = "1. Enroll in a Class";
            this.btnEnroll.UseVisualStyleBackColor = false;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // btnDrop
            // 
            this.btnDrop.BackColor = System.Drawing.Color.Snow;
            this.btnDrop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrop.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnDrop.FlatAppearance.BorderSize = 0;
            this.btnDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDrop.ForeColor = System.Drawing.Color.Black;
            this.btnDrop.Location = new System.Drawing.Point(10, 114);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(182, 35);
            this.btnDrop.TabIndex = 3;
            this.btnDrop.Text = "2. Drop a Class";
            this.btnDrop.UseVisualStyleBackColor = false;
            this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click);
            // 
            // btnShowMyCourses
            // 
            this.btnShowMyCourses.BackColor = System.Drawing.Color.Snow;
            this.btnShowMyCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowMyCourses.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnShowMyCourses.FlatAppearance.BorderSize = 0;
            this.btnShowMyCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowMyCourses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnShowMyCourses.ForeColor = System.Drawing.Color.Black;
            this.btnShowMyCourses.Location = new System.Drawing.Point(10, 159);
            this.btnShowMyCourses.Name = "btnShowMyCourses";
            this.btnShowMyCourses.Size = new System.Drawing.Size(182, 35);
            this.btnShowMyCourses.TabIndex = 4;
            this.btnShowMyCourses.Text = "3. Show My Courses";
            this.btnShowMyCourses.UseVisualStyleBackColor = false;
            this.btnShowMyCourses.Click += new System.EventHandler(this.btnShowMyCourses_Click);
            // 
            // btnShowMyGrades
            // 
            this.btnShowMyGrades.BackColor = System.Drawing.Color.Snow;
            this.btnShowMyGrades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowMyGrades.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnShowMyGrades.FlatAppearance.BorderSize = 0;
            this.btnShowMyGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowMyGrades.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnShowMyGrades.ForeColor = System.Drawing.Color.Black;
            this.btnShowMyGrades.Location = new System.Drawing.Point(10, 203);
            this.btnShowMyGrades.Name = "btnShowMyGrades";
            this.btnShowMyGrades.Size = new System.Drawing.Size(182, 35);
            this.btnShowMyGrades.TabIndex = 5;
            this.btnShowMyGrades.Text = "4. Show All Your Grades";
            this.btnShowMyGrades.UseVisualStyleBackColor = false;
            this.btnShowMyGrades.Click += new System.EventHandler(this.btnShowMyGrades_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.Snow;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Snow;
            this.btnClose.Location = new System.Drawing.Point(665, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // richTxtBoxResult
            // 
            this.richTxtBoxResult.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.richTxtBoxResult.Location = new System.Drawing.Point(417, 72);
            this.richTxtBoxResult.Name = "richTxtBoxResult";
            this.richTxtBoxResult.Size = new System.Drawing.Size(276, 169);
            this.richTxtBoxResult.TabIndex = 22;
            this.richTxtBoxResult.Text = "";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblResult.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.lblResult.Location = new System.Drawing.Point(524, 45);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(71, 24);
            this.lblResult.TabIndex = 23;
            this.lblResult.Text = "Result:";
            // 
            // btnShowAllCourses
            // 
            this.btnShowAllCourses.BackColor = System.Drawing.Color.Snow;
            this.btnShowAllCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAllCourses.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnShowAllCourses.FlatAppearance.BorderSize = 0;
            this.btnShowAllCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllCourses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnShowAllCourses.ForeColor = System.Drawing.Color.Black;
            this.btnShowAllCourses.Location = new System.Drawing.Point(211, 72);
            this.btnShowAllCourses.Name = "btnShowAllCourses";
            this.btnShowAllCourses.Size = new System.Drawing.Size(182, 35);
            this.btnShowAllCourses.TabIndex = 24;
            this.btnShowAllCourses.Text = "5. Show All Courses";
            this.btnShowAllCourses.UseVisualStyleBackColor = false;
            this.btnShowAllCourses.Click += new System.EventHandler(this.btnShowAllCourses_Click);
            // 
            // btnShowMyGPA
            // 
            this.btnShowMyGPA.BackColor = System.Drawing.Color.Snow;
            this.btnShowMyGPA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowMyGPA.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnShowMyGPA.FlatAppearance.BorderSize = 0;
            this.btnShowMyGPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowMyGPA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnShowMyGPA.ForeColor = System.Drawing.Color.Black;
            this.btnShowMyGPA.Location = new System.Drawing.Point(211, 203);
            this.btnShowMyGPA.Name = "btnShowMyGPA";
            this.btnShowMyGPA.Size = new System.Drawing.Size(182, 35);
            this.btnShowMyGPA.TabIndex = 31;
            this.btnShowMyGPA.Text = "8. Show My GPA";
            this.btnShowMyGPA.UseVisualStyleBackColor = false;
            this.btnShowMyGPA.Click += new System.EventHandler(this.btnShowMyGPA_Click);
            // 
            // btnShowMyCredits
            // 
            this.btnShowMyCredits.BackColor = System.Drawing.Color.Snow;
            this.btnShowMyCredits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowMyCredits.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnShowMyCredits.FlatAppearance.BorderSize = 0;
            this.btnShowMyCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowMyCredits.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnShowMyCredits.ForeColor = System.Drawing.Color.Black;
            this.btnShowMyCredits.Location = new System.Drawing.Point(211, 159);
            this.btnShowMyCredits.Name = "btnShowMyCredits";
            this.btnShowMyCredits.Size = new System.Drawing.Size(182, 35);
            this.btnShowMyCredits.TabIndex = 30;
            this.btnShowMyCredits.Text = "7. Show Credits of My Courses";
            this.btnShowMyCredits.UseVisualStyleBackColor = false;
            this.btnShowMyCredits.Click += new System.EventHandler(this.btnShowMyCredits_Click);
            // 
            // btnShowCreditsOfAllCourses
            // 
            this.btnShowCreditsOfAllCourses.BackColor = System.Drawing.Color.Snow;
            this.btnShowCreditsOfAllCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowCreditsOfAllCourses.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnShowCreditsOfAllCourses.FlatAppearance.BorderSize = 0;
            this.btnShowCreditsOfAllCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCreditsOfAllCourses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnShowCreditsOfAllCourses.ForeColor = System.Drawing.Color.Black;
            this.btnShowCreditsOfAllCourses.Location = new System.Drawing.Point(211, 114);
            this.btnShowCreditsOfAllCourses.Name = "btnShowCreditsOfAllCourses";
            this.btnShowCreditsOfAllCourses.Size = new System.Drawing.Size(182, 35);
            this.btnShowCreditsOfAllCourses.TabIndex = 29;
            this.btnShowCreditsOfAllCourses.Text = "6. Show Credits of All Courses";
            this.btnShowCreditsOfAllCourses.UseVisualStyleBackColor = false;
            this.btnShowCreditsOfAllCourses.Click += new System.EventHandler(this.btnShowCreditsOfAllCourses_Click);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.panelBlue.Controls.Add(this.lblMyName);
            this.panelBlue.Controls.Add(this.btnBack);
            this.panelBlue.Location = new System.Drawing.Point(0, 0);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(400, 283);
            this.panelBlue.TabIndex = 32;
            // 
            // Form_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(705, 280);
            this.Controls.Add(this.btnShowMyGPA);
            this.Controls.Add(this.btnShowMyCredits);
            this.Controls.Add(this.btnShowCreditsOfAllCourses);
            this.Controls.Add(this.btnShowAllCourses);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.richTxtBoxResult);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShowMyGrades);
            this.Controls.Add(this.btnShowMyCourses);
            this.Controls.Add(this.btnDrop);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.panelBlue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form_Student_Load);
            this.panelBlue.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lblMyName;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Button btnDrop;
        private System.Windows.Forms.Button btnShowMyCourses;
        private System.Windows.Forms.Button btnShowMyGrades;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox richTxtBoxResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnShowAllCourses;
        private System.Windows.Forms.Button btnShowMyGPA;
        private System.Windows.Forms.Button btnShowMyCredits;
        private System.Windows.Forms.Button btnShowCreditsOfAllCourses;
        private System.Windows.Forms.Panel panelBlue;
    }
}