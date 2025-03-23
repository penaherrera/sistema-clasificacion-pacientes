namespace sistema_clasificacion_pacientes
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Iniciar con el Login
            Form2 loginForm = new Form2();
            Application.Run(loginForm);
        }
    }
}