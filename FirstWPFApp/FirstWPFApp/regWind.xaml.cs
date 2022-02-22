using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
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
    /// Логика взаимодействия для regWind.xaml
    /// </summary>
    public partial class regWind : Window
    {
        public regWind()
        {
            InitializeComponent();
        }

        private void regMain(object sender, RoutedEventArgs e)
        {
            MainWindow tw = new MainWindow();
            Hide();
            tw.Show();
        }

        private void addClick(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("txt.txt", true);
            sw.WriteLine(Surname.Text + " " + ID.Text);
            sw.Close();
            Surname.Text = ID.Text = "";
        }

        private void deleteClick(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader("txt.txt");
            List<string> text = new List<string>();
            while (!sr.EndOfStream)
            {
                text.Add(sr.ReadLine());
            }
            sr.Close();
            for (int i = 0; i < text.Count; i++)
            {
                if (text[i].Contains(ID.Text))
                {
                    text.RemoveAt(i);
                }
            }
            StreamWriter sw = new StreamWriter("txt.txt");
            foreach (string s in text)
            {
                sw.WriteLine(s);
            }
            sw.Close();
        }
    }
}
