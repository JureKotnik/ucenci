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




        private void button2_Click(object sender, EventArgs e)
        {
     
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String a = comboBox1.Text;
            if (a == "Kraji")
            {

                using (NpgsqlConnection conn = new NpgsqlConnection("Server = ec2-54-78-127-245.eu-west-1.compute.amazonaws.com; Port = 5432; Database = dbqabpjav305q8; User Id = lofhqfjluzqqyf; Password = 0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; sslmode=Require; Trust Server Certificate=true;"))
                {
                    listBox1.Items.Clear();

                    using (var cmd = new NpgsqlCommand("SELECT * FROM kraji; ", conn))
                    {

                        conn.Open();

                        NpgsqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            listBox1.Items.Add(reader["ID"].ToString());
                            listBox1.Items.Add(string.Format("{0} | {1} | {2} ",
                                reader["ime"].ToString(),
                                reader["postna_stevilka"].ToString(),
                                reader["opis"].ToString()));



                        }
                        conn.Close();
                    }
                }
            }

            if (a == "Dejavnosti")
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Server = ec2-54-78-127-245.eu-west-1.compute.amazonaws.com; Port = 5432; Database = dbqabpjav305q8; User Id = lofhqfjluzqqyf; Password = 0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; sslmode=Require; Trust Server Certificate=true;"))
                {

                    listBox1.Items.Clear();

                    using (var cmd = new NpgsqlCommand("SELECT * FROM dejavnosti; ", conn))
                    {
                        conn.Open();

                        NpgsqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            listBox1.Items.Add(reader["ID"].ToString());
                            listBox1.Items.Add(string.Format("{0} | {1} | {2} | {3} | {4} ",
                                reader["ime"].ToString(),
                                reader["datum_zacetek"].ToString(),
                                reader["opis"].ToString(),
                                reader["sprememba"].ToString(),
                                reader["datum_konec"].ToString()));



                        }
                        conn.Close();
                    }
                }
            }
            if (a == "Dijaki")
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Server = ec2-54-78-127-245.eu-west-1.compute.amazonaws.com; Port = 5432; Database = dbqabpjav305q8; User Id = lofhqfjluzqqyf; Password = 0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; sslmode=Require; Trust Server Certificate=true;"))
                {
                    listBox1.Items.Clear();
                    using (var cmd = new NpgsqlCommand("SELECT * FROM dijaki; ", conn))
                    {
                        conn.Open();

                        NpgsqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            listBox1.Items.Add(reader["ID"].ToString());
                            listBox1.Items.Add(string.Format("{0} | {1} | {2} | {3} | {4} | {5} | {6}  ",
                                reader["ime"].ToString(),
                                reader["priimek"].ToString(),
                                reader["telefon"].ToString(),
                                reader["email"].ToString(),
                                reader["opis"].ToString(),
                                reader["kraj_id"].ToString(),
                                reader["datum_roj"].ToString()));



                        }
                        conn.Close();
                    }
                }
            }
            if (a == "Naloge")
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Server = ec2-54-78-127-245.eu-west-1.compute.amazonaws.com; Port = 5432; Database = dbqabpjav305q8; User Id = lofhqfjluzqqyf; Password = 0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; sslmode=Require; Trust Server Certificate=true;"))
                {
                    listBox1.Items.Clear();
                    using (var cmd = new NpgsqlCommand("SELECT * FROM naloge; ", conn))
                    {
                        conn.Open();

                        NpgsqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            listBox1.Items.Add(reader["ID"].ToString());
                            listBox1.Items.Add(string.Format("{0} | {1} | {2} |",
                                reader["ime"].ToString(),
                                reader["opravil"].ToString(),
                                reader["opis"].ToString()));



                        }
                        conn.Close();
                    }
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            String a = comboBox1.Text;
            if (a == "Kraji")
            {
                try
                {
                    using (NpgsqlConnection conn = new NpgsqlConnection("Server = ec2-54-78-127-245.eu-west-1.compute.amazonaws.com; Port = 5432; Database = dbqabpjav305q8; User Id = lofhqfjluzqqyf; Password = 0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; sslmode=Require; Trust Server Certificate=true;"))
                    {
                        listBox1.Items.Clear();
                        int l = Convert.ToInt32(label2.Text);
                        using (var cmd = new NpgsqlCommand("DELETE FROM kraji WHERE id='" + l + "';", conn))
                        {
                            conn.Open();
                            NpgsqlDataReader reader = cmd.ExecuteReader();
                            conn.Close();
                        }
                    }
                    MessageBox.Show("Uspešno ste odstranili Kraj");
                }
                catch (Exception)
                {

                    MessageBox.Show("Kraja niste odstranili uspešno");
                }
           
            }
            if (a == "Dejavnosti")
            {
                try
                {
                    using (NpgsqlConnection conn = new NpgsqlConnection("Server = ec2-54-78-127-245.eu-west-1.compute.amazonaws.com; Port = 5432; Database = dbqabpjav305q8; User Id = lofhqfjluzqqyf; Password = 0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; sslmode=Require; Trust Server Certificate=true;"))
                    {
                        listBox1.Items.Clear();
                        int l = Convert.ToInt32(label2.Text);
                        using (var cmd = new NpgsqlCommand("DELETE FROM dejavnosti WHERE id='" + l + "';", conn))
                        {
                            conn.Open();
                            NpgsqlDataReader reader = cmd.ExecuteReader();
                            conn.Close();
                        }
                    }
                    MessageBox.Show("Uspešno ste odstranili Dejavnost");
                }
                catch (Exception)
                {

                    MessageBox.Show("Dejavnosti niste odstranili uspešno");
                }
            }
            if (a == "Dijaki")
            {
                try
                {
                    using (NpgsqlConnection conn = new NpgsqlConnection("Server = ec2-54-78-127-245.eu-west-1.compute.amazonaws.com; Port = 5432; Database = dbqabpjav305q8; User Id = lofhqfjluzqqyf; Password = 0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; sslmode=Require; Trust Server Certificate=true;"))
                    {
                        listBox1.Items.Clear();
                        int l = Convert.ToInt32(label2.Text);
                        using (var cmd = new NpgsqlCommand("DELETE FROM dijaki WHERE id='" + l + "';", conn))
                        {
                            conn.Open();
                            NpgsqlDataReader reader = cmd.ExecuteReader();
                            conn.Close();
                        }
                    }
                    MessageBox.Show("Uspešno ste odstranili Dijaka");
                }
                catch (Exception)
                {

                    MessageBox.Show("Dijaka niste odstranili uspešno");
                }
            }
            if (a == "Naloge")
            {
                try
                {
                    using (NpgsqlConnection conn = new NpgsqlConnection("Server = ec2-54-78-127-245.eu-west-1.compute.amazonaws.com; Port = 5432; Database = dbqabpjav305q8; User Id = lofhqfjluzqqyf; Password = 0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; sslmode=Require; Trust Server Certificate=true;"))
                    {
                        listBox1.Items.Clear();
                        int l = Convert.ToInt32(label2.Text);
                        using (var cmd = new NpgsqlCommand("DELETE FROM naloge WHERE id='" + l + "';", conn))
                        {
                            conn.Open();
                            NpgsqlDataReader reader = cmd.ExecuteReader();
                            conn.Close();
                        }
                    }
                    MessageBox.Show("Uspešno ste odstranili Nalogo");
                }
                catch (Exception)
                {

                    MessageBox.Show("Naloge niste odstranili uspešno");
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                label2.Text = listBox1.SelectedItem.ToString();
            }
            catch (NullReferenceException)
            {
                label2.Text = "0";
            }
        }
    }
}
