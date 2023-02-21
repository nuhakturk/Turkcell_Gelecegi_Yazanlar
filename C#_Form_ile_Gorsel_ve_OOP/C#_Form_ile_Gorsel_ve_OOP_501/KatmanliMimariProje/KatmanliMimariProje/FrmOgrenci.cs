﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using BusinessLayer;

namespace KatmanliMimariProje
{
	public partial class FrmOgrenci : Form
	{
		public FrmOgrenci()
		{
			InitializeComponent();
		}

		void Temizle()
		{
			TxtID.Text = string.Empty;
			TxtAd.Text= string.Empty;
			TxtSoyad.Text= string.Empty;
			TxtNumara.Text= string.Empty;
			TxtBolum.Text= string.Empty;
		}

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			EntityOgrenci ent = new EntityOgrenci();
			ent.Ad = TxtAd.Text;
			ent.Soyad = TxtSoyad.Text;
			ent.Numara = TxtNumara.Text;
			ent.Bolum = TxtBolum.Text;
			BLOgrenci.OgrenciEkleBL(ent);
			MessageBox.Show("Öğrenci Başarıyla Eklendi");
			Temizle();
		}

		private void BtnListele_Click(object sender, EventArgs e)
		{
			List<EntityOgrenci> ogrenciler = BLOgrenci.OgrenciListesiBL();
			dataGridView1.DataSource = ogrenciler;
		}

		private void BtnSil_Click(object sender, EventArgs e)
		{
			int deger = int.Parse(TxtID.Text);
			EntityOgrenci en = new EntityOgrenci();
			en.OgrID = deger;
			BLOgrenci.OgrenciSilBL(en.OgrID);
		}
	}
}
