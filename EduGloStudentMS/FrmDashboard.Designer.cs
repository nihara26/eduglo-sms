namespace EduGloStudentMS
{
    partial class FrmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnstudent = new System.Windows.Forms.Button();
            this.btnlecturer = new System.Windows.Forms.Button();
            this.btncourse = new System.Windows.Forms.Button();
            this.studentlabel = new System.Windows.Forms.Label();
            this.lecturerlabel = new System.Windows.Forms.Label();
            this.courselabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 710);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(146, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 66);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(69, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 225);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.btnlogout);
            this.panel5.Location = new System.Drawing.Point(43, 480);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(293, 230);
            this.panel5.TabIndex = 11;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnlogout.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(26, 92);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(251, 59);
            this.btnlogout.TabIndex = 9;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Engravers MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(703, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dashboard";
            // 
            // btnstudent
            // 
            this.btnstudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnstudent.BackgroundImage")));
            this.btnstudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnstudent.Location = new System.Drawing.Point(471, 189);
            this.btnstudent.Name = "btnstudent";
            this.btnstudent.Size = new System.Drawing.Size(304, 185);
            this.btnstudent.TabIndex = 3;
            this.btnstudent.UseVisualStyleBackColor = true;
            this.btnstudent.Click += new System.EventHandler(this.btnstudent_Click);
            // 
            // btnlecturer
            // 
            this.btnlecturer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlecturer.BackgroundImage")));
            this.btnlecturer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlecturer.Location = new System.Drawing.Point(884, 189);
            this.btnlecturer.Name = "btnlecturer";
            this.btnlecturer.Size = new System.Drawing.Size(298, 185);
            this.btnlecturer.TabIndex = 4;
            this.btnlecturer.UseVisualStyleBackColor = true;
            this.btnlecturer.Click += new System.EventHandler(this.btnlecturer_Click);
            // 
            // btncourse
            // 
            this.btncourse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncourse.BackgroundImage")));
            this.btncourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncourse.Location = new System.Drawing.Point(677, 443);
            this.btncourse.Name = "btncourse";
            this.btncourse.Size = new System.Drawing.Size(283, 191);
            this.btncourse.TabIndex = 5;
            this.btncourse.UseVisualStyleBackColor = true;
            this.btncourse.Click += new System.EventHandler(this.btncourse_Click);
            // 
            // studentlabel
            // 
            this.studentlabel.AutoSize = true;
            this.studentlabel.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentlabel.Location = new System.Drawing.Point(557, 377);
            this.studentlabel.Name = "studentlabel";
            this.studentlabel.Size = new System.Drawing.Size(127, 20);
            this.studentlabel.TabIndex = 6;
            this.studentlabel.Text = "Student View";
            // 
            // lecturerlabel
            // 
            this.lecturerlabel.AutoSize = true;
            this.lecturerlabel.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturerlabel.Location = new System.Drawing.Point(958, 377);
            this.lecturerlabel.Name = "lecturerlabel";
            this.lecturerlabel.Size = new System.Drawing.Size(132, 20);
            this.lecturerlabel.TabIndex = 7;
            this.lecturerlabel.Text = "Lecturer View";
            // 
            // courselabel
            // 
            this.courselabel.AutoSize = true;
            this.courselabel.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courselabel.Location = new System.Drawing.Point(753, 637);
            this.courselabel.Name = "courselabel";
            this.courselabel.Size = new System.Drawing.Size(120, 20);
            this.courselabel.TabIndex = 8;
            this.courselabel.Text = "Course View";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 710);
            this.panel2.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(1010, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 523);
            this.panel4.TabIndex = 10;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1276, 715);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.courselabel);
            this.Controls.Add(this.lecturerlabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.studentlabel);
            this.Controls.Add(this.btncourse);
            this.Controls.Add(this.btnlecturer);
            this.Controls.Add(this.btnstudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.MaximizeBox = false;
            this.Name = "FrmDashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnstudent;
        private System.Windows.Forms.Button btnlecturer;
        private System.Windows.Forms.Button btncourse;
        private System.Windows.Forms.Label studentlabel;
        private System.Windows.Forms.Label lecturerlabel;
        private System.Windows.Forms.Label courselabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}