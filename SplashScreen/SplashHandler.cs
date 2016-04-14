using System;
using System.Threading;
using System.Windows.Forms;

namespace SplashScreen
{
    public static class SplashHandler
    {
        static SplashForm splash;

        public static void Start()
        {
            Thread splashThread = new Thread(new ThreadStart(StartSplash));
            splashThread.Start();
        }

        static void StartSplash()
        {
            // Instance a splash form given the image names
            splash = new SplashForm();

            // Run the form
            Application.Run(splash);

        }

        public static void Close()
        {
            if (splash == null) return;

            // Shut down the splash screen
            splash.Invoke(new EventHandler(splash.KillMe));
            splash.Dispose();
            splash = null;
        }

        public static void ChangeText(string text)
        {
            if (splash == null) return;
            splash.Invoke(new EventHandler(splash.ChangeText), text);
        }

        public static void BringTop()
        {
            if (splash == null) return;
            splash.Invoke(new EventHandler(splash.BringTop));
        }
    }
}
