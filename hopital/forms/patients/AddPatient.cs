using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hopital.services;

namespace hopital.forms.patients
{
    public partial class AddPatient : Form
    {
        private PatientService patientService;

        public AddPatient(PatientService service)
        {
            InitializeComponent();
            patientService = service;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string email = textEmail.Text;
            string phone = textPhone.Text;
            string address = textAddress.Text;
            int age = int.Parse(textAge.Text);
            string gender = textGender.Text;

            try
            {
                patientService.CreatePatient(name, email, gender, phone, age, address);
                MessageBox.Show("Patient ajouté avec succès !");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout du patient : " + ex.Message);
            }
        }
    }
}
