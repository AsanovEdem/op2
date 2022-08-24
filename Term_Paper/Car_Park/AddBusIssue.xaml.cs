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

namespace Car_Park
{
    /// <summary>
    /// Логика взаимодействия для AddBusIssue.xaml
    /// </summary>
    public partial class AddBusIssue : Window
    {
        public AddBusIssue()
        {
            InitializeComponent();
        }
        string issue = "Відсутній водій";
        int busNum = -1;
        DB_Manipulation dB = new DB_Manipulation();
        private void ChangeSearch(object sender, MouseButtonEventArgs e)
        {
            Label lbl = sender as Label;
            issue = lbl.Content.ToString();
            Label_DriverIs.Foreground = Label_BusFix.Foreground =
                new SolidColorBrush(Color.FromArgb(255, 187, 228, 255));
            lbl.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 251, 187));
        }

        private void ToMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.Show();
            this.Close();
        }

        private void Bnum_Changed(object sender, TextChangedEventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0) Placeholder_City1.Visibility = Visibility.Hidden;
            else Placeholder_City1.Visibility = Visibility.Visible;
            try
            {
                busNum = Convert.ToInt32(((TextBox)sender).Text);
                if (IsBusExist(busNum))
                {
                    Label_IsPossible.Visibility = Visibility.Hidden;
                    AddBtn.Visibility = Visibility.Visible;
                    RemoveBtn.Visibility = Visibility.Visible;
                }
                else
                {
                    Label_IsPossible.Visibility = Visibility.Visible;
                    AddBtn.Visibility = Visibility.Hidden;
                    RemoveBtn.Visibility = Visibility.Hidden;
                }
            }
            catch (Exception ex)
            {
                Label_IsPossible.Visibility = Visibility.Hidden;
                AddBtn.Visibility = Visibility.Hidden;
                RemoveBtn.Visibility = Visibility.Hidden;
            }
        }

        private void Add_Bus(object sender, RoutedEventArgs e)
        {
            dB.ExecuteQuery($"INSERT INTO Bus_Issue VALUES({busNum},'{issue}')");
            Bus_Issues biw = new Bus_Issues();
            biw.Show();
            this.Close();
        }
        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            dB.ExecuteQuery($"DELETE FROM Bus_Issue WHERE Bus_Number = {busNum}");
            Bus_Issues biw = new Bus_Issues();
            biw.Show();
            this.Close();
        }
        private bool IsBusExist(int bus)
        {
            var reader = dB.GetData("SELECT * FROM Buses");
            while (reader.Read())
            {
                if (reader.GetValue(0).ToString() == bus.ToString())
                {
                    reader.Close(); dB.CloseConn();
                    return true;
                }
            }
            reader.Close(); dB.CloseConn();
            return false;
        }
    }
}
