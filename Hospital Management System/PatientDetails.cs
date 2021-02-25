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
    public partial class PatientDetails : Form
    {
        public PatientDetails()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7NO3849\RIZWANSQL;Initial Catalog=HospitalDB;Integrated Security=True");

        private void PatientDetails_Load(object sender, EventArgs e)
        {
            patientdt();
        }
        public void patientdt()
        {
            using (SqlConnection c1 = new SqlConnection(@"Data Source=DESKTOP-7NO3849\RIZWANSQL;Initial Catalog=HospitalDB;Integrated Security=True"))
            {
                c1.Open();
                // Create new DataAdapter 
                using (SqlDataAdapter a1 = new SqlDataAdapter("SELECT * FROM hpatienttb", con))
                {

                    // Use DataAdapter to fill DataTable 
                    DataTable t1 = new DataTable();
                    a1.Fill(t1);
                    // Render data onto the screen 
                    PatientDetaill.DataSource = t1;
                }
                c1.Close();
            }
        }
        private void aboutDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDoctors ba1 = new AddDoctors();
            this.Visible = false;
            ba1.ShowDialog();
        }

        private void aboutReceptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReceptionist ba2 = new AddReceptionist();
            this.Visible = false;
            ba2.ShowDialog();
        }

        private void wardsMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicineMainform ba3 = new MedicineMainform();
            this.Visible = false;
            ba3.ShowDialog();
        }

        private void admitPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmitPatientForm ba4 = new AdmitPatientForm();
            this.Visible = false;
            ba4.ShowDialog();
        }

        private void patientDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientDetails ba0 = new PatientDetails();
            this.Visible = false;
            ba0.ShowDialog();
        }

        private void backToHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminMainForm ba1 = new AdminMainForm();
            this.Visible = false;
            ba1.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainLoginForm mlg = new MainLoginForm();
            this.Visible = false;
            mlg.ShowDialog();
        }

        private void releasePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseAdmitPatient rl = new ReleaseAdmitPatient();
            this.Visible = false;
            rl.ShowDialog();
        }
    }
}
