namespace KatmanliMimariProje
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
			this.BtnKaydet = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.TxtID = new System.Windows.Forms.TextBox();
			this.TxtAd = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.BtnSil = new System.Windows.Forms.Button();
			this.BtnGuncelle = new System.Windows.Forms.Button();
			this.BtnListele = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(13, 13);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(495, 244);
			this.dataGridView1.TabIndex = 0;
			// 
			// BtnKaydet
			// 
			this.BtnKaydet.Location = new System.Drawing.Point(629, 87);
			this.BtnKaydet.Name = "BtnKaydet";
			this.BtnKaydet.Size = new System.Drawing.Size(145, 38);
			this.BtnKaydet.TabIndex = 1;
			this.BtnKaydet.Text = "Kaydet";
			this.BtnKaydet.UseVisualStyleBackColor = true;
			this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(545, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Ders ID:";
			// 
			// TxtID
			// 
			this.TxtID.Location = new System.Drawing.Point(629, 15);
			this.TxtID.Name = "TxtID";
			this.TxtID.Size = new System.Drawing.Size(145, 30);
			this.TxtID.TabIndex = 3;
			// 
			// TxtAd
			// 
			this.TxtAd.Location = new System.Drawing.Point(629, 51);
			this.TxtAd.Name = "TxtAd";
			this.TxtAd.Size = new System.Drawing.Size(145, 30);
			this.TxtAd.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(535, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "Ders Adı:";
			// 
			// BtnSil
			// 
			this.BtnSil.Location = new System.Drawing.Point(629, 131);
			this.BtnSil.Name = "BtnSil";
			this.BtnSil.Size = new System.Drawing.Size(145, 38);
			this.BtnSil.TabIndex = 6;
			this.BtnSil.Text = "Sil";
			this.BtnSil.UseVisualStyleBackColor = true;
			// 
			// BtnGuncelle
			// 
			this.BtnGuncelle.Location = new System.Drawing.Point(629, 175);
			this.BtnGuncelle.Name = "BtnGuncelle";
			this.BtnGuncelle.Size = new System.Drawing.Size(145, 38);
			this.BtnGuncelle.TabIndex = 7;
			this.BtnGuncelle.Text = "Güncelle";
			this.BtnGuncelle.UseVisualStyleBackColor = true;
			// 
			// BtnListele
			// 
			this.BtnListele.Location = new System.Drawing.Point(629, 219);
			this.BtnListele.Name = "BtnListele";
			this.BtnListele.Size = new System.Drawing.Size(145, 38);
			this.BtnListele.TabIndex = 8;
			this.BtnListele.Text = "Listele";
			this.BtnListele.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(782, 266);
			this.Controls.Add(this.BtnListele);
			this.Controls.Add(this.BtnGuncelle);
			this.Controls.Add(this.BtnSil);
			this.Controls.Add(this.TxtAd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TxtID);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BtnKaydet);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ders İşlemleri";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button BtnKaydet;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtID;
		private System.Windows.Forms.TextBox TxtAd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button BtnSil;
		private System.Windows.Forms.Button BtnGuncelle;
		private System.Windows.Forms.Button BtnListele;
	}
}

