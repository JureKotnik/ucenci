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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            podrocje f2 = new podrocje();
            f2.ShowDialog();
            this.Close();
            
        }

        private void prikazbutton4_Click(object sender, EventArgs e)
        {
            Prikaz f3 = new Prikaz();
            f3.ShowDialog();
            this.Close();
        }

        private void brisanjebutton3_Click(object sender, EventArgs e)
        {
            Brisanje_izbor f3 = new Brisanje_izbor();
            f3.ShowDialog();
            this.Close();
        }
    }
}
