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
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void HideCompletedText(object sender, ElapsedEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                lblComplete.Visibility = Visibility.Hidden;
            });
        }

        Timer Timer = new Timer();

        private void ButtonVanillaBlue(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            btn.Background = Brushes.DarkGray;
            MTDPatcher.PatchVanillaBlues();
            lblComplete.Visibility = Visibility.Visible;
            btn.Background = Brushes.LightGray;
            Timer.Start();
        }

        private void ButtonOutlineBlue(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            btn.Background = Brushes.DarkGray;
            MTDPatcher.PatchOutlineBlues();
            lblComplete.Visibility = Visibility.Visible;
            btn.Background = Brushes.LightGray;
            Timer.Start();
        }

        private void ButtonHumanBlue(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            btn.Background = Brushes.DarkGray;
            MTDPatcher.PatchHumanBlues();
            lblComplete.Visibility = Visibility.Visible;
            btn.Background = Brushes.LightGray;
            Timer.Start();
        }

        private void ButtonVanillaGold(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            btn.Background = Brushes.DarkGray;
            MTDPatcher.PatchVanillaGolds();
            lblComplete.Visibility = Visibility.Visible;
            btn.Background = Brushes.LightGray;
            Timer.Start();
        }

        private void ButtonOutlineGold(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            btn.Background = Brushes.DarkGray;
            MTDPatcher.PatchOutlineGolds();
            lblComplete.Visibility = Visibility.Visible;
            btn.Background = Brushes.LightGray;
            Timer.Start();
        }

        private void ButtonHumanGold(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            btn.Background = Brushes.DarkGray;
            MTDPatcher.PatchHumanGolds();
            lblComplete.Visibility = Visibility.Visible;
            btn.Background = Brushes.LightGray;
            Timer.Start();
        }

        private void ButtonVanillaRed(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            btn.Background = Brushes.DarkGray;
            MTDPatcher.PatchVanillaReds();
            lblComplete.Visibility = Visibility.Visible;
            btn.Background = Brushes.LightGray;
            Timer.Start();
        }

        private void ButtonOutlineRed(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            btn.Background = Brushes.DarkGray;
            MTDPatcher.PatchOutlineReds();
            lblComplete.Visibility = Visibility.Visible;
            btn.Background = Brushes.LightGray;
            Timer.Start();
        }

        private void ButtonHumanRed(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            btn.Background = Brushes.DarkGray;
            MTDPatcher.PatchHumanReds();
            lblComplete.Visibility = Visibility.Visible;
            btn.Background = Brushes.LightGray;
            Timer.Start();
        }

    }
}