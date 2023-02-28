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

		private void BtnEkle_Click(object sender, EventArgs e)
		{
			TblNotlar t = new TblNotlar();
			t.Sinav1 = byte.Parse(TxtSinav1.Text);
			t.Sinav2 = byte.Parse(TxtSinav2.Text);
			t.Sinav3 = byte.Parse(TxtSinav3.Text);
			t.Quiz1 = byte.Parse(TxtQuiz1.Text);
			t.Quiz2 = byte.Parse(TxtQuiz2.Text);
			t.Proje = byte.Parse(TxtProje.Text);
			t.Ders = int.Parse(comboBox1.SelectedValue.ToString());
			t.Ogrenci = int.Parse(TxtOgrenci.Text);
			db.TblNotlar.Add(t);
			db.SaveChanges();
			MessageBox.Show("Öğrenci not bilgisi sisteme kaydedildi.");
		}
	}
}
