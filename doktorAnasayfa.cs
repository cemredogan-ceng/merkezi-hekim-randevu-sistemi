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
    public partial class doktorAnasayfa : Form
    {
        public doktorAnasayfa()
        {
            InitializeComponent();
        }

        private void receteGirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            receteGirisi receteGirisi = new receteGirisi();
            receteGirisi.Show();
        }

        private void muayeneListesiGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muayeneBilgileriniGir muayeneBilgileriniGir = new muayeneBilgileriniGir();
            muayeneBilgileriniGir.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void receteleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            receteListele receteListele = new receteListele();
            receteListele.Show();
        }

        private void ilacaGöreHastaListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SorguRecete sorguRecete = new SorguRecete();
            sorguRecete.Show();
        }

        private void receteListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            receteListele receteListele = new receteListele();
            receteListele.Show();
        }

        private void muayeneBilgileriniGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muayeneBilgileriniGörüntüle muayeneBilgileriniGörüntüle = new muayeneBilgileriniGörüntüle();
            muayeneBilgileriniGörüntüle.Show();
        }

        private void kayıtlıHastaMuayeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kayıtlıHastaMuayene kayıtlıHastaMuayene = new kayıtlıHastaMuayene();
            kayıtlıHastaMuayene.Show();
        }

        private void doktorAnasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
