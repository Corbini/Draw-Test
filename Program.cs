using System.Timers;
using System.Drawing;
using System.Windows.Media.Imaging;
using System.Windows.Documents;


namespace Draw_Test
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
            Tester tester = new Tester();
            Form1 view = new Form1(tester);
            tester.SetTextBox(view.getResultTextBox());
            Application.Run(view);
        }

    }
}