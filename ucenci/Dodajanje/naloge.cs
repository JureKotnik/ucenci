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
           
            using (NpgsqlConnection con = new NpgsqlConnection("Server=ec2-54-78-127-245.eu-west-1.compute.amazonaws.com;" + "Password=0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; Database=dbqabpjav305q8;"))
            {
                bool opravil = checkBox1.Checked;
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("INSERT INTO Naloge (ime,opravil,opis) VALUES(" + textBox1.Text + "," + opravil + "," +textBox2.Text + ")", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                con.Close();
            }
        }
    }
}
