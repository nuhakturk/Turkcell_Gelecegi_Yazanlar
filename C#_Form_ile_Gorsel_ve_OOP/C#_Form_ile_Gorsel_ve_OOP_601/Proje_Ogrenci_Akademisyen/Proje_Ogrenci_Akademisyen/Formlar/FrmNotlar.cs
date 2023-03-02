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
			comboBox2.DisplayMember = "DersAd";
			comboBox2.ValueMember = "DersID";
			comboBox2.DataSource = db.TblDersler.ToList();
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

		private void BtnHesapla_Click(object sender, EventArgs e)
		{
			byte s1, s2, s3, q1, q2, proje;
			double ortalama;
			s1 = byte.Parse(TxtSinav1.Text);
			s2 = byte.Parse(TxtSinav2.Text);
			s3 = byte.Parse(TxtSinav3.Text);
			q1 = byte.Parse(TxtQuiz1.Text);
			q2 = byte.Parse(TxtQuiz2.Text);
			proje = byte.Parse(TxtProje.Text);
			ortalama = (s1 + s2 + s3 + q1 + q2 + proje) / 6;
			TxtOrtalama.Text = ortalama.ToString();
		}

		private void BtnListele_Click(object sender, EventArgs e)
		{
			//dataGridView1.DataSource = db.View_1.ToList();
			dataGridView1.DataSource = db.Notlar2();
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			var degerler = from x in db.TblNotlar
						   select new
						   {
							   x.NotID,
							   x.Sinav1,
							   x.Ders,
							   x.TblDersler.DersAd
						   };
			dataGridView1.DataSource = degerler.Where(y => y.Ders == 3).ToList();
		}
	}
}
