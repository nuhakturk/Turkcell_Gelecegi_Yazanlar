﻿namespace Urun_Takip_Entity
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
			this.label1 = new System.Windows.Forms.Label();
			this.TxtID = new System.Windows.Forms.TextBox();
			this.BtnListele = new System.Windows.Forms.Button();
			this.TxtAd = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtSoyad = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TxtSehir = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.TxtBakiye = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.BtnKaydet = new System.Windows.Forms.Button();
			this.BtnSil = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(638, 365);
			this.dataGridView1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(722, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "ID:";
			// 
			// TxtID
			// 
			this.TxtID.Location = new System.Drawing.Point(765, 25);
			this.TxtID.Name = "TxtID";
			this.TxtID.Size = new System.Drawing.Size(146, 30);
			this.TxtID.TabIndex = 2;
			// 
			// BtnListele
			// 
			this.BtnListele.Location = new System.Drawing.Point(734, 215);
			this.BtnListele.Name = "BtnListele";
			this.BtnListele.Size = new System.Drawing.Size(177, 43);
			this.BtnListele.TabIndex = 3;
			this.BtnListele.Text = "Listele";
			this.BtnListele.UseVisualStyleBackColor = true;
			this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
			// 
			// TxtAd
			// 
			this.TxtAd.Location = new System.Drawing.Point(765, 61);
			this.TxtAd.Name = "TxtAd";
			this.TxtAd.Size = new System.Drawing.Size(146, 30);
			this.TxtAd.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(716, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "Ad:";
			// 
			// TxtSoyad
			// 
			this.TxtSoyad.Location = new System.Drawing.Point(765, 97);
			this.TxtSoyad.Name = "TxtSoyad";
			this.TxtSoyad.Size = new System.Drawing.Size(146, 30);
			this.TxtSoyad.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(684, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 25);
			this.label3.TabIndex = 6;
			this.label3.Text = "Soyad:";
			// 
			// TxtSehir
			// 
			this.TxtSehir.Location = new System.Drawing.Point(765, 133);
			this.TxtSehir.Name = "TxtSehir";
			this.TxtSehir.Size = new System.Drawing.Size(146, 30);
			this.TxtSehir.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(695, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 25);
			this.label4.TabIndex = 8;
			this.label4.Text = "Şehir:";
			// 
			// TxtBakiye
			// 
			this.TxtBakiye.Location = new System.Drawing.Point(765, 169);
			this.TxtBakiye.Name = "TxtBakiye";
			this.TxtBakiye.Size = new System.Drawing.Size(146, 30);
			this.TxtBakiye.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(682, 172);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 25);
			this.label5.TabIndex = 10;
			this.label5.Text = "Bakiye:";
			// 
			// BtnKaydet
			// 
			this.BtnKaydet.Location = new System.Drawing.Point(734, 264);
			this.BtnKaydet.Name = "BtnKaydet";
			this.BtnKaydet.Size = new System.Drawing.Size(177, 43);
			this.BtnKaydet.TabIndex = 12;
			this.BtnKaydet.Text = "Kaydet";
			this.BtnKaydet.UseVisualStyleBackColor = true;
			this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// BtnSil
			// 
			this.BtnSil.Location = new System.Drawing.Point(734, 313);
			this.BtnSil.Name = "BtnSil";
			this.BtnSil.Size = new System.Drawing.Size(177, 43);
			this.BtnSil.TabIndex = 13;
			this.BtnSil.Text = "Sil";
			this.BtnSil.UseVisualStyleBackColor = true;
			this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(923, 389);
			this.Controls.Add(this.BtnSil);
			this.Controls.Add(this.BtnKaydet);
			this.Controls.Add(this.TxtBakiye);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.TxtSehir);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.TxtSoyad);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.TxtAd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.BtnListele);
			this.Controls.Add(this.TxtID);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtID;
		private System.Windows.Forms.Button BtnListele;
		private System.Windows.Forms.TextBox TxtAd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtSoyad;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TxtSehir;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TxtBakiye;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button BtnKaydet;
		private System.Windows.Forms.Button BtnSil;
	}
}

