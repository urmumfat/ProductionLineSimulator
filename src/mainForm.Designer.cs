namespace productionLine
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            parametersTimer = new System.Windows.Forms.Timer(components);
            cpuUsageLabel = new Label();
            ramUsageLabel = new Label();
            SuspendLayout();
            // 
            // parametersTimer
            // 
            parametersTimer.Enabled = true;
            parametersTimer.Interval = 1000;
            parametersTimer.Tick += parametersTimer_Tick;
            // 
            // cpuUsageLabel
            // 
            cpuUsageLabel.AutoSize = true;
            cpuUsageLabel.Location = new Point(12, 19);
            cpuUsageLabel.Name = "cpuUsageLabel";
            cpuUsageLabel.Size = new Size(104, 15);
            cpuUsageLabel.TabIndex = 1;
            cpuUsageLabel.Text = "no cpu usage data";
            // 
            // ramUsageLabel
            // 
            ramUsageLabel.AutoSize = true;
            ramUsageLabel.Location = new Point(12, 47);
            ramUsageLabel.Name = "ramUsageLabel";
            ramUsageLabel.Size = new Size(110, 15);
            ramUsageLabel.TabIndex = 2;
            ramUsageLabel.Text = "no RAM usage data";
            ramUsageLabel.Click += ramUsageLabel_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 434);
            Controls.Add(ramUsageLabel);
            Controls.Add(cpuUsageLabel);
            Margin = new Padding(2);
            Name = "mainForm";
            Text = "Production Line Symulation";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer parametersTimer;
        private Label cpuUsageLabel;
        private Label ramUsageLabel;
    }
}
