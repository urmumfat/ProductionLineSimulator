namespace productionLine
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            loginForm loginWindow = new loginForm();

            if (loginWindow.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new mainForm());
            }
            else
            {
                MessageBox.Show("Login failed. Wrong username or password.");
                Application.Exit();
            } 
        }
    }
}