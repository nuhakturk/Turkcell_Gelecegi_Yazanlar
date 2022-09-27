
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
            this.label1.Location = new System.Drawing.Point(80, 107);
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
            this.BtnOpenFileDialog.Location = new System.Drawing.Point(513, 149);
            this.BtnOpenFileDialog.Name = "BtnOpenFileDialog";
            this.BtnOpenFileDialog.Size = new System.Drawing.Size(274, 47);
            this.BtnOpenFileDialog.TabIndex = 2;
            this.BtnOpenFileDialog.Text = "Open File Dialog";
            this.BtnOpenFileDialog.UseVisualStyleBackColor = true;
            this.BtnOpenFileDialog.Click += new System.EventHandler(this.BtnOpenFileDialog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 511);
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
    }
}

