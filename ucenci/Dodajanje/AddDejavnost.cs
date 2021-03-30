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
    public partial class AddDejavnost : Form
    {
        public AddDejavnost()
        {
            InitializeComponent();
        }
        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
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
            String timeStamp = GetTimestamp(DateTime.Now);
           
            
            using (NpgsqlConnection con = new NpgsqlConnection("Server = ec2-54-78-127-245.eu-west-1.compute.amazonaws.com; Port = 5432; Database = dbqabpjav305q8; User Id = lofhqfjluzqqyf; Password = 0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; sslmode=Require; Trust Server Certificate=true;"))
            {
               
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT add_dejavnost("+textBox1.Text+ "," +timeStamp+ "," + textBox3.Text + "," + opistextBox4.Text + ");", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                con.Close();
            }
        }
    }
}
