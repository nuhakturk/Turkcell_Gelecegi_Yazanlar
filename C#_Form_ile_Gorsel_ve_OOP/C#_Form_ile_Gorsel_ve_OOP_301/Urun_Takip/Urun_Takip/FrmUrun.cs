﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Urun_Takip
{

	public partial class FrmUrun : Form
	{
		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U5FIOK2\\SQLEXPRESS;Initial Catalog=DbUrun;Integrated Security=True");

		public FrmUrun()
		{
			InitializeComponent();
		}

		private void FrmUrun_Load(object sender, EventArgs e)
		{
			SqlCommand komut2 = new SqlCommand("Select * From TBLKATEGORI", baglanti);
			SqlDataAdapter da2 = new SqlDataAdapter(komut2);
			DataTable dt2 = new DataTable();
			da2.Fill(dt2);
			comboBox1.DisplayMember = "Ad";
			comboBox1.ValueMember = "ID";
			comboBox1.DataSource = dt2;
		}

		private void BtnListele_Click(object sender, EventArgs e)
		{
			SqlCommand komut1 = new SqlCommand("Select UrunId,UrunAd,Stok,AlisFiyat,SatisFiyat,Ad,Kategori From TBLURUNLER INNER JOIN TBLKATEGORI ON TBLURUNLER.Kategori = TBLKATEGORI.ID", baglanti);
			SqlDataAdapter da = new SqlDataAdapter(komut1);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
			dataGridView1.Columns["Kategori"].Visible = false;
		}

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut3 = new SqlCommand("insert into TblUrunler (UrunAd, Stok, AlisFiyat, SatisFiyat, Kategori) values (@p1, @p2, @p3, @p4, @p5)", baglanti);
			komut3.Parameters.AddWithValue("@p1", TxtAd.Text);
			komut3.Parameters.AddWithValue("@p2", NudStok.Value);
			komut3.Parameters.AddWithValue("@p3", TxtAlisFiyat.Text);
			komut3.Parameters.AddWithValue("@p4", TxtSatisFiyat.Text);
			komut3.Parameters.AddWithValue("@p5", comboBox1.SelectedValue);
			komut3.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Ürün kaydı başarılı bir şekilde gerçekleşti");
		}

		private void BtnSil_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut4 = new SqlCommand("delete from tblurunler where urunId=@p1", baglanti);
			komut4.Parameters.AddWithValue("@p1", TxtID.Text);
			komut4.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("İstediğiniz ürünün silme işlemi başarılı bir şekilde gerçekleşti");
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			TxtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			TxtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			NudStok.Value = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
			TxtAlisFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			TxtSatisFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			comboBox1.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[6].Value;
		}

		private void BtnGuncelle_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut5 = new SqlCommand("update tblurunler set urunad=@p1, stok=@p2, Alisfiyat=@p3, SatisFiyat=@p4, Kategori=@p5 where urunId=@p6", baglanti);
			komut5.Parameters.AddWithValue("@p1", TxtAd.Text);
			komut5.Parameters.AddWithValue("@p2", NudStok.Value);
			komut5.Parameters.AddWithValue("@p3", decimal.Parse(TxtAlisFiyat.Text));
			komut5.Parameters.AddWithValue("@p4", decimal.Parse(TxtSatisFiyat.Text));
			komut5.Parameters.AddWithValue("@p5", comboBox1.SelectedValue);
			komut5.Parameters.AddWithValue("@p6", TxtID.Text);
			komut5.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Ürün bilgileri başarıyla güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
	}
}
