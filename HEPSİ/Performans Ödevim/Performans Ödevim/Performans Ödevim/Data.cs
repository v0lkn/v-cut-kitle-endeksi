using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Performans_Ödevim
{
    class Data
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=desktop-33frqqu\sqlexpress;Initial Catalog=BiletSatisi;Integrated Security=True");
        public void KullanıcıGiris(string kullaniciad, string sifre)
        {

            bool loginKontrol = false;
            conn.Open();

            SqlCommand komut = new SqlCommand("SELECT KullaniciAd,KullaniciSifre FROM KullanıcıGiris", conn);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (kullaniciad == oku["KullaniciAd"].ToString() && sifre == oku["KullaniciSifre"].ToString())
                {
                    loginKontrol = true;
                }

            }
            if (loginKontrol == true)
            {
                Ana.KullanıcıAd = kullaniciad;
                Ana.Sifre = sifre;
               // Form2 kullanici = new Form2();

                //kullanici.ShowDialog();

            }


            conn.Close();

        }
        public void SubeEkle(string SubeAdi, string SubeAdres)
        {
            conn.Open();
            SqlCommand insert = new SqlCommand("insert into sube values('" + SubeAdi + "','" + SubeAdres + "')", conn);
            insert.ExecuteNonQuery();
            conn.Close();
        }
        public void SubeSil(int id)
        {
            conn.Open();
            SqlCommand delete = new SqlCommand("DELETE FROM Sube WHERE SubeKodu = '" + id + "'", conn);
            delete.ExecuteNonQuery();
            conn.Close();
        }
        public void SubeGuncelle(int id, string SubeAdi, string SubeAdres)
        {
            conn.Open();
            SqlCommand update = new SqlCommand("UPDATE Sube SET SubeAdi = '" + SubeAdi + "', SubeAdres = '" + SubeAdres + "' WHERE SubeKodu = '" + id + "'", conn);
            update.ExecuteNonQuery();
            conn.Close();
        }
    }
}
