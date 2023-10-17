using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            string ad, soyad, yazdır;
            ad = txtAd.Text;
            soyad = txtSoyad.Text;
            yazdır = ad + " " + soyad;
            textBox1.Text = yazdır;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sil;
            sil = " "; 
            textBox1.Text = " ";
        }
    }
}
