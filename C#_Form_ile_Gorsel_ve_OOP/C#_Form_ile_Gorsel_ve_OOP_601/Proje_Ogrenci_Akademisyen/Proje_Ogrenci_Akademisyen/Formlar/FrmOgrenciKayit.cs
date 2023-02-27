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
	public partial class FrmOgrenciKayit : Form
	{
		public FrmOgrenciKayit()
		{
			InitializeComponent();
		}

		//Data Source=DESKTOP-U5FIOK2\SQLEXPRESS;Initial Catalog=OgrenciSinav;Integrated Security=True
		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U5FIOK2\\SQLEXPRESS;Initial Catalog=OgrenciSinav;Integrated Security=True");
		OgrenciSinavEntities db = new OgrenciSinavEntities();

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
			//textBox1.Text = comboBox1.SelectedValue.ToString();
			TblOgrenci t = new TblOgrenci();
			t.OgrAd = TxtAd.Text;
			t.OgrSoyad = TxtSoyad.Text;
			t.OgrNumara = TxtNumara.Text;
			t.OgrSifre = TxtSifre.Text;
			t.OgrMail = TxtMail.Text;
			t.OgrResim = TxtResim.Text;
			t.OgrBolum = int.Parse(comboBox1.SelectedValue.ToString());
			db.TblOgrenci.Add(t);
			db.SaveChanges();
			MessageBox.Show("Öğrenci bilgileri sisteme başarılı bir şekilde kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
