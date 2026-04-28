using System.Diagnostics;
using LibreHardwareMonitor.Hardware;

namespace productionLine
{
    public partial class mainForm : Form
    {
        private PerformanceCounter cpuUsageCounter;
        private PerformanceCounter ramUsageCounter;

        private Computer computer;

        public mainForm()
        {
            InitializeComponent();
            cpuUsageCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramUsageCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");

            computer = new Computer
            {
                IsCpuEnabled = true,
                IsMotherboardEnabled = true
            };
            computer.Open();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void parametersTimer_Tick(object sender, EventArgs e)
        {
            float cpuUsage = cpuUsageCounter.NextValue();
            cpuUsageLabel.Text = $"CPU usage: {cpuUsage:0.0}%";

            float ramUsage = ramUsageCounter.NextValue();
            ramUsageLabel.Text = $"RAM usage: {ramUsage:0.0}%";
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            computer.Close();
            base.OnFormClosing(e);
        }

        private void ramUsageLabel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
