namespace Hospital_Management_System
{
    partial class PatientDetails
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
            this.AdmitMainMenu = new System.Windows.Forms.MenuStrip();
            this.aboutDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutReceptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wardsMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admitPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releasePatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PatientDetaill = new System.Windows.Forms.DataGridView();
            this.AdmitMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDetaill)).BeginInit();
            this.SuspendLayout();
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
            this.AdmitMainMenu.Size = new System.Drawing.Size(1260, 24);
            this.AdmitMainMenu.TabIndex = 10;
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
            // PatientDetaill
            // 
            this.PatientDetaill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientDetaill.Location = new System.Drawing.Point(12, 55);
            this.PatientDetaill.Name = "PatientDetaill";
            this.PatientDetaill.Size = new System.Drawing.Size(1236, 368);
            this.PatientDetaill.TabIndex = 11;
            // 
            // PatientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 435);
            this.Controls.Add(this.PatientDetaill);
            this.Controls.Add(this.AdmitMainMenu);
            this.Name = "PatientDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientDetails";
            this.Load += new System.EventHandler(this.PatientDetails_Load);
            this.AdmitMainMenu.ResumeLayout(false);
            this.AdmitMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDetaill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AdmitMainMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutReceptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wardsMedicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admitPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToHomeToolStripMenuItem;
        private System.Windows.Forms.DataGridView PatientDetaill;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releasePatientToolStripMenuItem;
    }
}