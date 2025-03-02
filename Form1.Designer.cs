namespace SistemPerformansTakibi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelRamUsage = new System.Windows.Forms.Label();
            this.progressRam = new System.Windows.Forms.ProgressBar();
            this.labelCpuUsage = new System.Windows.Forms.Label();
            this.labelgGpuUsage = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressGpu = new System.Windows.Forms.ProgressBar();
            this.progressCpu = new System.Windows.Forms.ProgressBar();
            this.labelCpuTemp = new System.Windows.Forms.Label();
            this.labelDiskUsage = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.labelGpuTemp = new System.Windows.Forms.Label();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // labelRamUsage
            // 
            this.labelRamUsage.AutoSize = true;
            this.labelRamUsage.Location = new System.Drawing.Point(48, 109);
            this.labelRamUsage.Name = "labelRamUsage";
            this.labelRamUsage.Size = new System.Drawing.Size(96, 16);
            this.labelRamUsage.TabIndex = 0;
            this.labelRamUsage.Text = "\tRAM Kullanımı:";
            // 
            // progressRam
            // 
            this.progressRam.Location = new System.Drawing.Point(401, 109);
            this.progressRam.Name = "progressRam";
            this.progressRam.Size = new System.Drawing.Size(100, 23);
            this.progressRam.TabIndex = 1;
            // 
            // labelCpuUsage
            // 
            this.labelCpuUsage.AutoSize = true;
            this.labelCpuUsage.Location = new System.Drawing.Point(48, 57);
            this.labelCpuUsage.Name = "labelCpuUsage";
            this.labelCpuUsage.Size = new System.Drawing.Size(94, 16);
            this.labelCpuUsage.TabIndex = 2;
            this.labelCpuUsage.Text = "CPU Kullanımı:";
            // 
            // labelgGpuUsage
            // 
            this.labelgGpuUsage.AutoSize = true;
            this.labelgGpuUsage.Location = new System.Drawing.Point(48, 170);
            this.labelgGpuUsage.Name = "labelgGpuUsage";
            this.labelgGpuUsage.Size = new System.Drawing.Size(95, 16);
            this.labelgGpuUsage.TabIndex = 3;
            this.labelgGpuUsage.Text = "GPU Kullanımı:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(401, 228);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // progressGpu
            // 
            this.progressGpu.Location = new System.Drawing.Point(401, 170);
            this.progressGpu.Name = "progressGpu";
            this.progressGpu.Size = new System.Drawing.Size(100, 23);
            this.progressGpu.TabIndex = 5;
            // 
            // progressCpu
            // 
            this.progressCpu.Location = new System.Drawing.Point(401, 57);
            this.progressCpu.Name = "progressCpu";
            this.progressCpu.Size = new System.Drawing.Size(100, 23);
            this.progressCpu.TabIndex = 6;
            // 
            // labelCpuTemp
            // 
            this.labelCpuTemp.AutoSize = true;
            this.labelCpuTemp.Location = new System.Drawing.Point(48, 235);
            this.labelCpuTemp.Name = "labelCpuTemp";
            this.labelCpuTemp.Size = new System.Drawing.Size(89, 16);
            this.labelCpuTemp.TabIndex = 7;
            this.labelCpuTemp.Text = "CPU Sıcaklığı";
            // 
            // labelDiskUsage
            // 
            this.labelDiskUsage.AutoSize = true;
            this.labelDiskUsage.Location = new System.Drawing.Point(48, 356);
            this.labelDiskUsage.Name = "labelDiskUsage";
            this.labelDiskUsage.Size = new System.Drawing.Size(90, 16);
            this.labelDiskUsage.TabIndex = 8;
            this.labelDiskUsage.Text = "Disk Kullanımı";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(401, 291);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(100, 23);
            this.progressBar4.TabIndex = 9;
            // 
            // labelGpuTemp
            // 
            this.labelGpuTemp.AutoSize = true;
            this.labelGpuTemp.Location = new System.Drawing.Point(48, 298);
            this.labelGpuTemp.Name = "labelGpuTemp";
            this.labelGpuTemp.Size = new System.Drawing.Size(90, 16);
            this.labelGpuTemp.TabIndex = 10;
            this.labelGpuTemp.Text = "GPU Sıcaklığı";
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(401, 349);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(100, 23);
            this.progressBar5.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 621);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.labelGpuTemp);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.labelDiskUsage);
            this.Controls.Add(this.labelCpuTemp);
            this.Controls.Add(this.progressCpu);
            this.Controls.Add(this.progressGpu);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelgGpuUsage);
            this.Controls.Add(this.labelCpuUsage);
            this.Controls.Add(this.progressRam);
            this.Controls.Add(this.labelRamUsage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRamUsage;
        private System.Windows.Forms.ProgressBar progressRam;
        private System.Windows.Forms.Label labelCpuUsage;
        private System.Windows.Forms.Label labelgGpuUsage;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressGpu;
        private System.Windows.Forms.ProgressBar progressCpu;
        private System.Windows.Forms.Label labelCpuTemp;
        private System.Windows.Forms.Label labelDiskUsage;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label labelGpuTemp;
        private System.Windows.Forms.ProgressBar progressBar5;
    }
}

