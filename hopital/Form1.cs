﻿using System;
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
    public partial class Form1 : Form
    {
        MySqlConnection cnx = new MySqlConnection("Server=localhost;Database=hopital;User ID=root;Password=;");

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter ad = new MySqlDataAdapter("SELECT * FROM users; ", cnx);
            DataTable dt = new DataTable();
            ad.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                Main f = new Main();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User is not here");
            }

        }
    }
}
