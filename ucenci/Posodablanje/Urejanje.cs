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
    public partial class Urejanje : Form
    {
        public Urejanje()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String a = comboBox1.Text;
            listBox1.Items.Clear();

            if (a == "Dejavnosti")
            {
               
                krajgroupBox1.Visible = false;
                dejavnostgroupBox1.Visible = true;
                dijakgroupBox1.Visible = false;
                nalogegroupBox1.Visible = false;

                using (NpgsqlConnection conn = new NpgsqlConnection("Server = ec2-54-78-127-245.eu-west-1.compute.amazonaws.com; Port = 5432; Database = dbqabpjav305q8; User Id = lofhqfjluzqqyf; Password = 0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; sslmode=Require; Trust Server Certificate=true;"))
                {

                    using (var cmd = new NpgsqlCommand("SELECT * FROM dejavnosti ;", conn))
                    {
                        conn.Open();

                        NpgsqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                         
                            listBox1.Items.Add(reader["id"].ToString());
                            listBox1.Items.Add(string.Format("{0} | {1} | {2} | {3} | {4} |",
                                reader["ime"].ToString(),
                                reader["opis"].ToString(),
                                reader["sprememba"].ToString(),
                                reader["datum_zacetek"].ToString(),
                                reader["datum_konec"].ToString()));

                        }
                        conn.Close();
                    }
                }
            }
            if (a == "Dijaki")
            {
                krajgroupBox1.Visible = false;
                dejavnostgroupBox1.Visible = false;
                dijakgroupBox1.Visible = true;
                nalogegroupBox1.Visible = false;

                using (NpgsqlConnection conn = new NpgsqlConnection("Server = ec2-54-78-127-245.eu-west-1.compute.amazonaws.com; Port = 5432; Database = dbqabpjav305q8; User Id = lofhqfjluzqqyf; Password = 0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; sslmode=Require; Trust Server Certificate=true;"))
                {

                    using (var cmd = new NpgsqlCommand("SELECT * FROM dijaki ;", conn))
                    {
                        conn.Open();

                        NpgsqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            listBox1.Items.Add(reader["id"].ToString());
                            listBox1.Items.Add(string.Format("{0} | {1} | {2} | {3} | {4} | {5} | {6} |",
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
                krajgroupBox1.Visible = false;
                dejavnostgroupBox1.Visible = false;
                dijakgroupBox1.Visible = false;
                nalogegroupBox1.Visible = true;

                using (NpgsqlConnection conn = new NpgsqlConnection("Server = ec2-54-78-127-245.eu-west-1.compute.amazonaws.com; Port = 5432; Database = dbqabpjav305q8; User Id = lofhqfjluzqqyf; Password = 0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; sslmode=Require; Trust Server Certificate=true;"))
                {

                    using (var cmd = new NpgsqlCommand("SELECT * FROM naloge ;", conn))
                    {
                        conn.Open();

                        NpgsqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            listBox1.Items.Add(reader["id"].ToString());
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

        private void button2_Click(object sender, EventArgs e)
        {
            String a = comboBox1.Text;
            if (a == "Naloge")
            {
                krajgroupBox1.Visible = false;
                dejavnostgroupBox1.Visible = false;
                dijakgroupBox1.Visible = false;
                nalogegroupBox1.Visible = true;
                try
                {
                    using (NpgsqlConnection conn = new NpgsqlConnection("Server = ec2-54-78-127-245.eu-west-1.compute.amazonaws.com; Port = 5432; Database = dbqabpjav305q8; User Id = lofhqfjluzqqyf; Password = 0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; sslmode=Require; Trust Server Certificate=true;"))
                    {
                        listBox1.Items.Clear();
                        int c = Convert.ToInt32(label16.Text);
                        using (var cmd = new NpgsqlCommand("UPDATE naloge SET ime=@a,opravil=@b,opis=@c WHERE id='" + c + "'", conn))
                        {


                            conn.Open();
                            cmd.Parameters.AddWithValue("a", textBox13.Text);
                            cmd.Parameters.AddWithValue("b", checkBox1.Checked);
                            cmd.Parameters.AddWithValue("c", textBox14.Text);
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            MessageBox.Show("Uspešno ste uredili Nalogo.");
                        }


                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Nekaj ni vnešeno pravilno");
                }
             
            }

            if (a == "Dijaki")
            {
                krajgroupBox1.Visible = false;
                dejavnostgroupBox1.Visible = false;
                dijakgroupBox1.Visible = true;
                nalogegroupBox1.Visible = false;

                try
                {
                    using (NpgsqlConnection conn = new NpgsqlConnection("Server = ec2-54-78-127-245.eu-west-1.compute.amazonaws.com; Port = 5432; Database = dbqabpjav305q8; User Id = lofhqfjluzqqyf; Password = 0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; sslmode=Require; Trust Server Certificate=true;"))
                    {
                        listBox1.Items.Clear();
                        int c = Convert.ToInt32(label16.Text);
                        using (var cmd = new NpgsqlCommand("UPDATE dijaki SET ime=@a,priimek=@b,datum_roj=@c,telefon=@d,opis=@e,email=@f WHERE id='" + c + "'", conn))
                        {

                            int u = Convert.ToInt32(textBox4.Text);
                            conn.Open();
                            cmd.Parameters.AddWithValue("a", textBox1.Text);
                            cmd.Parameters.AddWithValue("b", textBox2.Text);
                            cmd.Parameters.AddWithValue("c", textBox3.Text);
                            cmd.Parameters.AddWithValue("d", u);
                            cmd.Parameters.AddWithValue("e", textBox5.Text);
                            cmd.Parameters.AddWithValue("f", textBox6.Text);
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            MessageBox.Show("Uspešno ste uredili Dijaka.");
                        }


                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Nekaj ni vnešeno pravilno");
                }
             
            }

            if (a == "Dejavnosti")
            {
                krajgroupBox1.Visible = false;
                dejavnostgroupBox1.Visible = true;
                dijakgroupBox1.Visible = false;
                nalogegroupBox1.Visible = false;

                try
                {
                    using (NpgsqlConnection conn = new NpgsqlConnection("Server = ec2-54-78-127-245.eu-west-1.compute.amazonaws.com; Port = 5432; Database = dbqabpjav305q8; User Id = lofhqfjluzqqyf; Password = 0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; sslmode=Require; Trust Server Certificate=true;"))
                    {
                        listBox1.Items.Clear();
                        int c = Convert.ToInt32(label16.Text);
                        using (var cmd = new NpgsqlCommand("UPDATE dejavnosti SET ime=@a,opis=@b,datum_zacetek=@c,datum_konec=@d WHERE id='" + c + "'", conn))
                        {

                            conn.Open();
                            cmd.Parameters.AddWithValue("a", textBox9.Text);
                            cmd.Parameters.AddWithValue("b", textBox10.Text);
                            cmd.Parameters.AddWithValue("c", textBox8.Text);
                            cmd.Parameters.AddWithValue("d", textBox7.Text);
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            MessageBox.Show("Uspešno ste uredili dejavnost.");
                        }

                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Nekaj ni vnešeno pravilno");
                }
            
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                label16.Text = listBox1.SelectedItem.ToString();
            }
            catch (NullReferenceException)
            {
                label16.Text = "0";
            }
        }

        private void Z(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String a = comboBox1.Text;
            if (a == "Naloge")
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Server = ec2-54-78-127-245.eu-west-1.compute.amazonaws.com; Port = 5432; Database = dbqabpjav305q8; User Id = lofhqfjluzqqyf; Password = 0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; sslmode=Require; Trust Server Certificate=true;"))
                {
                    listBox1.Items.Clear();
                    int v = Convert.ToInt32(label16.Text);
                    using (var cmd = new NpgsqlCommand("SELECT * FROM naloge WHERE id='" + v + "' ", conn))
                    {
                        conn.Open();
                        NpgsqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            textBox13.Text = reader["ime"].ToString();
                            textBox14.Text = reader["opis"].ToString();
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
                    int v = Convert.ToInt32(label16.Text);
                    using (var cmd = new NpgsqlCommand("SELECT * FROM dejavnosti WHERE id='" + v + "' ", conn))
                    {
                        conn.Open();
                        NpgsqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            textBox9.Text = reader["ime"].ToString();
                            textBox14.Text = reader["opis"].ToString();
                            textBox8.Text = reader["datum_zacetek"].ToString();
                            textBox7.Text = reader["datum_konec"].ToString();
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
                    int v = Convert.ToInt32(label16.Text);
                    using (var cmd = new NpgsqlCommand("SELECT * FROM dijaki WHERE id='" + v + "' ", conn))
                    {
                        conn.Open();
                        NpgsqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            textBox1.Text = reader["ime"].ToString();
                            textBox2.Text = reader["priimek"].ToString();
                            textBox3.Text = reader["datum_roj"].ToString();
                            textBox4.Text = reader["telefon"].ToString();
                            textBox5.Text = reader["opis"].ToString();
                            textBox6.Text = reader["email"].ToString();
                        }
                        conn.Close();
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
