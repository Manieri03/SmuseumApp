using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace WpfSmuseum
{
    /// <summary>
    /// Logica di interazione per App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var splashScreen = new SplashScreen();
            this.MainWindow = splashScreen;
            splashScreen.Show(); 
            Task.Factory.StartNew(() =>
            {

                for (int i = 1; i <= 100; i++)
                {
                    System.Threading.Thread.Sleep(50);

                }
                this.Dispatcher.Invoke(() =>
                {

                    var mainWindow = new MainWindow();
                    this.MainWindow = mainWindow;
                    mainWindow.Show();
                    splashScreen.Close();
                });
            });
        }
    }
}
