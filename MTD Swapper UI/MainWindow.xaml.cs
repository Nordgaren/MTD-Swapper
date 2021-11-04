using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MTD_Swapper;

namespace MTD_Swapper_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Timer.Elapsed += HideCompletedText;
            Timer.Interval = 5000;
            Timer.AutoReset = false;
        }

        private void HideCompletedText(object sender, ElapsedEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                lblComplete.Visibility = Visibility.Hidden;
            });
        }

        private void ButtonHuman(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            btn.Background = Brushes.DarkGray;
            MTDPatcher.PatchMTDs(true);
            lblComplete.Visibility = Visibility.Visible;
            btn.Background = Brushes.LightGray;
            Timer.Start();
        }

        Timer Timer = new Timer();

        private void ButtonRed(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            btn.Background = Brushes.DarkGray;
            MTDPatcher.PatchMTDs(false);
            lblComplete.Visibility = Visibility.Visible;
            btn.Background = Brushes.LightGray;
            Timer.Start();
        }
    }
}
