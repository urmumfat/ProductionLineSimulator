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
        }
    }
}