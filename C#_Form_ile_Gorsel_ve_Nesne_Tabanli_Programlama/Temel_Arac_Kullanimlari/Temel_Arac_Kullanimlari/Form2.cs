using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temel_Arac_Kullanimlari
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, ort;
            string durum;
            s1 = Convert.ToInt16(TxtSinav1.Text);
            s2 = Convert.ToInt16(TxtSinav2.Text);
            s3 = Convert.ToInt16(TxtSinav3.Text);
            ort = (s1 + s2 + s3) / 3;
            TxtOrtalama.Text = ort.ToString();
            if(ort >= 50)
            {
                durum = "Geçti";
            }
            else
            {
                durum = "Kaldı";
            }
            TxtDurum.Text = durum;
        }
    }
}
