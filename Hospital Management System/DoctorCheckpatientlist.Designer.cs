namespace Hospital_Management_System
{
    partial class DoctorCheckpatientlist
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
            this.ChecklistofPatient = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DName = new System.Windows.Forms.TextBox();
            this.DID = new System.Windows.Forms.TextBox();
            this.BackToMainform = new System.Windows.Forms.Button();
            this.DoctorMenu = new System.Windows.Forms.MenuStrip();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.Patienttype = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChecklistofPatient)).BeginInit();
            this.DoctorMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChecklistofPatient
            // 
            this.ChecklistofPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChecklistofPatient.Location = new System.Drawing.Point(25, 160);
            this.ChecklistofPatient.Name = "ChecklistofPatient";
            this.ChecklistofPatient.Size = new System.Drawing.Size(1231, 378);
            this.ChecklistofPatient.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Doctor Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "DoctorID :";
            // 
            // DName
            // 
            this.DName.Location = new System.Drawing.Point(403, 62);
            this.DName.Name = "DName";
            this.DName.ReadOnly = true;
            this.DName.Size = new System.Drawing.Size(105, 20);
            this.DName.TabIndex = 5;
            // 
            // DID
            // 
            this.DID.Location = new System.Drawing.Point(231, 62);
            this.DID.Name = "DID";
            this.DID.ReadOnly = true;
            this.DID.Size = new System.Drawing.Size(79, 20);
            this.DID.TabIndex = 4;
            // 
            // BackToMainform
            // 
            this.BackToMainform.BackColor = System.Drawing.SystemColors.Control;
            this.BackToMainform.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.BackToMainform.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMainform.Location = new System.Drawing.Point(25, 37);
            this.BackToMainform.Name = "BackToMainform";
            this.BackToMainform.Size = new System.Drawing.Size(61, 41);
            this.BackToMainform.TabIndex = 8;
            this.BackToMainform.Text = "<--";
            this.BackToMainform.UseVisualStyleBackColor = false;
            this.BackToMainform.Click += new System.EventHandler(this.BackToMainform_Click);
            // 
            // DoctorMenu
            // 
            this.DoctorMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DoctorMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem,
            this.appointmentPatientToolStripMenuItem});
            this.DoctorMenu.Location = new System.Drawing.Point(0, 0);
            this.DoctorMenu.Name = "DoctorMenu";
            this.DoctorMenu.Size = new System.Drawing.Size(1268, 24);
            this.DoctorMenu.TabIndex = 9;
            this.DoctorMenu.Text = "menuStrip1";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select Patient Type:";
            // 
            // Patienttype
            // 
            this.Patienttype.FormattingEnabled = true;
            this.Patienttype.Items.AddRange(new object[] {
            "OPD Patient",
            "Appointment Patient"});
            this.Patienttype.Location = new System.Drawing.Point(327, 113);
            this.Patienttype.Name = "Patienttype";
            this.Patienttype.Size = new System.Drawing.Size(181, 21);
            this.Patienttype.TabIndex = 11;
            this.Patienttype.SelectedIndexChanged += new System.EventHandler(this.Patienttype_SelectedIndexChanged);
            // 
            // DoctorCheckpatientlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 550);
            this.Controls.Add(this.Patienttype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BackToMainform);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DName);
            this.Controls.Add(this.DID);
            this.Controls.Add(this.ChecklistofPatient);
            this.Controls.Add(this.DoctorMenu);
            this.MainMenuStrip = this.DoctorMenu;
            this.Name = "DoctorCheckpatientlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorCheckpatientlist";
            this.Load += new System.EventHandler(this.DoctorCheckpatientlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChecklistofPatient)).EndInit();
            this.DoctorMenu.ResumeLayout(false);
            this.DoctorMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ChecklistofPatient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DName;
        private System.Windows.Forms.TextBox DID;
        private System.Windows.Forms.Button BackToMainform;
        private System.Windows.Forms.MenuStrip DoctorMenu;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentPatientToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Patienttype;
    }
}