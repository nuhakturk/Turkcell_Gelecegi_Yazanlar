using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urun_Takip_Entity
{
	public partial class Frmistatistik : Form
	{
		public Frmistatistik()
		{
			InitializeComponent();
		}

		DbUrunEntities db = new DbUrunEntities();

		private void Frmistatistik_Load(object sender, EventArgs e)
		{
			LblMusteriSayisi.Text = db.TBLMUSTERI.Count().ToString();
			LblKategoriSayisi.Text = db.TBLKATEGORI.Count().ToString();
			LblUrunSayisi.Text = db.TBLURUNLER.Count().ToString();
			LblBeyazEsya.Text = db.TBLURUNLER.Count( x => x.Kategori == 1).ToString();
			LblToplamStok.Text = db.TBLURUNLER.Sum(x => x.Stok).ToString();
		}
	}
}
