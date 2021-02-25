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
    public partial class ReleaseAdmitPatient : Form
    {
        public ReleaseAdmitPatient()
        {
            InitializeComponent();
            ReleaseDate.Start();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7NO3849\RIZWANSQL;Initial Catalog=HospitalDB;Integrated Security=True");

        private void BillPaidbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                String updatecommandad = "Update AdmitPatienttb set ReleaseDate = '" +this.PatientReleaseDate.Text + "' , TotalDayAdmit = '" +this.Totaldaysadmit.Text + "' , TotalBill = '" +this.TotalBilltxt.Text+ "' where AdmitID = '" + this.APatientID.Text + "'";
                SqlCommand updatecommand1ad;
                updatecommand1ad = new SqlCommand(updatecommandad, con);
                SqlDataAdapter Updateadaptor = new SqlDataAdapter(updatecommandad, con);
                Updateadaptor.UpdateCommand = new SqlCommand(updatecommandad, con);
                Updateadaptor.UpdateCommand.ExecuteNonQuery();

                this.Apatientnametxt.Text = "";
                this.Apatientcell.Text = "";
                this.TotalBilltxt.Text = "";
                this.Totaldaysadmit.Text = "";

                MessageBox.Show("Bill Paid SuccessFully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void ReleaseAdmitPatient_Load(object sender, EventArgs e)
        {
            SearchAdmitPatientByID();
        }

        public void SearchAdmitPatientByID()
        {
            con.Open();
            try
            {
                string str = "select AdmitID from AdmitPatienttb WHERE TotalDayAdmit = 0 ";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    String abc = sdr["AdmitID"].ToString();
                    APatientID.Items.Add(abc);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void APatientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string strq = "select AdmitPatientName,AdmitPatientPhoneNo,AdmitedDate from AdmitPatienttb where AdmitID = '" + this.APatientID.Text + "' ";
                SqlCommand cmdq = new SqlCommand(strq, con);
                SqlDataReader sdrq;
                sdrq = cmdq.ExecuteReader();
                if (sdrq.Read())
                {
                    this.Apatientnametxt.Text = sdrq["AdmitPatientName"].ToString();
                    this.Apatientcell.Text = sdrq["AdmitPatientPhoneNo"].ToString();
                    this.AdmitDatetxt.Text = sdrq["AdmitedDate"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            calculatedays();
        }

        private void ReleaseDate_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.PatientReleaseDate.Text = dt.ToString();
        }
        public void calculatedays()
        {
            DateTime date1 = Convert.ToDateTime(PatientReleaseDate.Text);

            // creating object of DateTime
            DateTime ad = Convert.ToDateTime(AdmitDatetxt.Text); 

            // getting ShortTime from DateTime 
            // using Subtract() method; 
            TimeSpan value = date1.Subtract(ad);

            int day = value.Days;

            Totaldaysadmit.Text = day.ToString();

            int bidcharges = day * 500 * 10;

            TotalBilltxt.Text = bidcharges.ToString();
        }

        private void aboutDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDoctors cc5e = new AddDoctors();
            this.Visible = false;
            cc5e.ShowDialog();
        }

        private void releasePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseAdmitPatient rle = new ReleaseAdmitPatient();
            this.Visible = false;
            rle.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainLoginForm mlge = new MainLoginForm();
            this.Visible = false;
            mlge.ShowDialog();
        }

        private void patientDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientDetails cc0 = new PatientDetails();
            this.Visible = false;
            cc0.ShowDialog();
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

        private void backToHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminMainForm cc1 = new AdminMainForm();
            this.Visible = false;
            cc1.ShowDialog();
        }
    }
}

                   