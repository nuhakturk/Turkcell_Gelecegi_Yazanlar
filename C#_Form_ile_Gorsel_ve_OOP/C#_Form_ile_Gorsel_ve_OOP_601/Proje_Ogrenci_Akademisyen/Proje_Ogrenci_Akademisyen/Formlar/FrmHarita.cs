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
	}
}
