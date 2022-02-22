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
    /// Логика взаимодействия для tictactoeWind.xaml
    /// </summary>
    public partial class tictactoeWind : Window
    {
        private int count;

        public tictactoeWind()
        {
            InitializeComponent();
        }

        private void tictactoeMain(object sender, RoutedEventArgs e)
        {
            MainWindow tw = new MainWindow();
            Hide();
            tw.Show();
        }

        private void tictactoeClick(object sender, RoutedEventArgs e)
        {
            Button clickButton = (Button)e.Source;

            clickButton.IsEnabled = false;

            if (count == 0)
            {
                clickButton.Content = "x";
                count = 1;
            }
            else
            {
                clickButton.Content = "o";
                count = 0;
            }
            FindWinner();
        }


        private void FindWinner()
        {
            if (t1.Content == t2.Content && t2.Content == t3.Content && t3.Content == t4.Content && !t1.IsEnabled)
            {
                if (t1.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t6.Content == t7.Content && t7.Content == t8.Content && t8.Content == t9.Content && !t6.IsEnabled)
            {
                if (t6.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t11.Content == t12.Content && t12.Content == t13.Content && t13.Content == t14.Content && !t11.IsEnabled)
            {
                if (t11.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t16.Content == t17.Content && t17.Content == t18.Content && t18.Content == t19.Content && !t16.IsEnabled)
            {
                if (t16.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t21.Content == t22.Content && t22.Content == t23.Content && t23.Content == t24.Content && !t21.IsEnabled)
            {
                if (t21.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t2.Content == t3.Content && t3.Content == t4.Content && t4.Content == t5.Content && !t2.IsEnabled)
            {
                if (t2.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t7.Content == t8.Content && t8.Content == t9.Content && t9.Content == t10.Content && !t7.IsEnabled)
            {
                if (t7.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t12.Content == t13.Content && t13.Content == t14.Content && t14.Content == t15.Content && !t12.IsEnabled)
            {
                if (t12.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t17.Content == t18.Content && t18.Content == t19.Content && t19.Content == t20.Content && !t17.IsEnabled)
            {
                if (t17.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t22.Content == t23.Content && t23.Content == t24.Content && t24.Content == t25.Content && !t22.IsEnabled)
            {
                if (t22.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t2.Content == t3.Content && t3.Content == t4.Content && t4.Content == t5.Content && !t2.IsEnabled)
            {
                if (t2.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t2.Content == t7.Content && t7.Content == t12.Content && t12.Content == t17.Content && !t2.IsEnabled)
            {
                if (t2.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t3.Content == t8.Content && t8.Content == t13.Content && t13.Content == t18.Content && !t3.IsEnabled)
            {
                if (t3.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t4.Content == t9.Content && t9.Content == t14.Content && t14.Content == t19.Content && !t4.IsEnabled)
            {
                if (t4.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t5.Content == t10.Content && t10.Content == t15.Content && t15.Content == t20.Content && !t5.IsEnabled)
            {
                if (t5.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t6.Content == t11.Content && t11.Content == t16.Content && t16.Content == t21.Content && !t6.IsEnabled)
            {
                if (t6.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t7.Content == t12.Content && t12.Content == t17.Content && t17.Content == t22.Content && !t7.IsEnabled)
            {
                if (t7.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t8.Content == t13.Content && t13.Content == t18.Content && t18.Content == t23.Content && !t8.IsEnabled)
            {
                if (t8.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t9.Content == t14.Content && t14.Content == t19.Content && t19.Content == t24.Content && !t9.IsEnabled)
            {
                if (t9.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t10.Content == t15.Content && t15.Content == t20.Content && t20.Content == t25.Content && !t10.IsEnabled)
            {
                if (t10.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t1.Content == t7.Content && t7.Content == t13.Content && t13.Content == t19.Content && !t1.IsEnabled)
            {
                if (t1.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t2.Content == t8.Content && t8.Content == t14.Content && t14.Content == t20.Content && !t2.IsEnabled)
            {
                if (t2.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t6.Content == t12.Content && t12.Content == t18.Content && t18.Content == t24.Content && !t6.IsEnabled)
            {
                if (t6.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t7.Content == t13.Content && t13.Content == t19.Content && t19.Content == t25.Content && !t7.IsEnabled)
            {
                if (t7.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t4.Content == t8.Content && t8.Content == t12.Content && t12.Content == t16.Content && !t4.IsEnabled)
            {
                if (t4.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t10.Content == t14.Content && t14.Content == t18.Content && t18.Content == t22.Content && !t10.IsEnabled)
            {

                if (t10.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t5.Content == t9.Content && t9.Content == t13.Content && t13.Content == t7.Content && !t5.IsEnabled)
            {
                if (t5.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (t9.Content == t13.Content && t13.Content == t17.Content && t17.Content == t21.Content && !t9.IsEnabled)
            {
                if (t9.Content.ToString() == "x") tXWin.Visibility = Visibility.Visible;
                else tYWin.Visibility = Visibility.Visible;
            }
            if (tYWin.Visibility == Visibility.Visible || tXWin.Visibility == Visibility.Visible)
            {
                foreach (Button b in MyGrid.Children.OfType<Button>())
                {
                    b.IsEnabled = false;
                    if (b.Content.ToString() == "Main")
                    {
                        b.IsEnabled = true;
                    }
                }
            }
        }
    }
}
