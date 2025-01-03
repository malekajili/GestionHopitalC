using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hopital.dao;
using hopital.utils;

namespace hopital.services
{
    public class PatientService
    {
        private DatabaseHelper databaseHelper;
        public PatientService() {
            databaseHelper = new DatabaseHelper();
        }

        public void CreatePatient(string name, string email, string gender, string phone, int age, string address)
        {
            // Étape 1 : Créer l'utilisateur de base
            string queryUser = @"INSERT INTO users (name, role_id, email, gender, phone, age)
                                VALUES (@name, @roleId, @email, @gender, @phone, @age)";

            var parametersUser = new Dictionary<string, object>
            {
                { "@name", name },
                { "@roleId", GetRoleIdByName("PATIENT") }, // ID du rôle Patient
                { "@email", email },
                { "@gender", gender },
                { "@phone", phone },
                { "@age", age }
            };

            databaseHelper.ExecuteNonQuery(queryUser, parametersUser);

            // Étape 2 : Récupérer l'ID de l'utilisateur nouvellement créé
            int userId = GetLastInsertedUserId();

            // Étape 3 : Ajouter les informations spécifiques au patient
            string queryPatient = @"INSERT INTO patients (user_id, address) VALUES (@userId, @address)";
            var parametersPatient = new Dictionary<string, object>
            {
                { "@userId", userId },
                { "@address", address }
            };

            databaseHelper.ExecuteNonQuery(queryPatient, parametersPatient);
        }

        public void UpdatePatient(PatientEntity patient)
        {
            //string query = @"UPDATE users
            //         INNER JOIN patients ON users.id = patients.user_id
            //         SET users.name = @name, users.email = @email, users.gender = @gender, 
            //             users.phone = @phone, users.age = @age, patients.address = @address
            //         WHERE users.id = @id";
            try
            {
                
                string query = @"UPDATE users
                         INNER JOIN patients ON users.id = patients.user_id
                         SET users.name = @name, 
                             users.email = @email, 
                             users.gender = @gender, 
                             users.phone = @phone, 
                             users.age = @age, 
                             patients.address = @address
                         WHERE patients.id = @id";

                var parameters = new Dictionary<string, object>
                {
                    { "@name", patient.name },
                    { "@email", patient.email },
                    { "@gender", patient.gender },
                    { "@phone", patient.phone },
                    { "@age", patient.age },
                    { "@address", patient.address },
                    { "@id", patient.Id }
                };

                // Exécution de la requête
                databaseHelper.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during update: {ex.Message}");
                // Affichage de l'erreur dans la console
                MessageBox.Show($"Erreur lors de la mise à jour du patient : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public PatientEntity GetPatientById(int id)
        {
            // Requête pour récupérer les informations de l'utilisateur et du patient
            string query = @"
                            SELECT u.id, u.name, u.email, u.gender, u.phone, u.age, p.address
                            FROM users u
                            INNER JOIN patients p ON u.id = p.user_id
                            WHERE p.id = @id";
            var parameters = new Dictionary<string, object>
            {
                { "@id", id }
            };

            var dataTable = databaseHelper.ExecuteQuery(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                var row = dataTable.Rows[0];
                return new PatientEntity
                {
                    Id = Convert.ToInt32(row["id"]),
                    name = row["name"].ToString(),
                    email = row["email"].ToString(),
                    gender = row["gender"].ToString(),
                    phone = row["phone"].ToString(),
                    age = Convert.ToInt32(row["age"]),
                    address = row["address"].ToString()
                };
            }
            return null;
        }

        public void DeletePatient(int id)
        {
            string query = "DELETE FROM patients WHERE id = @id";
            var parameters = new Dictionary<string, object>
            {
                { "@id", id }
            };

            databaseHelper.ExecuteNonQuery(query, parameters);
        }

        public List<PatientEntity> GetAllPatients()
        {
            //string query = @"SELECT u.id, u.name, u.email, u.gender, u.phone, u.age, p.address 
            //             FROM users u
            //             INNER JOIN patients p ON u.id = p.user_id";
            string query = @"SELECT p.id AS PatientId, u.name, u.email, u.gender, u.phone, u.age, p.address 
                     FROM users u
                     INNER JOIN patients p ON u.id = p.user_id";

            DataTable result = databaseHelper.ExecuteQuery(query);
            var patients = new List<PatientEntity>();

            foreach (DataRow row in result.Rows)
            {
                patients.Add(new PatientEntity
                {
                    Id = Convert.ToInt32(row["PatientId"]),
                    name = row["name"].ToString(),
                    email = row["email"].ToString(),
                    gender = row["gender"].ToString(),
                    phone = row["phone"].ToString(),
                    age = Convert.ToInt32(row["age"]),
                    address = row["address"].ToString()
                });
            }

            return patients;
        }

        private int GetLastInsertedUserId()
        {
            string query = "SELECT LAST_INSERT_ID()";
            DataTable result = databaseHelper.ExecuteQuery(query);
            return Convert.ToInt32(result.Rows[0][0]);
        }

        private int GetRoleIdByName(string roleName)
        {
            string query = "SELECT id FROM roles WHERE name = @name";
            var parameters = new Dictionary<string, object> { { "@name", roleName } };
            DataTable result = databaseHelper.ExecuteQuery(query, parameters);
            return result.Rows.Count > 0 ? Convert.ToInt32(result.Rows[0]["id"]) : 0;
        }

    }
}
