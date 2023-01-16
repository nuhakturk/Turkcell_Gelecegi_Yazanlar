using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Urun_Takip
{
	public partial class Frmistatistik : Form
	{
		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U5FIOK2\\SQLEXPRESS;Initial Catalog=DbUrun;Integrated Security=True");

		public Frmistatistik()
		{
			InitializeComponent();
		}

		private void Frmistatistik_Load(object sender, EventArgs e)
		{
			//Toplam Kategori Sayısı
			baglanti.Open();
			SqlCommand komut1 = new SqlCommand("Select COUNT(*) From TBLKATEGORI", baglanti);
			SqlDataReader dr = komut1.ExecuteReader();
			while(dr.Read())
			{
				LblToplamKategori.Text = dr[0].ToString();
			}
			baglanti.Close();

			//Toplam Ürün Sayısı
			baglanti.Open();
			SqlCommand komut2 = new SqlCommand("Select COUNT(*) From TBLURUNLER", baglanti);
			SqlDataReader dr2 = komut2.ExecuteReader();
			while (dr2.Read())
			{
				LblToplamUrun.Text = dr2[0].ToString();
			}
			baglanti.Close();

			//Toplam Beyaz Eşya Sayısı
			baglanti.Open();
			SqlCommand komut3 = new SqlCommand("Select COUNT(*) From TBLURUNLER where Kategori=(Select ID From TBLKATEGORI where Ad = 'Beyaz Eşya')", baglanti);
			SqlDataReader dr3 = komut3.ExecuteReader();
			while (dr3.Read())
			{
				LblBeyazEsya.Text = dr3[0].ToString();
			}
			baglanti.Close();

			//Toplam Küçük Ev Aleti Sayısı
			baglanti.Open();
			SqlCommand komut4 = new SqlCommand("Select COUNT(*) From TBLURUNLER where Kategori=(Select ID From TBLKATEGORI where Ad = 'Küçük Ev Aletleri')", baglanti);
			SqlDataReader dr4 = komut4.ExecuteReader();
			while (dr4.Read())
			{
				LblKucukEvAleti.Text = dr4[0].ToString();
			}
			baglanti.Close();

			//En Yüksek Stoklu Ürün
			baglanti.Open();
			SqlCommand komut5 = new SqlCommand("Select * From TBLURUNLER where Stok=(Select Max(Stok) From TBLURUNLER)", baglanti);
			SqlDataReader dr5 = komut5.ExecuteReader();
			while (dr5.Read())
			{
				LblEnYuksekStok.Text = dr5["UrunAd"].ToString();
			}
			baglanti.Close();

			//En Düşük Stoklu Ürün
			baglanti.Open();
			SqlCommand komut6 = new SqlCommand("Select * From TBLURUNLER where Stok=(Select Min(Stok) From TBLURUNLER)", baglanti);
			SqlDataReader dr6 = komut6.ExecuteReader();
			while (dr6.Read())
			{
				LblEnDusukStok.Text = dr6["UrunAd"].ToString();
			}
			baglanti.Close();
		}
	}
}
