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
			SqlCommand komut1 = new SqlCommand("Select * From TblUrunler", baglanti);
			SqlDataAdapter da = new SqlDataAdapter(komut1);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
		}

		
	}
}
