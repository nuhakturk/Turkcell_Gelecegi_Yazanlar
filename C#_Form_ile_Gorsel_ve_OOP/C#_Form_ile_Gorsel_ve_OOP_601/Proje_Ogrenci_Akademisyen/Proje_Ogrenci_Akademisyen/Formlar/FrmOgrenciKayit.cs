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
	public partial class FrmOgrenciKayit : Form
	{
		public FrmOgrenciKayit()
		{
			InitializeComponent();
		}

		//Data Source=DESKTOP-U5FIOK2\SQLEXPRESS;Initial Catalog=OgrenciSinav;Integrated Security=True
		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U5FIOK2\\SQLEXPRESS;Initial Catalog=OgrenciSinav;Integrated Security=True");

		private void FrmOgrenciKayit_Load(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("Select * From TblBolum", baglanti);
			//SqlDataReader dr = komut.ExecuteReader();
			SqlDataAdapter da = new SqlDataAdapter(komut);
			DataTable ds = new DataTable();
			da.Fill(ds);
			comboBox1.ValueMember = "BolumID";
			comboBox1.DisplayMember = "BolumAd";
			comboBox1.DataSource = ds;
		}

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			textBox1.Text = comboBox1.SelectedValue.ToString();
		}
	}
}
