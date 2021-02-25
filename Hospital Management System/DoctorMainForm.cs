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
    public partial class DoctorMainForm : Form
    {
        public DoctorMainForm(string nam)
        {
            InitializeComponent();
            DName.Text = nam;
        }
        SqlConnection cond = new SqlConnection(@"Data Source=DESKTOP-7NO3849\RIZWANSQL;Initial Catalog=HospitalDB;Integrated Security=True");
       
        private void DoctorMainForm_Load(object sender, EventArgs e)
        {
            doctorID();
            patientdin();
            Medicines();
        }
        public void doctorID()
        {
            cond.Open();
            try
            {
                string str = "select DoctorID from Doctortb WHERE DoctorName = '" + DName.Text + "'";
                SqlCommand cmd = new SqlCommand(str, cond);
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    this.DID.Text = sdr["DoctorID"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cond.Close();
        }

        public void patientdin()
        {
            using (SqlConnection c11 = new SqlConnection(@"Data Source=DESKTOP-7NO3849\RIZWANSQL;Initial Catalog=HospitalDB;Integrated Security=True"))
            {
                c11.Open();
                // Create new DataAdapter 
                using (SqlDataAdapter a11 = new SqlDataAdapter("select PatientID,PatientName,PatientAge,PatientGender from hpatienttb where PatientDisease = ''", cond))
                {

                    // Use DataAdapter to fill DataTable 
                    DataTable t11 = new DataTable();
                    a11.Fill(t11);
                    // Render data onto the screen 
                    Patientin.DataSource = t11;
                }
                c11.Close();
            }
        }

        private void Patientin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.Patientin.Rows[e.RowIndex];
                PatientIDtxt.Text = row.Cells[0].Value.ToString();
                Patientnametxt.Text = row.Cells[1].Value.ToString();
                Patientagetxt.Text = row.Cells[2].Value.ToString();
                PatientGendertxt.Text = row.Cells[3].Value.ToString();
            }
        }

        private void Medicinetable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Medicinetable.Rows[e.RowIndex];
                Medicinetp.Text = row.Cells[1].Value.ToString();
            }
        }

        public void Medicines()
        {
            using (SqlConnection md = new SqlConnection(@"Data Source=DESKTOP-7NO3849\RIZWANSQL;Initial Catalog=HospitalDB;Integrated Security=True"))
            {
                md.Open();
                // Create new DataAdapter 
                using (SqlDataAdapter am1 = new SqlDataAdapter("select * from Medicinetb", cond))
                {

                    // Use DataAdapter to fill DataTable 
                    DataTable tm1 = new DataTable();
                    am1.Fill(tm1);
                    // Render data onto the screen 
                    Medicinetable.DataSource = tm1;
                }
                md.Close();
            }
        }

        private void AddMedicine_Click(object sender, EventArgs e)
        {
            Patientmedicinee.Text += Medicinetp.Text + " " + TotalMedicine.Text + " " + timeselect.Text + Environment.NewLine;

        }

        private void Morningbtn_CheckedChanged(object sender, EventArgs e)
        {
            if(Morningbtn.Checked==true)
            {
                timeselect.Text = "Morning";
            }
        }

        private void MNbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (MNbtn.Checked == true)
            {
                timeselect.Text = "Morning-Night";
            }
        }

        private void MAFTNbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (MAFTNbtn.Checked == true)
            {
                timeselect.Text = "Morning-Afternoon-night";
            }
        }

        private void Checkpatientbtn_Click(object sender, EventArgs e)
        {
            cond.Open();
            try
            {
                String updatecommandad = "Update hpatienttb set PatientDisease = '" + this.Patientmedicinee.Text + "' , DoctorID = '" + this.DID.Text + "' , PatientStatus = '" + this.Patientstatus.Text + "' where PatientID = '" + this.PatientIDtxt.Text + "';";
                SqlCommand updatecommand1ad;
                updatecommand1ad = new SqlCommand(updatecommandad, cond);
                SqlDataAdapter Updateadaptor = new SqlDataAdapter(updatecommandad, cond);
                Updateadaptor.UpdateCommand = new SqlCommand(updatecommandad, cond);
                Updateadaptor.UpdateCommand.ExecuteNonQuery();

                patientdin();
                MessageBox.Show("Pateint Check SuccessFully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cond.Close();
        }

        private void checkPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorCheckpatientlist b = new DoctorCheckpatientlist(DName.Text);
            this.Visible = false;
            b.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainLoginForm mlg = new MainLoginForm();
            this.Visible = false;
            mlg.ShowDialog();
        }

        private void appointmentPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckAppointmentPatient chk = new CheckAppointmentPatient(DName.Text);
            this.Visible = false;
            chk.ShowDialog();
        }
    }
}
