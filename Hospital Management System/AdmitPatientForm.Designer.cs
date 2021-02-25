namespace Hospital_Management_System
{
    partial class AdmitPatientForm
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
            this.ADpatientFemale = new System.Windows.Forms.RadioButton();
            this.ADpatientmale = new System.Windows.Forms.RadioButton();
            this.ADpatientAddress = new System.Windows.Forms.TextBox();
            this.ADpatientWardNo = new System.Windows.Forms.ComboBox();
            this.ADpatientDisease = new System.Windows.Forms.TextBox();
            this.ADpatientPhoneNo = new System.Windows.Forms.TextBox();
            this.ADpatientage = new System.Windows.Forms.TextBox();
            this.ADpatientnametxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Timetoday = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.AdmitPatientDetail = new System.Windows.Forms.DataGridView();
            this.DateTimeToday = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.Cleartxtbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Insertbtn = new System.Windows.Forms.Button();
            this.ADmitID = new System.Windows.Forms.TextBox();
            this.AdmitMainMenu = new System.Windows.Forms.MenuStrip();
            this.aboutDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutReceptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wardsMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admitPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releasePatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdmitPatientDetail)).BeginInit();
            this.panel2.SuspendLayout();
            this.AdmitMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.ADpatientFemale);
            this.groupBox1.Controls.Add(this.ADpatientmale);
            this.groupBox1.Controls.Add(this.ADpatientAddress);
            this.groupBox1.Controls.Add(this.ADpatientWardNo);
            this.groupBox1.Controls.Add(this.ADpatientDisease);
            this.groupBox1.Controls.Add(this.ADpatientPhoneNo);
            this.groupBox1.Controls.Add(this.ADpatientage);
            this.groupBox1.Controls.Add(this.ADpatientnametxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(71, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 401);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admit Patient";
            // 
            // ADpatientFemale
            // 
            this.ADpatientFemale.AutoSize = true;
            this.ADpatientFemale.Location = new System.Drawing.Point(365, 109);
            this.ADpatientFemale.Name = "ADpatientFemale";
            this.ADpatientFemale.Size = new System.Drawing.Size(80, 24);
            this.ADpatientFemale.TabIndex = 16;
            this.ADpatientFemale.TabStop = true;
            this.ADpatientFemale.Text = "Female";
            this.ADpatientFemale.UseVisualStyleBackColor = true;
            this.ADpatientFemale.CheckedChanged += new System.EventHandler(this.ADpatientFemale_CheckedChanged);
            // 
            // ADpatientmale
            // 
            this.ADpatientmale.AutoSize = true;
            this.ADpatientmale.Location = new System.Drawing.Point(259, 109);
            this.ADpatientmale.Name = "ADpatientmale";
            this.ADpatientmale.Size = new System.Drawing.Size(61, 24);
            this.ADpatientmale.TabIndex = 15;
            this.ADpatientmale.TabStop = true;
            this.ADpatientmale.Text = "Male";
            this.ADpatientmale.UseVisualStyleBackColor = true;
            this.ADpatientmale.CheckedChanged += new System.EventHandler(this.ADpatientmale_CheckedChanged);
            // 
            // ADpatientAddress
            // 
            this.ADpatientAddress.Location = new System.Drawing.Point(248, 338);
            this.ADpatientAddress.Name = "ADpatientAddress";
            this.ADpatientAddress.Size = new System.Drawing.Size(260, 26);
            this.ADpatientAddress.TabIndex = 14;
            // 
            // ADpatientWardNo
            // 
            this.ADpatientWardNo.FormattingEnabled = true;
            this.ADpatientWardNo.Location = new System.Drawing.Point(248, 291);
            this.ADpatientWardNo.Name = "ADpatientWardNo";
            this.ADpatientWardNo.Size = new System.Drawing.Size(262, 28);
            this.ADpatientWardNo.TabIndex = 13;
            // 
            // ADpatientDisease
            // 
            this.ADpatientDisease.Location = new System.Drawing.Point(248, 245);
            this.ADpatientDisease.Name = "ADpatientDisease";
            this.ADpatientDisease.Size = new System.Drawing.Size(258, 26);
            this.ADpatientDisease.TabIndex = 11;
            // 
            // ADpatientPhoneNo
            // 
            this.ADpatientPhoneNo.Location = new System.Drawing.Point(250, 200);
            this.ADpatientPhoneNo.Name = "ADpatientPhoneNo";
            this.ADpatientPhoneNo.Size = new System.Drawing.Size(258, 26);
            this.ADpatientPhoneNo.TabIndex = 10;
            // 
            // ADpatientage
            // 
            this.ADpatientage.Location = new System.Drawing.Point(250, 157);
            this.ADpatientage.Name = "ADpatientage";
            this.ADpatientage.Size = new System.Drawing.Size(258, 26);
            this.ADpatientage.TabIndex = 9;
            // 
            // ADpatientnametxt
            // 
            this.ADpatientnametxt.Location = new System.Drawing.Point(250, 60);
            this.ADpatientnametxt.Name = "ADpatientnametxt";
            this.ADpatientnametxt.Size = new System.Drawing.Size(258, 26);
            this.ADpatientnametxt.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Admit Patient Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Admit Patient WardNo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Admit Patient Disease:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Admit Patient PhoneNo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Admit Patient Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Admit Patient Gender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Admit Patient Name:";
            // 
            // Timetoday
            // 
            this.Timetoday.AutoSize = true;
            this.Timetoday.Location = new System.Drawing.Point(930, 47);
            this.Timetoday.Name = "Timetoday";
            this.Timetoday.Size = new System.Drawing.Size(35, 13);
            this.Timetoday.TabIndex = 1;
            this.Timetoday.Text = "label1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(828, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Date & Time:";
            // 
            // AdmitPatientDetail
            // 
            this.AdmitPatientDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdmitPatientDetail.Location = new System.Drawing.Point(12, 484);
            this.AdmitPatientDetail.Name = "AdmitPatientDetail";
            this.AdmitPatientDetail.Size = new System.Drawing.Size(1243, 199);
            this.AdmitPatientDetail.TabIndex = 4;
            // 
            // DateTimeToday
            // 
            this.DateTimeToday.Tick += new System.EventHandler(this.DateTimeToday_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.Searchbtn);
            this.panel2.Controls.Add(this.Cleartxtbtn);
            this.panel2.Controls.Add(this.Deletebtn);
            this.panel2.Controls.Add(this.Updatebtn);
            this.panel2.Controls.Add(this.Insertbtn);
            this.panel2.Location = new System.Drawing.Point(711, 134);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 304);
            this.panel2.TabIndex = 7;
            // 
            // Searchbtn
            // 
            this.Searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.Location = new System.Drawing.Point(16, 178);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(110, 48);
            this.Searchbtn.TabIndex = 5;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // Cleartxtbtn
            // 
            this.Cleartxtbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cleartxtbtn.Location = new System.Drawing.Point(16, 239);
            this.Cleartxtbtn.Name = "Cleartxtbtn";
            this.Cleartxtbtn.Size = new System.Drawing.Size(110, 45);
            this.Cleartxtbtn.TabIndex = 4;
            this.Cleartxtbtn.Text = "Clear";
            this.Cleartxtbtn.UseVisualStyleBackColor = true;
            this.Cleartxtbtn.Click += new System.EventHandler(this.Cleartxtbtn_Click_1);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(16, 121);
            this.Deletebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(110, 43);
            this.Deletebtn.TabIndex = 3;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click_1);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.Location = new System.Drawing.Point(16, 67);
            this.Updatebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(110, 42);
            this.Updatebtn.TabIndex = 2;
            this.Updatebtn.Text = "Upadate";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click_1);
            // 
            // Insertbtn
            // 
            this.Insertbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insertbtn.Location = new System.Drawing.Point(16, 11);
            this.Insertbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.Size = new System.Drawing.Size(110, 42);
            this.Insertbtn.TabIndex = 1;
            this.Insertbtn.Text = "Insert";
            this.Insertbtn.UseVisualStyleBackColor = true;
            this.Insertbtn.Click += new System.EventHandler(this.Insertbtn_Click_1);
            // 
            // ADmitID
            // 
            this.ADmitID.Location = new System.Drawing.Point(727, 90);
            this.ADmitID.Name = "ADmitID";
            this.ADmitID.Size = new System.Drawing.Size(100, 20);
            this.ADmitID.TabIndex = 8;
            // 
            // AdmitMainMenu
            // 
            this.AdmitMainMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AdmitMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutDoctorToolStripMenuItem,
            this.aboutReceptionToolStripMenuItem,
            this.wardsMedicineToolStripMenuItem,
            this.admitPatientToolStripMenuItem,
            this.patientDetailsToolStripMenuItem,
            this.backToHomeToolStripMenuItem,
            this.signOutToolStripMenuItem,
            this.releasePatientToolStripMenuItem});
            this.AdmitMainMenu.Location = new System.Drawing.Point(0, 0);
            this.AdmitMainMenu.Name = "AdmitMainMenu";
            this.AdmitMainMenu.Size = new System.Drawing.Size(1267, 24);
            this.AdmitMainMenu.TabIndex = 9;
            this.AdmitMainMenu.Text = "menuStrip1";
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
            // AdmitPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1267, 695);
            this.Controls.Add(this.AdmitMainMenu);
            this.Controls.Add(this.ADmitID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AdmitPatientDetail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Timetoday);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdmitPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AdmitPatientForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdmitPatientDetail)).EndInit();
            this.panel2.ResumeLayout(false);
            this.AdmitMainMenu.ResumeLayout(false);
            this.AdmitMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Timetoday;
        private System.Windows.Forms.RadioButton ADpatientFemale;
        private System.Windows.Forms.RadioButton ADpatientmale;
        private System.Windows.Forms.TextBox ADpatientAddress;
        private System.Windows.Forms.ComboBox ADpatientWardNo;
        private System.Windows.Forms.TextBox ADpatientDisease;
        private System.Windows.Forms.TextBox ADpatientPhoneNo;
        private System.Windows.Forms.TextBox ADpatientage;
        private System.Windows.Forms.TextBox ADpatientnametxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView AdmitPatientDetail;
        private System.Windows.Forms.Timer DateTimeToday;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Cleartxtbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Insertbtn;
        private System.Windows.Forms.TextBox ADmitID;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.MenuStrip AdmitMainMenu;
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