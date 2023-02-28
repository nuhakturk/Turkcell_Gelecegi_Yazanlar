namespace Proje_Ogrenci_Akademisyen.Formlar
{
	partial class FrmOgrenci
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.TxtNumara = new System.Windows.Forms.MaskedTextBox();
			this.BtnListele = new System.Windows.Forms.Button();
			this.TxtID = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.BtnResimSec = new System.Windows.Forms.Button();
			this.BtnGuncelle = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.TxtResim = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.TxtMail = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.TxtSifre = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.TxtSoyad = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtAd = new System.Windows.Forms.TextBox();
			this.BtnSil = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.TxtNumara);
			this.groupBox1.Controls.Add(this.BtnListele);
			this.groupBox1.Controls.Add(this.TxtID);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.BtnResimSec);
			this.groupBox1.Controls.Add(this.BtnGuncelle);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.TxtResim);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.TxtMail);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.TxtSifre);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.TxtSoyad);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.TxtAd);
			this.groupBox1.Controls.Add(this.BtnSil);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(852, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(434, 504);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// TxtNumara
			// 
			this.TxtNumara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
			this.TxtNumara.ForeColor = System.Drawing.Color.White;
			this.TxtNumara.Location = new System.Drawing.Point(130, 168);
			this.TxtNumara.Mask = "00000";
			this.TxtNumara.Name = "TxtNumara";
			this.TxtNumara.Size = new System.Drawing.Size(249, 28);
			this.TxtNumara.TabIndex = 3;
			this.TxtNumara.ValidatingType = typeof(int);
			// 
			// BtnListele
			// 
			this.BtnListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
			this.BtnListele.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnListele.ForeColor = System.Drawing.Color.White;
			this.BtnListele.Location = new System.Drawing.Point(142, 447);
			this.BtnListele.Name = "BtnListele";
			this.BtnListele.Size = new System.Drawing.Size(223, 37);
			this.BtnListele.TabIndex = 11;
			this.BtnListele.Text = "Listele";
			this.BtnListele.UseVisualStyleBackColor = false;
			this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
			// 
			// TxtID
			// 
			this.TxtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
			this.TxtID.Enabled = false;
			this.TxtID.ForeColor = System.Drawing.Color.White;
			this.TxtID.Location = new System.Drawing.Point(130, 66);
			this.TxtID.Name = "TxtID";
			this.TxtID.Size = new System.Drawing.Size(249, 28);
			this.TxtID.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(92, 69);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 22);
			this.label5.TabIndex = 9;
			this.label5.Text = "ID:";
			// 
			// BtnResimSec
			// 
			this.BtnResimSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
			this.BtnResimSec.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnResimSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnResimSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnResimSec.ForeColor = System.Drawing.Color.White;
			this.BtnResimSec.Location = new System.Drawing.Point(385, 269);
			this.BtnResimSec.Name = "BtnResimSec";
			this.BtnResimSec.Size = new System.Drawing.Size(30, 26);
			this.BtnResimSec.TabIndex = 7;
			this.BtnResimSec.Text = "...";
			this.BtnResimSec.UseVisualStyleBackColor = false;
			this.BtnResimSec.Click += new System.EventHandler(this.BtnResimSec_Click);
			// 
			// BtnGuncelle
			// 
			this.BtnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
			this.BtnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnGuncelle.ForeColor = System.Drawing.Color.White;
			this.BtnGuncelle.Location = new System.Drawing.Point(142, 404);
			this.BtnGuncelle.Name = "BtnGuncelle";
			this.BtnGuncelle.Size = new System.Drawing.Size(223, 37);
			this.BtnGuncelle.TabIndex = 10;
			this.BtnGuncelle.Text = "Güncelle";
			this.BtnGuncelle.UseVisualStyleBackColor = false;
			this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(97, 24);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(246, 22);
			this.label9.TabIndex = 17;
			this.label9.Text = "Öğrenci Düzenleme Formu";
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
			this.comboBox1.ForeColor = System.Drawing.Color.White;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            ""});
			this.comboBox1.Location = new System.Drawing.Point(130, 305);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(249, 30);
			this.comboBox1.TabIndex = 8;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(56, 308);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(71, 22);
			this.label8.TabIndex = 15;
			this.label8.Text = "Bölüm:";
			// 
			// TxtResim
			// 
			this.TxtResim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
			this.TxtResim.ForeColor = System.Drawing.Color.White;
			this.TxtResim.Location = new System.Drawing.Point(130, 270);
			this.TxtResim.Name = "TxtResim";
			this.TxtResim.Size = new System.Drawing.Size(249, 28);
			this.TxtResim.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(56, 274);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(71, 22);
			this.label7.TabIndex = 13;
			this.label7.Text = "Resim:";
			// 
			// TxtMail
			// 
			this.TxtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
			this.TxtMail.ForeColor = System.Drawing.Color.White;
			this.TxtMail.Location = new System.Drawing.Point(130, 236);
			this.TxtMail.Name = "TxtMail";
			this.TxtMail.Size = new System.Drawing.Size(249, 28);
			this.TxtMail.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(75, 239);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 22);
			this.label6.TabIndex = 11;
			this.label6.Text = "Mail:";
			// 
			// TxtSifre
			// 
			this.TxtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
			this.TxtSifre.ForeColor = System.Drawing.Color.White;
			this.TxtSifre.Location = new System.Drawing.Point(130, 202);
			this.TxtSifre.Name = "TxtSifre";
			this.TxtSifre.Size = new System.Drawing.Size(249, 28);
			this.TxtSifre.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(69, 204);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 22);
			this.label4.TabIndex = 7;
			this.label4.Text = "Şifre:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(42, 171);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 22);
			this.label3.TabIndex = 5;
			this.label3.Text = "Numara:";
			// 
			// TxtSoyad
			// 
			this.TxtSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
			this.TxtSoyad.ForeColor = System.Drawing.Color.White;
			this.TxtSoyad.Location = new System.Drawing.Point(130, 134);
			this.TxtSoyad.Name = "TxtSoyad";
			this.TxtSoyad.Size = new System.Drawing.Size(249, 28);
			this.TxtSoyad.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(50, 137);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 22);
			this.label2.TabIndex = 3;
			this.label2.Text = "Soyadı:";
			// 
			// TxtAd
			// 
			this.TxtAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
			this.TxtAd.ForeColor = System.Drawing.Color.White;
			this.TxtAd.Location = new System.Drawing.Point(130, 100);
			this.TxtAd.Name = "TxtAd";
			this.TxtAd.Size = new System.Drawing.Size(249, 28);
			this.TxtAd.TabIndex = 1;
			// 
			// BtnSil
			// 
			this.BtnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
			this.BtnSil.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnSil.ForeColor = System.Drawing.Color.White;
			this.BtnSil.Location = new System.Drawing.Point(142, 361);
			this.BtnSil.Name = "BtnSil";
			this.BtnSil.Size = new System.Drawing.Size(223, 37);
			this.BtnSil.TabIndex = 9;
			this.BtnSil.Text = "Sil";
			this.BtnSil.UseVisualStyleBackColor = false;
			this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(82, 103);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Adı:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridView1);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(834, 504);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 24);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(828, 477);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// FrmOgrenci
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1298, 528);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmOgrenci";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmOgrenci";
			this.Load += new System.EventHandler(this.FrmOgrenci_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button BtnResimSec;
		private System.Windows.Forms.Button BtnGuncelle;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox TxtResim;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox TxtMail;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox TxtID;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TxtSifre;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TxtSoyad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtAd;
		private System.Windows.Forms.Button BtnSil;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button BtnListele;
		private System.Windows.Forms.MaskedTextBox TxtNumara;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}