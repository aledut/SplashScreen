# SplashScreen - Loading screen for winform applications

       SplashHandler.Start(); Thread.Sleep(1000); // Give time to thread start... otherwise nothing works
       SplashHandler.BringTop(); 
       SplashHandler.ChangeText("Carregando..."); Thread.Sleep(2000);
       SplashHandler.ChangeText("Bla Bla..."); Thread.Sleep(2000);
       SplashHandler.ChangeText("Tra la la..."); Thread.Sleep(2000);
       Application.Run(new Form1()); // Place SplashHandler.Close() inside onLoad event
