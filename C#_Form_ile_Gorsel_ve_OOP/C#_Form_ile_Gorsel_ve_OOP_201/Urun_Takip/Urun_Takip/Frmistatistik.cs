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
		}
	}
}
