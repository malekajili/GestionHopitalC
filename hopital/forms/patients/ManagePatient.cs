using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hopital.dao;
using hopital.services;

namespace hopital.forms.patients
{
    public partial class ManagePatient : Form
    {
        private PatientService patientService;
        public ManagePatient(PatientService service)
        {
            InitializeComponent();
            patientService = service;

            // Charger les patients dès l'ouverture de la fenêtre
            LoadPatients();
        }

        private void ConfigureDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ID",
                HeaderText = "ID",
                DataPropertyName = "ID" // Correspond au champ ID dans l'objet projeté
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Nom",
                DataPropertyName = "Name" // Correspond au champ Name dans l'objet projeté
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Email",
                HeaderText = "Email",
                DataPropertyName = "Email" // Correspond au champ Email dans l'objet projeté
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Gender",
                HeaderText = "Genre",
                DataPropertyName = "Gender" // Correspond au champ Gender dans l'objet projeté
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Phone",
                HeaderText = "Téléphone",
                DataPropertyName = "Phone" // Correspond au champ Phone dans l'objet projeté
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Age",
                HeaderText = "Âge",
                DataPropertyName = "Age" // Correspond au champ Age dans l'objet projeté
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Address",
                HeaderText = "Adresse",
                DataPropertyName = "Address" // Correspond au champ Address dans l'objet projeté
            });
        }


        private void LoadPatients()
        {
            try
            {
                // Récupération des patients depuis le service
                List<PatientEntity> patients = patientService.GetAllPatients();

                ConfigureDataGridView(); // Configurer les colonnes explicitement

                // Affichage dans le DataGridView
                dataGridView1.DataSource = patients.Select(p => new
                {
                    ID = p.Id,
                    Name = p.name,
                    Email = p.email,
                    Gender = p.gender,
                    Phone = p.phone,
                    Age = p.age,
                    Address = p.address
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des patients : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    // Vérifier si la colonne ID existe
                    if (dataGridView1.SelectedRows[0].Cells["ID"] != null)
                    {
                        int patientId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                        // Récupérer les données du patient
                        PatientEntity patient = patientService.GetPatientById(patientId);

                        if (patient != null)
                        {
                            // Ouvrir le formulaire d'édition
                            using (var editForm = new EditPatient(patient, patientService))
                            {
                                if (editForm.ShowDialog() == DialogResult.OK)
                                {
                                    // Recharger les données après édition
                                    LoadPatients();
                                    MessageBox.Show("Patient modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Patient introuvable.  {patientId}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Impossible de récupérer l'ID du patient sélectionné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show($"Erreur lors de l'édition : {ex}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un patient à éditer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    // Vérifier si la colonne ID existe
                    if (dataGridView1.SelectedRows[0].Cells["ID"] != null)
                    {
                        int patientId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                        // Confirmation avant suppression
                        var confirmResult = MessageBox.Show("Voulez-vous vraiment supprimer ce patient ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (confirmResult == DialogResult.Yes)
                        {
                            // Supprimer le patient
                            patientService.DeletePatient(patientId);

                            // Recharger la liste
                            LoadPatients();
                            MessageBox.Show("Patient supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Impossible de récupérer l'ID du patient sélectionné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la suppression : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un patient à supprimer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
