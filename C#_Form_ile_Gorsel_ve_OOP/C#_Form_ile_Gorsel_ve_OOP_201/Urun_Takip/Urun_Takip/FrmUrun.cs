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

	public partial class FrmUrun : Form
	{
		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U5FIOK2\\SQLEXPRESS;Initial Catalog=DbUrun;Integrated Security=True");

		public FrmUrun()
		{
			InitializeComponent();
		}

		private void BtnListele_Click(object sender, EventArgs e)
		{
			SqlCommand komut1 = new SqlCommand("Select * From TblUrunler", baglanti);
			SqlDataAdapter da = new SqlDataAdapter(komut1);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
		}
	}
}
