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

namespace Proje_Ogrenci_Akademisyen.Formlar
{
	public partial class FrmGiris : Form
	{
		public FrmGiris()
		{
			InitializeComponent();
		}

		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U5FIOK2\\SQLEXPRESS;Initial Catalog=OgrenciSinav;Integrated Security=True");

		private void BtnGirisYap_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("Select * From TblOgrenci Where OgrNumara=@p1 and OgrSifre=@p2", baglanti);
			komut.Parameters.AddWithValue("@p1", TxtNumara.Text);
			komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
			SqlDataReader dr = komut.ExecuteReader();
			if(dr.Read())
			{
				FrmOgrenciPanel frm = new FrmOgrenciPanel();
				frm.numara = TxtNumara.Text;
				frm.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Numaranız veya şifreniz hatalıdır, lütfen tekrar deneyin","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			baglanti.Close();
		}
	}
}
