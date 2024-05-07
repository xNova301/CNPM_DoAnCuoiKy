using GiaoDien;
using Mau02;

namespace N16_GiaoDien
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
            // Application.Run(new QTCD_DSachCanHo_HCNS());
            Application.Run(new DangNhap());
        }
    }
}