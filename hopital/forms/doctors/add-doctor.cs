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
    public partial class add_doctor : Form
    {
        // Connection to the MySQL database
        MySqlConnection cnx = new MySqlConnection("Server=localhost;Database=hopital;User ID=root;Password=;");

        public add_doctor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Use parameterized query to prevent SQL injection
            MySqlCommand cmd = new MySqlCommand("INSERT INTO doctor (name, username, phone, speciality, address) VALUES (@name, @username, @phone, @speciality, @address)", cnx);

            // Add parameters
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@username", textBox2.Text);
            cmd.Parameters.AddWithValue("@phone", textBox4.Text);
            cmd.Parameters.AddWithValue("@speciality", comboBox1.Text);
            cmd.Parameters.AddWithValue("@address", textBox6.Text);

            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();

            MessageBox.Show("Doctor added successfully.");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            textBox6.Text = "";

        }
    }
}

