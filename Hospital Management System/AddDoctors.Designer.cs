namespace Hospital_Management_System
{
    partial class AddDoctors
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
            this.label1 = new System.Windows.Forms.Label();
            this.JoinindDate = new System.Windows.Forms.DateTimePicker();
            this.AddDoctorDOB = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.DoctorSearchtxt = new System.Windows.Forms.TextBox();
            this.DoctorGenderFemale = new System.Windows.Forms.RadioButton();
            this.DoctorGenderMale = new System.Windows.Forms.RadioButton();
            this.AddDoctorPassword = new System.Windows.Forms.TextBox();
            this.AddDoctorNametxt = new System.Windows.Forms.TextBox();
            this.AddDoctorAddresstxt = new System.Windows.Forms.TextBox();
            this.AddDoctorEmail = new System.Windows.Forms.TextBox();
            this.AddDoctorSalary = new System.Windows.Forms.TextBox();
            this.AddDcotorPhoneNo = new System.Windows.Forms.TextBox();
            this.AddDoctorDepartment = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cleartxtbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Insertbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.AddDoctorGroupbox = new System.Windows.Forms.GroupBox();
            this.Doctorsdt = new System.Windows.Forms.DataGridView();
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofJoiningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorPhoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctortbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDBDataSet = new Hospital_Management_System.HospitalDBDataSet();
            this.doctortbTableAdapter = new Hospital_Management_System.HospitalDBDataSetTableAdapters.DoctortbTableAdapter();
            this.doctortbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AdmitMainMenu = new System.Windows.Forms.MenuStrip();
            this.aboutDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutReceptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wardsMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admitPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releasePatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.AddDoctorGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Doctorsdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctortbBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctortbBindingSource)).BeginInit();
            this.AdmitMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "Joining Date:";
            // 
            // JoinindDate
            // 
            this.JoinindDate.CustomFormat = "yyyy-MM-dd";
            this.JoinindDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.JoinindDate.Location = new System.Drawing.Point(226, 171);
            this.JoinindDate.Name = "JoinindDate";
            this.JoinindDate.Size = new System.Drawing.Size(181, 20);
            this.JoinindDate.TabIndex = 41;
            // 
            // AddDoctorDOB
            // 
            this.AddDoctorDOB.CustomFormat = "yyyy-MM-dd";
            this.AddDoctorDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AddDoctorDOB.Location = new System.Drawing.Point(691, 95);
            this.AddDoctorDOB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddDoctorDOB.Name = "AddDoctorDOB";
            this.AddDoctorDOB.Size = new System.Drawing.Size(180, 20);
            this.AddDoctorDOB.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 18);
            this.label11.TabIndex = 3;
            this.label11.Text = "Search Doctor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(475, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 18);
            this.label10.TabIndex = 38;
            this.label10.Text = "Doctor Phone No:";
            // 
            // Searchbtn
            // 
            this.Searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.Location = new System.Drawing.Point(347, 296);
            this.Searchbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(110, 32);
            this.Searchbtn.TabIndex = 0;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // DoctorSearchtxt
            // 
            this.DoctorSearchtxt.Location = new System.Drawing.Point(225, 299);
            this.DoctorSearchtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DoctorSearchtxt.Name = "DoctorSearchtxt";
            this.DoctorSearchtxt.Size = new System.Drawing.Size(99, 20);
            this.DoctorSearchtxt.TabIndex = 2;
            // 
            // DoctorGenderFemale
            // 
            this.DoctorGenderFemale.AutoSize = true;
            this.DoctorGenderFemale.Location = new System.Drawing.Point(347, 133);
            this.DoctorGenderFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DoctorGenderFemale.Name = "DoctorGenderFemale";
            this.DoctorGenderFemale.Size = new System.Drawing.Size(59, 17);
            this.DoctorGenderFemale.TabIndex = 37;
            this.DoctorGenderFemale.TabStop = true;
            this.DoctorGenderFemale.Text = "Female";
            this.DoctorGenderFemale.UseVisualStyleBackColor = true;
            this.DoctorGenderFemale.CheckedChanged += new System.EventHandler(this.DoctorGenderFemale_CheckedChanged);
            // 
            // DoctorGenderMale
            // 
            this.DoctorGenderMale.AutoSize = true;
            this.DoctorGenderMale.Location = new System.Drawing.Point(230, 133);
            this.DoctorGenderMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DoctorGenderMale.Name = "DoctorGenderMale";
            this.DoctorGenderMale.Size = new System.Drawing.Size(48, 17);
            this.DoctorGenderMale.TabIndex = 36;
            this.DoctorGenderMale.TabStop = true;
            this.DoctorGenderMale.Text = "Male";
            this.DoctorGenderMale.UseVisualStyleBackColor = true;
            this.DoctorGenderMale.CheckedChanged += new System.EventHandler(this.DoctorGenderMale_CheckedChanged);
            // 
            // AddDoctorPassword
            // 
            this.AddDoctorPassword.Location = new System.Drawing.Point(691, 39);
            this.AddDoctorPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddDoctorPassword.Name = "AddDoctorPassword";
            this.AddDoctorPassword.Size = new System.Drawing.Size(180, 20);
            this.AddDoctorPassword.TabIndex = 34;
            // 
            // AddDoctorNametxt
            // 
            this.AddDoctorNametxt.Location = new System.Drawing.Point(226, 41);
            this.AddDoctorNametxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddDoctorNametxt.Name = "AddDoctorNametxt";
            this.AddDoctorNametxt.Size = new System.Drawing.Size(180, 20);
            this.AddDoctorNametxt.TabIndex = 33;
            // 
            // AddDoctorAddresstxt
            // 
            this.AddDoctorAddresstxt.Location = new System.Drawing.Point(225, 258);
            this.AddDoctorAddresstxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddDoctorAddresstxt.Name = "AddDoctorAddresstxt";
            this.AddDoctorAddresstxt.Size = new System.Drawing.Size(646, 20);
            this.AddDoctorAddresstxt.TabIndex = 32;
            // 
            // AddDoctorEmail
            // 
            this.AddDoctorEmail.Location = new System.Drawing.Point(691, 152);
            this.AddDoctorEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddDoctorEmail.Name = "AddDoctorEmail";
            this.AddDoctorEmail.Size = new System.Drawing.Size(180, 20);
            this.AddDoctorEmail.TabIndex = 31;
            // 
            // AddDoctorSalary
            // 
            this.AddDoctorSalary.Location = new System.Drawing.Point(225, 218);
            this.AddDoctorSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddDoctorSalary.Name = "AddDoctorSalary";
            this.AddDoctorSalary.Size = new System.Drawing.Size(181, 20);
            this.AddDoctorSalary.TabIndex = 30;
            // 
            // AddDcotorPhoneNo
            // 
            this.AddDcotorPhoneNo.Location = new System.Drawing.Point(691, 206);
            this.AddDcotorPhoneNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddDcotorPhoneNo.Name = "AddDcotorPhoneNo";
            this.AddDcotorPhoneNo.Size = new System.Drawing.Size(180, 20);
            this.AddDcotorPhoneNo.TabIndex = 29;
            // 
            // AddDoctorDepartment
            // 
            this.AddDoctorDepartment.FormattingEnabled = true;
            this.AddDoctorDepartment.Items.AddRange(new object[] {
            "Surgen",
            "Skin",
            "Dental"});
            this.AddDoctorDepartment.Location = new System.Drawing.Point(226, 85);
            this.AddDoctorDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddDoctorDepartment.Name = "AddDoctorDepartment";
            this.AddDoctorDepartment.Size = new System.Drawing.Size(180, 21);
            this.AddDoctorDepartment.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 18);
            this.label9.TabIndex = 28;
            this.label9.Text = "Doctor Salary:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(475, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 18);
            this.label8.TabIndex = 27;
            this.label8.Text = "Doctor Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Doctor Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Date Of Birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Department:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(471, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Doctor Password:";
            // 
            // Cleartxtbtn
            // 
            this.Cleartxtbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cleartxtbtn.Location = new System.Drawing.Point(16, 180);
            this.Cleartxtbtn.Name = "Cleartxtbtn";
            this.Cleartxtbtn.Size = new System.Drawing.Size(110, 45);
            this.Cleartxtbtn.TabIndex = 4;
            this.Cleartxtbtn.Text = "Clear";
            this.Cleartxtbtn.UseVisualStyleBackColor = true;
            this.Cleartxtbtn.Click += new System.EventHandler(this.Cleartxtbtn_Click);
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
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
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
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
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
            this.Insertbtn.Click += new System.EventHandler(this.Insertbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.Cleartxtbtn);
            this.panel2.Controls.Add(this.Deletebtn);
            this.panel2.Controls.Add(this.Updatebtn);
            this.panel2.Controls.Add(this.Insertbtn);
            this.panel2.Location = new System.Drawing.Point(1058, 111);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 238);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Doctor Name:";
            // 
            // AddDoctorGroupbox
            // 
            this.AddDoctorGroupbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.AddDoctorGroupbox.Controls.Add(this.label1);
            this.AddDoctorGroupbox.Controls.Add(this.JoinindDate);
            this.AddDoctorGroupbox.Controls.Add(this.AddDoctorDOB);
            this.AddDoctorGroupbox.Controls.Add(this.label11);
            this.AddDoctorGroupbox.Controls.Add(this.label10);
            this.AddDoctorGroupbox.Controls.Add(this.Searchbtn);
            this.AddDoctorGroupbox.Controls.Add(this.DoctorSearchtxt);
            this.AddDoctorGroupbox.Controls.Add(this.DoctorGenderFemale);
            this.AddDoctorGroupbox.Controls.Add(this.DoctorGenderMale);
            this.AddDoctorGroupbox.Controls.Add(this.AddDoctorDepartment);
            this.AddDoctorGroupbox.Controls.Add(this.AddDoctorPassword);
            this.AddDoctorGroupbox.Controls.Add(this.AddDoctorNametxt);
            this.AddDoctorGroupbox.Controls.Add(this.AddDoctorAddresstxt);
            this.AddDoctorGroupbox.Controls.Add(this.AddDoctorEmail);
            this.AddDoctorGroupbox.Controls.Add(this.AddDoctorSalary);
            this.AddDoctorGroupbox.Controls.Add(this.AddDcotorPhoneNo);
            this.AddDoctorGroupbox.Controls.Add(this.label9);
            this.AddDoctorGroupbox.Controls.Add(this.label8);
            this.AddDoctorGroupbox.Controls.Add(this.label7);
            this.AddDoctorGroupbox.Controls.Add(this.label6);
            this.AddDoctorGroupbox.Controls.Add(this.label5);
            this.AddDoctorGroupbox.Controls.Add(this.label4);
            this.AddDoctorGroupbox.Controls.Add(this.label3);
            this.AddDoctorGroupbox.Controls.Add(this.label2);
            this.AddDoctorGroupbox.Location = new System.Drawing.Point(85, 58);
            this.AddDoctorGroupbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddDoctorGroupbox.Name = "AddDoctorGroupbox";
            this.AddDoctorGroupbox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddDoctorGroupbox.Size = new System.Drawing.Size(914, 343);
            this.AddDoctorGroupbox.TabIndex = 7;
            this.AddDoctorGroupbox.TabStop = false;
            this.AddDoctorGroupbox.Text = "AddDoctors";
            // 
            // Doctorsdt
            // 
            this.Doctorsdt.AutoGenerateColumns = false;
            this.Doctorsdt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Doctorsdt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorIDDataGridViewTextBoxColumn,
            this.doctorNameDataGridViewTextBoxColumn,
            this.doctorPasswordDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.dateofBirthDataGridViewTextBoxColumn,
            this.dateofJoiningDataGridViewTextBoxColumn,
            this.doctorGenderDataGridViewTextBoxColumn,
            this.doctorAddressDataGridViewTextBoxColumn,
            this.doctorEmailDataGridViewTextBoxColumn,
            this.doctorSalaryDataGridViewTextBoxColumn,
            this.doctorPhoneNoDataGridViewTextBoxColumn});
            this.Doctorsdt.DataSource = this.doctortbBindingSource1;
            this.Doctorsdt.Location = new System.Drawing.Point(20, 422);
            this.Doctorsdt.Name = "Doctorsdt";
            this.Doctorsdt.Size = new System.Drawing.Size(1238, 201);
            this.Doctorsdt.TabIndex = 8;
            // 
            // doctorIDDataGridViewTextBoxColumn
            // 
            this.doctorIDDataGridViewTextBoxColumn.DataPropertyName = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.HeaderText = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.Name = "doctorIDDataGridViewTextBoxColumn";
            this.doctorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.doctorIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // doctorNameDataGridViewTextBoxColumn
            // 
            this.doctorNameDataGridViewTextBoxColumn.DataPropertyName = "DoctorName";
            this.doctorNameDataGridViewTextBoxColumn.HeaderText = "DoctorName";
            this.doctorNameDataGridViewTextBoxColumn.Name = "doctorNameDataGridViewTextBoxColumn";
            this.doctorNameDataGridViewTextBoxColumn.Width = 140;
            // 
            // doctorPasswordDataGridViewTextBoxColumn
            // 
            this.doctorPasswordDataGridViewTextBoxColumn.DataPropertyName = "DoctorPassword";
            this.doctorPasswordDataGridViewTextBoxColumn.HeaderText = "DoctorPassword";
            this.doctorPasswordDataGridViewTextBoxColumn.Name = "doctorPasswordDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // dateofBirthDataGridViewTextBoxColumn
            // 
            this.dateofBirthDataGridViewTextBoxColumn.DataPropertyName = "DateofBirth";
            this.dateofBirthDataGridViewTextBoxColumn.HeaderText = "DateofBirth";
            this.dateofBirthDataGridViewTextBoxColumn.Name = "dateofBirthDataGridViewTextBoxColumn";
            this.dateofBirthDataGridViewTextBoxColumn.Width = 90;
            // 
            // dateofJoiningDataGridViewTextBoxColumn
            // 
            this.dateofJoiningDataGridViewTextBoxColumn.DataPropertyName = "DateofJoining";
            this.dateofJoiningDataGridViewTextBoxColumn.HeaderText = "DateofJoining";
            this.dateofJoiningDataGridViewTextBoxColumn.Name = "dateofJoiningDataGridViewTextBoxColumn";
            this.dateofJoiningDataGridViewTextBoxColumn.Width = 90;
            // 
            // doctorGenderDataGridViewTextBoxColumn
            // 
            this.doctorGenderDataGridViewTextBoxColumn.DataPropertyName = "DoctorGender";
            this.doctorGenderDataGridViewTextBoxColumn.HeaderText = "DoctorGender";
            this.doctorGenderDataGridViewTextBoxColumn.Name = "doctorGenderDataGridViewTextBoxColumn";
            // 
            // doctorAddressDataGridViewTextBoxColumn
            // 
            this.doctorAddressDataGridViewTextBoxColumn.DataPropertyName = "DoctorAddress";
            this.doctorAddressDataGridViewTextBoxColumn.HeaderText = "DoctorAddress";
            this.doctorAddressDataGridViewTextBoxColumn.Name = "doctorAddressDataGridViewTextBoxColumn";
            this.doctorAddressDataGridViewTextBoxColumn.Width = 180;
            // 
            // doctorEmailDataGridViewTextBoxColumn
            // 
            this.doctorEmailDataGridViewTextBoxColumn.DataPropertyName = "DoctorEmail";
            this.doctorEmailDataGridViewTextBoxColumn.HeaderText = "DoctorEmail";
            this.doctorEmailDataGridViewTextBoxColumn.Name = "doctorEmailDataGridViewTextBoxColumn";
            this.doctorEmailDataGridViewTextBoxColumn.Width = 120;
            // 
            // doctorSalaryDataGridViewTextBoxColumn
            // 
            this.doctorSalaryDataGridViewTextBoxColumn.DataPropertyName = "DoctorSalary";
            this.doctorSalaryDataGridViewTextBoxColumn.HeaderText = "DoctorSalary";
            this.doctorSalaryDataGridViewTextBoxColumn.Name = "doctorSalaryDataGridViewTextBoxColumn";
            // 
            // doctorPhoneNoDataGridViewTextBoxColumn
            // 
            this.doctorPhoneNoDataGridViewTextBoxColumn.DataPropertyName = "DoctorPhoneNo";
            this.doctorPhoneNoDataGridViewTextBoxColumn.HeaderText = "DoctorPhoneNo";
            this.doctorPhoneNoDataGridViewTextBoxColumn.Name = "doctorPhoneNoDataGridViewTextBoxColumn";
            this.doctorPhoneNoDataGridViewTextBoxColumn.Width = 115;
            // 
            // doctortbBindingSource1
            // 
            this.doctortbBindingSource1.DataMember = "Doctortb";
            this.doctortbBindingSource1.DataSource = this.hospitalDBDataSet;
            // 
            // hospitalDBDataSet
            // 
            this.hospitalDBDataSet.DataSetName = "HospitalDBDataSet";
            this.hospitalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctortbTableAdapter
            // 
            this.doctortbTableAdapter.ClearBeforeFill = true;
            // 
            // doctortbBindingSource
            // 
            this.doctortbBindingSource.DataMember = "Doctortb";
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
            this.AdmitMainMenu.Size = new System.Drawing.Size(1287, 24);
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
            // AddDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1287, 635);
            this.Controls.Add(this.AdmitMainMenu);
            this.Controls.Add(this.Doctorsdt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AddDoctorGroupbox);
            this.Name = "AddDoctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDoctors";
            this.Load += new System.EventHandler(this.AddDoctors_Load);
            this.panel2.ResumeLayout(false);
            this.AddDoctorGroupbox.ResumeLayout(false);
            this.AddDoctorGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Doctorsdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctortbBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctortbBindingSource)).EndInit();
            this.AdmitMainMenu.ResumeLayout(false);
            this.AdmitMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource doctortbBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker JoinindDate;
        private System.Windows.Forms.DateTimePicker AddDoctorDOB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox DoctorSearchtxt;
        private System.Windows.Forms.RadioButton DoctorGenderFemale;
        private System.Windows.Forms.RadioButton DoctorGenderMale;
        private System.Windows.Forms.TextBox AddDoctorPassword;
        private System.Windows.Forms.TextBox AddDoctorNametxt;
        private System.Windows.Forms.TextBox AddDoctorAddresstxt;
        private System.Windows.Forms.TextBox AddDoctorEmail;
        private System.Windows.Forms.TextBox AddDoctorSalary;
        private System.Windows.Forms.TextBox AddDcotorPhoneNo;
        private System.Windows.Forms.ComboBox AddDoctorDepartment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Cleartxtbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Insertbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox AddDoctorGroupbox;
        private System.Windows.Forms.DataGridView Doctorsdt;
        private HospitalDBDataSet hospitalDBDataSet;
        private System.Windows.Forms.BindingSource doctortbBindingSource1;
        private HospitalDBDataSetTableAdapters.DoctortbTableAdapter doctortbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofJoiningDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorPhoneNoDataGridViewTextBoxColumn;
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