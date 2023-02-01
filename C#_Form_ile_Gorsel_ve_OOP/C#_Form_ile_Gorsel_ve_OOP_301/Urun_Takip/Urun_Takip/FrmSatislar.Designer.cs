namespace Urun_Takip
{
	partial class FrmSatislar
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
			this.MskTarih = new System.Windows.Forms.MaskedTextBox();
			this.TxtMusteri = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.TxtToplam = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.BtnGuncelle = new System.Windows.Forms.Button();
			this.BtnHesapla = new System.Windows.Forms.Button();
			this.BtnKaydet = new System.Windows.Forms.Button();
			this.BtnListele = new System.Windows.Forms.Button();
			this.TxtFiyat = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.TxtAdet = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 17);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(753, 455);
			this.dataGridView1.TabIndex = 7;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.MskTarih);
			this.groupBox1.Controls.Add(this.TxtMusteri);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.TxtToplam);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.BtnGuncelle);
			this.groupBox1.Controls.Add(this.BtnHesapla);
			this.groupBox1.Controls.Add(this.BtnKaydet);
			this.groupBox1.Controls.Add(this.BtnListele);
			this.groupBox1.Controls.Add(this.TxtFiyat);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.TxtAdet);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.TxtID);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(771, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(290, 465);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			// 
			// MskTarih
			// 
			this.MskTarih.Location = new System.Drawing.Point(141, 229);
			this.MskTarih.Mask = "00/00/0000";
			this.MskTarih.Name = "MskTarih";
			this.MskTarih.Size = new System.Drawing.Size(138, 28);
			this.MskTarih.TabIndex = 16;
			this.MskTarih.ValidatingType = typeof(System.DateTime);
			// 
			// TxtMusteri
			// 
			this.TxtMusteri.Location = new System.Drawing.Point(141, 91);
			this.TxtMusteri.Name = "TxtMusteri";
			this.TxtMusteri.Size = new System.Drawing.Size(138, 28);
			this.TxtMusteri.TabIndex = 15;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(141, 56);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(138, 30);
			this.comboBox1.TabIndex = 14;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(77, 230);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(52, 22);
			this.label8.TabIndex = 13;
			this.label8.Text = "Tarih";
			// 
			// TxtToplam
			// 
			this.TxtToplam.Location = new System.Drawing.Point(141, 192);
			this.TxtToplam.Name = "TxtToplam";
			this.TxtToplam.Size = new System.Drawing.Size(138, 28);
			this.TxtToplam.TabIndex = 10;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(54, 196);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 22);
			this.label7.TabIndex = 11;
			this.label7.Text = "Toplam:";
			// 
			// BtnGuncelle
			// 
			this.BtnGuncelle.Location = new System.Drawing.Point(123, 415);
			this.BtnGuncelle.Name = "BtnGuncelle";
			this.BtnGuncelle.Size = new System.Drawing.Size(156, 44);
			this.BtnGuncelle.TabIndex = 9;
			this.BtnGuncelle.Text = "Güncelle";
			this.BtnGuncelle.UseVisualStyleBackColor = true;
			this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
			// 
			// BtnHesapla
			// 
			this.BtnHesapla.Location = new System.Drawing.Point(123, 365);
			this.BtnHesapla.Name = "BtnHesapla";
			this.BtnHesapla.Size = new System.Drawing.Size(156, 44);
			this.BtnHesapla.TabIndex = 8;
			this.BtnHesapla.Text = "Hesapla";
			this.BtnHesapla.UseVisualStyleBackColor = true;
			this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
			// 
			// BtnKaydet
			// 
			this.BtnKaydet.Location = new System.Drawing.Point(123, 315);
			this.BtnKaydet.Name = "BtnKaydet";
			this.BtnKaydet.Size = new System.Drawing.Size(156, 44);
			this.BtnKaydet.TabIndex = 7;
			this.BtnKaydet.Text = "Kaydet";
			this.BtnKaydet.UseVisualStyleBackColor = true;
			this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// BtnListele
			// 
			this.BtnListele.Location = new System.Drawing.Point(123, 265);
			this.BtnListele.Name = "BtnListele";
			this.BtnListele.Size = new System.Drawing.Size(156, 44);
			this.BtnListele.TabIndex = 6;
			this.BtnListele.Text = "Listele";
			this.BtnListele.UseVisualStyleBackColor = true;
			this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
			// 
			// TxtFiyat
			// 
			this.TxtFiyat.Location = new System.Drawing.Point(141, 158);
			this.TxtFiyat.Name = "TxtFiyat";
			this.TxtFiyat.Size = new System.Drawing.Size(138, 28);
			this.TxtFiyat.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(75, 162);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 22);
			this.label5.TabIndex = 8;
			this.label5.Text = "Fiyat:";
			// 
			// TxtAdet
			// 
			this.TxtAdet.Location = new System.Drawing.Point(141, 124);
			this.TxtAdet.Name = "TxtAdet";
			this.TxtAdet.Size = new System.Drawing.Size(138, 28);
			this.TxtAdet.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(77, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 22);
			this.label4.TabIndex = 6;
			this.label4.Text = "Adet:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(56, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 22);
			this.label3.TabIndex = 4;
			this.label3.Text = "Müşteri:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(75, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 22);
			this.label2.TabIndex = 2;
			this.label2.Text = "Ürün:";
			// 
			// TxtID
			// 
			this.TxtID.Location = new System.Drawing.Point(141, 22);
			this.TxtID.Name = "TxtID";
			this.TxtID.Size = new System.Drawing.Size(138, 28);
			this.TxtID.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(52, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Satış ID:";
			// 
			// FrmSatislar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1073, 479);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmSatislar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmSatislar";
			this.Load += new System.EventHandler(this.FrmSatislar_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox TxtMusteri;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox TxtToplam;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button BtnGuncelle;
		private System.Windows.Forms.Button BtnHesapla;
		private System.Windows.Forms.Button BtnKaydet;
		private System.Windows.Forms.Button BtnListele;
		private System.Windows.Forms.TextBox TxtFiyat;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TxtAdet;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox MskTarih;
	}
}