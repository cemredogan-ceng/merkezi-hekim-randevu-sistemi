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
    public partial class kayıtlıHastaMuayene : Form
    {
        public kayıtlıHastaMuayene()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=Hastane; user Id=postgres; password=1234");
        private void kayıtlıHastaMuayene_Load(object sender, EventArgs e)
        {
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into kayıtlıhastamuayenegirişi(tckimlikno,muayenetarihi,receteno,sırano) values (@p1,@p2,@p3,@p4)", baglanti);
            komut1.Parameters.AddWithValue("@p1", textBoxTc.Text);
            komut1.Parameters.AddWithValue("@p2", Convert.ToDateTime(textBoxMuayeneTarihi.Text));
            komut1.Parameters.AddWithValue("@p3", Convert.ToInt32(textBoxReceteNo.Text));
            komut1.Parameters.AddWithValue("@p4", Convert.ToInt32(textBoxsıraNo.Text));

            //kayıtlı hastanın aynı günde birden fazla muayene olmasını engelemek için veritabanı verilerini kontrol etme
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("select * from kayıtlıhastamuayenegirişi", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            int kontrol = 0;
            int i = 0;
            int a = 0;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == textBoxTc.Text)
                {
                    for (a = 0; a < dt.Rows.Count; a++)
                    {
                        if (dt.Rows[a][1].ToString() == textBoxMuayeneTarihi.Text)
                        {
                            kontrol++;

                        }
                    }
                }
            }
            if (kontrol > 0)
            {
                MessageBox.Show("Bir hasta aynı günde sadece bir kez muayene olabilir.");

            }
            if (kontrol == 0)
            {
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Muayene bilgisi kaydedilmiştir.");
            }


           



        }
    }
}
