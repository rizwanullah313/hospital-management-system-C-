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
    public partial class MedicineMainform : Form
    {
        public MedicineMainform()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7NO3849\RIZWANSQL;Initial Catalog=HospitalDB;Integrated Security=True");

        private void Medicineinsertbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand commandm;
                SqlDataAdapter adaptorm = new SqlDataAdapter();
                String sql = "insert into Medicinetb (MedicineName) values ('" + MedicineNametxt.Text + "')";
                commandm = new SqlCommand(sql, conn);
                adaptorm.InsertCommand = new SqlCommand(sql, conn);
                adaptorm.InsertCommand.ExecuteNonQuery();
                commandm.Dispose();

                medicinedt();
                MessageBox.Show("Record Insert Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void Medicineupdatebtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                String updatecommand = "Update Medicinetb set MedicineName = '" + this.MedicineNametxt.Text + "' where MedicineID = '" + this.Medicineidtxt.Text + "';";
                SqlCommand updatecommand1;
                updatecommand1 = new SqlCommand(updatecommand, conn);
                SqlDataAdapter Updateadaptm = new SqlDataAdapter(updatecommand, conn);
                Updateadaptm.UpdateCommand = new SqlCommand(updatecommand, conn);
                Updateadaptm.UpdateCommand.ExecuteNonQuery();

                medicinedt();
                MessageBox.Show("Record Updates SuccessFully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

        }

        private void MedicineDeletebtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                string deletestm = "delete from Medicinetb WHERE MedicineID = '" + Medicineidtxt.Text + "'";
                SqlCommand deletecommand;
                deletecommand = new SqlCommand(deletestm, conn);
                SqlDataAdapter deleteadaptor = new SqlDataAdapter(deletestm, conn);
                deleteadaptor.DeleteCommand = new SqlCommand(deletestm, conn);
                deleteadaptor.DeleteCommand.ExecuteNonQuery();

                medicinedt();
                MessageBox.Show("Record delete SuccessFully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

        }

        private void MedicineMainform_Load(object sender, EventArgs e)
        {
            medicinedt();
            warddt();
        }
        public void medicinedt()
        {
            using (SqlConnection cm = new SqlConnection(@"Data Source=DESKTOP-7NO3849\RIZWANSQL;Initial Catalog=HospitalDB;Integrated Security=True"))
            {
                cm.Open();
                // Create new DataAdapter 
                using (SqlDataAdapter am = new SqlDataAdapter("SELECT * FROM Medicinetb", conn))
                {

                    // Use DataAdapter to fill DataTable 
                    DataTable tm = new DataTable();
                    am.Fill(tm);
                    // Render data onto the screen 
                    MedicineDetails.DataSource = tm;
                }
                cm.Close();
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            this.Medicineidtxt.Text = "";
            this.MedicineNametxt.Text = "";
            this.WardIDtxt.Text = "";
            this.WardNotxt.Text = "";

            String a = "";
            DoctorMainForm dd = new DoctorMainForm(a);
            dd.ShowDialog();
            this.Close();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand commandw;
                SqlDataAdapter adaptorw = new SqlDataAdapter();
                String sql = "insert into Wardtb (WARDNO) values ('" + WardNotxt.Text + "')";
                commandw = new SqlCommand(sql, conn);
                adaptorw.InsertCommand = new SqlCommand(sql, conn);
                adaptorw.InsertCommand.ExecuteNonQuery();
                commandw.Dispose();

                warddt();
                MessageBox.Show("Record Insert SuccessFully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void Deletewbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                string deletestw = "delete from Wardtb WHERE WARDID = '" + WardIDtxt.Text + "'";
                SqlCommand deletecommanw;
                deletecommanw = new SqlCommand(deletestw, conn);
                SqlDataAdapter deleteadaptor = new SqlDataAdapter(deletestw, conn);
                deleteadaptor.DeleteCommand = new SqlCommand(deletestw, conn);
                deleteadaptor.DeleteCommand.ExecuteNonQuery();

                warddt();
                MessageBox.Show("Record Delete SuccessFully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        public void warddt()
        {
            using (SqlConnection cmw = new SqlConnection(@"Data Source=DESKTOP-7NO3849\RIZWANSQL;Initial Catalog=HospitalDB;Integrated Security=True"))
            {
                cmw.Open();
                // Create new DataAdapter 
                using (SqlDataAdapter amw = new SqlDataAdapter("SELECT * FROM Wardtb", conn))
                {

                    // Use DataAdapter to fill DataTable 
                    DataTable tmw = new DataTable();
                    amw.Fill(tmw);
                    // Render data onto the screen 
                    Wards.DataSource = tmw;
                }
                cmw.Close();
            }
        }

        private void aboutDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDoctors dd5 = new AddDoctors();
            this.Visible = false;
            dd5.ShowDialog();
        }

        private void aboutReceptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReceptionist dd4 = new AddReceptionist();
            this.Visible = false;
            dd4.ShowDialog();
        }

        private void wardsMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicineMainform dd3 = new MedicineMainform();
            this.Visible = false;
            dd3.ShowDialog();
        }

        private void admitPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmitPatientForm dd2 = new AdmitPatientForm();
            this.Visible = false;
            dd2.ShowDialog();
        }

        private void patientDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientDetails dd0 = new PatientDetails();
            this.Visible = false;
            dd0.ShowDialog();
        }

        private void backToHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminMainForm dd1 = new AdminMainForm();
            this.Visible = false;
            dd1.ShowDialog();
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
