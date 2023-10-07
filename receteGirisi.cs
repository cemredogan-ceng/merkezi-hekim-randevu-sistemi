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
    public partial class receteGirisi : Form
    {
        public receteGirisi()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=Hastane; user Id=postgres; password=1234");
        NpgsqlConnection baglanti2 = new NpgsqlConnection("server=localHost; port=5432; Database=Hastane; user Id=postgres; password=1234");
        NpgsqlConnection baglanti3 = new NpgsqlConnection("server=localHost; port=5432; Database=Hastane; user Id=postgres; password=1234");



        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void textBoxİlacAdı_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttHastaEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into recetedetay(tckimlikno,ad,soyad,recetetarihi,tani,doktoradi,doktorsoyadi,barkodnumarasi1,ilacadi1,ilackutusayisi1,barkodnumarasi2,ilacadi2,ilackutusayisi2,barkodnumarasi3,ilacadi3,ilackutusayisi3,barkodnumarasi4,ilacadi4,ilackutusayisi4,barkodnumarasi5,ilacadi5,ilackutusayisi5,ilacdozu,ilacsayisi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19,@p20,@p21,@p22,@p23,@p24)", baglanti);
            komut1.Parameters.AddWithValue("@p1", textBoxTcKimlik.Text);
            komut1.Parameters.AddWithValue("@p2", textBoxAd.Text);
            komut1.Parameters.AddWithValue("@p3", textBoxSoyad.Text);
            komut1.Parameters.AddWithValue("@p4", Convert.ToDateTime(textBoxReceTarihi.Text));
            komut1.Parameters.AddWithValue("@p5", textBoxTanı.Text);
            komut1.Parameters.AddWithValue("@p6", textBoxDoktorAdı.Text);
            komut1.Parameters.AddWithValue("@p7", textBoxDoktorSoyadı.Text);


            //1.ilac bilgileri
            komut1.Parameters.AddWithValue("@p8", Convert.ToInt32(textBoxBarkod1.Text));
            komut1.Parameters.AddWithValue("@p9", textBoxİlacAdı1.Text);
            komut1.Parameters.AddWithValue("@p10", Convert.ToInt32(textBoxİlacKutuSayısı1.Text));

            //2.ilac bilgileri
            komut1.Parameters.AddWithValue("@p11", Convert.ToInt32(txtBarkod2.Text));
            komut1.Parameters.AddWithValue("@p12", txtİlacAd2.Text);
            komut1.Parameters.AddWithValue("@p13", Convert.ToInt32(txtİlacKutu2.Text));

            //3.ilac bilgileri
            komut1.Parameters.AddWithValue("@p14", Convert.ToInt32(txtBarkod3.Text));
            komut1.Parameters.AddWithValue("@p15", txtİlacAd3.Text);
            komut1.Parameters.AddWithValue("@p16", Convert.ToInt32(txtİlacKutu3.Text));

            //4.ilac bilgileri
            komut1.Parameters.AddWithValue("@p17", Convert.ToInt32(txtBarkod4.Text));
            komut1.Parameters.AddWithValue("@p18", txtİlacAd4.Text);
            komut1.Parameters.AddWithValue("@p19", Convert.ToInt32(txtİlacKutu4.Text));

            //5.ilac bilgileri
            komut1.Parameters.AddWithValue("@p20", Convert.ToInt32(txtBarkod5.Text));
            komut1.Parameters.AddWithValue("@p21", txtİlacAd5.Text);
            komut1.Parameters.AddWithValue("@p22", Convert.ToInt32(txtİlacKutu5.Text));

            komut1.Parameters.AddWithValue("@p23", textBoxGünlükDoz.Text);
            komut1.Parameters.AddWithValue("@p24", Convert.ToInt32(textBoxİlacSayısı.Text));

           

            //2.ilaç girilmeden de çalışmasını sağlar
            if (Convert.ToInt32(txtBarkod2.Text) == 0)
            {
                txtBarkod2.Visible = false;
            }

            if (txtİlacAd2.Text == "")
            {
                txtİlacAd2.Visible = false;
            }
            if (Convert.ToInt32(txtİlacKutu2.Text) == 0)
            {
                txtİlacKutu2.Visible = false;
            }


            //3.ilaç girilmeden de çalışmasını sağlar
            if (Convert.ToInt32(txtBarkod3.Text) == 0)
            {
                txtBarkod3.Visible = false;
            }

            if (txtİlacAd3.Text == "")
            {
                txtİlacAd3.Visible = false;
            }
            if (Convert.ToInt32(txtİlacKutu3.Text) == 0)
            {
                txtİlacKutu3.Visible = false;
            }


            //4.ilaç girilmeden de çalışmasını sağlar
            if (Convert.ToInt32(txtBarkod4.Text) == 0)
            {
                txtBarkod4.Visible = false;
            }

            if (txtİlacAd4.Text == "")
            {
                txtİlacAd4.Visible = false;
            }
            if (Convert.ToInt32(txtİlacKutu4.Text) == 0)
            {
                txtİlacKutu4.Visible = false;
            }


            //5.ilaç girilmeden de çalışmasını sağlar
            if (Convert.ToInt32(txtBarkod5.Text) == 0)
            {
                txtBarkod5.Visible = false;
            }

            if (txtİlacAd5.Text == "")
            {
                txtİlacAd5.Visible = false;
            }
            if (Convert.ToInt32(txtİlacKutu5.Text) == 0)
            {
                txtİlacKutu5.Visible = false;
            }


            //Aynı ilaçtan 3 kutudan fazla yazılamaz kontrolü
            if (Convert.ToInt32(textBoxİlacKutuSayısı1.Text) > 3 || Convert.ToInt32(txtİlacKutu2.Text) > 3 || Convert.ToInt32(txtİlacKutu3.Text) > 3 || Convert.ToInt32(txtİlacKutu4.Text) > 3 || Convert.ToInt32(txtİlacKutu5.Text) > 3)

            {
                
                if (Convert.ToInt32(textBoxİlacKutuSayısı1.Text) > 3)
                {
                    MessageBox.Show("Aynı ilaçtan 3 kutudan fazla yazılamaz!!!!!");
                }

                if (Convert.ToInt32(txtİlacKutu2.Text) > 3)
                {
                    MessageBox.Show("Aynı ilaçtan 3 kutudan fazla yazılamaz!!!!!");
                }


                if (Convert.ToInt32(txtİlacKutu3.Text) > 3)
                {
                    MessageBox.Show("Aynı ilaçtan 3 kutudan fazla yazılamaz!!!!!");
                }


                if (Convert.ToInt32(txtİlacKutu4.Text) > 3)
                {
                    MessageBox.Show("Aynı ilaçtan 3 kutudan fazla yazılamaz!!!!!");
                }


                if (Convert.ToInt32(txtİlacKutu5.Text) > 3)
                {
                    MessageBox.Show("Aynı ilaçtan 3 kutudan fazla yazılamaz!!!!!");
                }

            }

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("select * from recetedetay", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            int kontrol = 0;
            int i = 0;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == textBoxTcKimlik.Text)
                {
                    kontrol++;
                    if (kontrol > 0)
                    {
                        MessageBox.Show("İlgili muayeneye ait reçete bulunmaktadır!!");
                        break;
                    }
                }
            }
            if (kontrol == 0)
            {
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Reçete kaydedilmiştir.");
            }
        }
        private void receteGirisi_Load(object sender, EventArgs e)
        {

        }
    }
}
