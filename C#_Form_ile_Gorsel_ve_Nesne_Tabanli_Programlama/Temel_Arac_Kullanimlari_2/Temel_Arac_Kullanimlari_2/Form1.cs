using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temel_Arac_Kullanimlari_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yazdırmaKomutlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Yazdırma komutları menü alanına tıklandı";
        }

        private void sarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DodgerBlue;
        }

        private void pembeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.HotPink;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.google.com");
        }

        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.youtube.com");
        }

        private void twitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.twitter.com");
        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.facebook.com");
        }

        private void hakkımızdaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu uygulamayı Turkcell Geleceği Yazanlar Platformu dersleri altında gerçekleştirmekteyiz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        int sayac = 0;
        private void başlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label2.Text = sayac.ToString();
        }

        private void BtnBaslat_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void BtnDurdur_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        int sure = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Text = sure.ToString();
            sure++;
            if (sure >= 0 && sure <= 30)
            {
                panel1.BackColor = Color.Red;
                panel3.BackColor = Color.Transparent;
            }
            if (sure > 30 && sure <= 40)
            {
                panel2.BackColor = Color.Yellow;
            }
            if (sure > 40 && sure <= 70)
            {
                panel3.BackColor = Color.Green;
                panel1.BackColor = Color.Transparent;
                panel2.BackColor = Color.Transparent;
            }
            if (sure == 71)
            {
                sure = 0;
            }
        }
    }
}
