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
    /// Логика взаимодействия для calcWind.xaml
    /// </summary>
    public partial class calcWind : Window
    {
        static string symb = "";
        static double res = 0;

        public calcWind()
        {
            InitializeComponent();
        }

        private void calcMain(object sender, RoutedEventArgs e)
        {
            MainWindow tw = new MainWindow();
            Hide();
            tw.Show();
        }

        private void cSignChangeClick(object sender, RoutedEventArgs e)
        {
            bool sign = true;

            if (sign == true)
            {
                textbox.Text = "-" + textbox.Text;
                sign = false;
            }
            else if (sign == false)
            {
                textbox.Text = textbox.Text.Replace("-", "");
                sign = true;
            }
        }

        private void cClick(object sender, RoutedEventArgs e)
        {
            textbox.Text = textbox.Text + e.Source.ToString().Split(' ')[1];
        }

        private void cAllCleanClick(object sender, RoutedEventArgs e)
        {
            textbox.Text = "";
        }

        private void cCleanClick(object sender, RoutedEventArgs e)
        {
            int lenght = textbox.Text.Length - 1;
            string text = textbox.Text;
            textbox.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textbox.Text = textbox.Text + text[i];
            }
        }

        public void calculate()
        {
            string[] fulltext = textbox.Text.Split(symb);

            double a,b;

            if (fulltext[0].Contains(','))
            {
                string[] first = fulltext[0].Split(',');
                int doublepart = first[1].Length;
                a = Convert.ToInt32(first[0]) + Convert.ToInt32(first[1]) / (Math.Pow(10, doublepart));
            }
            else
            {
                a = Convert.ToDouble(fulltext[0]);
            }

            if (fulltext[1].Contains(','))
            {
                string[] second = fulltext[1].Split(',');
                int doublepart = second[1].Length;
                b = Convert.ToInt32(second[0]) + Convert.ToInt32(second[1]) / (Math.Pow(10, doublepart));
            }
            else
            {
                b = Convert.ToDouble(fulltext[1]);
            }

            switch (symb)
            {
                case "+":
                    res = Math.Round(a + b, 6);
                    break;
                case "-":
                    res = Math.Round(a - b, 6);
                    break;
                case "*":
                    res = Math.Round(a * b, 6);
                    break;
                case "/":
                    res = Math.Round(a / b, 6);
                    break;
            }
            textbox.Text = Convert.ToString(res);
        }

        private void cDivideClick(object sender, RoutedEventArgs e)
        {
            if (symb != "")
            {
                calculate();
            }
            textbox.Text += "/";
            symb = "/";
        }

        private void cMultiplyClick(object sender, RoutedEventArgs e)
        {
            if (symb != "")
            {
                calculate();
            }
            textbox.Text += "*";
            symb = "*";
        }

        private void cMinusClick(object sender, RoutedEventArgs e)
        {
            if (symb != "")
            {
                calculate();
            }
            textbox.Text += "-";
            symb = "-";
        }

        private void cPlusClick(object sender, RoutedEventArgs e)
        {
            if (symb != "")
            {
                calculate();
            }
            textbox.Text += "+";
            symb = "+";
        }

        private void cEqualsClick(object sender, RoutedEventArgs e)
        {
            calculate();
            symb = "";
        }
    }
}
