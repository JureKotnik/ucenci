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

            if (a == "Kraji")
            {
                krajgroupBox1.Visible = true;
                dejavnostgroupBox1.Visible = false;
                dijakgroupBox1.Visible = false;
                nalogegroupBox1.Visible = false;

                using (NpgsqlConnection con = new NpgsqlConnection("Server=ec2-54-78-127-245.eu-west-1.compute.amazonaws.com;" + "Password=0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; Database=dbqabpjav305q8;"))
                {



                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT izberi_kraj();", con);
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
                krajgroupBox1.Visible = false;
                dejavnostgroupBox1.Visible = true;
                dijakgroupBox1.Visible = false;
                nalogegroupBox1.Visible = false;

                using (NpgsqlConnection con = new NpgsqlConnection("Server=ec2-54-78-127-245.eu-west-1.compute.amazonaws.com;" + "Password=0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; Database=dbqabpjav305q8;"))
                {



                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT izberi_dejavnost();", con);
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
                krajgroupBox1.Visible = false;
                dejavnostgroupBox1.Visible = false;
                dijakgroupBox1.Visible = true;
                nalogegroupBox1.Visible = false;

                using (NpgsqlConnection con = new NpgsqlConnection("Server=ec2-54-78-127-245.eu-west-1.compute.amazonaws.com;" + "Password=0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; Database=dbqabpjav305q8;"))
                {



                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT izberi_dijak();", con);
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
                krajgroupBox1.Visible = false;
                dejavnostgroupBox1.Visible = false;
                dijakgroupBox1.Visible = false;
                nalogegroupBox1.Visible = true;

                using (NpgsqlConnection con = new NpgsqlConnection("Server=ec2-54-78-127-245.eu-west-1.compute.amazonaws.com;" + "Password=0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; Database=dbqabpjav305q8;"))
                {



                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT izberi_naloge();", con);
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

                using (NpgsqlConnection con = new NpgsqlConnection("Server=ec2-54-78-127-245.eu-west-1.compute.amazonaws.com;" + "Password=0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; Database=dbqabpjav305q8;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT update_naloge(" + textBox13.Text + "," + checkBox1.Text + "," + textBox14.Text + ",);", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    con.Close();
                }
            }

            if (a == "Dijaki")
            {
                krajgroupBox1.Visible = false;
                dejavnostgroupBox1.Visible = false;
                dijakgroupBox1.Visible = true;
                nalogegroupBox1.Visible = false;

                using (NpgsqlConnection con = new NpgsqlConnection("Server=ec2-54-78-127-245.eu-west-1.compute.amazonaws.com;" + "Password=0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; Database=dbqabpjav305q8;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT update_dijaki(" + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + textBox4.Text + "," + textBox6.Text + "," + textBox5.Text + ",);", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    con.Close();
                }
            }

            if (a == "Dejavnosti")
            {
                krajgroupBox1.Visible = false;
                dejavnostgroupBox1.Visible = true;
                dijakgroupBox1.Visible = false;
                nalogegroupBox1.Visible = false;

                using (NpgsqlConnection con = new NpgsqlConnection("Server=ec2-54-78-127-245.eu-west-1.compute.amazonaws.com;" + "Password=0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; Database=dbqabpjav305q8;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT update_dejavnost(" + textBox9.Text + "," + textBox8.Text + "," + textBox7.Text + "," + textBox10.Text + ",);", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    con.Close();
                }
            }

            if (a == "Kraji")
            {
                using (NpgsqlConnection con = new NpgsqlConnection("Server=ec2-54-78-127-245.eu-west-1.compute.amazonaws.com;" + "Password=0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; Database=dbqabpjav305q8;"))
                {
                    int p = Convert.ToInt32(textBox11.Text);
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT update_kraj(" + textBox12.Text + "," + p + ");", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    con.Close();
                }
            }
        }
    }
}
