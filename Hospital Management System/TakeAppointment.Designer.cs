namespace Hospital_Management_System
{
    partial class TakeAppointment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dnametxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DoctorName = new System.Windows.Forms.DataGridView();
            this.patientfnametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.appointmentdate = new System.Windows.Forms.DateTimePicker();
            this.patientagetxt = new System.Windows.Forms.TextBox();
            this.Doctortp = new System.Windows.Forms.ComboBox();
            this.patientaddress = new System.Windows.Forms.TextBox();
            this.DoctorIDtxt = new System.Windows.Forms.TextBox();
            this.Femalebtn = new System.Windows.Forms.RadioButton();
            this.Malebtn = new System.Windows.Forms.RadioButton();
            this.Patientphoneno = new System.Windows.Forms.TextBox();
            this.Patientnametxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Todaydatetime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Insertbtn = new System.Windows.Forms.Button();
            this.TimeToday = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.RIDy1 = new System.Windows.Forms.TextBox();
            this.RIDt1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorName)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.Dnametxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.DoctorName);
            this.groupBox1.Controls.Add(this.patientfnametxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.appointmentdate);
            this.groupBox1.Controls.Add(this.patientagetxt);
            this.groupBox1.Controls.Add(this.Doctortp);
            this.groupBox1.Controls.Add(this.patientaddress);
            this.groupBox1.Controls.Add(this.DoctorIDtxt);
            this.groupBox1.Controls.Add(this.Femalebtn);
            this.groupBox1.Controls.Add(this.Malebtn);
            this.groupBox1.Controls.Add(this.Patientphoneno);
            this.groupBox1.Controls.Add(this.Patientnametxt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(63, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 389);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment";
            // 
            // Dnametxt
            // 
            this.Dnametxt.Location = new System.Drawing.Point(151, 110);
            this.Dnametxt.Name = "Dnametxt";
            this.Dnametxt.ReadOnly = true;
            this.Dnametxt.Size = new System.Drawing.Size(121, 20);
            this.Dnametxt.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Doctor Name:";
            // 
            // DoctorName
            // 
            this.DoctorName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorName.Location = new System.Drawing.Point(316, 19);
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.Size = new System.Drawing.Size(246, 102);
            this.DoctorName.TabIndex = 22;
            this.DoctorName.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorName_CellContentClick);
            // 
            // patientfnametxt
            // 
            this.patientfnametxt.Location = new System.Drawing.Point(151, 220);
            this.patientfnametxt.Name = "patientfnametxt";
            this.patientfnametxt.Size = new System.Drawing.Size(121, 20);
            this.patientfnametxt.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient Father Name:";
            // 
            // appointmentdate
            // 
            this.appointmentdate.CustomFormat = "yyyy-MM-dd";
            this.appointmentdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.appointmentdate.Location = new System.Drawing.Point(439, 182);
            this.appointmentdate.Name = "appointmentdate";
            this.appointmentdate.Size = new System.Drawing.Size(121, 20);
            this.appointmentdate.TabIndex = 21;
            // 
            // patientagetxt
            // 
            this.patientagetxt.Location = new System.Drawing.Point(151, 182);
            this.patientagetxt.Name = "patientagetxt";
            this.patientagetxt.Size = new System.Drawing.Size(121, 20);
            this.patientagetxt.TabIndex = 19;
            // 
            // Doctortp
            // 
            this.Doctortp.FormattingEnabled = true;
            this.Doctortp.Location = new System.Drawing.Point(151, 36);
            this.Doctortp.Name = "Doctortp";
            this.Doctortp.Size = new System.Drawing.Size(121, 21);
            this.Doctortp.TabIndex = 18;
            this.Doctortp.SelectedIndexChanged += new System.EventHandler(this.Doctortp_SelectedIndexChanged);
            // 
            // patientaddress
            // 
            this.patientaddress.Location = new System.Drawing.Point(151, 269);
            this.patientaddress.Name = "patientaddress";
            this.patientaddress.Size = new System.Drawing.Size(411, 20);
            this.patientaddress.TabIndex = 17;
            // 
            // DoctorIDtxt
            // 
            this.DoctorIDtxt.Location = new System.Drawing.Point(151, 73);
            this.DoctorIDtxt.Name = "DoctorIDtxt";
            this.DoctorIDtxt.ReadOnly = true;
            this.DoctorIDtxt.Size = new System.Drawing.Size(121, 20);
            this.DoctorIDtxt.TabIndex = 15;
            // 
            // Femalebtn
            // 
            this.Femalebtn.AutoSize = true;
            this.Femalebtn.Location = new System.Drawing.Point(490, 143);
            this.Femalebtn.Name = "Femalebtn";
            this.Femalebtn.Size = new System.Drawing.Size(59, 17);
            this.Femalebtn.TabIndex = 14;
            this.Femalebtn.TabStop = true;
            this.Femalebtn.Text = "Female";
            this.Femalebtn.UseVisualStyleBackColor = true;
            this.Femalebtn.CheckedChanged += new System.EventHandler(this.Femalebtn_CheckedChanged);
            // 
            // Malebtn
            // 
            this.Malebtn.AutoSize = true;
            this.Malebtn.Location = new System.Drawing.Point(439, 143);
            this.Malebtn.Name = "Malebtn";
            this.Malebtn.Size = new System.Drawing.Size(48, 17);
            this.Malebtn.TabIndex = 13;
            this.Malebtn.TabStop = true;
            this.Malebtn.Text = "Male";
            this.Malebtn.UseVisualStyleBackColor = true;
            this.Malebtn.CheckedChanged += new System.EventHandler(this.Malebtn_CheckedChanged);
            // 
            // Patientphoneno
            // 
            this.Patientphoneno.Location = new System.Drawing.Point(439, 220);
            this.Patientphoneno.Name = "Patientphoneno";
            this.Patientphoneno.Size = new System.Drawing.Size(121, 20);
            this.Patientphoneno.TabIndex = 12;
            // 
            // Patientnametxt
            // 
            this.Patientnametxt.Location = new System.Drawing.Point(151, 145);
            this.Patientnametxt.Name = "Patientnametxt";
            this.Patientnametxt.Size = new System.Drawing.Size(121, 20);
            this.Patientnametxt.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(313, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Appointment Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Doctor Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Doctor ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Patient Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Patient Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Patient Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patient Phone No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Name:";
            // 
            // Todaydatetime
            // 
            this.Todaydatetime.AutoSize = true;
            this.Todaydatetime.Location = new System.Drawing.Point(674, 47);
            this.Todaydatetime.Name = "Todaydatetime";
            this.Todaydatetime.Size = new System.Drawing.Size(41, 13);
            this.Todaydatetime.TabIndex = 1;
            this.Todaydatetime.Text = "label11";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.Clearbtn);
            this.panel1.Controls.Add(this.Insertbtn);
            this.panel1.Location = new System.Drawing.Point(723, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 188);
            this.panel1.TabIndex = 2;
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(20, 108);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(75, 23);
            this.Clearbtn.TabIndex = 1;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Insertbtn
            // 
            this.Insertbtn.Location = new System.Drawing.Point(21, 55);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.Size = new System.Drawing.Size(75, 23);
            this.Insertbtn.TabIndex = 0;
            this.Insertbtn.Text = "ADD";
            this.Insertbtn.UseVisualStyleBackColor = true;
            this.Insertbtn.Click += new System.EventHandler(this.Insertbtn_Click);
            // 
            // TimeToday
            // 
            this.TimeToday.Tick += new System.EventHandler(this.TimeToday_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem,
            this.backToHomeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // backToHomeToolStripMenuItem
            // 
            this.backToHomeToolStripMenuItem.Name = "backToHomeToolStripMenuItem";
            this.backToHomeToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.backToHomeToolStripMenuItem.Text = "Back To Home";
            this.backToHomeToolStripMenuItem.Click += new System.EventHandler(this.backToHomeToolStripMenuItem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(317, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Receptionist Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Receptionist ID:";
            // 
            // RIDy1
            // 
            this.RIDy1.Location = new System.Drawing.Point(436, 54);
            this.RIDy1.Name = "RIDy1";
            this.RIDy1.ReadOnly = true;
            this.RIDy1.Size = new System.Drawing.Size(100, 20);
            this.RIDy1.TabIndex = 9;
            // 
            // RIDt1
            // 
            this.RIDt1.Location = new System.Drawing.Point(169, 54);
            this.RIDt1.Name = "RIDt1";
            this.RIDt1.ReadOnly = true;
            this.RIDt1.Size = new System.Drawing.Size(100, 20);
            this.RIDt1.TabIndex = 8;
            // 
            // TakeAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(849, 538);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.RIDy1);
            this.Controls.Add(this.RIDt1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Todaydatetime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TakeAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TakeAppointment";
            this.Load += new System.EventHandler(this.TakeAppointment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorName)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox patientagetxt;
        private System.Windows.Forms.ComboBox Doctortp;
        private System.Windows.Forms.TextBox patientaddress;
        private System.Windows.Forms.TextBox DoctorIDtxt;
        private System.Windows.Forms.RadioButton Femalebtn;
        private System.Windows.Forms.RadioButton Malebtn;
        private System.Windows.Forms.TextBox Patientphoneno;
        private System.Windows.Forms.TextBox patientfnametxt;
        private System.Windows.Forms.TextBox Patientnametxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Todaydatetime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button Insertbtn;
        private System.Windows.Forms.DateTimePicker appointmentdate;
        private System.Windows.Forms.Timer TimeToday;
        private System.Windows.Forms.DataGridView DoctorName;
        private System.Windows.Forms.TextBox Dnametxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToHomeToolStripMenuItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox RIDy1;
        private System.Windows.Forms.TextBox RIDt1;
    }
}