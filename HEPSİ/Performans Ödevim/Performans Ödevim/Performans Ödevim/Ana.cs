using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Performans_Ödevim
{
    public partial class Ana : Form
    {
        public Ana()
        {
            InitializeComponent();
        }
        public static string KullanıcıAd = "";
        public static string Sifre = "";
        public static int id = 0;
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kayıt kyt = new Kayıt();
            kyt.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Giriş grs = new Giriş();
            grs.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BiletAl frm5 = new BiletAl();
            frm5.ShowDialog();

            Data dt = new Data();
            dt.KullanıcıGiris(comboBox1.SelectedText, comboBox2.SelectedText);
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Filo frm6 = new Filo();
            frm6.ShowDialog();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Şube frm5 = new Şube();
            frm5.ShowDialog();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
