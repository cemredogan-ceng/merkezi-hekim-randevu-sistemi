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
    public partial class hastaKayıt : Form
    {
        public hastaKayıt()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=Hastane; user Id=postgres; password=1234");
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hastaKayıt_Load(object sender, EventArgs e)
        {

        }

        //hasta bilgilerini al ve hastabilgileri tablosuna kaydet
        private void bttHastaEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into hastabilgileri(tckimlikno,ad,soyad,dogumyeri,dogumtarihi,medenidurum,adres,telefonno) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);
            komut1.Parameters.AddWithValue("@p1", textBoxTcKimlik.Text);
            komut1.Parameters.AddWithValue("@p2", textBoxAd.Text);
            komut1.Parameters.AddWithValue("@p3", textBoxSoyad.Text);
            komut1.Parameters.AddWithValue("@p4", textBoxDogumYeri.Text);
            komut1.Parameters.AddWithValue("@p5", Convert.ToDateTime(textBoxDogumTarihi.Text));
            komut1.Parameters.AddWithValue("@p6", textBoxMedeniDurum.Text);
            komut1.Parameters.AddWithValue("@p7", textBoxAdres.Text);
            komut1.Parameters.AddWithValue("@p8", textBoxTelefon.Text);


            komut1.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Hasta Kayıt işlemi başarıyla tamamlandı");
        }

        //Hastaları datagridviewde görüntüle
        private void bttnHastaGörüntüle_Click(object sender, EventArgs e)
        {
            string sorgu = " SELECT * FROM hastabilgileri";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewHastaListele.DataSource = ds.Tables[0];
        }
    }
}
