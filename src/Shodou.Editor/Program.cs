namespace Shodou.Editor
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            if (args.Length > 0 && args[0] == "--dark")
            {
                Application.Run(new EditorForm(true));
            }
            else
            {
                Application.Run(new EditorForm(false));
            }
        }
    }
}