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
    public partial class CheckAppointmentPatient : Form
    {
        public CheckAppointmentPatient(string nameetxt)
        {
            InitializeComponent();
           this.DNametextdb.Text = nameetxt;
        }
SqlConnection conchk = new SqlConnection(@"Data Source=DESKTOP-7NO3849\RIZWANSQL;Initial Catalog=HospitalDB;Integrated Security=True");

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            conchk.Open();
            try
            {
                String upd = "Update Appointmenttable set PatientCheckStatus = '" + this.PAtientcheck + "' , DoctorCharges = '" + this.Doctorfee.Text + "' where Appointmentid = '" + this.PatientIDtxt.Text + "'";
                SqlCommand updatecommand1ad;
                updatecommand1ad = new SqlCommand(upd, conchk);
                SqlDataAdapter Update = new SqlDataAdapter(upd, conchk);
                Update.UpdateCommand = new SqlCommand(upd, conchk);
                Update.UpdateCommand.ExecuteNonQuery();
                AppointmentpatientDetails();
                this.PatientIDtxt.Text = "";
                this.PatientNametxt.Text = "";
                this.PatientFatherNametxt.Text = "";
                this.PatientGendertxt.Text = "";
                this.PatientAgetxt.Text = "";
                this.PatientAddresstxt.Text = "";
                this.DoctorIdtxt.Text = "";
                this.DoctorTypetxt.Text = "";
                this.DoctorNametxt.Text = "";
                this.Checkdate.Text = "";
                this.Appointmentdate.Text = "";
                this.Doctorfee.Text = "";
                this.PAtientcheck.Checked = false;
                this.PAtientPhoneNotxt.Text = "";
                MessageBox.Show("Pateint Check SuccessFully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conchk.Close();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            conchk.Open();
            string st = "select * from Appointmenttable WHERE Appointmentphoneno = '" + this.PAtientPhoneNotxt.Text + "'";
            SqlCommand cmdr = new SqlCommand(st, conchk);
            SqlDataReader sd;
            sd = cmdr.ExecuteReader();
            if (sd.Read())
            {
                this.PatientIDtxt.Text = sd["Appointmentid"].ToString();
                this.PatientNametxt.Text = sd["Appointmentname"].ToString();
                this.PatientFatherNametxt.Text = sd["Appointmentfathername"].ToString();
                this.PAtientPhoneNotxt.Text = sd["Appointmentphoneno"].ToString();
                this.PatientGendertxt.Text = sd["Appointmentgender"].ToString();
                this.PatientAgetxt.Text = sd["Appointmentage"].ToString();
                this.PatientAddresstxt.Text = sd["Appointmentaddress"].ToString();
                this.DoctorIdtxt.Text = sd["Doctorid"].ToString();
                this.DoctorTypetxt.Text = sd["Doctortype"].ToString();
                this.DoctorNametxt.Text = sd["Doctorname"].ToString();
                this.Checkdate.Text = sd["Appointmentdate"].ToString();
                this.Appointmentdate.Text = sd["todaydate"].ToString();
            }
            else
            {
                MessageBox.Show("Record Not Found");
            }
            conchk.Close();
        }

        public void AppointmentpatientDetails()
        {
            using (SqlConnection c2 = new SqlConnection(@"Data Source=DESKTOP-7NO3849\RIZWANSQL;Initial Catalog=HospitalDB;Integrated Security=True"))
            {
                c2.Open();
                // Create new DataAdapter 
                using (SqlDataAdapter a2 = new SqlDataAdapter("SELECT * FROM Appointmenttable where Patientcheckstatus = '"+ " " + "' and DoctorID = '" + this.Docid.Text +"'", conchk))
                {

                    // Use DataAdapter to fill DataTable 
                    DataTable t2 = new DataTable();
                    a2.Fill(t2);
                    // Render data onto the screen 
                    AppointmentPatientdt.DataSource = t2;
                }
                c2.Close();
            }
        }
        public void doctorIDD()
        {
            conchk.Open();
            string str = "select DoctorID from Doctortb WHERE DoctorName = '" + DNametextdb.Text + "'";
            SqlCommand cmd = new SqlCommand(str, conchk);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                this.Docid.Text = sdr["DoctorID"].ToString();
            }
            else
            {
                //MessageBox.Show("Record Not Found");
            }
            conchk.Close();
        }
        private void CheckAppointmentPatient_Load(object sender, EventArgs e)
        {
            doctorIDD();
            AppointmentpatientDetails();
        }

        private void AppointmentPatientdt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.AppointmentPatientdt.Rows[e.RowIndex];
                PatientIDtxt.Text = row.Cells[0].Value.ToString();
                PatientNametxt.Text = row.Cells[1].Value.ToString();
                PatientFatherNametxt.Text = row.Cells[2].Value.ToString();
                PAtientPhoneNotxt.Text = row.Cells[3].Value.ToString();

                PatientGendertxt.Text = row.Cells[4].Value.ToString();
                PatientAgetxt.Text = row.Cells[5].Value.ToString();
                PatientAddresstxt.Text = row.Cells[6].Value.ToString();
                DoctorIdtxt.Text = row.Cells[7].Value.ToString();

                DoctorTypetxt.Text = row.Cells[8].Value.ToString();
                DoctorNametxt.Text = row.Cells[9].Value.ToString();
                Checkdate.Text = row.Cells[10].Value.ToString();
                Appointmentdate.Text = row.Cells[11].Value.ToString();
            }
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainLoginForm bm = new MainLoginForm();
            this.Visible = false;
            bm.ShowDialog();
        }

        private void appointmentPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckAppointmentPatient bmc = new CheckAppointmentPatient(DNametextdb.Text);
            this.Visible = false;
            bmc.ShowDialog();
        }

        private void backToHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorMainForm dmb = new DoctorMainForm(DNametextdb.Text);
            this.Visible = false;
            dmb.ShowDialog();
        }

        private void checkPatientlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckAppointmentPatient chg = new CheckAppointmentPatient(DNametextdb.Text);
            this.Visible = false;
            this.ShowDialog();
        }
    }
}
