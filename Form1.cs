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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void doktorGirisi_Click(object sender, EventArgs e)
        {
            doktorAnasayfa doktoranasayfa = new doktorAnasayfa();
            doktoranasayfa.Show();
        }

        private void SekreterGirisi_Click(object sender, EventArgs e)
        {
            sekreterAnasayfa sekreterAnasayfa = new sekreterAnasayfa();
            sekreterAnasayfa.Show();
        }
    }
}
