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
    public partial class AddDoctors : Form
    {
        public AddDoctors()
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
                SqlCommand command;
                SqlDataAdapter adaptor = new SqlDataAdapter();
                String sql = "insert into Doctortb (DoctorName,DoctorPassword,Department,DateOfBirth,DateOfJoining,DoctorGender,DoctorAddress,DoctorEmail,DoctorSalary,DoctorPhoneNo) values ('" + this.AddDoctorNametxt.Text + "','" + this.AddDoctorPassword.Text + "','" + this.AddDoctorDepartment.Text + "','" + this.AddDoctorDOB.Text + "','" + this.JoinindDate.Text + "','" + this.Gender + "','" + this.AddDoctorAddresstxt.Text + "','" + this.AddDoctorEmail.Text + "','" + this.AddDoctorSalary.Text + "','" + this.AddDcotorPhoneNo.Text + "')";
                command = new SqlCommand(sql, con);
                adaptor.InsertCommand = new SqlCommand(sql, con);
                adaptor.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                con.Close();

                MessageBox.Show("Record SuccessFully Inserted");
                DoctorDeatils();
                this.AddDoctorNametxt.Text = "";
                this.AddDoctorPassword.Text = "";
                this.AddDoctorDepartment.Text = "";
                this.AddDoctorDOB.Text = "";
                this.JoinindDate.Text = "";
                this.Gender = "";
                this.AddDoctorAddresstxt.Text = "";
                this.AddDoctorEmail.Text = "";
                this.AddDoctorSalary.Text = "";
                this.AddDcotorPhoneNo.Text = "";
                DoctorSearchtxt.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                String updatecommand = "Update Doctortb set DoctorName = '" + this.AddDoctorNametxt.Text + "' , DoctorPassword = '" + this.AddDoctorPassword.Text + "' , Department = '" + this.AddDoctorDepartment.Text + "' , DateOfBirth = '" + this.AddDoctorDOB.Text + "' , DateOfJoining = '" + this.JoinindDate.Text + "' , DoctorGender = '" + this.Gender + "' , DoctorAddress = '" + this.AddDoctorAddresstxt.Text + "' , DoctorEmail = '" + this.AddDoctorEmail.Text + "' , DoctorSalary = '" + this.AddDoctorSalary.Text + "' , DoctorPhoneNo = '" + this.AddDcotorPhoneNo.Text + "' where DoctorID = '" + this.DoctorSearchtxt.Text + "';";
                SqlCommand updatecommand1;
                updatecommand1 = new SqlCommand(updatecommand, con);
                SqlDataAdapter Updateadaptor = new SqlDataAdapter(updatecommand, con);
                Updateadaptor.UpdateCommand = new SqlCommand(updatecommand, con);
                Updateadaptor.UpdateCommand.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record SuccessFully Updated");
                DoctorDeatils();
                this.AddDoctorNametxt.Text = "";
                this.AddDoctorPassword.Text = "";
                this.AddDoctorDepartment.Text = "";
                this.AddDoctorDOB.Text = "";
                this.JoinindDate.Text = "";
                this.Gender = "";
                this.AddDoctorAddresstxt.Text = "";
                this.AddDoctorEmail.Text = "";
                this.AddDoctorSalary.Text = "";
                this.AddDcotorPhoneNo.Text = "";
                DoctorSearchtxt.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string deletestr = "delete from Doctortb WHERE DoctorID = '" + DoctorSearchtxt.Text + "'";
                SqlCommand deletecommand;
                deletecommand = new SqlCommand(deletestr, con);
                SqlDataAdapter deleteadaptor = new SqlDataAdapter(deletestr, con);
                deleteadaptor.DeleteCommand = new SqlCommand(deletestr, con);
                deleteadaptor.DeleteCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Records Successfully Delete");
                DoctorDeatils();
                this.AddDoctorNametxt.Text = "";
                this.AddDoctorPassword.Text = "";
                this.AddDoctorDepartment.Text = "";
                this.AddDoctorDOB.Text = "";
                this.JoinindDate.Text = "";
                this.Gender = "";
                this.AddDoctorAddresstxt.Text = "";
                this.AddDoctorEmail.Text = "";
                this.AddDoctorSalary.Text = "";
                this.AddDcotorPhoneNo.Text = "";
                DoctorSearchtxt.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Cleartxtbtn_Click(object sender, EventArgs e)
        {
            this.AddDoctorNametxt.Text = "";
            this.AddDoctorPassword.Text = "";
            this.AddDoctorDepartment.Text = "";
            this.AddDoctorDOB.Text = "";
            this.JoinindDate.Text = "";
            this.Gender = "";
            this.AddDoctorAddresstxt.Text = "";
            this.AddDoctorEmail.Text = "";
            this.AddDoctorSalary.Text = "";
            this.AddDcotorPhoneNo.Text = "";
            DoctorSearchtxt.Text = "";
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "select * from Doctortb WHERE DoctorID = '" + DoctorSearchtxt.Text + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                this.AddDoctorNametxt.Text = sdr["DoctorName"].ToString();
                this.AddDoctorPassword.Text = sdr["DoctorPassword"].ToString();
                this.AddDoctorDepartment.Text = sdr["Department"].ToString();
                this.AddDoctorDOB.Text = sdr["DateOfBirth"].ToString();
                this.JoinindDate.Text = sdr["DateOfJoining"].ToString();
                this.Gender = sdr["DoctorGender"].ToString();
                this.AddDoctorAddresstxt.Text = sdr["DoctorAddress"].ToString();
                this.AddDoctorEmail.Text = sdr["DoctorEmail"].ToString();
                this.AddDoctorSalary.Text = sdr["DoctorSalary"].ToString();
                this.AddDcotorPhoneNo.Text = sdr["DoctorPhoneNo"].ToString();
            }
            else
            {
                MessageBox.Show("Record Not Found");
            }
            con.Close();
        }

        private void AddDoctors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDBDataSet.Doctortb' table. You can move, or remove it, as needed.
            this.doctortbTableAdapter.Fill(this.hospitalDBDataSet.Doctortb);
            DoctorDeatils();
        }
        
        public void DoctorDeatils()
        {
            using (SqlConnection c1 = new SqlConnection(@"Data Source=DESKTOP-7NO3849\RIZWANSQL;Initial Catalog=HospitalDB;Integrated Security=True"))
            {
                c1.Open();
                // Create new DataAdapter 
                using (SqlDataAdapter a1 = new SqlDataAdapter("SELECT * FROM Doctortb", con))
                {

                    // Use DataAdapter to fill DataTable 
                    DataTable t1 = new DataTable();
                    a1.Fill(t1);
                    // Render data onto the screen 
                    Doctorsdt.DataSource = t1;
                }
                c1.Close();
            }
        }

        private void aboutDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDoctors bb5 = new AddDoctors();
            this.Visible = false;
            bb5.ShowDialog();
        }

        private void aboutReceptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReceptionist bb4 = new AddReceptionist();
            this.Visible = false;
            bb4.ShowDialog();
        }

        private void wardsMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicineMainform bb3 = new MedicineMainform();
            this.Visible = false;
            bb3.ShowDialog();
        }

        private void admitPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmitPatientForm bb2 = new AdmitPatientForm();
            this.Visible = false;
            bb2.ShowDialog();
        }

        private void patientDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientDetails bb0 = new PatientDetails();
            this.Visible = false;
            bb0.ShowDialog();
        }

        private void backToHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminMainForm bb1 = new AdminMainForm();
            this.Visible = false;
            bb1.ShowDialog();
        }

        private void DoctorGenderMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void DoctorGenderFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
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
