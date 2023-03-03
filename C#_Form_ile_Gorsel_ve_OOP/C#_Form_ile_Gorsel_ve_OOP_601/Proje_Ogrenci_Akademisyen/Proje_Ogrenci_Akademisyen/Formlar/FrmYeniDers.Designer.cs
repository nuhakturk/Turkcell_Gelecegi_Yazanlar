namespace Proje_Ogrenci_Akademisyen.Formlar
{
	partial class FrmYeniDers
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
			this.components = new System.ComponentModel.Container();
			this.TxtDersAd = new System.Windows.Forms.TextBox();
			this.BtnKaydet = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.BtnCikis = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// TxtDersAd
			// 
			this.TxtDersAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
			this.TxtDersAd.ForeColor = System.Drawing.Color.White;
			this.TxtDersAd.Location = new System.Drawing.Point(135, 45);
			this.TxtDersAd.Name = "TxtDersAd";
			this.TxtDersAd.Size = new System.Drawing.Size(299, 28);
			this.TxtDersAd.TabIndex = 1;
			// 
			// BtnKaydet
			// 
			this.BtnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
			this.BtnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnKaydet.ForeColor = System.Drawing.Color.White;
			this.BtnKaydet.Location = new System.Drawing.Point(170, 103);
			this.BtnKaydet.Name = "BtnKaydet";
			this.BtnKaydet.Size = new System.Drawing.Size(223, 37);
			this.BtnKaydet.TabIndex = 2;
			this.BtnKaydet.Text = "Kaydet";
			this.BtnKaydet.UseVisualStyleBackColor = false;
			this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(24, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ders Adı:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.TxtDersAd);
			this.groupBox1.Controls.Add(this.BtnKaydet);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 41);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(479, 186);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// BtnCikis
			// 
			this.BtnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
			this.BtnCikis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BtnCikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
			this.BtnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnCikis.ForeColor = System.Drawing.Color.White;
			this.BtnCikis.Location = new System.Drawing.Point(461, 9);
			this.BtnCikis.Name = "BtnCikis";
			this.BtnCikis.Size = new System.Drawing.Size(30, 30);
			this.BtnCikis.TabIndex = 6;
			this.BtnCikis.Text = "X";
			this.BtnCikis.UseVisualStyleBackColor = false;
			this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
			// 
			// FrmYeniDers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(503, 237);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.BtnCikis);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FrmYeniDers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmYeniDers";
			this.Load += new System.EventHandler(this.FrmYeniDers_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox TxtDersAd;
		private System.Windows.Forms.Button BtnKaydet;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button BtnCikis;
	}
}