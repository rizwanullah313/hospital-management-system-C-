namespace Hospital_Management_System
{
    partial class MainLoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.UserPasswordtxt = new System.Windows.Forms.TextBox();
            this.UserNametxt = new System.Windows.Forms.TextBox();
            this.UserTypecombobox = new System.Windows.Forms.ComboBox();
            this.UserPassword = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.UserTypelb = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.Exitbtn);
            this.panel1.Controls.Add(this.Loginbtn);
            this.panel1.Controls.Add(this.UserPasswordtxt);
            this.panel1.Controls.Add(this.UserNametxt);
            this.panel1.Controls.Add(this.UserTypecombobox);
            this.panel1.Controls.Add(this.UserPassword);
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Controls.Add(this.UserTypelb);
            this.panel1.Location = new System.Drawing.Point(86, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 265);
            this.panel1.TabIndex = 2;
            // 
            // Exitbtn
            // 
            this.Exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.Location = new System.Drawing.Point(301, 208);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(75, 31);
            this.Exitbtn.TabIndex = 7;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Loginbtn
            // 
            this.Loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.Location = new System.Drawing.Point(218, 208);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(77, 31);
            this.Loginbtn.TabIndex = 6;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // UserPasswordtxt
            // 
            this.UserPasswordtxt.Location = new System.Drawing.Point(218, 165);
            this.UserPasswordtxt.Name = "UserPasswordtxt";
            this.UserPasswordtxt.Size = new System.Drawing.Size(158, 20);
            this.UserPasswordtxt.TabIndex = 5;
            this.UserPasswordtxt.UseSystemPasswordChar = true;
            // 
            // UserNametxt
            // 
            this.UserNametxt.BackColor = System.Drawing.SystemColors.Window;
            this.UserNametxt.Location = new System.Drawing.Point(218, 108);
            this.UserNametxt.Name = "UserNametxt";
            this.UserNametxt.Size = new System.Drawing.Size(158, 20);
            this.UserNametxt.TabIndex = 4;
            // 
            // UserTypecombobox
            // 
            this.UserTypecombobox.BackColor = System.Drawing.SystemColors.Window;
            this.UserTypecombobox.FormattingEnabled = true;
            this.UserTypecombobox.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Receptionist"});
            this.UserTypecombobox.Location = new System.Drawing.Point(218, 51);
            this.UserTypecombobox.Name = "UserTypecombobox";
            this.UserTypecombobox.Size = new System.Drawing.Size(158, 21);
            this.UserTypecombobox.TabIndex = 3;
            // 
            // UserPassword
            // 
            this.UserPassword.AutoSize = true;
            this.UserPassword.BackColor = System.Drawing.SystemColors.Window;
            this.UserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPassword.Location = new System.Drawing.Point(40, 161);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(155, 24);
            this.UserPassword.TabIndex = 2;
            this.UserPassword.Text = "User Password:";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.BackColor = System.Drawing.SystemColors.Window;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(40, 103);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(120, 24);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "User Name:";
            // 
            // UserTypelb
            // 
            this.UserTypelb.AutoSize = true;
            this.UserTypelb.BackColor = System.Drawing.SystemColors.Window;
            this.UserTypelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTypelb.Location = new System.Drawing.Point(44, 48);
            this.UserTypelb.Name = "UserTypelb";
            this.UserTypelb.Size = new System.Drawing.Size(112, 24);
            this.UserTypelb.TabIndex = 0;
            this.UserTypelb.Text = "User Type:";
            // 
            // MainLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(605, 500);
            this.Controls.Add(this.panel1);
            this.Name = "MainLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainLoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.TextBox UserPasswordtxt;
        private System.Windows.Forms.TextBox UserNametxt;
        private System.Windows.Forms.ComboBox UserTypecombobox;
        private System.Windows.Forms.Label UserPassword;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label UserTypelb;
    }
}