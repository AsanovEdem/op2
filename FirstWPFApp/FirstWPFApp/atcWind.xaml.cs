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
using System.Windows.Shapes;

namespace FirstWPFApp
{
    /// <summary>
    /// Логика взаимодействия для atcWind.xaml
    /// </summary>
    public partial class atcWind : Window
    {
        public atcWind()
        {
            InitializeComponent();
        }

        private void atcMain(object sender, RoutedEventArgs e)
        {
            MainWindow tw = new MainWindow();
            Hide();
            tw.Show();
        }
    }
}
