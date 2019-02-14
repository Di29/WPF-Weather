using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using QuickType;
using Weather;

namespace WpfTEST
{
    
    public partial class MainWindow : Window
    {
        WebClient client = new WebClient();
        string cities;
        Prediction prediction = new Prediction();
        List<string> predictions = new List<string>();

        public MainWindow()
        {
            InitializeComponent();

            card1.Visibility = Visibility.Hidden;
            card2.Visibility = Visibility.Hidden;
            card3.Visibility = Visibility.Hidden;
            card4.Visibility = Visibility.Hidden;
            card5.Visibility = Visibility.Hidden;
            card6.Visibility = Visibility.Hidden;
            card7.Visibility = Visibility.Hidden;
            scroll.Visibility = Visibility.Hidden;
            bord.Visibility = Visibility.Collapsed;
            
        }
        
        private void addItem(string text)
        {
            TextBlock block = new TextBlock();

            block.Text = text;

            block.Margin = new Thickness(2, 3, 2, 3);
            block.Cursor = Cursors.Hand;

            block.MouseLeftButtonUp += (sender, e) =>
            {
                searchBox.Text = (sender as TextBlock).Text;
                bord.Visibility = Visibility.Collapsed;
                press.Text = "Press Enter";
                resultStack.Children.Clear();
            };

            block.MouseEnter += (sender, e) =>
            {
                TextBlock b = sender as TextBlock;
                b.Background = Brushes.AliceBlue;
            };

            block.MouseLeave += (sender, e) =>
            {
                TextBlock b = sender as TextBlock;
                b.Background = Brushes.Transparent;
            };

            resultStack.Children.Add(block);
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            scroll.Visibility = Visibility.Visible;
            bord.Visibility = Visibility.Visible;
            cities = client.DownloadString($"https://maps.googleapis.com/maps/api/place/autocomplete/json?input={searchBox.Text}&types=(cities)&key=AIzaSyBvDu2hO0vbycYJvQBxfLoXwjKoQgl8w00");
            var city = QuickType.Welcome.FromJson(cities);
            for (int i = 0; i < city.Predictions.Length; i++)
            {
                predictions.Add(city.Predictions[i].Description);
            }


            bool found = false;
            var border = (resultStack.Parent as ScrollViewer).Parent as Border;

            string query = (sender as TextBox).Text;

            if (query.Length == 0)
            {
                resultStack.Children.Clear();
                border.Visibility = Visibility.Collapsed;
            }
            else
            {
                border.Visibility = Visibility.Visible;
            }

            resultStack.Children.Clear();

            foreach (var obj in predictions)
            {
                if (obj.ToLower().StartsWith(query.ToLower()))
                {
                    addItem(obj);
                    found = true;
                }
            }

            if (!found)
            {
                resultStack.Children.Add(new TextBlock() { Text = "No results found" });
            }
        }

        private void startSearch(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                press.Visibility = Visibility.Hidden;
                card1.Visibility = Visibility.Visible;
                card2.Visibility = Visibility.Visible;
                card3.Visibility = Visibility.Visible;
                card4.Visibility = Visibility.Visible;
                card5.Visibility = Visibility.Visible;
                card6.Visibility = Visibility.Visible;
                card7.Visibility = Visibility.Visible;


            }
        }

