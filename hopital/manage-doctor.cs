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
using System.Data;

namespace hopital
{
    public partial class manage_doctor : Form
    {
        MySqlConnection cnx = new MySqlConnection("Server=localhost;Database=hopital;User ID=root;Password=;");

        public manage_doctor()
        {
            InitializeComponent();
            MySqlDataAdapter ad = new MySqlDataAdapter("select * from doctor;", cnx);
            DataTable d = new DataTable();
            ad.Fill(d);
            dataGridView1.DataSource = d;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ask for confirmation before deleting
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this doctor?",
                                                        "Confirm Deletion",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    // Create and execute the delete command
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM doctor WHERE id = @id", cnx);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    cnx.Close();

                   
                    MessageBox.Show("Doctor deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the DataGridView
                    MySqlDataAdapter ad = new MySqlDataAdapter("SELECT * FROM doctor;", cnx);
                    DataTable d = new DataTable();
                    ad.Fill(d);
                    dataGridView1.DataSource = d;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Ensure the connection is closed, even if an error occurs
                    if (cnx.State == ConnectionState.Open)
                    {
                        cnx.Close();
                    }
                }
            }
            else
            {
               
                return;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            edit_doctor f = new edit_doctor();
            f.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); // ID
            f.textBox1.ReadOnly = true;
            f.textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); // Name
            f.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString(); // Username
            f.textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString(); // Phone
            f.comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString(); // Specializes
            f.textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString(); // Address




            f.Show();
        }
    }
}
