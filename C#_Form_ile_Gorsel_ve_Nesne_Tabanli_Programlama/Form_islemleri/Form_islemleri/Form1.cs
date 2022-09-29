using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_islemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void kodolustur()
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(10000, 100000);
            TxtKod2.Text = sayi.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kodolustur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TxtKullaniciAd.Text == "Admin" && TxtSifre.Text == "1234" && TxtKod1.Text == TxtKod2.Text)
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı bilgi girişi: Kullanıcı adı, şifre veya kod yanlış girildi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
