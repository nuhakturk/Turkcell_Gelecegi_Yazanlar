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

		public string numara;
		OgrenciSinavEntities db = new OgrenciSinavEntities();

		private void FrmOgrenciPanel_Load(object sender, EventArgs e)
		{
			TxtNumara.Text = numara;
			TxtAd.Text = db.TblOgrenci.Where(x => x.OgrNumara== numara).Select(y => y.OgrAd).FirstOrDefault();
			TxtSoyad.Text = db.TblOgrenci.Where(x => x.OgrNumara== numara).Select(y => y.OgrSoyad).FirstOrDefault();
			TxtSifre.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrSifre).FirstOrDefault();
			TxtMail.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrMail).FirstOrDefault();
			TxtResim.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrResim).FirstOrDefault();
			TxtBolum.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrBolum).FirstOrDefault().ToString();

		}
	}
}
