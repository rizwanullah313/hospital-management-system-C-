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
    public partial class AddReceptionist : Form
    {
        public AddReceptionist()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7NO3849\RIZWANSQL;Initial Catalog=HospitalDB;Integrated Security=True");
        String Gender = " ";

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                SqlCommand commandR;
                SqlDataAdapter adaptorR = new SqlDataAdapter();
                String sqlr = "insert into Receptiontb (ReceptionistName,ReceptionistPassword,DateOfBirth,DateOfJoining,ReceptionistGender,ReceptionistAddress,ReceptionistEmail,ReceptionistPhoneNo,ReceptionistSalary) values ('" + this.ReceptionistNametxt.Text + "','" + this.ReceptionistPasswordtxt.Text + "','" + this.DOBOfReceptionist.Text + "','" + this.DOJOfReceptionist.Text + "','" + this.Gender + "','" + this.ReceptionistAddresstxt.Text + "','" + this.ReceptionistEmailtxt.Text + "','" + this.ReceptionistPhoneNotxt.Text + "','" + this.ReceptionistSalarytxt.Text + "')";
                commandR = new SqlCommand(sqlr, con);
                adaptorR.InsertCommand = new SqlCommand(sqlr, con);
                adaptorR.InsertCommand.ExecuteNonQuery();
                commandR.Dispose();
                con.Close();

                ReceptionistDetails();
                ReceptionistNametxt.Text = "";
                ReceptionistPasswordtxt.Text = "";
                ReceptionistPhoneNotxt.Text = "";
                ReceptionistSalarytxt.Text = "";
                ReceptionistAddresstxt.Text = "";
                ReceptionistSearchtxt.Text = "";
                MessageBox.Show("Record SuccessFully Inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                String updatere = "Update Receptiontb set ReceptionistName = '" + this.ReceptionistNametxt.Text + "' , ReceptionistPassword = '" + this.ReceptionistPasswordtxt.Text + "' , DateOfBirth = '" + this.DOBOfReceptionist.Text + "' , DateOfJoining = '" + this.DOJOfReceptionist.Text + "' , ReceptionistGender = '" + this.Gender + "' , ReceptionistAddress = '" + this.ReceptionistAddresstxt.Text + "' , ReceptionistEmail = '" + this.ReceptionistEmailtxt.Text + "' , ReceptionistPhoneNo = '" + this.ReceptionistPhoneNotxt.Text + "' , ReceptionistSalary = '" + this.ReceptionistSalarytxt.Text + "' where RID = '" + this.ReceptionistSearchtxt.Text + "';";
                SqlCommand updatecommand12;
                updatecommand12 = new SqlCommand(updatere, con);
                SqlDataAdapter UpdateadaptorR = new SqlDataAdapter(updatere, con);
                UpdateadaptorR.UpdateCommand = new SqlCommand(updatere, con);
                UpdateadaptorR.UpdateCommand.ExecuteNonQuery();
                con.Close();

                ReceptionistDetails();
                ReceptionistNametxt.Text = "";
                ReceptionistPasswordtxt.Text = "";
                ReceptionistPhoneNotxt.Text = "";
                ReceptionistSalarytxt.Text = "";
                ReceptionistAddresstxt.Text = "";
                ReceptionistSearchtxt.Text = "";
                MessageBox.Show("Record SuccessFully Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string deletere = "delete from receptiontb WHERE RID = '" + ReceptionistSearchtxt.Text + "'";
                SqlCommand deletecommand1;
                deletecommand1 = new SqlCommand(deletere, con);
                SqlDataAdapter deleteadaptor01 = new SqlDataAdapter(deletere, con);
                deleteadaptor01.DeleteCommand = new SqlCommand(deletere, con);
                deleteadaptor01.DeleteCommand.ExecuteNonQuery();
                con.Close();

                ReceptionistDetails();
                ReceptionistNametxt.Text = "";
                ReceptionistPasswordtxt.Text = "";
                ReceptionistPhoneNotxt.Text = "";
                ReceptionistSalarytxt.Text = "";
                ReceptionistAddresstxt.Text = "";
                ReceptionistSearchtxt.Text = "";
                MessageBox.Show("Record Delete SuccessFully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string st = "select * from Receptiontb WHERE RID = '" + ReceptionistSearchtxt.Text + "'";
            SqlCommand cmdr = new SqlCommand(st, con);
            SqlDataReader sd;
            sd = cmdr.ExecuteReader();
            if (sd.Read())
            {
                this.ReceptionistNametxt.Text = sd["ReceptionistName"].ToString();
                this.ReceptionistPasswordtxt.Text = sd["ReceptionistPassword"].ToString();
                this.DOBOfReceptionist.Text = sd["DateOfBirth"].ToString();
                this.DOJOfReceptionist.Text = sd["DateOfJoining"].ToString();
                this.Gender = sd["ReceptionistGender"].ToString();
                this.ReceptionistAddresstxt.Text = sd["ReceptionistAddress"].ToString();
                this.ReceptionistEmailtxt.Text = sd["ReceptionistEmail"].ToString();
                this.ReceptionistPhoneNotxt.Text = sd["ReceptionistPhoneNo"].ToString();
                this.ReceptionistSalarytxt.Text = sd["ReceptionistSalary"].ToString();
            }
            else
            {
                MessageBox.Show("Record Not Found");
            }
            con.Close();
        }

        private void ClearTxtbtn_Click(object sender, EventArgs e)
        {
            ReceptionistNametxt.Text = "";
            ReceptionistPasswordtxt.Text = "";
            ReceptionistPhoneNotxt.Text = "";
            ReceptionistSalarytxt.Text = "";
            ReceptionistAddresstxt.Text = "";
            ReceptionistSearchtxt.Text = "";
        }

        private void ReceptionistGenderMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void receptionistGenderFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        public void ReceptionistDetails()
        {
            using (SqlConnection c2 = new SqlConnection(@"Data Source=DESKTOP-7NO3849\RIZWANSQL;Initial Catalog=HospitalDB;Integrated Security=True"))
            {
                c2.Open();
                // Create new DataAdapter 
                using (SqlDataAdapter a2 = new SqlDataAdapter("SELECT * FROM Receptiontb", con))
                {

                    // Use DataAdapter to fill DataTable 
                    DataTable t2 = new DataTable();
                    a2.Fill(t2);
                    // Render data onto the screen 
                    AddReceptionistDetails.DataSource = t2;
                }
                c2.Close();
            }
        }

        private void AddReceptionist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDBDataSet.Receptiontb' table. You can move, or remove it, as needed.
            this.receptiontbTableAdapter.Fill(this.hospitalDBDataSet.Receptiontb);
            ReceptionistDetails();
        }

        private void aboutDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDoctors cc5 = new AddDoctors();
            this.Visible = false;
            cc5.ShowDialog();
        }

        private void aboutReceptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReceptionist cc4 = new AddReceptionist();
            this.Visible = false;
            cc4.ShowDialog();
        }

        private void wardsMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicineMainform cc3 = new MedicineMainform();
            this.Visible = false;
            cc3.ShowDialog();
        }

        private void admitPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmitPatientForm cc2 = new AdmitPatientForm();
            this.Visible = false;
            cc2.ShowDialog();
        }

        private void patientDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientDetails cc0 = new PatientDetails();
            this.Visible = false;
            cc0.ShowDialog();
        }

        private void backToHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminMainForm cc1 = new AdminMainForm();
            this.Visible = false;
            cc1.ShowDialog();
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
