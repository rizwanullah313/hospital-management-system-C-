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
    public partial class TakeAppointment : Form
    {
        public TakeAppointment(String numh)
        {
            InitializeComponent();
            TimeToday.Start();
            RIDy1.Text = numh;
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7NO3849\RIZWANSQL;Initial Catalog=HospitalDB;Integrated Security=True");
        String Gender = "";
        private void TakeAppointment_Load(object sender, EventArgs e)
        {
            Doctortype();
            resID();
        }
        public void resID()
        {
            con.Open();
            try
            {
                string str = "select RID from Receptiontb WHERE ReceptionistName = '" + RIDy1.Text + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    this.RIDt1.Text = sdr["RID"].ToString();
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
            con.Open();
            try
            {
                SqlCommand commands;
                SqlDataAdapter adaptor = new SqlDataAdapter();
                String sqlap = "insert into Appointmenttable (AppatientName,apptientfathername,Appatientphoneno,appatientgender,appatientage,appatientaddress,Doctorid,Doctortype,Doctorname,Appointmentdate,todaydate,patientcheckstatus,RID) values ('" + this.Patientnametxt.Text + "','" + this.patientfnametxt.Text + "','" + this.Patientphoneno.Text + "','" + this.Gender + "','" + this.patientagetxt.Text + "','" + this.patientaddress.Text + "','" + this.DoctorIDtxt.Text + "','" + this.Doctortp.Text + "','" + this.Dnametxt.Text + "','" + this.appointmentdate.Text + "','" + this.Todaydatetime.Text + "','"+" "+"','"+this.RIDt1.Text+"')";
                commands = new SqlCommand(sqlap, con);
                adaptor.InsertCommand = new SqlCommand(sqlap, con);
                adaptor.InsertCommand.ExecuteNonQuery();
                commands.Dispose();


                this.Patientnametxt.Text = "";
                this.patientfnametxt.Text = "";
                this.Patientphoneno.Text = "";
                this.patientagetxt.Text = "";
                this.patientaddress.Text = "";
                this.DoctorIDtxt.Text = "";
                this.Doctortp.Text = "";
                this.DoctorName.Text = "";
                this.appointmentdate.Text = "";
                this.Todaydatetime.Text = "";
                MessageBox.Show("Record Insert SuccessFully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public void Dname()
        {
            using (SqlConnection c1 = new SqlConnection(@"Data Source=DESKTOP-7NO3849\RIZWANSQL;Initial Catalog=HospitalDB;Integrated Security=True"))
            {
                c1.Open();
                // Create new DataAdapter 
                using (SqlDataAdapter a1 = new SqlDataAdapter("SELECT DoctorID,DoctorName FROM Doctortb where Department = '" + Doctortp.Text + "'", con))
                {

                    // Use DataAdapter to fill DataTable 
                    DataTable t1 = new DataTable();
                    a1.Fill(t1);
                    // Render data onto the screen 
                    DoctorName.DataSource = t1;
                }
                c1.Close();
            }
        }

        public void Doctortype()
        {
            con.Open();
            string str = "select distinct Department from Doctortb ";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader sdr;
            try
            {
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    String tp = sdr["Department"].ToString();
                    Doctortp.Items.Add(tp);


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void Doctortp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dname();
        }

        private void DoctorName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DoctorName.Rows[e.RowIndex];
                DoctorIDtxt.Text = row.Cells[0].Value.ToString();
                Dnametxt.Text = row.Cells[1].Value.ToString();
            }
        }

        private void Malebtn_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void Femalebtn_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void TimeToday_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.Todaydatetime.Text = dt.ToString();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            this.Patientnametxt.Text = "";
            this.patientfnametxt.Text = "";
            this.Patientphoneno.Text = "";
            this.patientagetxt.Text = "";
            this.patientaddress.Text = "";
            this.DoctorIDtxt.Text = "";
            this.Doctortp.Text = "";
            this.DoctorName.Text = "";
            this.appointmentdate.Text = "";
            this.Todaydatetime.Text = "";
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainLoginForm mlg = new MainLoginForm();
            this.Visible = false;
            mlg.ShowDialog();
        }

        private void backToHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceptionistMainForm dmd = new ReceptionistMainForm(RIDy1.Text);
            this.Visible = false;
            dmd.ShowDialog();
        }
    }
}
