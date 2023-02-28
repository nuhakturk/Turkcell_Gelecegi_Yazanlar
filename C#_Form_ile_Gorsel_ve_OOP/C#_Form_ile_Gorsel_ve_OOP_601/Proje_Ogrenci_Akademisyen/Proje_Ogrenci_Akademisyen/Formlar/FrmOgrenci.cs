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
using Proje_Ogrenci_Akademisyen.Entity;

namespace Proje_Ogrenci_Akademisyen.Formlar
{
	public partial class FrmOgrenci : Form
	{
		public FrmOgrenci()
		{
			InitializeComponent();
		}

		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U5FIOK2\\SQLEXPRESS;Initial Catalog=OgrenciSinav;Integrated Security=True");
		OgrenciSinavEntities db = new OgrenciSinavEntities();

		void Listele()
		{
			var degerler = from x in db.TblOgrenci
						   select new
						   {
							   x.OgrID,
							   x.OgrAd,
							   x.OgrSoyad,
							   x.OgrNumara,
							   x.OgrSifre,
							   x.OgrMail,
							   x.OgrResim,
							   x.OgrBolum,
							   x.TblBolum.BolumAd
						   };
			dataGridView1.DataSource = degerler.ToList();
		}

		private void FrmOgrenci_Load(object sender, EventArgs e)
		{
			Listele();
			dataGridView1.Columns["OgrBolum"].Visible = false;
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

		private void BtnListele_Click(object sender, EventArgs e)
		{
			Listele();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			TxtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			TxtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			TxtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			TxtNumara.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			TxtSifre.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			TxtMail.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			TxtResim.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
			comboBox1.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
		}
	}
}