        private void Window()
        {

            var input = searchBox.Text;

            string data;
            WebClient client = new WebClient();

            string apiCall = "http://api.apixu.com/v1/forecast.json?key=60b564a152774ee39c1135357190402   &q=" + input + "&days=7";

            try
            {
                data = client.DownloadString(apiCall);

                var weather = Weather.Welcome.FromJson(data);

                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri("http:" + weather.Forecast.Forecastday[0].Day.Condition.Icon);
                image.EndInit();
                icon1.Source = image;

                city.Text = weather.Location.Name + " " + weather.Location.Country;
                day1.Text = weather.Forecast.Forecastday[0].Date.Date.ToString("dd.MM.yy");
                condition.Text = weather.Forecast.Forecastday[0].Day.AvgtempC + " °C " + weather.Forecast.Forecastday[0].Day.Condition.Text;
                avgTemp.Text = "Min temp: \t Max temp: \n" + weather.Forecast.Forecastday[0].Day.MintempC + " °C \t\t" + weather.Forecast.Forecastday[0].Day.MaxtempC + " °C ";
                humidity.Text = "Humidity: " + weather.Forecast.Forecastday[0].Day.Avghumidity + " %";
                windSpeed.Text = "Wind speed: " + weather.Forecast.Forecastday[0].Day.MaxwindKph + " k/h";

                BitmapImage image2 = new BitmapImage();
                image2.BeginInit();
                image2.UriSource = new Uri("http:" + weather.Forecast.Forecastday[1].Day.Condition.Icon);
                image2.EndInit();
                icon2.Source = image2;

                day2.Text = weather.Forecast.Forecastday[1].Date.Date.ToString("dd.MM.yy");
                condition2.Text = weather.Forecast.Forecastday[1].Day.AvgtempC + " °C " + weather.Forecast.Forecastday[1].Day.Condition.Text;
                avgTemp2.Text = "Min temp: \t Max temp: \n" + weather.Forecast.Forecastday[1].Day.MintempC + " °C \t\t" + weather.Forecast.Forecastday[1].Day.MaxtempC + " °C ";
                humidity2.Text = "Humidity: " + weather.Forecast.Forecastday[1].Day.Avghumidity + " %";
                windSpeed2.Text = "Wind speed: " + weather.Forecast.Forecastday[1].Day.MaxwindKph + " k/h";

                BitmapImage image3 = new BitmapImage();
                image3.BeginInit();
                image3.UriSource = new Uri("http:" + weather.Forecast.Forecastday[2].Day.Condition.Icon);
                image3.EndInit();
                icon3.Source = image3;

                day3.Text = weather.Forecast.Forecastday[2].Date.Date.ToString("dd.MM.yy");
                condition3.Text = weather.Forecast.Forecastday[2].Day.AvgtempC + " °C " + weather.Forecast.Forecastday[2].Day.Condition.Text;
                avgTemp3.Text = "Min temp: \t Max temp: \n" + weather.Forecast.Forecastday[2].Day.MintempC + " °C \t\t" + weather.Forecast.Forecastday[2].Day.MaxtempC + " °C ";
                humidity3.Text = "Humidity: " + weather.Forecast.Forecastday[2].Day.Avghumidity + " %";
                windSpeed3.Text = "Wind speed: " + weather.Forecast.Forecastday[2].Day.MaxwindKph + " k/h";

                BitmapImage image4 = new BitmapImage();
                image4.BeginInit();
                image4.UriSource = new Uri("http:" + weather.Forecast.Forecastday[3].Day.Condition.Icon);
                image4.EndInit();
                icon4.Source = image4;

                day4.Text = weather.Forecast.Forecastday[3].Date.Date.ToString("dd.MM.yy");
                condition4.Text = weather.Forecast.Forecastday[3].Day.AvgtempC + " °C " + weather.Forecast.Forecastday[3].Day.Condition.Text;
                avgTemp4.Text = "Min temp: \t Max temp: \n" + weather.Forecast.Forecastday[3].Day.MintempC + " °C \t\t" + weather.Forecast.Forecastday[3].Day.MaxtempC + " °C ";
                humidity4.Text = "Humidity: " + weather.Forecast.Forecastday[3].Day.Avghumidity + " %";
                windSpeed4.Text = "Wind speed: " + weather.Forecast.Forecastday[3].Day.MaxwindKph + " k/h";

                BitmapImage image5 = new BitmapImage();
                image5.BeginInit();
                image5.UriSource = new Uri("http:" + weather.Forecast.Forecastday[4].Day.Condition.Icon);
                image5.EndInit();
                icon5.Source = image5;

                day5.Text = weather.Forecast.Forecastday[4].Date.Date.ToString("dd.MM.yy");
                condition5.Text = weather.Forecast.Forecastday[4].Day.AvgtempC + " °C " + weather.Forecast.Forecastday[4].Day.Condition.Text;
                avgTemp5.Text = "Min temp: \t Max temp: \n" + weather.Forecast.Forecastday[4].Day.MintempC + " °C \t\t" + weather.Forecast.Forecastday[4].Day.MaxtempC + " °C ";
                humidity5.Text = "Humidity: " + weather.Forecast.Forecastday[4].Day.Avghumidity + " %";
                windSpeed5.Text = "Wind speed: " + weather.Forecast.Forecastday[4].Day.MaxwindKph + " k/h";
            }
            catch
            {
                city.Text = "No results found.";
            }
        }
    }
}
