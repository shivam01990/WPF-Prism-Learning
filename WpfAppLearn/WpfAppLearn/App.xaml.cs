using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfAppLearn.Views;

namespace WpfAppLearn
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
           
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

             Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
             LogOn logon = new LogOn();
            bool? res = logon.ShowDialog();
            Application.Current.MainWindow = null;
            Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;

            //if (res.HasValue && res.Value && Authenticate(logon.UserName, logon.Password))
            //{
            //    Bootstrapper bs = new Bootstrapper();
            //    bs.Run();
            //}
            //else
            //{
            //    MessageBox.Show(
            //        "Application is exiting due to invalid credentials",
            //        "Application Exit",
            //        MessageBoxButton.OK,
            //        MessageBoxImage.Error);
            //    Application.Current.Shutdown(1);
            //}


           
        }
    }
}
