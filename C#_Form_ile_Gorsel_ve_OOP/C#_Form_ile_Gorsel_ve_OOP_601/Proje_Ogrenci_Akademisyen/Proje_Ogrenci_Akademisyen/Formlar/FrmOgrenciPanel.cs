﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Ogrenci_Akademisyen.Formlar
{
	public partial class FrmOgrenciPanel : Form
	{
		public FrmOgrenciPanel()
		{
			InitializeComponent();
		}

		public string numara;
		private void FrmOgrenciPanel_Load(object sender, EventArgs e)
		{
			TxtNumara.Text = numara;
		}
	}
}
