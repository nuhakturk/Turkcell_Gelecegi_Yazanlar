
namespace Dosya_islemleri
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.BtnKonumSec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnOpenFileDialog = new System.Windows.Forms.Button();
            this.BtnSaveFileDialog = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.TxtYol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnKonum = new System.Windows.Forms.Button();
            this.BtnOlustur = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.BtnOku = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnYazdir = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BtnKonumSec
            // 
            this.BtnKonumSec.Location = new System.Drawing.Point(513, 85);
            this.BtnKonumSec.Name = "BtnKonumSec";
            this.BtnKonumSec.Size = new System.Drawing.Size(274, 47);
            this.BtnKonumSec.TabIndex = 0;
            this.BtnKonumSec.Text = "Folder Browser Dialog";
            this.BtnKonumSec.UseVisualStyleBackColor = true;
            this.BtnKonumSec.Click += new System.EventHandler(this.BtnKonumSec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnOpenFileDialog
            // 
            this.BtnOpenFileDialog.Location = new System.Drawing.Point(513, 138);
            this.BtnOpenFileDialog.Name = "BtnOpenFileDialog";
            this.BtnOpenFileDialog.Size = new System.Drawing.Size(274, 47);
            this.BtnOpenFileDialog.TabIndex = 2;
            this.BtnOpenFileDialog.Text = "Open File Dialog";
            this.BtnOpenFileDialog.UseVisualStyleBackColor = true;
            this.BtnOpenFileDialog.Click += new System.EventHandler(this.BtnOpenFileDialog_Click);
            // 
            // BtnSaveFileDialog
            // 
            this.BtnSaveFileDialog.Location = new System.Drawing.Point(513, 191);
            this.BtnSaveFileDialog.Name = "BtnSaveFileDialog";
            this.BtnSaveFileDialog.Size = new System.Drawing.Size(274, 47);
            this.BtnSaveFileDialog.TabIndex = 3;
            this.BtnSaveFileDialog.Text = "Save File Dialog";
            this.BtnSaveFileDialog.UseVisualStyleBackColor = true;
            this.BtnSaveFileDialog.Click += new System.EventHandler(this.BtnSaveFileDialog_Click);
            // 
            // TxtYol
            // 
            this.TxtYol.Location = new System.Drawing.Point(136, 38);
            this.TxtYol.Name = "TxtYol";
            this.TxtYol.Size = new System.Drawing.Size(250, 30);
            this.TxtYol.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Belge Yolu:";
            // 
            // BtnKonum
            // 
            this.BtnKonum.Location = new System.Drawing.Point(513, 244);
            this.BtnKonum.Name = "BtnKonum";
            this.BtnKonum.Size = new System.Drawing.Size(274, 47);
            this.BtnKonum.TabIndex = 6;
            this.BtnKonum.Text = "Konum Seç";
            this.BtnKonum.UseVisualStyleBackColor = true;
            this.BtnKonum.Click += new System.EventHandler(this.BtnKonum_Click);
            // 
            // BtnOlustur
            // 
            this.BtnOlustur.Location = new System.Drawing.Point(513, 297);
            this.BtnOlustur.Name = "BtnOlustur";
            this.BtnOlustur.Size = new System.Drawing.Size(274, 47);
            this.BtnOlustur.TabIndex = 7;
            this.BtnOlustur.Text = "Oluştur";
            this.BtnOlustur.UseVisualStyleBackColor = true;
            this.BtnOlustur.Click += new System.EventHandler(this.BtnOlustur_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Belge Adı:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(136, 85);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(250, 30);
            this.TxtAd.TabIndex = 8;
            // 
            // BtnOku
            // 
            this.BtnOku.Location = new System.Drawing.Point(513, 350);
            this.BtnOku.Name = "BtnOku";
            this.BtnOku.Size = new System.Drawing.Size(274, 47);
            this.BtnOku.TabIndex = 10;
            this.BtnOku.Text = "Oku";
            this.BtnOku.UseVisualStyleBackColor = true;
            this.BtnOku.Click += new System.EventHandler(this.BtnOku_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(33, 174);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(403, 129);
            this.listBox1.TabIndex = 11;
            // 
            // BtnYazdir
            // 
            this.BtnYazdir.Location = new System.Drawing.Point(513, 403);
            this.BtnYazdir.Name = "BtnYazdir";
            this.BtnYazdir.Size = new System.Drawing.Size(274, 47);
            this.BtnYazdir.TabIndex = 12;
            this.BtnYazdir.Text = "Yazdır";
            this.BtnYazdir.UseVisualStyleBackColor = true;
            this.BtnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(33, 318);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(403, 167);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 511);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BtnYazdir);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnOku);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.BtnOlustur);
            this.Controls.Add(this.BtnKonum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtYol);
            this.Controls.Add(this.BtnSaveFileDialog);
            this.Controls.Add(this.BtnOpenFileDialog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnKonumSec);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button BtnKonumSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnOpenFileDialog;
        private System.Windows.Forms.Button BtnSaveFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox TxtYol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnKonum;
        private System.Windows.Forms.Button BtnOlustur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Button BtnOku;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnYazdir;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

