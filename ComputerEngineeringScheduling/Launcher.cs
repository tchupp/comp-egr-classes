using System;
using System.Windows.Forms;

namespace ComputerEngineeringScheduling
{
    static class Launcher
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainWindow window = new MainWindow();
            Application.Run(window);
        }
    }

}
