﻿using System;
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
    public partial class Addkraj : Form
    {
        public Addkraj()
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            podrocje f1 = new podrocje();
            f1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox2.Text);
            using (NpgsqlConnection con = new NpgsqlConnection("Server=ec2-54-78-127-245.eu-west-1.compute.amazonaws.com;" + "Password=0f97f004987c14fa398b21069e1d5ecacc20742baa4c9265ad383d987721990e; Database=dbqabpjav305q8;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("INSERT INTO kraji (ime,posta) VALUES("+textBox1.Text+","+a+")", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                con.Close();
            }
        }
    }
}