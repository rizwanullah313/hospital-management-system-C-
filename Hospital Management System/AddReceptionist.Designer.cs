namespace Hospital_Management_System
{
    partial class AddReceptionist
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClearTxtbtn = new System.Windows.Forms.Button();
            this.Insertbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.ReceptionistSearchtxt = new System.Windows.Forms.TextBox();
            this.ReceptionistAddresstxt = new System.Windows.Forms.TextBox();
            this.receptionistGenderFemale = new System.Windows.Forms.RadioButton();
            this.ReceptionistGenderMale = new System.Windows.Forms.RadioButton();
            this.ReceptionistPhoneNotxt = new System.Windows.Forms.TextBox();
            this.ReceptionistEmailtxt = new System.Windows.Forms.TextBox();
            this.ReceptionistPasswordtxt = new System.Windows.Forms.TextBox();
            this.DOJOfReceptionist = new System.Windows.Forms.DateTimePicker();
            this.ReceptionistSalarytxt = new System.Windows.Forms.TextBox();
            this.ReceptionistNametxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DOBOfReceptionist = new System.Windows.Forms.DateTimePicker();
            this.AddReceptionistDetails = new System.Windows.Forms.DataGridView();
            this.rIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionistPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfJoiningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionistGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionistAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionistEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionistPhoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionistSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptiontbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDBDataSet = new Hospital_Management_System.HospitalDBDataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.receptiontbTableAdapter = new Hospital_Management_System.HospitalDBDataSetTableAdapters.ReceptiontbTableAdapter();
            this.AdmitMainMenu = new System.Windows.Forms.MenuStrip();
            this.aboutDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutReceptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wardsMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admitPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releasePatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddReceptionistDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptiontbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.AdmitMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.ClearTxtbtn);
            this.panel1.Controls.Add(this.Insertbtn);
            this.panel1.Controls.Add(this.Updatebtn);
            this.panel1.Controls.Add(this.Deletebtn);
            this.panel1.Location = new System.Drawing.Point(1027, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(98, 195);
            this.panel1.TabIndex = 4;
            // 
            // ClearTxtbtn
            // 
            this.ClearTxtbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearTxtbtn.Location = new System.Drawing.Point(14, 152);
            this.ClearTxtbtn.Name = "ClearTxtbtn";
            this.ClearTxtbtn.Size = new System.Drawing.Size(70, 34);
            this.ClearTxtbtn.TabIndex = 3;
            this.ClearTxtbtn.Text = "Clear";
            this.ClearTxtbtn.UseVisualStyleBackColor = true;
            this.ClearTxtbtn.Click += new System.EventHandler(this.ClearTxtbtn_Click);
            // 
            // Insertbtn
            // 
            this.Insertbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insertbtn.Location = new System.Drawing.Point(12, 12);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.Size = new System.Drawing.Size(70, 34);
            this.Insertbtn.TabIndex = 0;
            this.Insertbtn.Text = "Insert";
            this.Insertbtn.UseVisualStyleBackColor = true;
            this.Insertbtn.Click += new System.EventHandler(this.Insertbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.Location = new System.Drawing.Point(12, 61);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(70, 34);
            this.Updatebtn.TabIndex = 1;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(14, 105);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(68, 34);
            this.Deletebtn.TabIndex = 2;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Searchbtn
            // 
            this.Searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.Location = new System.Drawing.Point(338, 244);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(75, 31);
            this.Searchbtn.TabIndex = 21;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // ReceptionistSearchtxt
            // 
            this.ReceptionistSearchtxt.Location = new System.Drawing.Point(209, 249);
            this.ReceptionistSearchtxt.Name = "ReceptionistSearchtxt";
            this.ReceptionistSearchtxt.Size = new System.Drawing.Size(100, 26);
            this.ReceptionistSearchtxt.TabIndex = 20;
            // 
            // ReceptionistAddresstxt
            // 
            this.ReceptionistAddresstxt.Location = new System.Drawing.Point(209, 205);
            this.ReceptionistAddresstxt.Name = "ReceptionistAddresstxt";
            this.ReceptionistAddresstxt.Size = new System.Drawing.Size(719, 26);
            this.ReceptionistAddresstxt.TabIndex = 19;
            // 
            // receptionistGenderFemale
            // 
            this.receptionistGenderFemale.AutoSize = true;
            this.receptionistGenderFemale.Location = new System.Drawing.Point(318, 82);
            this.receptionistGenderFemale.Name = "receptionistGenderFemale";
            this.receptionistGenderFemale.Size = new System.Drawing.Size(80, 24);
            this.receptionistGenderFemale.TabIndex = 18;
            this.receptionistGenderFemale.TabStop = true;
            this.receptionistGenderFemale.Text = "Female";
            this.receptionistGenderFemale.UseVisualStyleBackColor = true;
            this.receptionistGenderFemale.CheckedChanged += new System.EventHandler(this.receptionistGenderFemale_CheckedChanged);
            // 
            // ReceptionistGenderMale
            // 
            this.ReceptionistGenderMale.AutoSize = true;
            this.ReceptionistGenderMale.Location = new System.Drawing.Point(233, 82);
            this.ReceptionistGenderMale.Name = "ReceptionistGenderMale";
            this.ReceptionistGenderMale.Size = new System.Drawing.Size(61, 24);
            this.ReceptionistGenderMale.TabIndex = 17;
            this.ReceptionistGenderMale.TabStop = true;
            this.ReceptionistGenderMale.Text = "Male";
            this.ReceptionistGenderMale.UseVisualStyleBackColor = true;
            this.ReceptionistGenderMale.CheckedChanged += new System.EventHandler(this.ReceptionistGenderMale_CheckedChanged);
            // 
            // ReceptionistPhoneNotxt
            // 
            this.ReceptionistPhoneNotxt.Location = new System.Drawing.Point(729, 126);
            this.ReceptionistPhoneNotxt.Name = "ReceptionistPhoneNotxt";
            this.ReceptionistPhoneNotxt.Size = new System.Drawing.Size(200, 26);
            this.ReceptionistPhoneNotxt.TabIndex = 16;
            // 
            // ReceptionistEmailtxt
            // 
            this.ReceptionistEmailtxt.Location = new System.Drawing.Point(729, 85);
            this.ReceptionistEmailtxt.Name = "ReceptionistEmailtxt";
            this.ReceptionistEmailtxt.Size = new System.Drawing.Size(200, 26);
            this.ReceptionistEmailtxt.TabIndex = 15;
            // 
            // ReceptionistPasswordtxt
            // 
            this.ReceptionistPasswordtxt.Location = new System.Drawing.Point(729, 44);
            this.ReceptionistPasswordtxt.Name = "ReceptionistPasswordtxt";
            this.ReceptionistPasswordtxt.Size = new System.Drawing.Size(200, 26);
            this.ReceptionistPasswordtxt.TabIndex = 14;
            // 
            // DOJOfReceptionist
            // 
            this.DOJOfReceptionist.CustomFormat = "yyyy-MM-dd";
            this.DOJOfReceptionist.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOJOfReceptionist.Location = new System.Drawing.Point(210, 168);
            this.DOJOfReceptionist.Name = "DOJOfReceptionist";
            this.DOJOfReceptionist.Size = new System.Drawing.Size(212, 26);
            this.DOJOfReceptionist.TabIndex = 13;
            // 
            // ReceptionistSalarytxt
            // 
            this.ReceptionistSalarytxt.Location = new System.Drawing.Point(729, 168);
            this.ReceptionistSalarytxt.Name = "ReceptionistSalarytxt";
            this.ReceptionistSalarytxt.Size = new System.Drawing.Size(200, 26);
            this.ReceptionistSalarytxt.TabIndex = 11;
            // 
            // ReceptionistNametxt
            // 
            this.ReceptionistNametxt.Location = new System.Drawing.Point(210, 40);
            this.ReceptionistNametxt.Name = "ReceptionistNametxt";
            this.ReceptionistNametxt.Size = new System.Drawing.Size(212, 26);
            this.ReceptionistNametxt.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Search Receptionist:";
            // 
            // DOBOfReceptionist
            // 
            this.DOBOfReceptionist.CustomFormat = "yyyy-MM-dd";
            this.DOBOfReceptionist.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOBOfReceptionist.Location = new System.Drawing.Point(210, 124);
            this.DOBOfReceptionist.Name = "DOBOfReceptionist";
            this.DOBOfReceptionist.Size = new System.Drawing.Size(212, 26);
            this.DOBOfReceptionist.TabIndex = 12;
            // 
            // AddReceptionistDetails
            // 
            this.AddReceptionistDetails.AutoGenerateColumns = false;
            this.AddReceptionistDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddReceptionistDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rIDDataGridViewTextBoxColumn,
            this.receptionistNameDataGridViewTextBoxColumn,
            this.receptionistPasswordDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.dateOfJoiningDataGridViewTextBoxColumn,
            this.receptionistGenderDataGridViewTextBoxColumn,
            this.receptionistAddressDataGridViewTextBoxColumn,
            this.receptionistEmailDataGridViewTextBoxColumn,
            this.receptionistPhoneNoDataGridViewTextBoxColumn,
            this.receptionistSalaryDataGridViewTextBoxColumn});
            this.AddReceptionistDetails.DataSource = this.receptiontbBindingSource;
            this.AddReceptionistDetails.Location = new System.Drawing.Point(22, 337);
            this.AddReceptionistDetails.Name = "AddReceptionistDetails";
            this.AddReceptionistDetails.Size = new System.Drawing.Size(1103, 211);
            this.AddReceptionistDetails.TabIndex = 5;
            // 
            // rIDDataGridViewTextBoxColumn
            // 
            this.rIDDataGridViewTextBoxColumn.DataPropertyName = "RID";
            this.rIDDataGridViewTextBoxColumn.HeaderText = "RID";
            this.rIDDataGridViewTextBoxColumn.Name = "rIDDataGridViewTextBoxColumn";
            this.rIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // receptionistNameDataGridViewTextBoxColumn
            // 
            this.receptionistNameDataGridViewTextBoxColumn.DataPropertyName = "ReceptionistName";
            this.receptionistNameDataGridViewTextBoxColumn.HeaderText = "ReceptionistName";
            this.receptionistNameDataGridViewTextBoxColumn.Name = "receptionistNameDataGridViewTextBoxColumn";
            this.receptionistNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // receptionistPasswordDataGridViewTextBoxColumn
            // 
            this.receptionistPasswordDataGridViewTextBoxColumn.DataPropertyName = "ReceptionistPassword";
            this.receptionistPasswordDataGridViewTextBoxColumn.HeaderText = "ReceptionistPassword";
            this.receptionistPasswordDataGridViewTextBoxColumn.Name = "receptionistPasswordDataGridViewTextBoxColumn";
            this.receptionistPasswordDataGridViewTextBoxColumn.Width = 115;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 90;
            // 
            // dateOfJoiningDataGridViewTextBoxColumn
            // 
            this.dateOfJoiningDataGridViewTextBoxColumn.DataPropertyName = "DateOfJoining";
            this.dateOfJoiningDataGridViewTextBoxColumn.HeaderText = "DateOfJoining";
            this.dateOfJoiningDataGridViewTextBoxColumn.Name = "dateOfJoiningDataGridViewTextBoxColumn";
            this.dateOfJoiningDataGridViewTextBoxColumn.Width = 90;
            // 
            // receptionistGenderDataGridViewTextBoxColumn
            // 
            this.receptionistGenderDataGridViewTextBoxColumn.DataPropertyName = "ReceptionistGender";
            this.receptionistGenderDataGridViewTextBoxColumn.HeaderText = "ReceptionistGender";
            this.receptionistGenderDataGridViewTextBoxColumn.Name = "receptionistGenderDataGridViewTextBoxColumn";
            // 
            // receptionistAddressDataGridViewTextBoxColumn
            // 
            this.receptionistAddressDataGridViewTextBoxColumn.DataPropertyName = "ReceptionistAddress";
            this.receptionistAddressDataGridViewTextBoxColumn.HeaderText = "ReceptionistAddress";
            this.receptionistAddressDataGridViewTextBoxColumn.Name = "receptionistAddressDataGridViewTextBoxColumn";
            this.receptionistAddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // receptionistEmailDataGridViewTextBoxColumn
            // 
            this.receptionistEmailDataGridViewTextBoxColumn.DataPropertyName = "ReceptionistEmail";
            this.receptionistEmailDataGridViewTextBoxColumn.HeaderText = "ReceptionistEmail";
            this.receptionistEmailDataGridViewTextBoxColumn.Name = "receptionistEmailDataGridViewTextBoxColumn";
            this.receptionistEmailDataGridViewTextBoxColumn.Width = 130;
            // 
            // receptionistPhoneNoDataGridViewTextBoxColumn
            // 
            this.receptionistPhoneNoDataGridViewTextBoxColumn.DataPropertyName = "ReceptionistPhoneNo";
            this.receptionistPhoneNoDataGridViewTextBoxColumn.HeaderText = "ReceptionistPhoneNo";
            this.receptionistPhoneNoDataGridViewTextBoxColumn.Name = "receptionistPhoneNoDataGridViewTextBoxColumn";
            // 
            // receptionistSalaryDataGridViewTextBoxColumn
            // 
            this.receptionistSalaryDataGridViewTextBoxColumn.DataPropertyName = "ReceptionistSalary";
            this.receptionistSalaryDataGridViewTextBoxColumn.HeaderText = "ReceptionistSalary";
            this.receptionistSalaryDataGridViewTextBoxColumn.Name = "receptionistSalaryDataGridViewTextBoxColumn";
            // 
            // receptiontbBindingSource
            // 
            this.receptiontbBindingSource.DataMember = "Receptiontb";
            this.receptiontbBindingSource.DataSource = this.hospitalDBDataSet;
            // 
            // hospitalDBDataSet
            // 
            this.hospitalDBDataSet.DataSetName = "HospitalDBDataSet";
            this.hospitalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Receptionist Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(536, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Receptionist Salary:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(536, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Receptionist PhoneNo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date Of Joining:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Redeptionist Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Receptionist Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Receptionist Gender:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receptionist Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date Of Birth:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.Searchbtn);
            this.groupBox1.Controls.Add(this.ReceptionistSearchtxt);
            this.groupBox1.Controls.Add(this.ReceptionistAddresstxt);
            this.groupBox1.Controls.Add(this.receptionistGenderFemale);
            this.groupBox1.Controls.Add(this.ReceptionistGenderMale);
            this.groupBox1.Controls.Add(this.ReceptionistPhoneNotxt);
            this.groupBox1.Controls.Add(this.ReceptionistEmailtxt);
            this.groupBox1.Controls.Add(this.ReceptionistPasswordtxt);
            this.groupBox1.Controls.Add(this.DOJOfReceptionist);
            this.groupBox1.Controls.Add(this.DOBOfReceptionist);
            this.groupBox1.Controls.Add(this.ReceptionistSalarytxt);
            this.groupBox1.Controls.Add(this.ReceptionistNametxt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 291);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD Receptionist";
            // 
            // receptiontbTableAdapter
            // 
            this.receptiontbTableAdapter.ClearBeforeFill = true;
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
            this.AdmitMainMenu.Size = new System.Drawing.Size(1146, 24);
            this.AdmitMainMenu.TabIndex = 6;
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
            // AddReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1146, 560);
            this.Controls.Add(this.AdmitMainMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddReceptionistDetails);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddReceptionist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddReceptionist";
            this.Load += new System.EventHandler(this.AddReceptionist_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddReceptionistDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptiontbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.AdmitMainMenu.ResumeLayout(false);
            this.AdmitMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClearTxtbtn;
        private System.Windows.Forms.Button Insertbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox ReceptionistSearchtxt;
        private System.Windows.Forms.TextBox ReceptionistAddresstxt;
        private System.Windows.Forms.RadioButton receptionistGenderFemale;
        private System.Windows.Forms.RadioButton ReceptionistGenderMale;
        private System.Windows.Forms.TextBox ReceptionistPhoneNotxt;
        private System.Windows.Forms.TextBox ReceptionistEmailtxt;
        private System.Windows.Forms.TextBox ReceptionistPasswordtxt;
        private System.Windows.Forms.DateTimePicker DOJOfReceptionist;
        private System.Windows.Forms.TextBox ReceptionistSalarytxt;
        private System.Windows.Forms.TextBox ReceptionistNametxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DOBOfReceptionist;
        private System.Windows.Forms.DataGridView AddReceptionistDetails;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private HospitalDBDataSet hospitalDBDataSet;
        private System.Windows.Forms.BindingSource receptiontbBindingSource;
        private HospitalDBDataSetTableAdapters.ReceptiontbTableAdapter receptiontbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionistNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionistPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfJoiningDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionistGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionistAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionistEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionistPhoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionistSalaryDataGridViewTextBoxColumn;
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