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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Access Modifiers
        //private --> Sadece bulunduğu sınıftan çağrılır
        //public --> her yerden erişim sağlanır

        //Sınıf içindeki metotlara ve değişkenlere ya da proplara direkt erişim sağlanmaz
        //Sınıftan nesne türeterek

        //SınıfAdı NesneAdı = New SınıfAdı();

        string abc;
        public void yazdir()
        {
            label1.Text = "merhaba";
            label2.Text = "selam";
            label3.Text = "hi";
        }

        void Topla()
        {
            int sayi1 = 5;
            int sayi2 = 10;
            int sonuc = sayi1 + sayi2;
            label1.Text = sonuc.ToString();
        }

       

        void EkranaYazdir(string p1,string p2)
        {
            label2.Text = p1 + " " + p2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Topla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EkranaYazdir("merhaba", "nasılsın");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string marka;
            string model;
            decimal fiyat;
            yazdir();
        }

        int carp()
        {
            int sayi1 = 10;
            int sayi2 = 25;
            int sonuc = sayi1 * sayi2;
            return sonuc;
        }

        int hesapla(int s1,int s2,int s3)
        {
            int sonuc = s1 * s2 * s3;
            return sonuc;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = carp().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = hesapla(4, 5, 6).ToString();
        }
    }
}
