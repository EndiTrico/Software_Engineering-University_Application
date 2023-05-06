
namespace University_Application
{
    partial class Form_Student_Drop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Student_Drop));
            this.lblDrop = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.comboBoxChooseCourse = new System.Windows.Forms.ComboBox();
            this.btnDrop = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDrop
            // 
            this.lblDrop.AutoSize = true;
            this.lblDrop.BackColor = System.Drawing.Color.Transparent;
            this.lblDrop.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Bold);
            this.lblDrop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.lblDrop.Location = new System.Drawing.Point(254, 9);
            this.lblDrop.Name = "lblDrop";
            this.lblDrop.Size = new System.Drawing.Size(178, 33);
            this.lblDrop.TabIndex = 6;
            this.lblDrop.Text = "Drop a Course";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseName.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblCourseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.lblCourseName.Location = new System.Drawing.Point(148, 76);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(123, 22);
            this.lblCourseName.TabIndex = 7;
            this.lblCourseName.Text = "Course Name: ";
            // 
            // comboBoxChooseCourse
            // 
            this.comboBoxChooseCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxChooseCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxChooseCourse.Font = new System.Drawing.Font("Corbel", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChooseCourse.FormattingEnabled = true;
            this.comboBoxChooseCourse.Location = new System.Drawing.Point(277, 75);
            this.comboBoxChooseCourse.Name = "comboBoxChooseCourse";
            this.comboBoxChooseCourse.Size = new System.Drawing.Size(261, 26);
            this.comboBoxChooseCourse.TabIndex = 25;
            this.comboBoxChooseCourse.Text = "Choose a Course";
            this.comboBoxChooseCourse.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnDrop
            // 
            this.btnDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.btnDrop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrop.FlatAppearance.BorderSize = 0;
            this.btnDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrop.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.btnDrop.ForeColor = System.Drawing.Color.Snow;
            this.btnDrop.Location = new System.Drawing.Point(411, 135);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(127, 34);
            this.btnDrop.TabIndex = 26;
            this.btnDrop.Text = "Drop";
            this.btnDrop.UseVisualStyleBackColor = false;
            this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.Snow;
            this.btnExit.Location = new System.Drawing.Point(534, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
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
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.pictureBoxLogo.Image = global::University_Application.Properties.Resources.SUNY_White_Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(142, 191);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogo.TabIndex = 30;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Form_Student_Drop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(574, 190);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDrop);
            this.Controls.Add(this.comboBoxChooseCourse);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblDrop);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Student_Drop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Student_Drop";
            this.Load += new System.EventHandler(this.Form_Student_Drop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDrop;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.ComboBox comboBoxChooseCourse;
        private System.Windows.Forms.Button btnDrop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}