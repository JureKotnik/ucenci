using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            }
            if (a == "Dejavnosti")
            {
                krajgroupBox1.Visible = false;
                dejavnostgroupBox1.Visible = true;
                dijakgroupBox1.Visible = false;
                nalogegroupBox1.Visible = false;
            }
            if (a == "Dijaki")
            {
                krajgroupBox1.Visible = false;
                dejavnostgroupBox1.Visible = false;
                dijakgroupBox1.Visible = true;
                nalogegroupBox1.Visible = false;
            }
            if (a == "Naloge")
            {
                krajgroupBox1.Visible = false;
                dejavnostgroupBox1.Visible = false;
                dijakgroupBox1.Visible = false;
                nalogegroupBox1.Visible = true;
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
