using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proje_Ogrenci_Akademisyen.Entity;

namespace Proje_Ogrenci_Akademisyen.Formlar
{
	public partial class FrmOgrenciPanel : Form
	{
		public FrmOgrenciPanel()
		{
			InitializeComponent();
		}

		int ogrenciID;
		public string numara;
		OgrenciSinavEntities db = new OgrenciSinavEntities();

		private void FrmOgrenciPanel_Load(object sender, EventArgs e)
		{
			TxtNumara.Text = numara;
			TxtAd.Text = db.TblOgrenci.Where(x => x.OgrNumara== numara).Select(y => y.OgrAd).FirstOrDefault();
			TxtSoyad.Text = db.TblOgrenci.Where(x => x.OgrNumara== numara).Select(y => y.OgrSoyad).FirstOrDefault();
			TxtSifre.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrSifre).FirstOrDefault();
			TxtMail.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrMail).FirstOrDefault();
			//TxtResim.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrResim).FirstOrDefault();
			TxtBolum.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrBolum).FirstOrDefault().ToString();

			ogrenciID = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrID).FirstOrDefault();

			var sinavNotlari = (from x in db.TblNotlar
							   select new
							   {
								   x.TblDersler.DersAd,
								   x.Sinav1,
								   x.Sinav2,
								   x.Sinav3,
								   x.Quiz1,
								   x.Quiz2,
								   x.Proje,
								   x.Ortalama,
								   x.Ogrenci
							   }).Where(x => x.Ogrenci == ogrenciID).ToList();
			dataGridView1.DataSource = sinavNotlari;
		}

		private void BtnGuncelle_Click(object sender, EventArgs e)
		{
			if (TxtYeniSifre.Text == TxtYeniSifreTekrar.Text)
			{
				var deger = db.TblOgrenci.Find(ogrenciID);
				deger.OgrSifre = TxtYeniSifre.Text;
				db.SaveChanges();
				MessageBox.Show("Şifre değiştirme işlemi başarılı bir şekilde gerçekleşti");
			}
			else
			{
				MessageBox.Show("Girdiğiniz yeni şifreler birbiri ile uyuşmuyor!");
			}
		}
	}
}
