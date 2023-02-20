using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using BusinessLayer;

namespace KatmanliMimariProje
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			EntityDers ent = new EntityDers();
			ent.DersAd = TxtAd.Text;
			BLDers.DersEkleBL(ent);
		}

		private void BtnListele_Click(object sender, EventArgs e)
		{
			List<EntityDers> ders = BLDers.DersListesiBL();
			dataGridView1.DataSource = ders;
		}
	}
}
