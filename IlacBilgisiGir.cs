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
    public partial class IlacBilgisiGir : Form
    {
        public IlacBilgisiGir()
        {
            InitializeComponent();
        }

        private void IlacBilgisiGir_Load(object sender, EventArgs e)
        {
          
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=Hastane; user Id=postgres; password=1234");
      
        //ilaç bilgilerini al ve ilacbilgileri tablosuna aktar
        private void bttnIlacEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into ilacbilgileri(barkodno,ilacadı,ilactipi) values (@p1,@p2,@p3)", baglanti);
            komut1.Parameters.AddWithValue("@p1", textBoxilacBarkod.Text);
            komut1.Parameters.AddWithValue("@p2", textBoxilacAd.Text);
            komut1.Parameters.AddWithValue("@p3", textBoxilacTip.Text);
           


            komut1.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("İlaç Kayıt işlemi başarıyla tamamlandı");
        }

        //ilaç bilgilerini datagridde göster
        private void bttnIlacListele_Click(object sender, EventArgs e)
        {
            string sorgu = " SELECT * FROM ilacbilgileri";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewIlacListesi.DataSource = ds.Tables[0];
        }
    }
}
