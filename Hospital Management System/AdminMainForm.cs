using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void aboutDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDoctors aa1 = new AddDoctors();
            this.Visible = false;
            aa1.ShowDialog();
        }

        private void aboutReceptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReceptionist aa2 = new AddReceptionist();
            this.Visible = false;
            aa2.ShowDialog();
        }

        private void wardsMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicineMainform aa3 = new MedicineMainform();
            this.Visible = false;
            aa3.ShowDialog();
        }

        private void admitPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmitPatientForm aa4 = new AdmitPatientForm();
            this.Visible = false;
            aa4.ShowDialog();
        }

        private void patientDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientDetails ppp = new PatientDetails();
            this.Visible = false;
            ppp.ShowDialog();
        }

        private void backToHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminMainForm aa5 = new AdminMainForm();
            this.Visible = false;
            aa5.ShowDialog();
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
