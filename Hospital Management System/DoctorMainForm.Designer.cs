namespace Hospital_Management_System
{
    partial class DoctorMainForm
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
            this.DID = new System.Windows.Forms.TextBox();
            this.DName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Patientmedicinee = new System.Windows.Forms.TextBox();
            this.Checkpatientbtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.PatientIDtxt = new System.Windows.Forms.TextBox();
            this.PatientGendertxt = new System.Windows.Forms.TextBox();
            this.Patientstatus = new System.Windows.Forms.CheckBox();
            this.Patientagetxt = new System.Windows.Forms.TextBox();
            this.Patientnametxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Patientin = new System.Windows.Forms.DataGridView();
            this.Medicinetable = new System.Windows.Forms.DataGridView();
            this.Morningbtn = new System.Windows.Forms.RadioButton();
            this.MNbtn = new System.Windows.Forms.RadioButton();
            this.MAFTNbtn = new System.Windows.Forms.RadioButton();
            this.TotalMedicine = new System.Windows.Forms.TextBox();
            this.AddMedicine = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeselect = new System.Windows.Forms.TextBox();
            this.Medicinetp = new System.Windows.Forms.TextBox();
            this.DoctorMenu = new System.Windows.Forms.MenuStrip();
            this.checkPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Patientin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Medicinetable)).BeginInit();
            this.panel1.SuspendLayout();
            this.DoctorMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // DID
            // 
            this.DID.Location = new System.Drawing.Point(86, 33);
            this.DID.Name = "DID";
            this.DID.ReadOnly = true;
            this.DID.Size = new System.Drawing.Size(79, 20);
            this.DID.TabIndex = 0;
            // 
            // DName
            // 
            this.DName.Location = new System.Drawing.Point(258, 33);
            this.DName.Name = "DName";
            this.DName.ReadOnly = true;
            this.DName.Size = new System.Drawing.Size(105, 20);
            this.DName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DoctorID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Doctor Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.Patientmedicinee);
            this.groupBox1.Controls.Add(this.Checkpatientbtn);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.PatientIDtxt);
            this.groupBox1.Controls.Add(this.PatientGendertxt);
            this.groupBox1.Controls.Add(this.Patientstatus);
            this.groupBox1.Controls.Add(this.Patientagetxt);
            this.groupBox1.Controls.Add(this.Patientnametxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(29, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 458);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHECK PATIENT";
            // 
            // Patientmedicinee
            // 
            this.Patientmedicinee.Location = new System.Drawing.Point(110, 190);
            this.Patientmedicinee.Multiline = true;
            this.Patientmedicinee.Name = "Patientmedicinee";
            this.Patientmedicinee.Size = new System.Drawing.Size(173, 223);
            this.Patientmedicinee.TabIndex = 17;
            // 
            // Checkpatientbtn
            // 
            this.Checkpatientbtn.Location = new System.Drawing.Point(302, 409);
            this.Checkpatientbtn.Name = "Checkpatientbtn";
            this.Checkpatientbtn.Size = new System.Drawing.Size(101, 39);
            this.Checkpatientbtn.TabIndex = 16;
            this.Checkpatientbtn.Text = "Check";
            this.Checkpatientbtn.UseVisualStyleBackColor = true;
            this.Checkpatientbtn.Click += new System.EventHandler(this.Checkpatientbtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "PatientID:";
            // 
            // PatientIDtxt
            // 
            this.PatientIDtxt.Location = new System.Drawing.Point(108, 23);
            this.PatientIDtxt.Name = "PatientIDtxt";
            this.PatientIDtxt.ReadOnly = true;
            this.PatientIDtxt.Size = new System.Drawing.Size(173, 20);
            this.PatientIDtxt.TabIndex = 13;
            // 
            // PatientGendertxt
            // 
            this.PatientGendertxt.Location = new System.Drawing.Point(110, 145);
            this.PatientGendertxt.Name = "PatientGendertxt";
            this.PatientGendertxt.ReadOnly = true;
            this.PatientGendertxt.Size = new System.Drawing.Size(173, 20);
            this.PatientGendertxt.TabIndex = 12;
            // 
            // Patientstatus
            // 
            this.Patientstatus.AutoSize = true;
            this.Patientstatus.Location = new System.Drawing.Point(107, 435);
            this.Patientstatus.Name = "Patientstatus";
            this.Patientstatus.Size = new System.Drawing.Size(57, 17);
            this.Patientstatus.TabIndex = 11;
            this.Patientstatus.Text = "Check";
            this.Patientstatus.UseVisualStyleBackColor = true;
            // 
            // Patientagetxt
            // 
            this.Patientagetxt.Location = new System.Drawing.Point(110, 105);
            this.Patientagetxt.Name = "Patientagetxt";
            this.Patientagetxt.ReadOnly = true;
            this.Patientagetxt.Size = new System.Drawing.Size(173, 20);
            this.Patientagetxt.TabIndex = 7;
            // 
            // Patientnametxt
            // 
            this.Patientnametxt.Location = new System.Drawing.Point(110, 61);
            this.Patientnametxt.Name = "Patientnametxt";
            this.Patientnametxt.ReadOnly = true;
            this.Patientnametxt.Size = new System.Drawing.Size(173, 20);
            this.Patientnametxt.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Patient Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Patient prescription:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Patient Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Patient Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Patient Name:";
            // 
            // Patientin
            // 
            this.Patientin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Patientin.Location = new System.Drawing.Point(460, 296);
            this.Patientin.Name = "Patientin";
            this.Patientin.Size = new System.Drawing.Size(440, 236);
            this.Patientin.TabIndex = 5;
            this.Patientin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Patientin_CellContentClick);
            // 
            // Medicinetable
            // 
            this.Medicinetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Medicinetable.Location = new System.Drawing.Point(460, 51);
            this.Medicinetable.Name = "Medicinetable";
            this.Medicinetable.Size = new System.Drawing.Size(235, 239);
            this.Medicinetable.TabIndex = 6;
            this.Medicinetable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Medicinetable_CellContentClick);
            // 
            // Morningbtn
            // 
            this.Morningbtn.AutoSize = true;
            this.Morningbtn.Location = new System.Drawing.Point(25, 3);
            this.Morningbtn.Name = "Morningbtn";
            this.Morningbtn.Size = new System.Drawing.Size(63, 17);
            this.Morningbtn.TabIndex = 7;
            this.Morningbtn.TabStop = true;
            this.Morningbtn.Text = "Morning";
            this.Morningbtn.UseVisualStyleBackColor = true;
            this.Morningbtn.CheckedChanged += new System.EventHandler(this.Morningbtn_CheckedChanged);
            // 
            // MNbtn
            // 
            this.MNbtn.AutoSize = true;
            this.MNbtn.Location = new System.Drawing.Point(25, 35);
            this.MNbtn.Name = "MNbtn";
            this.MNbtn.Size = new System.Drawing.Size(91, 17);
            this.MNbtn.TabIndex = 8;
            this.MNbtn.TabStop = true;
            this.MNbtn.Text = "Morning-Night";
            this.MNbtn.UseVisualStyleBackColor = true;
            this.MNbtn.CheckedChanged += new System.EventHandler(this.MNbtn_CheckedChanged);
            // 
            // MAFTNbtn
            // 
            this.MAFTNbtn.AutoSize = true;
            this.MAFTNbtn.Location = new System.Drawing.Point(25, 69);
            this.MAFTNbtn.Name = "MAFTNbtn";
            this.MAFTNbtn.Size = new System.Drawing.Size(140, 17);
            this.MAFTNbtn.TabIndex = 9;
            this.MAFTNbtn.TabStop = true;
            this.MAFTNbtn.Text = "Morning,Afternoon,Night";
            this.MAFTNbtn.UseVisualStyleBackColor = true;
            this.MAFTNbtn.CheckedChanged += new System.EventHandler(this.MAFTNbtn_CheckedChanged);
            // 
            // TotalMedicine
            // 
            this.TotalMedicine.Location = new System.Drawing.Point(25, 175);
            this.TotalMedicine.Name = "TotalMedicine";
            this.TotalMedicine.Size = new System.Drawing.Size(140, 20);
            this.TotalMedicine.TabIndex = 10;
            // 
            // AddMedicine
            // 
            this.AddMedicine.Location = new System.Drawing.Point(65, 213);
            this.AddMedicine.Name = "AddMedicine";
            this.AddMedicine.Size = new System.Drawing.Size(75, 23);
            this.AddMedicine.TabIndex = 11;
            this.AddMedicine.Text = "GiveMedicine";
            this.AddMedicine.UseVisualStyleBackColor = true;
            this.AddMedicine.Click += new System.EventHandler(this.AddMedicine_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.timeselect);
            this.panel1.Controls.Add(this.Medicinetp);
            this.panel1.Controls.Add(this.Morningbtn);
            this.panel1.Controls.Add(this.AddMedicine);
            this.panel1.Controls.Add(this.MNbtn);
            this.panel1.Controls.Add(this.TotalMedicine);
            this.panel1.Controls.Add(this.MAFTNbtn);
            this.panel1.Location = new System.Drawing.Point(701, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 239);
            this.panel1.TabIndex = 12;
            // 
            // timeselect
            // 
            this.timeselect.Location = new System.Drawing.Point(25, 97);
            this.timeselect.Name = "timeselect";
            this.timeselect.ReadOnly = true;
            this.timeselect.Size = new System.Drawing.Size(140, 20);
            this.timeselect.TabIndex = 13;
            // 
            // Medicinetp
            // 
            this.Medicinetp.Location = new System.Drawing.Point(25, 135);
            this.Medicinetp.Name = "Medicinetp";
            this.Medicinetp.ReadOnly = true;
            this.Medicinetp.Size = new System.Drawing.Size(140, 20);
            this.Medicinetp.TabIndex = 12;
            // 
            // DoctorMenu
            // 
            this.DoctorMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DoctorMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkPatientToolStripMenuItem,
            this.signOutToolStripMenuItem,
            this.appointmentPatientToolStripMenuItem});
            this.DoctorMenu.Location = new System.Drawing.Point(0, 0);
            this.DoctorMenu.Name = "DoctorMenu";
            this.DoctorMenu.Size = new System.Drawing.Size(1015, 24);
            this.DoctorMenu.TabIndex = 13;
            this.DoctorMenu.Text = "menuStrip1";
            // 
            // checkPatientToolStripMenuItem
            // 
            this.checkPatientToolStripMenuItem.Name = "checkPatientToolStripMenuItem";
            this.checkPatientToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.checkPatientToolStripMenuItem.Text = "CheckPatient";
            this.checkPatientToolStripMenuItem.Click += new System.EventHandler(this.checkPatientToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // appointmentPatientToolStripMenuItem
            // 
            this.appointmentPatientToolStripMenuItem.Name = "appointmentPatientToolStripMenuItem";
            this.appointmentPatientToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.appointmentPatientToolStripMenuItem.Text = "Appointment Patient";
            this.appointmentPatientToolStripMenuItem.Click += new System.EventHandler(this.appointmentPatientToolStripMenuItem_Click);
            // 
            // DoctorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1015, 544);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Medicinetable);
            this.Controls.Add(this.Patientin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DName);
            this.Controls.Add(this.DID);
            this.Controls.Add(this.DoctorMenu);
            this.MainMenuStrip = this.DoctorMenu;
            this.Name = "DoctorMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorMainForm";
            this.Load += new System.EventHandler(this.DoctorMainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Patientin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Medicinetable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DoctorMenu.ResumeLayout(false);
            this.DoctorMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DID;
        private System.Windows.Forms.TextBox DName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Patientagetxt;
        private System.Windows.Forms.TextBox Patientnametxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Patientstatus;
        private System.Windows.Forms.DataGridView Patientin;
        private System.Windows.Forms.TextBox PatientGendertxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PatientIDtxt;
        private System.Windows.Forms.DataGridView Medicinetable;
        private System.Windows.Forms.RadioButton Morningbtn;
        private System.Windows.Forms.RadioButton MNbtn;
        private System.Windows.Forms.RadioButton MAFTNbtn;
        private System.Windows.Forms.TextBox TotalMedicine;
        private System.Windows.Forms.Button AddMedicine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Medicinetp;
        private System.Windows.Forms.TextBox timeselect;
        private System.Windows.Forms.Button Checkpatientbtn;
        private System.Windows.Forms.TextBox Patientmedicinee;
        private System.Windows.Forms.MenuStrip DoctorMenu;
        private System.Windows.Forms.ToolStripMenuItem checkPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentPatientToolStripMenuItem;
    }
}