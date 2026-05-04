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
        private void mainForm_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = confirmedUser.Username;
            accessLabel.Text = $"{confirmedUser.AuthorizationLvl}";
        }

        private void parametersTimer_Tick(object sender, EventArgs e)
        {
            parametersUpdate(cpuUsageCounter.NextValue(), cpuUsageLabel, "CPU usage: ", cpuFillPanel, cpuBackgroudPanel, 20, 80);
            parametersUpdate(ramUsageCounter.NextValue(), ramUsageLabel, "RAM usage: ", ramFillPanel, ramBackgroudPanel, 60, 80);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            computer.Close();
            base.OnFormClosing(e);
        }

        private void ramUsageLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void parametersUpdate(float usage, Label label, string textPrefix, Panel fillPanel, Panel backgroudPanel, int colourThreshold1, int colourThreshold2)
        {
            label.Text = textPrefix + $"{usage:0.0}%";
            fillPanel.Width = ((int)usage * backgroudPanel.Width) / 100;

            if ((int)usage > colourThreshold2) fillPanel.BackColor = Color.Red;
            else if ((int)usage > colourThreshold1) fillPanel.BackColor = Color.Yellow;
            else fillPanel.BackColor = Color.LimeGreen;
        }
    }
}
