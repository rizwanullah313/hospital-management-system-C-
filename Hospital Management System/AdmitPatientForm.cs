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
    public partial class AdmitPatientForm : Form
    {
        public AdmitPatientForm()
        {
            InitializeComponent();
            DateTimeToday.Start();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7NO3849\RIZWANSQL;Initial Catalog=HospitalDB;Integrated Security=True");
        String Gender = " ";

        public void AdmitPatientDetails()
        {
            using (SqlConnection c1 = new SqlConnection(@"Data Source=DESKTOP-7NO3849\RIZWANSQL;Initial Catalog=HospitalDB;Integrated Security=True"))
            {
                c1.Open();
                // Create new DataAdapter 
                using (SqlDataAdapter a1 = new SqlDataAdapter("SELECT * FROM AdmitPatienttb", con))
                {

                    // Use DataAdapter to fill DataTable 
                    DataTable t1 = new DataTable();
                    a1.Fill(t1);
                    // Render data onto the screen 
                    AdmitPatientDetail.DataSource = t1;
                }
                c1.Close();
            }
        }
        private void DateTimeToday_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.Timetoday.Text = dt.ToString();
        }

        private void Cleartxtbtn_Click_1(object sender, EventArgs e)
        {
            ADmitID.Text = "";
            ADpatientage.Text = "";
            ADpatientAddress.Text = "";
            ADpatientDisease.Text = "";
            ADpatientnametxt.Text = "";
            ADpatientPhoneNo.Text = "";
        }

        private void Deletebtn_Click_1(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string deletead = "delete from AdmitPatienttb WHERE AdmitID = '" + ADmitID.Text + "'";
                SqlCommand deletecommand;
                deletecommand = new SqlCommand(deletead, con);
                SqlDataAdapter deleteadaptor = new SqlDataAdapter(deletead, con);
                deleteadaptor.DeleteCommand = new SqlCommand(deletead, con);
                deleteadaptor.DeleteCommand.ExecuteNonQuery();

                AdmitPatientDetails();
                ADmitID.Text = "";
                ADpatientage.Text = "";
                ADpatientAddress.Text = "";
                ADpatientDisease.Text = "";
                ADpatientnametxt.Text = "";
                ADpatientPhoneNo.Text = "";
                MessageBox.Show("Record Delete SuccessFully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }


        private void Updatebtn_Click_1(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                String updatecommandad = "Update AdmitPatienttb set AdmitPatientName = '" + this.ADpatientnametxt.Text + "' , AdmitPatientAge = '" + this.ADpatientage.Text + "' , AdmitPatientGender = '" + this.Gender + "' , AdmitPatientPhoneNo = '" + this.ADpatientPhoneNo.Text + "' , AdmitPatientAddress = '" + this.ADpatientAddress.Text + "' , AdmitedDate = '" + this.Timetoday.Text + "' , ReleaseDate = '" + " " + "' , WardNo = '" + this.ADpatientWardNo.Text + "' , TotalDayAdmit = '" + " " + "' , AdmitPatientDisease = '" + this.ADpatientDisease.Text + "' , TotalBill = '" + " " + "' where AdmitID = '" + this.ADmitID.Text + "';";
                SqlCommand updatecommand1ad;
                updatecommand1ad = new SqlCommand(updatecommandad, con);
                SqlDataAdapter Updateadaptor = new SqlDataAdapter(updatecommandad, con);
                Updateadaptor.UpdateCommand = new SqlCommand(updatecommandad, con);
                Updateadaptor.UpdateCommand.ExecuteNonQuery();

                AdmitPatientDetails();
                ADmitID.Text = "";
                ADpatientage.Text = "";
                ADpatientAddress.Text = "";
                ADpatientDisease.Text = "";
                ADpatientnametxt.Text = "";
                ADpatientPhoneNo.Text = "";
                MessageBox.Show("Record Update SuccessFully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void Insertbtn_Click_1(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                SqlCommand commandad;
                SqlDataAdapter adaptor = new SqlDataAdapter();
                String sql = "insert into AdmitPatienttb (AdmitPatientName,AdmitPatientAge,AdmitPatientGender,AdmitPatientPhoneNo,AdmitPatientAddress,AdmitedDate,WardNo,TotalDayAdmit,AdmitPatientDisease,TotalBill) values ('" + this.ADpatientnametxt.Text + "','" + this.ADpatientage.Text + "','" + this.Gender + "','" + this.ADpatientPhoneNo.Text + "','" + this.ADpatientAddress.Text + "','" + this.Timetoday.Text + "','" + this.ADpatientWardNo.Text + "','" + " " + "','" + this.ADpatientAddress.Text + "','" + " " + "')";
                commandad = new SqlCommand(sql, con);
                adaptor.InsertCommand = new SqlCommand(sql, con);
                adaptor.InsertCommand.ExecuteNonQuery();
                commandad.Dispose();

                AdmitPatientDetails();
                ADmitID.Text = "";
                ADpatientage.Text = "";
                ADpatientAddress.Text = "";
                ADpatientDisease.Text = "";
                ADpatientnametxt.Text = "";
                ADpatientPhoneNo.Text = "";
                MessageBox.Show("Record Insert SuccessFully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void AdmitPatientForm_Load(object sender, EventArgs e)
        {
            AdmitPatientDetails();
            ward();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string str = "select * from AdmitPatienttb WHERE AdmitID = '" + ADmitID.Text + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    this.ADpatientnametxt.Text = sdr["AdmitPatientName"].ToString();
                    this.ADpatientage.Text = sdr["AdmitPatientAge"].ToString();
                    this.ADpatientPhoneNo.Text = sdr["AdmitPatientPhoneNo"].ToString();
                    this.ADpatientDisease.Text = sdr["AdmitPatientDisease"].ToString();
                    this.ADpatientAddress.Text = sdr["AdmitPatientAddress"].ToString();
                    this.Gender = sdr["AdmitPatientGender"].ToString();
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        public void ward()
        {
            con.Open();
            string str1 = "select WARDNO from Wardtb ";
            SqlCommand cmd = new SqlCommand(str1, con);
            SqlDataReader sdr1;
            sdr1 = cmd.ExecuteReader();
            while (sdr1.Read())
            {
                String abc = sdr1["WARDNO"].ToString();
                ADpatientWardNo.Items.Add(abc);

            }
            con.Close();
        }

        private void aboutDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDoctors ee5 = new AddDoctors();
            this.Visible = false;
            ee5.ShowDialog();
        }

        private void aboutReceptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReceptionist ee4 = new AddReceptionist();
            this.Visible = false;
            ee4.ShowDialog();
        }

        private void wardsMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicineMainform ee3 = new MedicineMainform();
            this.Visible = false;
            ee3.ShowDialog();
        }

        private void admitPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmitPatientForm ee2 = new AdmitPatientForm();
            this.Visible = false;
            ee2.ShowDialog();
        }

        private void patientDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientDetails ee0 = new PatientDetails();
            this.Visible = false;
            ee0.ShowDialog();
        }

        private void backToHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminMainForm ee1 = new AdminMainForm();
            this.Visible = false;
            ee1.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainLoginForm mlg = new MainLoginForm();
            this.Visible = false;
            mlg.ShowDialog();
        }

        private void ADpatientmale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void ADpatientFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void releasePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseAdmitPatient rl = new ReleaseAdmitPatient();
            this.Visible = false;
            rl.ShowDialog();
        }
    }
}
