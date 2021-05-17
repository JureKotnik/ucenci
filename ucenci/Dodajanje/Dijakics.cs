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
    public partial class Dijakics : Form
    {
        public Dijakics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            podrocje f1 = new podrocje();
            f1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (NpgsqlConnection conn = new NpgsqlConnection("Server = ec2-54-78-127-245.eu-west-1.compute.amazonaws.com; Port = 5432; Database = dbqabpjav305q8; User Id = lofhqfjluzqqyf; Password = 0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; sslmode=Require; Trust Server Certificate=true;"))
            {
                try
                {
                    //using (var cmd = new NpgsqlCommand("SELECT * FROM add_dejavnost(@a,@e,@c,@d);", conn))
                    using (var cmd = new NpgsqlCommand("INSERT INTO dijaki(ime,priimek,telefon,email,opis,kraj_id,datum_roj) VALUES (@a,@b,@d,@e,@f,@g,@c);", conn))
                    {
                    int t = Convert.ToInt32(textBox4.Text);
                    int u = Convert.ToInt32(label8.Text);
                        conn.Open();
                        cmd.Parameters.AddWithValue("a", textBox1.Text);
                        cmd.Parameters.AddWithValue("b", textBox2.Text);
                        cmd.Parameters.AddWithValue("c", textBox3.Text);
                        cmd.Parameters.AddWithValue("d", t);
                        cmd.Parameters.AddWithValue("e", textBox6.Text);
                        cmd.Parameters.AddWithValue("f", textBox5.Text);
                        cmd.Parameters.AddWithValue("g", u);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                    }
                    MessageBox.Show("Uspešno ste dodali Dijaka");
                }
                catch (Exception)
                {
                    MessageBox.Show("Dijaka niste dodali uspešno");

                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            using (NpgsqlConnection conn = new NpgsqlConnection("Server = ec2-54-78-127-245.eu-west-1.compute.amazonaws.com; Port = 5432; Database = dbqabpjav305q8; User Id = lofhqfjluzqqyf; Password = 0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; sslmode=Require; Trust Server Certificate=true;"))
            {


                using (var cmd = new NpgsqlCommand("SELECT * FROM kraji ;", conn))
                {
                    conn.Open();

                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listBox2.Items.Add(reader["id"].ToString());
                        listBox2.Items.Add(reader["ime"].ToString());

                    }
                    conn.Close();
                }

            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                label8.Text = listBox2.SelectedItem.ToString();
            }
            catch (NullReferenceException)
            {
                label8.Text = "0";
            }
        }
    }
}
