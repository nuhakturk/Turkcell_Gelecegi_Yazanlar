using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temel_Arac_Kullanimlari_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            chart1.Series["Bolge"].Points.AddXY("Akdeniz", 15);
            chart1.Series["Bolge"].Points.AddXY("Ege", 23);
            chart1.Series["Bolge"].Points.AddXY("Karadeniz", 17);
            chart1.Series["Bolge"].Points.AddXY("Doğu Anadolu", 16);
            chart1.Series["Bolge"].Points.AddXY("Marmara", 24);
        }
    }
}
