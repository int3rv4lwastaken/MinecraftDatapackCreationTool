namespace MinecraftDatapackGenerator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Configuring application shits WOOOO
            var application = new Form1();

            // Makes it so that the user cannot resize the window
            application.MinimumSize = application.Size;
            application.MaximumSize = application.Size;

            // RUN IT BABBYYY
            Application.Run(application);
        }
    }
}