using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using LibreHardwareMonitor.Hardware;

namespace SistemPerformansTakibi
{
    public partial class Form1 : Form
    {
        private PerformanceCounter cpuCounter;
        private PerformanceCounter ramCounter;
        private Computer computer;
        public Form1()
        {
            InitializeComponent();
            // Performans sayaçlarını başlat
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");

            // LibreHardwareMonitor başlat
            computer = new Computer
            {
                IsCpuEnabled = true,
                IsGpuEnabled = true
            };
            computer.Open();

            // Timer başlat, her saniye verileri güncelle
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 saniye
            timer.Tick += UpdateStats;
            timer.Start();
        }
        private void UpdateStats(object sender, EventArgs e)
        {
            // ✅ CPU Kullanımı
            float cpuUsage = cpuCounter.NextValue();
            progressCpu.Value = (int)cpuUsage;
            labelCpuUsage.Text = $"CPU Kullanımı: {cpuUsage:F1}%";

            // ✅ RAM Kullanımı
            float totalRam = 16000; // Bilgisayardaki toplam RAM (MB olarak)
            float usedRam = totalRam - ramCounter.NextValue();
            float ramUsage = (usedRam / totalRam) * 100;
            progressRam.Value = (int)ramUsage;
            labelRamUsage.Text = $"RAM: {usedRam:F1} MB / {totalRam} MB";

            // ✅ GPU Kullanımı
            float gpuUsage = GetGpuUsage();
            progressGpu.Value = (int)gpuUsage;
            labelgGpuUsage.Text = $"GPU Kullanımı: {gpuUsage:F1}%";

            // ✅ CPU ve GPU Sıcaklıkları
            float cpuTemp = GetTemperature(HardwareType.Cpu);
            float gpuTemp = GetTemperature(HardwareType.GpuNvidia) + GetTemperature(HardwareType.GpuAmd);

            labelCpuTemp.Text = $"CPU Sıcaklığı: {cpuTemp} °C";
            labelGpuTemp.Text = $"GPU Sıcaklığı: {gpuTemp} °C";

            // ✅ Disk Kullanımı
            DriveInfo drive = new DriveInfo("C");
            long usedDisk = drive.TotalSize - drive.AvailableFreeSpace;
            labelDiskUsage.Text = $"Disk: {usedDisk / 1024 / 1024 / 1024} GB / {drive.TotalSize / 1024 / 1024 / 1024} GB";
        }
        private float GetGpuUsage()
        {
            foreach (var hardware in computer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.GpuNvidia || hardware.HardwareType == HardwareType.GpuAmd)
                {
                    hardware.Update();
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load)
                        {
                            return sensor.Value.GetValueOrDefault();
                        }
                    }
                }
            }
            return 0;
        }
        private float GetTemperature(HardwareType type)
        {
            foreach (var hardware in computer.Hardware)
            {
                if (hardware.HardwareType == type)
                {
                    hardware.Update();
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            return sensor.Value.GetValueOrDefault();
                        }
                    }
                }
            }
            return 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
