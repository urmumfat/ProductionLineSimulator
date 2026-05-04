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
            usernameTitleLabel = new Label();
            accessTitleLabel = new Label();
            cpuBackgroudPanel = new Panel();
            cpuFillPanel = new Panel();
            ramBackgroudPanel = new Panel();
            ramFillPanel = new Panel();
            cpuBackgroudPanel.SuspendLayout();
            ramBackgroudPanel.SuspendLayout();
            SuspendLayout();
            // 
            // parametersTimer
            // 
            parametersTimer.Enabled = true;
            parametersTimer.Interval = 500;
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
            ramUsageLabel.Location = new Point(17, 122);
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
            usernameLabel.Location = new Point(1064, 32);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(73, 25);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "no data";
            // 
            // accessLabel
            // 
            accessLabel.AutoSize = true;
            accessLabel.Location = new Point(1064, 78);
            accessLabel.Name = "accessLabel";
            accessLabel.Size = new Size(73, 25);
            accessLabel.TabIndex = 4;
            accessLabel.Text = "no data";
            // 
            // usernameTitleLabel
            // 
            usernameTitleLabel.AutoSize = true;
            usernameTitleLabel.Enabled = false;
            usernameTitleLabel.Location = new Point(1003, 32);
            usernameTitleLabel.Margin = new Padding(4, 0, 4, 0);
            usernameTitleLabel.Name = "usernameTitleLabel";
            usernameTitleLabel.Size = new Size(51, 25);
            usernameTitleLabel.TabIndex = 5;
            usernameTitleLabel.Text = "User:";
            // 
            // accessTitleLabel
            // 
            accessTitleLabel.AutoSize = true;
            accessTitleLabel.Enabled = false;
            accessTitleLabel.Location = new Point(940, 78);
            accessTitleLabel.Margin = new Padding(4, 0, 4, 0);
            accessTitleLabel.Name = "accessTitleLabel";
            accessTitleLabel.Size = new Size(123, 25);
            accessTitleLabel.TabIndex = 6;
            accessTitleLabel.Text = "Authorization:";
            // 
            // cpuBackgroudPanel
            // 
            cpuBackgroudPanel.BackColor = Color.Gray;
            cpuBackgroudPanel.Controls.Add(cpuFillPanel);
            cpuBackgroudPanel.Location = new Point(20, 62);
            cpuBackgroudPanel.Margin = new Padding(4, 5, 4, 5);
            cpuBackgroudPanel.Name = "cpuBackgroudPanel";
            cpuBackgroudPanel.Size = new Size(229, 30);
            cpuBackgroudPanel.TabIndex = 7;
            // 
            // cpuFillPanel
            // 
            cpuFillPanel.BackColor = Color.LimeGreen;
            cpuFillPanel.Location = new Point(0, 0);
            cpuFillPanel.Margin = new Padding(4, 5, 4, 5);
            cpuFillPanel.Name = "cpuFillPanel";
            cpuFillPanel.Size = new Size(114, 30);
            cpuFillPanel.TabIndex = 9;
            // 
            // ramBackgroudPanel
            // 
            ramBackgroudPanel.BackColor = Color.Gray;
            ramBackgroudPanel.Controls.Add(ramFillPanel);
            ramBackgroudPanel.Location = new Point(20, 152);
            ramBackgroudPanel.Margin = new Padding(4, 5, 4, 5);
            ramBackgroudPanel.Name = "ramBackgroudPanel";
            ramBackgroudPanel.Size = new Size(229, 30);
            ramBackgroudPanel.TabIndex = 8;
            // 
            // ramFillPanel
            // 
            ramFillPanel.BackColor = Color.LimeGreen;
            ramFillPanel.Location = new Point(0, 0);
            ramFillPanel.Margin = new Padding(4, 5, 4, 5);
            ramFillPanel.Name = "ramFillPanel";
            ramFillPanel.Size = new Size(114, 30);
            ramFillPanel.TabIndex = 10;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 723);
            Controls.Add(ramBackgroudPanel);
            Controls.Add(cpuBackgroudPanel);
            Controls.Add(accessTitleLabel);
            Controls.Add(usernameTitleLabel);
            Controls.Add(accessLabel);
            Controls.Add(usernameLabel);
            Controls.Add(ramUsageLabel);
            Controls.Add(cpuUsageLabel);
            Name = "mainForm";
            Text = "Production Line Symulation";
            Load += mainForm_Load;
            cpuBackgroudPanel.ResumeLayout(false);
            ramBackgroudPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer parametersTimer;
        private Label cpuUsageLabel;
        private Label ramUsageLabel;
        private Label usernameLabel;
        private Label accessLabel;
        private Label usernameTitleLabel;
        private Label accessTitleLabel;
        private Panel cpuBackgroudPanel;
        private Panel cpuFillPanel;
        private Panel ramBackgroudPanel;
        private Panel ramFillPanel;
    }
}
