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
            usernameLabel = new Label();
            accessLabel = new Label();
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
            cpuUsageLabel.Location = new Point(17, 32);
            cpuUsageLabel.Margin = new Padding(4, 0, 4, 0);
            cpuUsageLabel.Name = "cpuUsageLabel";
            cpuUsageLabel.Size = new Size(159, 25);
            cpuUsageLabel.TabIndex = 1;
            cpuUsageLabel.Text = "no cpu usage data";
            // 
            // ramUsageLabel
            // 
            ramUsageLabel.AutoSize = true;
            ramUsageLabel.Location = new Point(17, 78);
            ramUsageLabel.Margin = new Padding(4, 0, 4, 0);
            ramUsageLabel.Name = "ramUsageLabel";
            ramUsageLabel.Size = new Size(169, 25);
            ramUsageLabel.TabIndex = 2;
            ramUsageLabel.Text = "no RAM usage data";
            ramUsageLabel.Click += ramUsageLabel_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Enabled = false;
            usernameLabel.Location = new Point(1099, 32);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(73, 25);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "no data";
            // 
            // accessLabel
            // 
            accessLabel.AutoSize = true;
            accessLabel.Enabled = false;
            accessLabel.Location = new Point(1099, 78);
            accessLabel.Name = "accessLabel";
            accessLabel.Size = new Size(73, 25);
            accessLabel.TabIndex = 4;
            accessLabel.Text = "no data";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 723);
            Controls.Add(accessLabel);
            Controls.Add(usernameLabel);
            Controls.Add(ramUsageLabel);
            Controls.Add(cpuUsageLabel);
            Name = "mainForm";
            Text = "Production Line Symulation";
            Load += mainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer parametersTimer;
        private Label cpuUsageLabel;
        private Label ramUsageLabel;
        private Label usernameLabel;
        private Label accessLabel;
    }
}
