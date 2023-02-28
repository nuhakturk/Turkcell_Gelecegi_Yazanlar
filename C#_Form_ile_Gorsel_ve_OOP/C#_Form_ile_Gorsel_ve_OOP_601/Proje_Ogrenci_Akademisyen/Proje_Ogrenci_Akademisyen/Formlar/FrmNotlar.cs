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
	public partial class FrmNotlar : Form
	{
		public FrmNotlar()
		{
			InitializeComponent();
		}

		OgrenciSinavEntities db = new OgrenciSinavEntities();

		private void FrmNotlar_Load(object sender, EventArgs e)
		{
			comboBox1.DisplayMember = "DersAd";
			comboBox1.ValueMember = "DersID";
			comboBox1.DataSource = db.TblDersler.ToList();
		}
	}
}
