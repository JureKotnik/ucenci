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
    public partial class naloge : Form
    {
        public naloge()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
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
                    using (var cmd = new NpgsqlCommand("INSERT INTO naloge(ime,opravil,opis) VALUES (@a,@c,@d);", conn))
                    {

                        conn.Open();
                        cmd.Parameters.AddWithValue("a", textBox1.Text);
                        cmd.Parameters.AddWithValue("c", checkBox1.Checked);
                        cmd.Parameters.AddWithValue("d", textBox2.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                    }
                    MessageBox.Show("Uspešno ste dodali nalogo");
                }
                catch (Exception)
                {
                    MessageBox.Show("Naloge niste dodali uspešno");

                }


            }
        }
    }
}
