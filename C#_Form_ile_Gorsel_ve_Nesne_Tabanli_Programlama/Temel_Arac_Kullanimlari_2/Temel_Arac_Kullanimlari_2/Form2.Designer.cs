
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnArttir = new System.Windows.Forms.Button();
            this.BtnAzalt = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Bolge";
            this.chart1.Series.Add(series3);
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
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(724, 48);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 60;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 255);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BtnAzalt);
            this.Controls.Add(this.BtnArttir);
            this.Controls.Add(this.chart1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button BtnArttir;
        private System.Windows.Forms.Button BtnAzalt;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}