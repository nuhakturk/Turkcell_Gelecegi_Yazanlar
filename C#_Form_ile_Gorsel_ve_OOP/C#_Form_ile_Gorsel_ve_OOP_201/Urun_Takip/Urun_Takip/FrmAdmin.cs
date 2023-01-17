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


namespace Urun_Takip
{
	public partial class FrmAdmin : Form
	{
		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U5FIOK2\\SQLEXPRESS;Initial Catalog=DbUrun;Integrated Security=True");

		public FrmAdmin()
		{
			InitializeComponent();
		}

		private void BtnGirisYap_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("Select * From TBLADMIN where Kullanici=@p1 and Sifre=@p2", baglanti);
			komut.Parameters.AddWithValue("@p1", TxtKullanici.Text);
			komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
			SqlDataReader dr=komut.ExecuteReader();
			if(dr.Read())
			{
				FrmUrun fr = new FrmUrun();
				fr.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Kullanıcı adı veya şifrenizde hata var yeniden deneyin");
			}
			baglanti.Close();
		}
	}
}
