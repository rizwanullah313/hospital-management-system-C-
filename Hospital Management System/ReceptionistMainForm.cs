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
    public partial class ReceptionistMainForm : Form
    {
        public ReceptionistMainForm(String num)
        {
            InitializeComponent();
            timer1.Start();
            RIDy.Text = num;
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7NO3849\RIZWANSQL;Initial Catalog=HospitalDB;Integrated Security=True");
        String Gender = " ";

        public void resID()
        {
            con.Open();
            try
            {
                string str = "select RID from Receptiontb WHERE ReceptionistName = '" + RIDy.Text + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    this.RIDt.Text = sdr["RID"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            string abc = "";
            abc = RIDt.Text;
            con.Open();
            try
            {
                SqlCommand commandc;
                SqlDataAdapter adaptorc = new SqlDataAdapter();
                String sqlc = "insert into hpatienttb (PatientName,PatientAge,PatientGender,PatientAddress,PatientPhoneNo,PatientDisease,PatientBill,PatientStatus,DoctorID,PatientInDate,RID) values ('" + this.PatientNametxt.Text + "','" + this.PatientAgetxt.Text + "','" + this.Gender + "','" + this.PatientAddress.Text + "','" + this.PatientPhoneNo.Text + "','" + " " + "','" + this.Doctorfee.Text + "','" + " " + "','" + " " + "','" + this.DateTimelb.Text +"','"+abc+"')";
                commandc = new SqlCommand(sqlc, con);
                adaptorc.InsertCommand = new SqlCommand(sqlc, con);
                adaptorc.InsertCommand.ExecuteNonQuery();
                commandc.Dispose();

                this.PatientNametxt.Text = "";
                this.PatientAgetxt.Text = "";
                this.PatientAddress.Text = "";
                this.PatientPhoneNo.Text = "";
                this.Doctorfee.Text = "";
                this.DateTimelb.Text = "";

                MessageBox.Show("Record Insert Successfully");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void PatientGenderMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void PatientGenderFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.DateTimelb.Text = dt.ToString();
        }

        private void ReceptionistMainForm_Load(object sender, EventArgs e)
        {
            resID();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainLoginForm mlg = new MainLoginForm();
            this.Visible = false;
            mlg.ShowDialog();
        }

        private void takeAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TakeAppointment ta = new TakeAppointment(RIDy.Text);
            this.Visible = false;
            ta.ShowDialog();
        }
    }
}
