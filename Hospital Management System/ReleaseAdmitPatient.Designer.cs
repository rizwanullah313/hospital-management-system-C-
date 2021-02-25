namespace Hospital_Management_System
{
    partial class ReleaseAdmitPatient
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
            this.Admitpatientrelease = new System.Windows.Forms.GroupBox();
            this.AdmitDatetxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BillPaidbtn = new System.Windows.Forms.Button();
            this.TotalBilltxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Totaldaysadmit = new System.Windows.Forms.TextBox();
            this.Apatientcell = new System.Windows.Forms.TextBox();
            this.Apatientnametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.APatientID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PatientReleaseDate = new System.Windows.Forms.Label();
            this.ReleaseDate = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1AdmitMainMenu = new System.Windows.Forms.MenuStrip();
            this.aboutDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutReceptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wardsMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admitPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releasePatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Admitpatientrelease.SuspendLayout();
            this.menuStrip1AdmitMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Admitpatientrelease
            // 
            this.Admitpatientrelease.Controls.Add(this.AdmitDatetxt);
            this.Admitpatientrelease.Controls.Add(this.label6);
            this.Admitpatientrelease.Controls.Add(this.BillPaidbtn);
            this.Admitpatientrelease.Controls.Add(this.TotalBilltxt);
            this.Admitpatientrelease.Controls.Add(this.label5);
            this.Admitpatientrelease.Controls.Add(this.Totaldaysadmit);
            this.Admitpatientrelease.Controls.Add(this.Apatientcell);
            this.Admitpatientrelease.Controls.Add(this.Apatientnametxt);
            this.Admitpatientrelease.Controls.Add(this.label4);
            this.Admitpatientrelease.Controls.Add(this.label3);
            this.Admitpatientrelease.Controls.Add(this.label2);
            this.Admitpatientrelease.Controls.Add(this.APatientID);
            this.Admitpatientrelease.Controls.Add(this.label1);
            this.Admitpatientrelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admitpatientrelease.Location = new System.Drawing.Point(110, 68);
            this.Admitpatientrelease.Name = "Admitpatientrelease";
            this.Admitpatientrelease.Size = new System.Drawing.Size(647, 433);
            this.Admitpatientrelease.TabIndex = 0;
            this.Admitpatientrelease.TabStop = false;
            this.Admitpatientrelease.Text = "Release Admit Patient";
            // 
            // AdmitDatetxt
            // 
            this.AdmitDatetxt.Location = new System.Drawing.Point(203, 215);
            this.AdmitDatetxt.Name = "AdmitDatetxt";
            this.AdmitDatetxt.ReadOnly = true;
            this.AdmitDatetxt.Size = new System.Drawing.Size(163, 26);
            this.AdmitDatetxt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Admit Date:";
            // 
            // BillPaidbtn
            // 
            this.BillPaidbtn.Location = new System.Drawing.Point(205, 380);
            this.BillPaidbtn.Name = "BillPaidbtn";
            this.BillPaidbtn.Size = new System.Drawing.Size(163, 38);
            this.BillPaidbtn.TabIndex = 10;
            this.BillPaidbtn.Text = "Paid";
            this.BillPaidbtn.UseVisualStyleBackColor = true;
            this.BillPaidbtn.Click += new System.EventHandler(this.BillPaidbtn_Click);
            // 
            // TotalBilltxt
            // 
            this.TotalBilltxt.Location = new System.Drawing.Point(205, 325);
            this.TotalBilltxt.Name = "TotalBilltxt";
            this.TotalBilltxt.ReadOnly = true;
            this.TotalBilltxt.Size = new System.Drawing.Size(163, 26);
            this.TotalBilltxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "TotalBill:";
            // 
            // Totaldaysadmit
            // 
            this.Totaldaysadmit.Location = new System.Drawing.Point(205, 270);
            this.Totaldaysadmit.Name = "Totaldaysadmit";
            this.Totaldaysadmit.ReadOnly = true;
            this.Totaldaysadmit.Size = new System.Drawing.Size(163, 26);
            this.Totaldaysadmit.TabIndex = 7;
            // 
            // Apatientcell
            // 
            this.Apatientcell.Location = new System.Drawing.Point(203, 161);
            this.Apatientcell.Name = "Apatientcell";
            this.Apatientcell.ReadOnly = true;
            this.Apatientcell.Size = new System.Drawing.Size(163, 26);
            this.Apatientcell.TabIndex = 6;
            // 
            // Apatientnametxt
            // 
            this.Apatientnametxt.Location = new System.Drawing.Point(203, 106);
            this.Apatientnametxt.Name = "Apatientnametxt";
            this.Apatientnametxt.ReadOnly = true;
            this.Apatientnametxt.Size = new System.Drawing.Size(163, 26);
            this.Apatientnametxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Day Admit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Patient Phone No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patient Name:";
            // 
            // APatientID
            // 
            this.APatientID.FormattingEnabled = true;
            this.APatientID.Location = new System.Drawing.Point(203, 49);
            this.APatientID.Name = "APatientID";
            this.APatientID.Size = new System.Drawing.Size(165, 28);
            this.APatientID.TabIndex = 1;
            this.APatientID.SelectedIndexChanged += new System.EventHandler(this.APatientID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admit Patient ID:";
            // 
            // PatientReleaseDate
            // 
            this.PatientReleaseDate.AutoSize = true;
            this.PatientReleaseDate.Location = new System.Drawing.Point(773, 43);
            this.PatientReleaseDate.Name = "PatientReleaseDate";
            this.PatientReleaseDate.Size = new System.Drawing.Size(35, 13);
            this.PatientReleaseDate.TabIndex = 1;
            this.PatientReleaseDate.Text = "label7";
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.Enabled = true;
            this.ReleaseDate.Tick += new System.EventHandler(this.ReleaseDate_Tick);
            // 
            // menuStrip1AdmitMainMenu
            // 
            this.menuStrip1AdmitMainMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1AdmitMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutDoctorToolStripMenuItem,
            this.aboutReceptionToolStripMenuItem,
            this.wardsMedicineToolStripMenuItem,
            this.admitPatientToolStripMenuItem,
            this.patientDetailsToolStripMenuItem,
            this.backToHomeToolStripMenuItem,
            this.signOutToolStripMenuItem,
            this.releasePatientToolStripMenuItem});
            this.menuStrip1AdmitMainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1AdmitMainMenu.Name = "menuStrip1AdmitMainMenu";
            this.menuStrip1AdmitMainMenu.Size = new System.Drawing.Size(941, 24);
            this.menuStrip1AdmitMainMenu.TabIndex = 10;
            this.menuStrip1AdmitMainMenu.Text = "menuStrip1";
            // 
            // aboutDoctorToolStripMenuItem
            // 
            this.aboutDoctorToolStripMenuItem.Image = global::Hospital_Management_System.Properties.Resources.images;
            this.aboutDoctorToolStripMenuItem.Name = "aboutDoctorToolStripMenuItem";
            this.aboutDoctorToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.aboutDoctorToolStripMenuItem.Text = "About Doctor";
            this.aboutDoctorToolStripMenuItem.Click += new System.EventHandler(this.aboutDoctorToolStripMenuItem_Click);
            // 
            // aboutReceptionToolStripMenuItem
            // 
            this.aboutReceptionToolStripMenuItem.Image = global::Hospital_Management_System.Properties.Resources.download__2_;
            this.aboutReceptionToolStripMenuItem.Name = "aboutReceptionToolStripMenuItem";
            this.aboutReceptionToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.aboutReceptionToolStripMenuItem.Text = "About Reception";
            this.aboutReceptionToolStripMenuItem.Click += new System.EventHandler(this.aboutReceptionToolStripMenuItem_Click);
            // 
            // wardsMedicineToolStripMenuItem
            // 
            this.wardsMedicineToolStripMenuItem.Image = global::Hospital_Management_System.Properties.Resources.download;
            this.wardsMedicineToolStripMenuItem.Name = "wardsMedicineToolStripMenuItem";
            this.wardsMedicineToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.wardsMedicineToolStripMenuItem.Text = "Wards & Medicine";
            this.wardsMedicineToolStripMenuItem.Click += new System.EventHandler(this.wardsMedicineToolStripMenuItem_Click);
            // 
            // admitPatientToolStripMenuItem
            // 
            this.admitPatientToolStripMenuItem.Image = global::Hospital_Management_System.Properties.Resources.download1;
            this.admitPatientToolStripMenuItem.Name = "admitPatientToolStripMenuItem";
            this.admitPatientToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.admitPatientToolStripMenuItem.Text = "Admit Patient";
            this.admitPatientToolStripMenuItem.Click += new System.EventHandler(this.admitPatientToolStripMenuItem_Click);
            // 
            // patientDetailsToolStripMenuItem
            // 
            this.patientDetailsToolStripMenuItem.Image = global::Hospital_Management_System.Properties.Resources.images1;
            this.patientDetailsToolStripMenuItem.Name = "patientDetailsToolStripMenuItem";
            this.patientDetailsToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.patientDetailsToolStripMenuItem.Text = "Patient Details";
            this.patientDetailsToolStripMenuItem.Click += new System.EventHandler(this.patientDetailsToolStripMenuItem_Click);
            // 
            // backToHomeToolStripMenuItem
            // 
            this.backToHomeToolStripMenuItem.Name = "backToHomeToolStripMenuItem";
            this.backToHomeToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.backToHomeToolStripMenuItem.Text = "Back To Home";
            this.backToHomeToolStripMenuItem.Click += new System.EventHandler(this.backToHomeToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // releasePatientToolStripMenuItem
            // 
            this.releasePatientToolStripMenuItem.Name = "releasePatientToolStripMenuItem";
            this.releasePatientToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.releasePatientToolStripMenuItem.Text = "Release Patient";
            this.releasePatientToolStripMenuItem.Click += new System.EventHandler(this.releasePatientToolStripMenuItem_Click);
            // 
            // ReleaseAdmitPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(941, 513);
            this.Controls.Add(this.menuStrip1AdmitMainMenu);
            this.Controls.Add(this.PatientReleaseDate);
            this.Controls.Add(this.Admitpatientrelease);
            this.Name = "ReleaseAdmitPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReleaseAdmitPatient";
            this.Load += new System.EventHandler(this.ReleaseAdmitPatient_Load);
            this.Admitpatientrelease.ResumeLayout(false);
            this.Admitpatientrelease.PerformLayout();
            this.menuStrip1AdmitMainMenu.ResumeLayout(false);
            this.menuStrip1AdmitMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Admitpatientrelease;
        private System.Windows.Forms.ComboBox APatientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Totaldaysadmit;
        private System.Windows.Forms.TextBox Apatientcell;
        private System.Windows.Forms.TextBox Apatientnametxt;
        private System.Windows.Forms.TextBox TotalBilltxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BillPaidbtn;
        private System.Windows.Forms.TextBox AdmitDatetxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label PatientReleaseDate;
        private System.Windows.Forms.Timer ReleaseDate;
        private System.Windows.Forms.MenuStrip menuStrip1AdmitMainMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutReceptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wardsMedicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admitPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releasePatientToolStripMenuItem;
    }
}