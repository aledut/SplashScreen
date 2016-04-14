using SplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            SplashHandler.Start(); Thread.Sleep(1000); // Give time to thread start... otherwise nothing works
            SplashHandler.BringTop(); 
            SplashHandler.ChangeText("Carregando..."); Thread.Sleep(2000);
            SplashHandler.ChangeText("Bla Bla..."); Thread.Sleep(2000);
            SplashHandler.ChangeText("Tra la la...");Thread.Sleep(2000);
            Application.Run(new Form1()); // Place SplashHandler.Close() inside onLoad event
        }
    }
}
