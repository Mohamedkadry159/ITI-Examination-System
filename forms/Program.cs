using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITI_APP_TEST
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show Splash Screen
            SplashForm splash = new SplashForm();
            splash.Show();
            Application.DoEvents(); // Allow splash screen to render properly

            // Simulate loading process (e.g., loading resources)
            System.Threading.Thread.Sleep(3000); // 3 seconds delay

            // Close the Splash Screen
            splash.Close();

            // Open Login Form
            Application.Run(new LoginForm());
        }
    }
}
