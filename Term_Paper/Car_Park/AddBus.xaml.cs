using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для AddBus.xaml
    /// </summary>
    public partial class AddBus : Window
    {
        public AddBus()
        {
            InitializeComponent();
        }
        string[] drivers = {""};
        private void ToMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
        DB_Manipulation dB = new DB_Manipulation();
        bool CanAddBus = false;
        private void Info_Changed(object sender, TextChangedEventArgs e)
        {
            CanAddBus = true;
            int capacity = -1;
            if (Capacity_TB.Text.Length > 0)
            {
                Placeholder_Capacity.Content = "";
                try
                {
                    capacity = Convert.ToInt32(Capacity_TB.Text);
                }
                catch { Capacity_TB.Text = ""; }
            }
            else Placeholder_Capacity.Content = "Місткість";
            if (capacity <= 1 || capacity >= 100) CanAddBus = false;

            string type = "";
            if (Type_TB.Text.Length > 0)
            {
                Placeholder_Type.Content = "";
                try
                {
                    type = Type_TB.Text;
                }
                catch { Type_TB.Text = ""; }
            }
            else Placeholder_Type.Content = "Тип";

            if(type != "Шкільний" && type != "Мінібус" && type != "Туристичний") CanAddBus = false;

            string strDrivers = "";

            if (Drivers_TB.Text.Length > 0)
            {
                Placeholder_Drivers.Content = "";
                try
                {
                    strDrivers = Drivers_TB.Text;
                }
                catch { Drivers_TB.Text = ""; }
            }
            else Placeholder_Drivers.Content = "Водії";

            drivers = strDrivers.Split(' ');
            foreach (string driver in drivers)
            {
                if (!IsDriverExist(driver)) CanAddBus = false;
            }

            if(CanAddBus)
            {
                Label_IsPossible.Visibility = Visibility.Hidden;
                AddBus_Btn.Visibility = Visibility.Visible;
            }
            else
            {
                Label_IsPossible.Visibility = Visibility.Visible;
                AddBus_Btn.Visibility = Visibility.Hidden;
            }
        }
        private bool IsDriverExist(string driver)
        {
            SqlDataReader reader = dB.GetData("SELECT * FROM Drivers");
            while (reader.Read())
            {
                if (reader.GetValue(4).ToString() == driver) 
                {
                    reader.Close(); dB.CloseConn();
                    return true; 
                }
            }
            reader.Close(); dB.CloseConn();
            return false;
        }

        private void AddBus_Btn_Click(object sender, RoutedEventArgs e)
        {
            SqlDataReader getBusNum = dB.GetData("SELECT * FROM Drivers");
            int BusNum = 1;
            while (getBusNum.Read())
            {
                BusNum = Convert.ToInt32(getBusNum.GetValue(0)) + 1;
            }
            getBusNum.Close(); dB.CloseConn();

            dB.ExecuteQuery($"INSERT INTO Buses VALUES ({BusNum}, '{Type_TB.Text}', {Capacity_TB.Text})");

            foreach(string driver in drivers)
            {
                SqlDataReader getDriverPassport = dB.GetData($"SELECT * FROM Drivers WHERE Surname = '{driver}'");
                getDriverPassport.Read();
                int passport = getDriverPassport.GetInt32(0);
                getDriverPassport.Close(); dB.CloseConn();
                dB.ExecuteQuery($"INSERT INTO Bus_Driver VALUES ({BusNum}, {passport})");
            }
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
