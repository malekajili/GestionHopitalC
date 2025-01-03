using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hopital.forms.patients;
using hopital.services;

namespace hopital
{
    public partial class Main : Form
    {
        private PatientService patientService;
        public Main()
        {
            InitializeComponent();
            patientService = new PatientService();
            timer1.Enabled = true;
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        { label1.Left += 8;
            if (label1.Left > this.Width)
                label1.Left -= this.Width;
        }

        private void addDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_doctor f = new add_doctor();
            f.Show();
        }

        private void manageDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manage_doctor f = new manage_doctor();
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient(patientService);
            addPatient.Show();
        }

        private void managePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePatient managePatient = new ManagePatient(patientService);
            managePatient.Show();
        }
    }
}
