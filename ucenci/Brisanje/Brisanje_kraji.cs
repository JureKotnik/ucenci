using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ucenci
{
    public partial class Brisanje_kraji : Form
    {
        public Brisanje_kraji()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=ec2-54-78-127-245.eu-west-1.compute.amazonaws.com;" + "Password=0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; Database=dbqabpjav305q8;"))
            {

                string a = listBox1.SelectedIndex.ToString();

                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("DELETE GROM kraji WHERE ime="+a+";", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string ime = reader.GetString(2);
                    listBox1.Items.Add(ime);
                }
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=ec2-54-78-127-245.eu-west-1.compute.amazonaws.com;" + "Password=0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; Database=dbqabpjav305q8;"))
            {



                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM kraji", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string ime = reader.GetString(2);
                    listBox1.Items.Add(ime);
                }
                con.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String a = comboBox1.Text;
            if (a == "Kraji")
            {
                using (NpgsqlConnection con = new NpgsqlConnection("Server=ec2-54-78-127-245.eu-west-1.compute.amazonaws.com;" + "Password=0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; Database=dbqabpjav305q8;"))
                {



                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM kraji", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        string ime = reader.GetString(2);
                        listBox1.Items.Add(ime);
                    }
                    con.Close();
                }
            }

            if (a == "Dejavnosti")
            {
                using (NpgsqlConnection con = new NpgsqlConnection("Server=ec2-54-78-127-245.eu-west-1.compute.amazonaws.com;" + "Password=0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; Database=dbqabpjav305q8;"))
                {



                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM Dejavnosti", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        string ime = reader.GetString(2);
                        string datum_zacetek = reader.GetString(3);
                        string datum_konec = reader.GetString(4);
                        listBox1.Items.Add(ime);
                        listBox1.Items.Add(datum_zacetek);
                        listBox1.Items.Add(datum_konec);
                    }
                    con.Close();
                }
            }
            if (a == "Dijaki")
            {
                using (NpgsqlConnection con = new NpgsqlConnection("Server=ec2-54-78-127-245.eu-west-1.compute.amazonaws.com;" + "Password=0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; Database=dbqabpjav305q8;"))
                {



                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM Dijaki", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        string ime = reader.GetString(2);
                        string priimek = reader.GetString(3);
                        string datum_roj = reader.GetString(4);
                        string telefon = reader.GetString(5);
                        string email = reader.GetString(6);
                        listBox1.Items.Add(ime);
                        listBox1.Items.Add(priimek);
                        listBox1.Items.Add(datum_roj);
                        listBox1.Items.Add(telefon);
                        listBox1.Items.Add(email);
                    }
                    con.Close();
                }
            }
            if (a == "Naloge")
            {
                using (NpgsqlConnection con = new NpgsqlConnection("Server=ec2-54-78-127-245.eu-west-1.compute.amazonaws.com;" + "Password=0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; Database=dbqabpjav305q8;"))
                {



                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM kraji", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        string ime = reader.GetString(2);
                        string Opravil = reader.GetString(3);
                        listBox1.Items.Add(ime);
                        listBox1.Items.Add(Opravil);
                    }
                    con.Close();
                }
            }
            if (a == "Uporabniki")
            {
                using (NpgsqlConnection con = new NpgsqlConnection("Server=ec2-54-78-127-245.eu-west-1.compute.amazonaws.com;" + "Password=0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; Database=dbqabpjav305q8;"))
                {



                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM kraji", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        string ime = reader.GetString(2);
                        string priimek = reader.GetString(3);
                        string email = reader.GetString(4);
                        string telefon = reader.GetString(5);
                        string Username = reader.GetString(6);
                        listBox1.Items.Add(ime);
                        listBox1.Items.Add(priimek);
                        listBox1.Items.Add(email);
                        listBox1.Items.Add(telefon);
                        listBox1.Items.Add(Username);
                    }
                    con.Close();
                }
            }
        }
    }
}
