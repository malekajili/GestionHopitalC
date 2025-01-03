using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace hopital
{
    public partial class edit_doctor : Form
    {
        MySqlConnection cnx = new MySqlConnection("Server=localhost;Database=hopital;User ID=root;Password=;");
        public edit_doctor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a MySQL command for updating the doctor's details
            MySqlCommand cmd = new MySqlCommand("UPDATE doctor SET name = @name, username = @username, phone = @phone, speciality = @speciality, address = @address WHERE id = @id", cnx);

            // Add parameters to prevent SQL injection
            cmd.Parameters.AddWithValue("@id", textBox1.Text);           // ID (read-only, used for WHERE clause)
            cmd.Parameters.AddWithValue("@name", textBox3.Text);         // Name
            cmd.Parameters.AddWithValue("@phone", textBox4.Text);     // Username
            cmd.Parameters.AddWithValue("@username", textBox2.Text);        // Phone
            cmd.Parameters.AddWithValue("@speciality", comboBox1.Text);  // Speciality
            cmd.Parameters.AddWithValue("@address", textBox6.Text);      // Address

            try
            {
                // Open the database connection
                cnx.Open();

                // Execute the update command
                cmd.ExecuteNonQuery();

                // Show success message
                MessageBox.Show("Doctor information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, you can close the form after saving
                this.Close();
            }
            catch (Exception ex)
            {
                // Show error message if something goes wrong
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection
                cnx.Close();
            }
        }

    }
}
