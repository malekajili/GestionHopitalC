using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using hopital.dao;
using hopital.services;

namespace hopital.forms.patients
{
    public partial class EditPatient : Form
    {
        private PatientEntity patient;
        private PatientService patientService;
        public EditPatient(PatientEntity patient, PatientService service)
        {
            InitializeComponent();
            this.patient = patient;
            patientService = service;

            // Remplir les champs avec les données du patient
            textName.Text = patient.name;
            textEmail.Text = patient.email;
            textGender.Text = patient.gender;
            textPhone.Text = patient.phone;
            textAge.Text = patient.age.ToString();
            textAddress.Text = patient.address;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Mettre à jour les informations du patient
                patient.name = textName.Text;
                patient.email = textEmail.Text;
                patient.gender = textGender.Text;
                patient.phone = textPhone.Text;
                patient.age = int.Parse(textAge.Text);
                patient.address = textAddress.Text;

                // Enregistrer les modifications via le service
                patientService.UpdatePatient(patient);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex) {
                MessageBox.Show($"Erreur lors de la sauvegarde : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
