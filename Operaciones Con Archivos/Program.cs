namespace Operaciones_Con_Archivos
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
      
        public const string FICHERO = "Fichero.txt";
        public const string RESULTADO_SUMA = "Resultado_suma.txt";

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}