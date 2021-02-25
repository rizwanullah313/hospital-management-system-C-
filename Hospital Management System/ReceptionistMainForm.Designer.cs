namespace Hospital_Management_System
{
    partial class ReceptionistMainForm
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
            this.Doctorfee = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Insertbtn = new System.Windows.Forms.Button();
            this.PatientGenderFemale = new System.Windows.Forms.RadioButton();
            this.PatientGenderMale = new System.Windows.Forms.RadioButton();
            this.PatientAddress = new System.Windows.Forms.TextBox();
            this.PatientPhoneNo = new System.Windows.Forms.TextBox();
            this.PatientAgetxt = new System.Windows.Forms.TextBox();
            this.PatientNametxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTimelb = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RIDt = new System.Windows.Forms.TextBox();
            this.RIDy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.Doctorfee);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Insertbtn);
            this.groupBox1.Controls.Add(this.PatientGenderFemale);
            this.groupBox1.Controls.Add(this.PatientGenderMale);
            this.groupBox1.Controls.Add(this.PatientAddress);
            this.groupBox1.Controls.Add(this.PatientPhoneNo);
            this.groupBox1.Controls.Add(this.PatientAgetxt);
            this.groupBox1.Controls.Add(this.PatientNametxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(416, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(483, 485);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient In Reception";
            // 
            // Doctorfee
            // 
            this.Doctorfee.AutoSize = true;
            this.Doctorfee.Location = new System.Drawing.Point(219, 338);
            this.Doctorfee.Name = "Doctorfee";
            this.Doctorfee.Size = new System.Drawing.Size(48, 20);
            this.Doctorfee.TabIndex = 13;
            this.Doctorfee.Text = "500";
            this.Doctorfee.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Doctor Fees:";
            // 
            // Insertbtn
            // 
            this.Insertbtn.Location = new System.Drawing.Point(29, 383);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.Size = new System.Drawing.Size(107, 38);
            this.Insertbtn.TabIndex = 11;
            this.Insertbtn.Text = "Insert";
            this.Insertbtn.UseVisualStyleBackColor = true;
            this.Insertbtn.Click += new System.EventHandler(this.Insertbtn_Click);
            // 
            // PatientGenderFemale
            // 
            this.PatientGenderFemale.AutoSize = true;
            this.PatientGenderFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientGenderFemale.Location = new System.Drawing.Point(334, 170);
            this.PatientGenderFemale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PatientGenderFemale.Name = "PatientGenderFemale";
            this.PatientGenderFemale.Size = new System.Drawing.Size(80, 24);
            this.PatientGenderFemale.TabIndex = 10;
            this.PatientGenderFemale.TabStop = true;
            this.PatientGenderFemale.Text = "Female";
            this.PatientGenderFemale.UseVisualStyleBackColor = true;
            this.PatientGenderFemale.CheckedChanged += new System.EventHandler(this.PatientGenderFemale_CheckedChanged);
            // 
            // PatientGenderMale
            // 
            this.PatientGenderMale.AutoSize = true;
            this.PatientGenderMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientGenderMale.Location = new System.Drawing.Point(233, 170);
            this.PatientGenderMale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PatientGenderMale.Name = "PatientGenderMale";
            this.PatientGenderMale.Size = new System.Drawing.Size(61, 24);
            this.PatientGenderMale.TabIndex = 9;
            this.PatientGenderMale.TabStop = true;
            this.PatientGenderMale.Text = "Male";
            this.PatientGenderMale.UseVisualStyleBackColor = true;
            this.PatientGenderMale.CheckedChanged += new System.EventHandler(this.PatientGenderMale_CheckedChanged);
            // 
            // PatientAddress
            // 
            this.PatientAddress.Location = new System.Drawing.Point(218, 286);
            this.PatientAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PatientAddress.Name = "PatientAddress";
            this.PatientAddress.Size = new System.Drawing.Size(250, 22);
            this.PatientAddress.TabIndex = 8;
            // 
            // PatientPhoneNo
            // 
            this.PatientPhoneNo.Location = new System.Drawing.Point(218, 226);
            this.PatientPhoneNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PatientPhoneNo.Name = "PatientPhoneNo";
            this.PatientPhoneNo.Size = new System.Drawing.Size(248, 22);
            this.PatientPhoneNo.TabIndex = 7;
            // 
            // PatientAgetxt
            // 
            this.PatientAgetxt.Location = new System.Drawing.Point(218, 106);
            this.PatientAgetxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PatientAgetxt.Name = "PatientAgetxt";
            this.PatientAgetxt.Size = new System.Drawing.Size(250, 22);
            this.PatientAgetxt.TabIndex = 6;
            // 
            // PatientNametxt
            // 
            this.PatientNametxt.Location = new System.Drawing.Point(219, 49);
            this.PatientNametxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PatientNametxt.Name = "PatientNametxt";
            this.PatientNametxt.Size = new System.Drawing.Size(250, 22);
            this.PatientNametxt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 292);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Patient Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Patient Phone No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patient Gender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient Age:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Name:";
            // 
            // DateTimelb
            // 
            this.DateTimelb.AutoSize = true;
            this.DateTimelb.Location = new System.Drawing.Point(123, 43);
            this.DateTimelb.Name = "DateTimelb";
            this.DateTimelb.Size = new System.Drawing.Size(35, 13);
            this.DateTimelb.TabIndex = 2;
            this.DateTimelb.Text = "label6";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem,
            this.takeAppointmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1249, 24);
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
            // takeAppointmentToolStripMenuItem
            // 
            this.takeAppointmentToolStripMenuItem.Name = "takeAppointmentToolStripMenuItem";
            this.takeAppointmentToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.takeAppointmentToolStripMenuItem.Text = "Take Appointment";
            this.takeAppointmentToolStripMenuItem.Click += new System.EventHandler(this.takeAppointmentToolStripMenuItem_Click);
            // 
            // RIDt
            // 
            this.RIDt.Location = new System.Drawing.Point(126, 121);
            this.RIDt.Name = "RIDt";
            this.RIDt.ReadOnly = true;
            this.RIDt.Size = new System.Drawing.Size(100, 20);
            this.RIDt.TabIndex = 4;
            // 
            // RIDy
            // 
            this.RIDy.Location = new System.Drawing.Point(126, 163);
            this.RIDy.Name = "RIDy";
            this.RIDy.ReadOnly = true;
            this.RIDy.Size = new System.Drawing.Size(100, 20);
            this.RIDy.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Receptionist ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Receptionist Name:";
            // 
            // ReceptionistMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1249, 534);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RIDy);
            this.Controls.Add(this.RIDt);
            this.Controls.Add(this.DateTimelb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReceptionistMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceptionistMainForm";
            this.Load += new System.EventHandler(this.ReceptionistMainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PatientGenderFemale;
        private System.Windows.Forms.RadioButton PatientGenderMale;
        private System.Windows.Forms.TextBox PatientAddress;
        private System.Windows.Forms.TextBox PatientPhoneNo;
        private System.Windows.Forms.TextBox PatientAgetxt;
        private System.Windows.Forms.TextBox PatientNametxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Insertbtn;
        private System.Windows.Forms.Label DateTimelb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox Doctorfee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeAppointmentToolStripMenuItem;
        private System.Windows.Forms.TextBox RIDt;
        private System.Windows.Forms.TextBox RIDy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}