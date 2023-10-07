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
    public partial class SorguRecete : Form
    {
        public SorguRecete()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=Hastane; user Id=postgres; password=1234");
        private void buttonGörüntüle_Click(object sender, EventArgs e)
        {
            //tc kimlik no ya göre bir hastaya yazılan ilaçlar listelenir
            baglanti.Open();
            string sorgu = "Select * From recetedetay  Where tckimlikno=@tckimlikno";
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@tckimlikno", textBoxTc.Text);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSorguRecete.DataSource = dt;
            baglanti.Close();

        }

        private void SorguRecete_Load(object sender, EventArgs e)
        {

        }
    }
}
