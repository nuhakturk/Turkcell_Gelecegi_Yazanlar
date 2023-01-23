using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urun_Takip
{
	public partial class FrmMusteri : Form
	{
		DataSet1TableAdapters.TBLMUSTERITableAdapter tb = new DataSet1TableAdapters.TBLMUSTERITableAdapter();

		public FrmMusteri()
		{
			InitializeComponent();
		}


		private void BtnListele_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = tb.MusteriListesi();
			//databind
		}

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			tb.MusteriEkle(TxtAd.Text, TxtSoyad.Text, TxtSehir.Text, decimal.Parse(TxtBakiye.Text));
			MessageBox.Show("Müşteri sisteme kaydedildi");
		}

		private void BtnSil_Click(object sender, EventArgs e)
		{
			tb.MusteriSil(int.Parse(TxtID.Text));
			MessageBox.Show("Müşteri sistemden silindi");
		}
	}
}
