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
    public partial class DoctorCheckpatientlist : Form
    {
        public DoctorCheckpatientlist(string namee)
        {
            InitializeComponent();
            DName.Text = namee;
        }
        SqlConnection conid = new SqlConnection(@"Data Source=DESKTOP-7NO3849\RIZWANSQL;Initial Catalog=HospitalDB;Integrated Security=True");

        public void doctorIDD()
        {
            conid.Open();
            string str = "select DoctorID from Doctortb WHERE DoctorName = '" + DName.Text + "'";
            SqlCommand cmd = new SqlCommand(str, conid);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                this.DID.Text = sdr["DoctorID"].ToString();
            }
            else
            {
                //MessageBox.Show("Record Not Found");
            }
            conid.Close();
        }

        public void checkpatientlist()
        {
            using (SqlConnection md = new SqlConnection(@"Data Source=DESKTOP-7NO3849\RIZWANSQL;Initial Catalog=HospitalDB;Integrated Security=True"))
            {
                md.Open();
                // Create new DataAdapter 
                using (SqlDataAdapter am1 = new SqlDataAdapter("select * from hpatienttb where DoctorID = '" + this.DID.Text+"'", conid))
                {
                    // Use DataAdapter to fill DataTable 
                    DataTable tm1 = new DataTable();
                    am1.Fill(tm1);
                    // Render data onto the screen 
                    ChecklistofPatient.DataSource = tm1;
                }
                md.Close();
            }
        }
        public void checkpatientlistapp()
        {
            using (SqlConnection md = new SqlConnection(@"Data Source=DESKTOP-7NO3849\RIZWANSQL;Initial Catalog=HospitalDB;Integrated Security=True"))
            {
                md.Open();
                // Create new DataAdapter 
                using (SqlDataAdapter am1 = new SqlDataAdapter("select * from Appointmenttable where DoctorID = '" + this.DID.Text + "'", conid))
                {
                    // Use DataAdapter to fill DataTable 
                    DataTable tm1 = new DataTable();
                    am1.Fill(tm1);
                    // Render data onto the screen 
                    ChecklistofPatient.DataSource = tm1;
                }
                md.Close();
            }
        }

        private void DoctorCheckpatientlist_Load(object sender, EventArgs e)
        {
            doctorIDD();
        }

        private void BackToMainform_Click(object sender, EventArgs e)
        {
            DoctorMainForm dmm = new DoctorMainForm(DName.Text);
            this.Visible = false;
            dmm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainLoginForm mlg = new MainLoginForm();
            this.Visible = false;
            mlg.ShowDialog();
        }

        private void appointmentPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckAppointmentPatient chck = new CheckAppointmentPatient(DName.Text);
            this.Visible = false;
            chck.ShowDialog();
        }

        private void Patienttype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Patienttype.SelectedIndex == 0)
            {
                checkpatientlist();
            }
            if (Patienttype.SelectedIndex == 1)
            {
                checkpatientlistapp();
            }
        }
    }
}
