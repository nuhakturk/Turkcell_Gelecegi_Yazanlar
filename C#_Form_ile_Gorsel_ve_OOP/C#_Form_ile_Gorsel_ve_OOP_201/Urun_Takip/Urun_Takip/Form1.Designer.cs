﻿namespace Urun_Takip
{
	partial class Form1
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.TxtID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtKategoriAd = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.BtnListele = new System.Windows.Forms.Button();
			this.BtnKaydet = new System.Windows.Forms.Button();
			this.BtnSil = new System.Windows.Forms.Button();
			this.BtnGuncelle = new System.Windows.Forms.Button();
			this.BtnAra = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 99);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(507, 270);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.TxtID);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.TxtKategoriAd);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(13, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(507, 81);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// TxtID
			// 
			this.TxtID.Location = new System.Drawing.Point(371, 31);
			this.TxtID.Name = "TxtID";
			this.TxtID.Size = new System.Drawing.Size(116, 30);
			this.TxtID.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(328, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "ID:";
			// 
			// TxtKategoriAd
			// 
			this.TxtKategoriAd.Location = new System.Drawing.Point(141, 31);
			this.TxtKategoriAd.Name = "TxtKategoriAd";
			this.TxtKategoriAd.Size = new System.Drawing.Size(138, 30);
			this.TxtKategoriAd.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kategori Adı:";
			// 
			// BtnListele
			// 
			this.BtnListele.Location = new System.Drawing.Point(538, 99);
			this.BtnListele.Name = "BtnListele";
			this.BtnListele.Size = new System.Drawing.Size(156, 44);
			this.BtnListele.TabIndex = 2;
			this.BtnListele.Text = "Listele";
			this.BtnListele.UseVisualStyleBackColor = true;
			this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
			// 
			// BtnKaydet
			// 
			this.BtnKaydet.Location = new System.Drawing.Point(538, 149);
			this.BtnKaydet.Name = "BtnKaydet";
			this.BtnKaydet.Size = new System.Drawing.Size(156, 44);
			this.BtnKaydet.TabIndex = 3;
			this.BtnKaydet.Text = "Kaydet";
			this.BtnKaydet.UseVisualStyleBackColor = true;
			this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// BtnSil
			// 
			this.BtnSil.Location = new System.Drawing.Point(538, 199);
			this.BtnSil.Name = "BtnSil";
			this.BtnSil.Size = new System.Drawing.Size(156, 44);
			this.BtnSil.TabIndex = 4;
			this.BtnSil.Text = "Sil";
			this.BtnSil.UseVisualStyleBackColor = true;
			this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
			// 
			// BtnGuncelle
			// 
			this.BtnGuncelle.Location = new System.Drawing.Point(538, 249);
			this.BtnGuncelle.Name = "BtnGuncelle";
			this.BtnGuncelle.Size = new System.Drawing.Size(156, 44);
			this.BtnGuncelle.TabIndex = 5;
			this.BtnGuncelle.Text = "Güncelle";
			this.BtnGuncelle.UseVisualStyleBackColor = true;
			this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
			// 
			// BtnAra
			// 
			this.BtnAra.Location = new System.Drawing.Point(538, 299);
			this.BtnAra.Name = "BtnAra";
			this.BtnAra.Size = new System.Drawing.Size(156, 44);
			this.BtnAra.TabIndex = 6;
			this.BtnAra.Text = "Ara";
			this.BtnAra.UseVisualStyleBackColor = true;
			this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(712, 381);
			this.Controls.Add(this.BtnAra);
			this.Controls.Add(this.BtnGuncelle);
			this.Controls.Add(this.BtnSil);
			this.Controls.Add(this.BtnKaydet);
			this.Controls.Add(this.BtnListele);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kategoriler";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox TxtKategoriAd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnListele;
		private System.Windows.Forms.Button BtnKaydet;
		private System.Windows.Forms.Button BtnSil;
		private System.Windows.Forms.Button BtnGuncelle;
		private System.Windows.Forms.Button BtnAra;
		private System.Windows.Forms.TextBox TxtID;
		private System.Windows.Forms.Label label2;
	}
}

