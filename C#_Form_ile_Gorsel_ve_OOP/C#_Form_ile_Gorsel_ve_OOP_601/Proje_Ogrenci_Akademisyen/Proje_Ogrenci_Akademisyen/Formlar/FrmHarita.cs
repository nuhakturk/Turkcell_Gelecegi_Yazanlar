using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Ogrenci_Akademisyen.Formlar
{
	public partial class FrmHarita : Form
	{
		public FrmHarita()
		{
			InitializeComponent();
		}

		private void PnlBolumListesi_Click(object sender, EventArgs e)
		{
			FrmBolumListesi fr = new FrmBolumListesi();
			fr.Show();
		}

		private void PnlYeniBolum_Click(object sender, EventArgs e)
		{
			FrmBolumler fr = new FrmBolumler();
			fr.Show();
		}

		private void PnlNotlar_Click(object sender, EventArgs e)
		{
			FrmNotlar fr = new FrmNotlar();
			fr.Show();
		}

		private void PnlOgrenci_Click(object sender, EventArgs e)
		{
			FrmOgrenci fr = new FrmOgrenci();
			fr.Show();
		}

		private void PnlOgrenciKayit_Click(object sender, EventArgs e)
		{
			FrmOgrenciKayit fr = new FrmOgrenciKayit();
			fr.Show();
		}

		private void PnlDersListesi_Click(object sender, EventArgs e)
		{
			FrmDersListesi fr = new FrmDersListesi();
			fr.Show();
		}

		private void PnlYeniDers_Click(object sender, EventArgs e)
		{
			FrmYeniDers fr = new FrmYeniDers();
			fr.Show();
		}

		private void PnlYardim_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Bu proje Turkcell Geleceği Yazanlar Eğitimi Kapsamında hazırlanmıştır. Müfredatın son projesinde amacımız şu ana kadar öğrenmiş olduğumuz konuların büyük bir kısmını içeren örnek bir veri tabanlı proje uygulaması geliştirmektir. Projemizde akademisyen için kullanıcı adı: 00000 olup şifre: 000 şeklindedir. Akademisyen panelinden öğrenci, ders, bölüm, sınav notları gibi işlemlerin tamamı gerçekleştirilebilir. Sisteme giriş yapan öğrenci sadece kendisine ait bilgileri ve sınav notlarını görüntüler.", "Yardım Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
	}
}
