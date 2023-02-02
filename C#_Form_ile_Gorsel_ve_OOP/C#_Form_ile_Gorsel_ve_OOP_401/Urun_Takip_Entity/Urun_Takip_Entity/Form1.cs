using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urun_Takip_Entity
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		DbUrunEntities db = new DbUrunEntities();
		
		private void BtnListele_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = db.TBLMUSTERI.ToList();
		}
	}
}
