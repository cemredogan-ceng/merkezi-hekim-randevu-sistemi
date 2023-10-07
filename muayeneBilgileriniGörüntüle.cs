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
    public partial class muayeneBilgileriniGörüntüle : Form
    {
        public muayeneBilgileriniGörüntüle()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=Hastane; user Id=postgres; password=1234");
        private void muayeneBilgileriniGörüntüle_Load(object sender, EventArgs e)
        {
            //muayene bilgilerini görüntüleme
            string sorgu = " SELECT * FROM muayenelistesi";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewMuayeneGörüntüle.DataSource = ds.Tables[0];
        }
    }
}
