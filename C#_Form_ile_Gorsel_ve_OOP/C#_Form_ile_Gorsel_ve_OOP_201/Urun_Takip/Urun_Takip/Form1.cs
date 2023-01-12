using System;
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
	public partial class Form1 : Form
	{
		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U5FIOK2\\SQLEXPRESS;Initial Catalog=DbUrun;Integrated Security=True");

		public Form1()
		{
			InitializeComponent();
		}

		private void BtnListele_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("Select * From TBLKATEGORI", baglanti);
			SqlDataAdapter da = new SqlDataAdapter(komut);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
		}

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut2 = new SqlCommand("insert into TBLKATEGORI (Ad) Values (@p1)", baglanti);
			komut2.Parameters.AddWithValue("@p1", TxtKategoriAd.Text);
			komut2.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Kategoriniz başarılı bir şekilde eklendi");
		}
	}
}
//Data Source=DESKTOP-U5FIOK2\SQLEXPRESS;Initial Catalog=DbUrun;Integrated Security=True