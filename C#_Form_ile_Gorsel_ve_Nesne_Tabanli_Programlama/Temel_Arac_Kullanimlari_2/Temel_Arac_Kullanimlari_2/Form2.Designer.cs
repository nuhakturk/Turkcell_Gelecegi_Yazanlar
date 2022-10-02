
namespace Temel_Arac_Kullanimlari_2
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnArttir = new System.Windows.Forms.Button();
            this.BtnAzalt = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.PrgBarIslem1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PrgBarIslem2 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.PrgBarIslem3 = new System.Windows.Forms.ProgressBar();
            this.BtnBaslat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Bolge";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(359, 151);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // BtnArttir
            // 
            this.BtnArttir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnArttir.Location = new System.Drawing.Point(514, 47);
            this.BtnArttir.Name = "BtnArttir";
            this.BtnArttir.Size = new System.Drawing.Size(95, 37);
            this.BtnArttir.TabIndex = 1;
            this.BtnArttir.Text = "Arttır";
            this.BtnArttir.UseVisualStyleBackColor = true;
            this.BtnArttir.Click += new System.EventHandler(this.BtnArttir_Click);
            // 
            // BtnAzalt
            // 
            this.BtnAzalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAzalt.Location = new System.Drawing.Point(514, 104);
            this.BtnAzalt.Name = "BtnAzalt";
            this.BtnAzalt.Size = new System.Drawing.Size(95, 37);
            this.BtnAzalt.TabIndex = 2;
            this.BtnAzalt.Text = "Azalt";
            this.BtnAzalt.UseVisualStyleBackColor = true;
            this.BtnAzalt.Click += new System.EventHandler(this.BtnAzalt_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 195);
            this.progressBar1.Maximum = 200;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(724, 48);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 60;
            // 
            // PrgBarIslem1
            // 
            this.PrgBarIslem1.Location = new System.Drawing.Point(218, 275);
            this.PrgBarIslem1.Name = "PrgBarIslem1";
            this.PrgBarIslem1.Size = new System.Drawing.Size(363, 38);
            this.PrgBarIslem1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "İşlem 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "İşlem 2:";
            // 
            // PrgBarIslem2
            // 
            this.PrgBarIslem2.Location = new System.Drawing.Point(218, 319);
            this.PrgBarIslem2.Name = "PrgBarIslem2";
            this.PrgBarIslem2.Size = new System.Drawing.Size(363, 38);
            this.PrgBarIslem2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "İşlem 3:";
            // 
            // PrgBarIslem3
            // 
            this.PrgBarIslem3.Location = new System.Drawing.Point(218, 363);
            this.PrgBarIslem3.Name = "PrgBarIslem3";
            this.PrgBarIslem3.Size = new System.Drawing.Size(363, 38);
            this.PrgBarIslem3.TabIndex = 8;
            // 
            // BtnBaslat
            // 
            this.BtnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBaslat.Location = new System.Drawing.Point(621, 273);
            this.BtnBaslat.Name = "BtnBaslat";
            this.BtnBaslat.Size = new System.Drawing.Size(115, 43);
            this.BtnBaslat.TabIndex = 10;
            this.BtnBaslat.Text = "Başlat";
            this.BtnBaslat.UseVisualStyleBackColor = true;
            this.BtnBaslat.Click += new System.EventHandler(this.BtnBaslat_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 414);
            this.Controls.Add(this.BtnBaslat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrgBarIslem3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrgBarIslem2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrgBarIslem1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BtnAzalt);
            this.Controls.Add(this.BtnArttir);
            this.Controls.Add(this.chart1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button BtnArttir;
        private System.Windows.Forms.Button BtnAzalt;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar PrgBarIslem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar PrgBarIslem2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar PrgBarIslem3;
        private System.Windows.Forms.Button BtnBaslat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}