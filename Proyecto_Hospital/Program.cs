using CapaPresentacion;

namespace Proyecto_Hospital
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
            //Application.Run(new PacienteView());
            //Application.Run(new MedicoView());
            //Application.Run(new MedicamentoView());
            Application.Run(new MenuView());
        }
    }
}