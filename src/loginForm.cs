namespace productionLine
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            SuspendLayout();
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(144, 89);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(100, 23);
            usernameBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(144, 141);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(100, 23);
            passwordBox.TabIndex = 1;
            // 
            // loginForm
            // 
            ClientSize = new Size(400, 300);
            Controls.Add(passwordBox);
            Controls.Add(usernameBox);
            Name = "loginForm";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();

        }

        private TextBox passwordBox;
        private TextBox usernameBox;
    }
}