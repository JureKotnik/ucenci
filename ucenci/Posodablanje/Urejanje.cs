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
                    NpgsqlCommand com = new NpgsqlCommand("SELECT update_kraj();", con);
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
                    NpgsqlCommand com = new NpgsqlCommand("SELECT update_dejavnost();", con);
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
                    NpgsqlCommand com = new NpgsqlCommand("SELECT update_dijaki();", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
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
                    NpgsqlCommand com = new NpgsqlCommand("SELECT naloge_update();", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
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
    }
}
