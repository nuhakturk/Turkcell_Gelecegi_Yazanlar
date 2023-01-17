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
	public partial class FrmGrafikler : Form
	{
		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U5FIOK2\\SQLEXPRESS;Initial Catalog=DbUrun;Integrated Security=True");

		public FrmGrafikler()
		{
			InitializeComponent();
		}

		private void FrmGrafikler_Load(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("Select Ad, Count(*) From TBLURUNLER inner join TBLKATEGORI on TBLURUNLER.Kategori=TBLKATEGORI.ID Group By Ad", baglanti);
			SqlDataReader dr = komut.ExecuteReader();
			while(dr.Read())
			{
				chart1.Series["Kategori"].Points.AddXY(dr[0], dr[1]);
			}
			baglanti.Close();
		}
	}
}
