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
	public partial class FrmUrunler : Form
	{
		public FrmUrunler()
		{
			InitializeComponent();
		}

		DbUrunEntities db = new DbUrunEntities();

		private void BtnListele_Click(object sender, EventArgs e)
		{
			//dataGridView1.DataSource = db.TBLURUNLER.ToList();
			var urunler = from x in db.TBLURUNLER
						  select new
						  {
							  x.UrunId,
							  x.UrunAd,
							  x.Stok,
							  x.AlisFiyat,
							  x.SatisFiyat,
							  x.TBLKATEGORI.Ad
						  };
			dataGridView1.DataSource = urunler.ToList();
		}
	}
}
