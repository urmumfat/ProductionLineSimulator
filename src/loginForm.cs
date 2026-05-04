using Microsoft.VisualBasic.ApplicationServices;
using Mono.Unix.Native;
using System.Linq;
using System.Net.Security;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace productionLine
{
    public partial class loginForm : Form
    {

        public loginForm()
        {
            InitializeComponent();
        }

        private TextBox passwordBox;
        private Label passwordLabel;
        private TextBox usernameBox;
        private Label usernameLabel;
        private Button logInButton;


        private void InitializeComponent()
        {
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            logInButton = new Button();
            SuspendLayout();
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(149, 86);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(100, 31);
            usernameBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(149, 160);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(100, 31);
            passwordBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.FlatStyle = FlatStyle.System;
            usernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(149, 58);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(102, 25);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(149, 132);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(97, 25);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password:";
            // 
            // logInButton
            // 
            logInButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logInButton.Location = new Point(149, 216);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(100, 30);
            logInButton.TabIndex = 4;
            logInButton.Text = "log in";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += logInButton_Click;
            // 
            // loginForm
            // 
            ClientSize = new Size(404, 301);
            Controls.Add(logInButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(passwordBox);
            Controls.Add(usernameBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameBox.Text) || string.IsNullOrEmpty(passwordBox.Text))
            {
                MessageBox.Show("Please enter both username and password");
                return;
            }

            User usr;

            usr = Authenticate(usernameBox.Text, passwordBox.Text);

            if (usr != null)
            {
                confirmedUser.Username = usr.Username;
                confirmedUser.AccessLvl = usr.AccessLvl;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed login. Invalid username or password", "Invalid credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string enteredUsername = usernameBox.Text;
            string enteredPassword = passwordBox.Text;
        }

        private User Authenticate(string enteredUsername, string enteredPassword)
        {
            try
            {
                string jsonString = File.ReadAllText("users.json");

                var user = JsonSerializer.Deserialize<List<User>>(jsonString);

                if (user == null)
                {
                    MessageBox.Show("Error during authentication", "Authentication error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return user.FirstOrDefault(u => u.Username == enteredUsername && u.Password == enteredPassword);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("users.json file loading error", "File error");
                this.Close();
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error: {ex.Message}", "External error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return null;
            }
        }
    }
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int AccessLvl { get; set; }
    }

    public static class confirmedUser
    {
        public static string Username { get; set; }
        public static int AccessLvl { get; set; }
    }
}