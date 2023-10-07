using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _210601048_Cemre_DOĞAN_FinalOdev
{
    public partial class sekreterAnasayfa : Form
    {
        public sekreterAnasayfa()
        {
            InitializeComponent();
        }

        private void hastaKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hastaKayıt hastaKayıt = new hastaKayıt();
            hastaKayıt.Show();
        }

        private void ilaçBilgileriniGirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IlacBilgisiGir ılacBilgisiGir = new IlacBilgisiGir();
            ılacBilgisiGir.Show();
        }

        private void receteleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            receteListele receteListele = new receteListele();
            receteListele.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sekreterAnasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
