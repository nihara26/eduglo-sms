﻿namespace EduGloStudentMS
{
    partial class FrmStudent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudent));
            this.label2 = new System.Windows.Forms.Label();
            this.btnhome = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.txtstuname = new System.Windows.Forms.TextBox();
            this.txtstudentdob = new System.Windows.Forms.TextBox();
            this.txtstuaddress = new System.Windows.Forms.TextBox();
            this.txtstutelephone = new System.Windows.Forms.TextBox();
            this.comstucourses = new System.Windows.Forms.ComboBox();
            this.rdibtnmale = new System.Windows.Forms.RadioButton();
            this.rdibtnfemale = new System.Windows.Forms.RadioButton();
            this.rdibtnother = new System.Windows.Forms.RadioButton();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnshowall = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datagridstudent = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teleNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentManagemntSystemDataSet = new EduGloStudentMS.StudentManagemntSystemDataSet();
            this.studentTableAdapter = new EduGloStudentMS.StudentManagemntSystemDataSetTableAdapters.StudentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridstudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagemntSystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(615, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student Details ";
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.SystemColors.Control;
            this.btnhome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhome.BackgroundImage")));
            this.btnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnhome.Location = new System.Drawing.Point(1461, 12);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(61, 53);
            this.btnhome.TabIndex = 4;
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Student ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date of birth :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gender :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 447);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tele.No :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 503);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Course :";
            // 
            // txtstudentid
            // 
            this.txtstudentid.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtstudentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentid.Location = new System.Drawing.Point(257, 163);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(262, 24);
            this.txtstudentid.TabIndex = 13;
            // 
            // txtstuname
            // 
            this.txtstuname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtstuname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstuname.Location = new System.Drawing.Point(257, 221);
            this.txtstuname.Name = "txtstuname";
            this.txtstuname.Size = new System.Drawing.Size(262, 24);
            this.txtstuname.TabIndex = 14;
            // 
            // txtstudentdob
            // 
            this.txtstudentdob.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtstudentdob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentdob.Location = new System.Drawing.Point(257, 282);
            this.txtstudentdob.Name = "txtstudentdob";
            this.txtstudentdob.Size = new System.Drawing.Size(262, 24);
            this.txtstudentdob.TabIndex = 15;
            // 
            // txtstuaddress
            // 
            this.txtstuaddress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtstuaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstuaddress.Location = new System.Drawing.Point(257, 392);
            this.txtstuaddress.Name = "txtstuaddress";
            this.txtstuaddress.Size = new System.Drawing.Size(262, 24);
            this.txtstuaddress.TabIndex = 17;
            // 
            // txtstutelephone
            // 
            this.txtstutelephone.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtstutelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstutelephone.Location = new System.Drawing.Point(257, 447);
            this.txtstutelephone.Name = "txtstutelephone";
            this.txtstutelephone.Size = new System.Drawing.Size(262, 24);
            this.txtstutelephone.TabIndex = 18;
            // 
            // comstucourses
            // 
            this.comstucourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comstucourses.FormattingEnabled = true;
            this.comstucourses.Items.AddRange(new object[] {
            "Computer Science",
            "Business Administration",
            "Electrical Engineering",
            "Psychology",
            "Mechanical Engineering"});
            this.comstucourses.Location = new System.Drawing.Point(257, 503);
            this.comstucourses.Name = "comstucourses";
            this.comstucourses.Size = new System.Drawing.Size(262, 26);
            this.comstucourses.TabIndex = 20;
            // 
            // rdibtnmale
            // 
            this.rdibtnmale.AutoSize = true;
            this.rdibtnmale.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rdibtnmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdibtnmale.Location = new System.Drawing.Point(257, 342);
            this.rdibtnmale.Name = "rdibtnmale";
            this.rdibtnmale.Size = new System.Drawing.Size(66, 24);
            this.rdibtnmale.TabIndex = 21;
            this.rdibtnmale.TabStop = true;
            this.rdibtnmale.Text = "Male";
            this.rdibtnmale.UseVisualStyleBackColor = false;
            // 
            // rdibtnfemale
            // 
            this.rdibtnfemale.AutoSize = true;
            this.rdibtnfemale.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rdibtnfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdibtnfemale.Location = new System.Drawing.Point(346, 342);
            this.rdibtnfemale.Name = "rdibtnfemale";
            this.rdibtnfemale.Size = new System.Drawing.Size(85, 24);
            this.rdibtnfemale.TabIndex = 22;
            this.rdibtnfemale.TabStop = true;
            this.rdibtnfemale.Text = "Female";
            this.rdibtnfemale.UseVisualStyleBackColor = false;
            // 
            // rdibtnother
            // 
            this.rdibtnother.AutoSize = true;
            this.rdibtnother.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rdibtnother.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdibtnother.Location = new System.Drawing.Point(447, 343);
            this.rdibtnother.Name = "rdibtnother";
            this.rdibtnother.Size = new System.Drawing.Size(72, 24);
            this.rdibtnother.TabIndex = 23;
            this.rdibtnother.TabStop = true;
            this.rdibtnother.Text = "Other";
            this.rdibtnother.UseVisualStyleBackColor = false;
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btninsert.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.Location = new System.Drawing.Point(98, 616);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(167, 59);
            this.btninsert.TabIndex = 24;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = false;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnupdate.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(299, 616);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(167, 59);
            this.btnupdate.TabIndex = 25;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btndelete.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(98, 705);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(167, 59);
            this.btndelete.TabIndex = 26;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnclear.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(299, 705);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(167, 59);
            this.btnclear.TabIndex = 27;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnsearch.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(754, 134);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(167, 59);
            this.btnsearch.TabIndex = 28;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            // 
            // btnshowall
            // 
            this.btnshowall.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnshowall.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowall.Location = new System.Drawing.Point(1175, 134);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(167, 59);
            this.btnshowall.TabIndex = 29;
            this.btnshowall.Text = "Show All";
            this.btnshowall.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 59);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Location = new System.Drawing.Point(48, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 448);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(37, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 446);
            this.panel2.TabIndex = 74;
            // 
            // datagridstudent
            // 
            this.datagridstudent.AutoGenerateColumns = false;
            this.datagridstudent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.datagridstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridstudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.teleNoDataGridViewTextBoxColumn,
            this.courseIDDataGridViewTextBoxColumn});
            this.datagridstudent.DataSource = this.studentBindingSource;
            this.datagridstudent.Location = new System.Drawing.Point(593, 208);
            this.datagridstudent.Name = "datagridstudent";
            this.datagridstudent.RowHeadersWidth = 51;
            this.datagridstudent.RowTemplate.Height = 24;
            this.datagridstudent.Size = new System.Drawing.Size(900, 546);
            this.datagridstudent.TabIndex = 75;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "Student_ID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "Student_ID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // teleNoDataGridViewTextBoxColumn
            // 
            this.teleNoDataGridViewTextBoxColumn.DataPropertyName = "Tele_No";
            this.teleNoDataGridViewTextBoxColumn.HeaderText = "Tele_No";
            this.teleNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teleNoDataGridViewTextBoxColumn.Name = "teleNoDataGridViewTextBoxColumn";
            this.teleNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.studentManagemntSystemDataSet;
            // 
            // studentManagemntSystemDataSet
            // 
            this.studentManagemntSystemDataSet.DataSetName = "StudentManagemntSystemDataSet";
            this.studentManagemntSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1534, 791);
            this.Controls.Add(this.datagridstudent);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnshowall);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.rdibtnother);
            this.Controls.Add(this.rdibtnfemale);
            this.Controls.Add(this.rdibtnmale);
            this.Controls.Add(this.comstucourses);
            this.Controls.Add(this.txtstutelephone);
            this.Controls.Add(this.txtstuaddress);
            this.Controls.Add(this.txtstudentdob);
            this.Controls.Add(this.txtstuname);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "FrmStudent";
            this.Text = "FrmStudent";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridstudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagemntSystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.TextBox txtstuname;
        private System.Windows.Forms.TextBox txtstudentdob;
        private System.Windows.Forms.TextBox txtstuaddress;
        private System.Windows.Forms.TextBox txtstutelephone;
        private System.Windows.Forms.ComboBox comstucourses;
        private System.Windows.Forms.RadioButton rdibtnmale;
        private System.Windows.Forms.RadioButton rdibtnfemale;
        private System.Windows.Forms.RadioButton rdibtnother;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnshowall;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView datagridstudent;
        private StudentManagemntSystemDataSet studentManagemntSystemDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private StudentManagemntSystemDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teleNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
    }
}