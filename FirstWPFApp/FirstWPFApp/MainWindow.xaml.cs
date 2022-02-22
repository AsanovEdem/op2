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

namespace FirstWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calcWind(object sender, RoutedEventArgs e)
        {
            calcWind sw = new calcWind();
            Hide();
            sw.Show();
        }

        private void tictactoeWind(object sender, RoutedEventArgs e)
        {
            tictactoeWind mw;
            mw = new tictactoeWind();
            Hide();
            mw.Show();
        }

        private void regWind(object sender, RoutedEventArgs e)
        {
            regWind tw = new regWind();
            Hide();
            tw.Show();
        }

        private void atcWind(object sender, RoutedEventArgs e)
        {
            atcWind tw = new atcWind();
            Hide();
            tw.Show();
        }

        private void exitbtn(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
