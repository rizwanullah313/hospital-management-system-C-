namespace Hospital_Management_System
{
    partial class MedicineMainform
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Medicine = new System.Windows.Forms.Label();
            this.Medicineidtxt = new System.Windows.Forms.TextBox();
            this.MedicineNametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.MedicineDeletebtn = new System.Windows.Forms.Button();
            this.Medicineupdatebtn = new System.Windows.Forms.Button();
            this.Medicineinsertbtn = new System.Windows.Forms.Button();
            this.MedicineDetails = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WardIDtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Deletewbtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.WardNotxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Wards = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutReceptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wardsMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admitPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdmitMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.releasePatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineDetails)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Wards)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.Medicine);
            this.groupBox1.Controls.Add(this.Medicineidtxt);
            this.groupBox1.Controls.Add(this.MedicineNametxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(58, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD Mediciene";
            // 
            // Medicine
            // 
            this.Medicine.AutoSize = true;
            this.Medicine.Location = new System.Drawing.Point(14, 38);
            this.Medicine.Name = "Medicine";
            this.Medicine.Size = new System.Drawing.Size(61, 13);
            this.Medicine.TabIndex = 5;
            this.Medicine.Text = "MedicineID";
            // 
            // Medicineidtxt
            // 
            this.Medicineidtxt.Location = new System.Drawing.Point(111, 34);
            this.Medicineidtxt.Name = "Medicineidtxt";
            this.Medicineidtxt.Size = new System.Drawing.Size(177, 20);
            this.Medicineidtxt.TabIndex = 4;
            // 
            // MedicineNametxt
            // 
            this.MedicineNametxt.Location = new System.Drawing.Point(111, 69);
            this.MedicineNametxt.Name = "MedicineNametxt";
            this.MedicineNametxt.Size = new System.Drawing.Size(177, 20);
            this.MedicineNametxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medicine Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.Clearbtn);
            this.panel1.Controls.Add(this.MedicineDeletebtn);
            this.panel1.Controls.Add(this.Medicineupdatebtn);
            this.panel1.Controls.Add(this.Medicineinsertbtn);
            this.panel1.Location = new System.Drawing.Point(75, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 194);
            this.panel1.TabIndex = 1;
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(16, 149);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(75, 23);
            this.Clearbtn.TabIndex = 3;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // MedicineDeletebtn
            // 
            this.MedicineDeletebtn.Location = new System.Drawing.Point(17, 110);
            this.MedicineDeletebtn.Name = "MedicineDeletebtn";
            this.MedicineDeletebtn.Size = new System.Drawing.Size(75, 23);
            this.MedicineDeletebtn.TabIndex = 2;
            this.MedicineDeletebtn.Text = "Delete";
            this.MedicineDeletebtn.UseVisualStyleBackColor = true;
            this.MedicineDeletebtn.Click += new System.EventHandler(this.MedicineDeletebtn_Click);
            // 
            // Medicineupdatebtn
            // 
            this.Medicineupdatebtn.Location = new System.Drawing.Point(16, 66);
            this.Medicineupdatebtn.Name = "Medicineupdatebtn";
            this.Medicineupdatebtn.Size = new System.Drawing.Size(75, 23);
            this.Medicineupdatebtn.TabIndex = 1;
            this.Medicineupdatebtn.Text = "Update";
            this.Medicineupdatebtn.UseVisualStyleBackColor = true;
            this.Medicineupdatebtn.Click += new System.EventHandler(this.Medicineupdatebtn_Click);
            // 
            // Medicineinsertbtn
            // 
            this.Medicineinsertbtn.Location = new System.Drawing.Point(14, 24);
            this.Medicineinsertbtn.Name = "Medicineinsertbtn";
            this.Medicineinsertbtn.Size = new System.Drawing.Size(75, 23);
            this.Medicineinsertbtn.TabIndex = 0;
            this.Medicineinsertbtn.Text = "Insert";
            this.Medicineinsertbtn.UseVisualStyleBackColor = true;
            this.Medicineinsertbtn.Click += new System.EventHandler(this.Medicineinsertbtn_Click);
            // 
            // MedicineDetails
            // 
            this.MedicineDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicineDetails.Location = new System.Drawing.Point(209, 258);
            this.MedicineDetails.Name = "MedicineDetails";
            this.MedicineDetails.Size = new System.Drawing.Size(235, 281);
            this.MedicineDetails.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox2.Controls.Add(this.WardIDtxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Deletewbtn);
            this.groupBox2.Controls.Add(this.Addbtn);
            this.groupBox2.Controls.Add(this.WardNotxt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(528, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 154);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Wards";
            // 
            // WardIDtxt
            // 
            this.WardIDtxt.Location = new System.Drawing.Point(100, 35);
            this.WardIDtxt.Name = "WardIDtxt";
            this.WardIDtxt.Size = new System.Drawing.Size(100, 20);
            this.WardIDtxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ward ID:";
            // 
            // Deletewbtn
            // 
            this.Deletewbtn.Location = new System.Drawing.Point(125, 108);
            this.Deletewbtn.Name = "Deletewbtn";
            this.Deletewbtn.Size = new System.Drawing.Size(75, 23);
            this.Deletewbtn.TabIndex = 3;
            this.Deletewbtn.Text = "DELETE";
            this.Deletewbtn.UseVisualStyleBackColor = true;
            this.Deletewbtn.Click += new System.EventHandler(this.Deletewbtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(36, 108);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(75, 23);
            this.Addbtn.TabIndex = 2;
            this.Addbtn.Text = "ADD";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // WardNotxt
            // 
            this.WardNotxt.Location = new System.Drawing.Point(100, 72);
            this.WardNotxt.Name = "WardNotxt";
            this.WardNotxt.Size = new System.Drawing.Size(100, 20);
            this.WardNotxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ward No:";
            // 
            // Wards
            // 
            this.Wards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Wards.Location = new System.Drawing.Point(528, 295);
            this.Wards.Name = "Wards";
            this.Wards.Size = new System.Drawing.Size(217, 244);
            this.Wards.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutDoctorToolStripMenuItem,
            this.aboutReceptionToolStripMenuItem,
            this.wardsMedicineToolStripMenuItem,
            this.admitPatientToolStripMenuItem,
            this.patientDetailsToolStripMenuItem,
            this.backToHomeToolStripMenuItem,
            this.AdmitMainMenu,
            this.releasePatientToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
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
            // AdmitMainMenu
            // 
            this.AdmitMainMenu.Name = "AdmitMainMenu";
            this.AdmitMainMenu.Size = new System.Drawing.Size(65, 20);
            this.AdmitMainMenu.Text = "Sign Out";
            this.AdmitMainMenu.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // releasePatientToolStripMenuItem
            // 
            this.releasePatientToolStripMenuItem.Name = "releasePatientToolStripMenuItem";
            this.releasePatientToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.releasePatientToolStripMenuItem.Text = "Release Patient";
            this.releasePatientToolStripMenuItem.Click += new System.EventHandler(this.releasePatientToolStripMenuItem_Click);
            // 
            // MedicineMainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(844, 551);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Wards);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.MedicineDetails);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MedicineMainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicineMainform";
            this.Load += new System.EventHandler(this.MedicineMainform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MedicineDetails)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Wards)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MedicineDeletebtn;
        private System.Windows.Forms.Button Medicineupdatebtn;
        private System.Windows.Forms.Button Medicineinsertbtn;
        private System.Windows.Forms.DataGridView MedicineDetails;
        private System.Windows.Forms.TextBox MedicineNametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Medicine;
        private System.Windows.Forms.TextBox Medicineidtxt;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Deletewbtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.TextBox WardNotxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Wards;
        private System.Windows.Forms.TextBox WardIDtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutReceptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wardsMedicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admitPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdmitMainMenu;
        private System.Windows.Forms.ToolStripMenuItem releasePatientToolStripMenuItem;
    }
}