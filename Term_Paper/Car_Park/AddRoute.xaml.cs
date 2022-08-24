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
    /// Логика взаимодействия для AddRoute.xaml
    /// </summary>
    public partial class AddRoute : Window
    {
        public AddRoute()
        {
            InitializeComponent();
        }
        DB_Manipulation dB = new DB_Manipulation();
        private void ToMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void AddRoute_Click(object sender, RoutedEventArgs e)
        {
            if (!IsCityInDB(City1_TB.Text))
            {
                int newCityID = -1;
                var getId = dB.GetData("SELECT * FROM Cities");
                while (getId.Read()) newCityID = Convert.ToInt32(getId.GetValue(0)) + 1;
                getId.Close(); dB.CloseConn();
                dB.ExecuteQuery($"INSERT INTO Cities VALUES ({newCityID}, '{City1_TB.Text}')");
            }
            if (!IsCityInDB(City2_TB.Text))
            {
                int newCityID = -1;
                var getId = dB.GetData("SELECT * FROM Cities");
                while (getId.Read()) newCityID = Convert.ToInt32(getId.GetValue(0)) + 1;
                getId.Close(); dB.CloseConn();
                dB.ExecuteQuery($"INSERT INTO Cities VALUES ({newCityID}, '{City2_TB.Text}')");
            }

            var getCity1ID = dB.GetData($"SELECT * FROM Cities WHERE City_Name = '{City1_TB.Text}'");
            getCity1ID.Read(); int c1ID = Convert.ToInt32(getCity1ID.GetValue(0));
            getCity1ID.Close(); dB.CloseConn();

            var getCity2ID = dB.GetData($"SELECT * FROM Cities WHERE City_Name = '{City2_TB.Text}'");
            getCity2ID.Read(); int c2ID = Convert.ToInt32(getCity2ID.GetValue(0));
            getCity2ID.Close(); dB.CloseConn();

            int rID = -1;
            var getRouteID = dB.GetData("SELECT * FROM Routes ORDER BY Route_ID");
            while(getRouteID.Read()) rID = Convert.ToInt32(getRouteID.GetValue(0)) + 1;
            getRouteID.Close(); dB.CloseConn();

            dB.ExecuteQuery($"INSERT INTO Routes VALUES({rID}, {c1ID}, {c2ID}, " +
                $"'{MoveTimeS_TB.Text}:00:00', '{MoveTimeE_TB.Text}:00:00', {Interval_TB.Text}, {MoveLenght_TB.Text})");

            string[] busNums = BusNum_TB.Text.Split(' ');

            foreach (string bus in busNums)
            {
                dB.ExecuteQuery($"INSERT INTO Route_Bus VALUES ({rID},{bus})");
            }
        }
        private void Info_Changed(object sender, TextChangedEventArgs e)
        {
            Placeholder_City1.Visibility = Placeholder_City2.Visibility =
            Placeholder_BusNum.Visibility = Placeholder_MoveLenght.Visibility =
            Placeholder_MoveTimeE.Visibility = Placeholder_MoveTimeS.Visibility =
            Placeholder_Interval.Visibility = Visibility.Visible;

            if (City1_TB.Text.Length > 0) Placeholder_City1.Visibility = Visibility.Hidden;

            if (City2_TB.Text.Length > 0) Placeholder_City2.Visibility = Visibility.Hidden;

            if (BusNum_TB.Text.Length > 0) Placeholder_BusNum.Visibility = Visibility.Hidden;

            if (MoveLenght_TB.Text.Length > 0) Placeholder_MoveLenght.Visibility = Visibility.Hidden;

            if (MoveTimeS_TB.Text.Length > 0) Placeholder_MoveTimeS.Visibility= Visibility.Hidden;

            if (MoveTimeE_TB.Text.Length > 0) Placeholder_MoveTimeE.Visibility = Visibility.Hidden;

            if (Interval_TB.Text.Length > 0) Placeholder_Interval.Visibility = Visibility.Hidden;

            int mLenght = -1, mTimeS = -1, mTimeE = -1, mInterval = -1;
            if (IsCityExist(City1_TB.Text) && IsCityExist(City2_TB.Text))
            {
                try
                {
                    mLenght = Convert.ToInt32(MoveLenght_TB.Text);
                    mTimeS = Convert.ToInt32(MoveTimeS_TB.Text);
                    mTimeE = Convert.ToInt32(MoveTimeE_TB.Text);
                    mInterval = Convert.ToInt32(Interval_TB.Text);
                }
                catch { }
                if (mLenght > 0 && mLenght < 1000 && mInterval > 0 && mInterval < 1000
                    && mTimeS < mTimeE && mTimeE >= 0 && mTimeE <= 23 && mTimeS >= 0 && mTimeS <= 23)
                {
                    string[] busNums = BusNum_TB.Text.Split(' ');
                    if (IsBusesExist(busNums))
                    {
                        IsAddEnable(true); return;
                    }
                }
            }
            IsAddEnable(false);
        }
        private bool IsBusesExist(string[] buses)
        {
            int counter = 0;
            foreach(string bNum in buses)
            {
                var reader = dB.GetData("SELECT * FROM Buses");
                while (reader.Read())
                {
                    if(reader.GetValue(0).ToString() == bNum)
                    {
                        counter++;
                    }
                }
                reader.Close(); dB.CloseConn();
            }
            if (counter == buses.Length) return true;
            return false;
        }
        private bool IsCityExist(string city)
        {
            foreach (char c in city)
            {
                try
                {
                    int a = Convert.ToInt32(c.ToString());
                    return false;
                }
                catch { }
            }
            if (city.Length <= 2 || city.Length >= 20)
            {
                return false;
            }
            return true;
        }
        private bool IsCityInDB(string city)
        {
            var reader = dB.GetData($"SELECT * FROM Cities WHERE EXISTS (SELECT City_Name FROM Cities WHERE City_Name = '{city}');");
            while (reader.Read()) 
            { 
                reader.Close(); 
                dB.CloseConn(); 
                return true; 
            }
            reader.Close(); dB.CloseConn();
            return false;
        }
        private void IsAddEnable(bool check)
        {
            if (check)
            {
                AddRoute_Btn.Visibility = Visibility.Visible;
                Label_IsPossible.Visibility = Visibility.Hidden;
            } else
            {
                AddRoute_Btn.Visibility = Visibility.Hidden;
                Label_IsPossible.Visibility = Visibility.Visible;
            }
        }
    }
}
