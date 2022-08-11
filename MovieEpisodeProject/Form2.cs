using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieEpisodeProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SınıfAdı NesneAdı=New SınıfAdı();
            Araba arb = new Araba();
            arb.marka = "Renault";
            arb.model = "2018";
            arb.fiyat = 250000;
            label1.Text = arb.marka + " " + arb.model + " " + arb.fiyat;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Matematik matematik = new Matematik();
            label1.Text = matematik.topla(45, 85).ToString();
        }
    }
}
