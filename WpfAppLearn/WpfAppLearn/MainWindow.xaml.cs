using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls.Dialogs;

namespace WpfAppLearn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
          

        }

        public async void testc()
        {

            var controller = await this.ShowProgressAsync("WAIT WHILE WE DO STUFF!", "Searching...");
              //System.Threading.Thread.Sleep(5000);
              int charCount = 100000;
              await Task.Run(() =>
              {

                  for (int i = 0; i < charCount; i++)
                  {
                      controller.SetProgress(i * .00001);
                  }

                  controller.SetProgress(1.0);
              });
              await controller.CloseAsync();
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            testc();
        }
    }
}
