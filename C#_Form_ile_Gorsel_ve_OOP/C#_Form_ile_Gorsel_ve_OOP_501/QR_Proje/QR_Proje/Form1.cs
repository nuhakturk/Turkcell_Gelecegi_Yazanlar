using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace QR_Proje
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//Oluşturma işlemi encoder
			QRCodeEncoder enc = new QRCodeEncoder();
			pictureBox1.Image = enc.Encode(textBox1.Text);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			QRCodeDecoder dnc = new QRCodeDecoder();
			textBox1.Text = dnc.Decode(new QRCodeBitmapImage(pictureBox1.Image as Bitmap));
		}
	}
}
