﻿namespace Proje_Ogrenci_Akademisyen.Formlar
{
	partial class FrmGiris
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.TxtNumara = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.TxtSoyad = new System.Windows.Forms.TextBox();
			this.BtnGuncelle = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TxtNumara
			// 
			this.TxtNumara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
			this.TxtNumara.ForeColor = System.Drawing.Color.White;
			this.TxtNumara.Location = new System.Drawing.Point(138, 107);
			this.TxtNumara.Mask = "00000";
			this.TxtNumara.Name = "TxtNumara";
			this.TxtNumara.Size = new System.Drawing.Size(249, 28);
			this.TxtNumara.TabIndex = 0;
			this.TxtNumara.ValidatingType = typeof(int);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(47, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 22);
			this.label3.TabIndex = 6;
			this.label3.Text = "Numara:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(80, 144);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 22);
			this.label1.TabIndex = 8;
			this.label1.Text = "Şifre";
			// 
			// TxtSoyad
			// 
			this.TxtSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
			this.TxtSoyad.ForeColor = System.Drawing.Color.White;
			this.TxtSoyad.Location = new System.Drawing.Point(138, 141);
			this.TxtSoyad.Name = "TxtSoyad";
			this.TxtSoyad.Size = new System.Drawing.Size(249, 28);
			this.TxtSoyad.TabIndex = 1;
			this.TxtSoyad.UseSystemPasswordChar = true;
			// 
			// BtnGuncelle
			// 
			this.BtnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
			this.BtnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnGuncelle.ForeColor = System.Drawing.Color.White;
			this.BtnGuncelle.Location = new System.Drawing.Point(138, 207);
			this.BtnGuncelle.Name = "BtnGuncelle";
			this.BtnGuncelle.Size = new System.Drawing.Size(249, 37);
			this.BtnGuncelle.TabIndex = 3;
			this.BtnGuncelle.Text = "Giriş Yap";
			this.BtnGuncelle.UseVisualStyleBackColor = false;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.ForeColor = System.Drawing.Color.White;
			this.checkBox1.Location = new System.Drawing.Point(262, 175);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(125, 26);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "Beni Hatırla";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.LinkColor = System.Drawing.Color.White;
			this.linkLabel1.Location = new System.Drawing.Point(194, 256);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(137, 22);
			this.linkLabel1.TabIndex = 4;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Şifremi Unuttum";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(53, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(398, 34);
			this.label2.TabIndex = 14;
			this.label2.Text = "Öğrenci - Akademisyen Not Sistemi";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(59, 318);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(382, 20);
			this.label4.TabIndex = 15;
			this.label4.Text = "Geleceği Yazanlar 2023 Projesidir - Tüm Hakları Saklıdır\r\n";
			// 
			// FrmGiris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(444, 351);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.BtnGuncelle);
			this.Controls.Add(this.TxtSoyad);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.TxtNumara);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FrmGiris";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmGiris";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MaskedTextBox TxtNumara;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtSoyad;
		private System.Windows.Forms.Button BtnGuncelle;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
	}
}