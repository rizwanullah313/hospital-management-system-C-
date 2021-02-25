using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class MainLoginForm : Form
    {
        public MainLoginForm()
        {
            InitializeComponent();
        }
        SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-7NO3849\RIZWANSQL;Initial Catalog=HospitalDB;Integrated Security=True");
        public void Admin()
        {
            con1.Open();
            try
            {
                string stq = "select AdminName,AdminPassword from Admintb WHERE AdminName = '" + UserNametxt.Text + "' and AdminPassword = '" + UserPasswordtxt.Text + "'";
                SqlCommand cmd = new SqlCommand(stq, con1);
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                if (UserTypecombobox.SelectedIndex == 0)
                {
                    if (sdr.Read())
                    {
                        this.Visible = false;
                        AdminMainForm adm = new AdminMainForm();
                        adm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username and Password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con1.Close();
        }
        public void Doctor()
        {
            con1.Open();
            try
            {
                string str1 = "select DoctorName,DoctorPassword from Doctortb WHERE DoctorName = '" + UserNametxt.Text + "' and DoctorPassword = '" + UserPasswordtxt.Text + "'";
                SqlCommand cmd1 = new SqlCommand(str1, con1);
                SqlDataReader sdr1;
                sdr1 = cmd1.ExecuteReader();
                if (UserTypecombobox.SelectedIndex == 1)
                {
                    if (sdr1.Read())
                    {
                        this.Visible = false;
                        DoctorMainForm dm = new DoctorMainForm(UserNametxt.Text);
                        dm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username and Password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con1.Close();
        }
        public void Receptionist()
        {
            con1.Open();
            try
            {
                string str12 = "select ReceptionistName,ReceptionistPassword from Receptiontb WHERE ReceptionistName = '" + UserNametxt.Text + "' and ReceptionistPassword = '" + UserPasswordtxt.Text + "'";
                SqlCommand cmd12 = new SqlCommand(str12, con1);
                SqlDataReader sdr12;
                sdr12 = cmd12.ExecuteReader();
                if (UserTypecombobox.SelectedIndex == 2)
                {
                    if (sdr12.Read())
                    {
                        this.Visible = false;
                        ReceptionistMainForm rmf = new ReceptionistMainForm(UserNametxt.Text);
                        rmf.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username and Password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con1.Close();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            Admin();
            Doctor();
            Receptionist();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
