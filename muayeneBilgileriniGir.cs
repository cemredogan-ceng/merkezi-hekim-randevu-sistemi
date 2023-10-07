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

namespace _210601048_Cemre_DOĞAN_FinalOdev
{
    public partial class muayeneBilgileriniGir : Form
    {
        public muayeneBilgileriniGir()
        {
            InitializeComponent();
        }
        
        private void textBoxAdres_TextChanged(object sender, EventArgs e)
        {

        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=Hastane; user Id=postgres; password=1234");
        private void bttnMuayeneBilgisiKaydet_Click(object sender, EventArgs e)
        {
            //muayene bilgilerini alıp muayenelistesine kaydetme
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("insert into muayenelistesi(sırano,tckimlikno,ad,soyad,dogumyeri,dogumtarihi,bulgular,teshis,tedavi) values (@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17, @p18)", baglanti);
            komut2.Parameters.AddWithValue("@p10", Convert.ToInt32(sıraNoTxt.Text));
            komut2.Parameters.AddWithValue("@p11", TCTxt.Text);
            komut2.Parameters.AddWithValue("@p12", adTxt.Text);
            komut2.Parameters.AddWithValue("@p13", soyadTxt.Text);
            komut2.Parameters.AddWithValue("@p14", dogumYeriTxt.Text);
            komut2.Parameters.AddWithValue("@p15", Convert.ToDateTime(dogumTarihiTxt.Text));
            komut2.Parameters.AddWithValue("@p16", bulgularTxt.Text);
            komut2.Parameters.AddWithValue("@p17", teshisTxt.Text);
            komut2.Parameters.AddWithValue("@p18", tedaviTxt.Text);


            komut2.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Muayene bilgileri başarıyla kaydedildi.");
        }

        private void muayeneBilgileriniGir_Load(object sender, EventArgs e)
        {

        }
    }
    }

