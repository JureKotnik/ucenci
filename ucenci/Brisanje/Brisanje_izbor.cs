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
    public partial class Brisanje_izbor : Form
    {
        public Brisanje_izbor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String a = comboBox1.Text;

            if (a == "Kraji")
            {
                this.Hide();
                Addkraj f4 = new Addkraj();
                f4.ShowDialog();
                this.Close();
            }
            if (a == "Dejavnosti")
            {
                this.Hide();
                AddDejavnost f5 = new AddDejavnost();
                f5.ShowDialog();
                this.Close();
            }
            if (a == "Dijaki")
            {
                this.Hide();
                Dijakics f4 = new Dijakics();
                f4.ShowDialog();
                this.Close();
            }
            if (a == "Naloge")
            {
                this.Hide();
                naloge f4 = new naloge();
                f4.ShowDialog();
                this.Close();
            }
            if (a == "Uporabniki")
            {
                this.Hide();
                Addkraj f4 = new Addkraj();
                f4.ShowDialog();
                this.Close();
            }
        }
    }
}
