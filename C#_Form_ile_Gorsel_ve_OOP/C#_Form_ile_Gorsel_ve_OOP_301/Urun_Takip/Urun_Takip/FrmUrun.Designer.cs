﻿namespace Urun_Takip
{
	partial class FrmUrun
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.BtnListele = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.NudStok = new System.Windows.Forms.NumericUpDown();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.BtnGuncelle = new System.Windows.Forms.Button();
			this.BtnSil = new System.Windows.Forms.Button();
			this.BtnKaydet = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.TxtSatisFiyat = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.TxtAlisFiyat = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.TxtAd = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NudStok)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(753, 455);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// BtnListele
			// 
			this.BtnListele.Location = new System.Drawing.Point(123, 248);
			this.BtnListele.Name = "BtnListele";
			this.BtnListele.Size = new System.Drawing.Size(156, 44);
			this.BtnListele.TabIndex = 4;
			this.BtnListele.Text = "Listele";
			this.BtnListele.UseVisualStyleBackColor = true;
			this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.NudStok);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.BtnGuncelle);
			this.groupBox1.Controls.Add(this.BtnSil);
			this.groupBox1.Controls.Add(this.BtnKaydet);
			this.groupBox1.Controls.Add(this.BtnListele);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.TxtSatisFiyat);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.TxtAlisFiyat);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.TxtAd);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.TxtID);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(771, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(290, 465);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			// 
			// NudStok
			// 
			this.NudStok.Location = new System.Drawing.Point(141, 99);
			this.NudStok.Name = "NudStok";
			this.NudStok.Size = new System.Drawing.Size(138, 28);
			this.NudStok.TabIndex = 16;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(141, 202);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(138, 30);
			this.comboBox1.TabIndex = 15;
			// 
			// BtnGuncelle
			// 
			this.BtnGuncelle.Location = new System.Drawing.Point(123, 398);
			this.BtnGuncelle.Name = "BtnGuncelle";
			this.BtnGuncelle.Size = new System.Drawing.Size(156, 44);
			this.BtnGuncelle.TabIndex = 14;
			this.BtnGuncelle.Text = "Güncelle";
			this.BtnGuncelle.UseVisualStyleBackColor = true;
			this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
			// 
			// BtnSil
			// 
			this.BtnSil.Location = new System.Drawing.Point(123, 348);
			this.BtnSil.Name = "BtnSil";
			this.BtnSil.Size = new System.Drawing.Size(156, 44);
			this.BtnSil.TabIndex = 13;
			this.BtnSil.Text = "Sil";
			this.BtnSil.UseVisualStyleBackColor = true;
			this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
			// 
			// BtnKaydet
			// 
			this.BtnKaydet.Location = new System.Drawing.Point(123, 298);
			this.BtnKaydet.Name = "BtnKaydet";
			this.BtnKaydet.Size = new System.Drawing.Size(156, 44);
			this.BtnKaydet.TabIndex = 12;
			this.BtnKaydet.Text = "Kaydet";
			this.BtnKaydet.UseVisualStyleBackColor = true;
			this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(59, 205);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 22);
			this.label6.TabIndex = 10;
			this.label6.Text = "Kategori:";
			// 
			// TxtSatisFiyat
			// 
			this.TxtSatisFiyat.Location = new System.Drawing.Point(141, 167);
			this.TxtSatisFiyat.Name = "TxtSatisFiyat";
			this.TxtSatisFiyat.Size = new System.Drawing.Size(138, 28);
			this.TxtSatisFiyat.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(38, 171);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(103, 22);
			this.label5.TabIndex = 8;
			this.label5.Text = "Satış Fiyatı:";
			// 
			// TxtAlisFiyat
			// 
			this.TxtAlisFiyat.Location = new System.Drawing.Point(141, 133);
			this.TxtAlisFiyat.Name = "TxtAlisFiyat";
			this.TxtAlisFiyat.Size = new System.Drawing.Size(138, 28);
			this.TxtAlisFiyat.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(49, 137);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 22);
			this.label4.TabIndex = 6;
			this.label4.Text = "Alış Fiyatı:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(90, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 22);
			this.label3.TabIndex = 4;
			this.label3.Text = "Stok:";
			// 
			// TxtAd
			// 
			this.TxtAd.Location = new System.Drawing.Point(141, 65);
			this.TxtAd.Name = "TxtAd";
			this.TxtAd.Size = new System.Drawing.Size(138, 28);
			this.TxtAd.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(56, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 22);
			this.label2.TabIndex = 2;
			this.label2.Text = "Ürün Adı:";
			// 
			// TxtID
			// 
			this.TxtID.Location = new System.Drawing.Point(141, 31);
			this.TxtID.Name = "TxtID";
			this.TxtID.Size = new System.Drawing.Size(138, 28);
			this.TxtID.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(65, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ürün ID:";
			// 
			// FrmUrun
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1073, 479);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmUrun";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmUrun";
			this.Load += new System.EventHandler(this.FrmUrun_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NudStok)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button BtnListele;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button BtnGuncelle;
		private System.Windows.Forms.Button BtnSil;
		private System.Windows.Forms.Button BtnKaydet;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox TxtSatisFiyat;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TxtAlisFiyat;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TxtAd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown NudStok;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}