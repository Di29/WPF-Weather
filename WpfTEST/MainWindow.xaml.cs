using System;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using QuickType;

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

        private void SearchBoxTextChanged(object sender, TextChangedEventArgs e)
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

        private void StartSearch(object sender, KeyEventArgs e)
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

                Search();
            }
        }

        private void Search()
        {

            var input = searchBox.Text;

            string data;
            
            WebClient client = new WebClient();

            string forecast = "http://api.apixu.com/v1/forecast.json?key=60b564a152774ee39c1135357190402   &q=" + input + "&days=7";
           

            try
            {

                data = client.DownloadString(forecast);
                

                var weather = Weather.Welcome.FromJson(data);
                city.Text = weather.Location.Name + " , " + weather.Location.Country;
                time.Text = weather.Location.Localtime;

                #region Day1

                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri("http:" + weather.Forecast.Forecastday[0].Day.Condition.Icon);
                image.EndInit();
                icon1.Source = image;

                condition.Text = weather.Current.Condition.Text;
                avgTemp.Text = weather.Current.TempC + " °C ";
                humidity.Text = weather.Current.Humidity + " %";
                windSpeed.Text = weather.Current.WindKph+ " km/h";
                feels.Text = weather.Current.FeelslikeC + " °C ";

                #endregion

                #region Day 2

                BitmapImage image2 = new BitmapImage();
                image2.BeginInit();
                image2.UriSource = new Uri("http:" + weather.Forecast.Forecastday[1].Day.Condition.Icon);
                image2.EndInit();
                icon2.Source = image2;

                day2.Text = weather.Forecast.Forecastday[1].Date.Date.ToString("dd.MM.yy");
                condition2.Text = weather.Forecast.Forecastday[1].Day.Condition.Text;
                avgTemp2.Text = weather.Forecast.Forecastday[1].Day.AvgtempC + " °C ";
                humidity2.Text = weather.Forecast.Forecastday[1].Day.Avghumidity + " %";
                windSpeed2.Text = weather.Forecast.Forecastday[1].Day.MaxwindKph + " km/h";
                minTemp2.Text = weather.Forecast.Forecastday[1].Day.MintempC + " °C ";
                maxTemp2.Text = weather.Forecast.Forecastday[1].Day.MaxtempC + " °C ";

                #endregion

                #region Day 3

                BitmapImage image3 = new BitmapImage();
                image3.BeginInit();
                image3.UriSource = new Uri("http:" + weather.Forecast.Forecastday[2].Day.Condition.Icon);
                image3.EndInit();
                icon3.Source = image3;

                day3.Text = weather.Forecast.Forecastday[2].Date.Date.ToString("dd.MM.yy");
                condition3.Text = weather.Forecast.Forecastday[2].Day.Condition.Text;
                avgTemp3.Text = weather.Forecast.Forecastday[2].Day.AvgtempC + " °C ";
                humidity3.Text = weather.Forecast.Forecastday[2].Day.Avghumidity + " %";
                windSpeed3.Text = weather.Forecast.Forecastday[2].Day.MaxwindKph + " km/h";
                minTemp3.Text = weather.Forecast.Forecastday[2].Day.MintempC + " °C ";
                maxTemp3.Text = weather.Forecast.Forecastday[2].Day.MaxtempC + " °C ";

                #endregion

                #region Day 4

                BitmapImage image4 = new BitmapImage();
                image4.BeginInit();
                image4.UriSource = new Uri("http:" + weather.Forecast.Forecastday[3].Day.Condition.Icon);
                image4.EndInit();
                icon4.Source = image4;

                day4.Text = weather.Forecast.Forecastday[3].Date.Date.ToString("dd.MM.yy");
                condition4.Text = weather.Forecast.Forecastday[3].Day.Condition.Text;
                avgTemp4.Text = weather.Forecast.Forecastday[3].Day.AvgtempC + " °C ";
                humidity4.Text = weather.Forecast.Forecastday[3].Day.Avghumidity + " %";
                windSpeed4.Text = weather.Forecast.Forecastday[3].Day.MaxwindKph + " km/h";
                minTemp4.Text = weather.Forecast.Forecastday[3].Day.MintempC + " °C ";
                maxTemp4.Text = weather.Forecast.Forecastday[3].Day.MaxtempC + " °C ";

                #endregion

                #region Day 5

                BitmapImage image5 = new BitmapImage();
                image5.BeginInit();
                image5.UriSource = new Uri("http:" + weather.Forecast.Forecastday[4].Day.Condition.Icon);
                image5.EndInit();
                icon5.Source = image5;

                day5.Text = weather.Forecast.Forecastday[4].Date.Date.ToString("dd.MM.yy");
                condition5.Text = weather.Forecast.Forecastday[4].Day.Condition.Text;
                avgTemp5.Text = weather.Forecast.Forecastday[4].Day.AvgtempC + " °C ";
                humidity5.Text = weather.Forecast.Forecastday[4].Day.Avghumidity + " %";
                windSpeed5.Text = weather.Forecast.Forecastday[4].Day.MaxwindKph + " km/h";
                minTemp5.Text = weather.Forecast.Forecastday[4].Day.MintempC + " °C ";
                maxTemp5.Text = weather.Forecast.Forecastday[4].Day.MaxtempC + " °C ";

                #endregion

                #region Day 6

                BitmapImage image6 = new BitmapImage();
                image6.BeginInit();
                image6.UriSource = new Uri("http:" + weather.Forecast.Forecastday[5].Day.Condition.Icon);
                image6.EndInit();
                icon6.Source = image5;

                day6.Text = weather.Forecast.Forecastday[5].Date.Date.ToString("dd.MM.yy");
                condition6.Text = weather.Forecast.Forecastday[5].Day.Condition.Text;
                avgTemp6.Text = weather.Forecast.Forecastday[5].Day.AvgtempC + " °C ";
                humidity6.Text = weather.Forecast.Forecastday[5].Day.Avghumidity + " %";
                windSpeed6.Text = weather.Forecast.Forecastday[5].Day.MaxwindKph + " km/h";
                minTemp6.Text = weather.Forecast.Forecastday[5].Day.MintempC + " °C ";
                maxTemp6.Text = weather.Forecast.Forecastday[5].Day.MaxtempC + " °C ";

                #endregion

                #region Day 7

                BitmapImage image7 = new BitmapImage();
                image7.BeginInit();
                image7.UriSource = new Uri("http:" + weather.Forecast.Forecastday[6].Day.Condition.Icon);
                image7.EndInit();
                icon7.Source = image5;

                day7.Text = weather.Forecast.Forecastday[6].Date.Date.ToString("dd.MM.yy");
                condition7.Text = weather.Forecast.Forecastday[6].Day.Condition.Text;
                avgTemp7.Text = weather.Forecast.Forecastday[6].Day.AvgtempC + " °C ";
                humidity7.Text = weather.Forecast.Forecastday[6].Day.Avghumidity + " %";
                windSpeed7.Text = weather.Forecast.Forecastday[6].Day.MaxwindKph + " km/h";
                minTemp7.Text = weather.Forecast.Forecastday[6].Day.MintempC + " °C ";
                maxTemp7.Text = weather.Forecast.Forecastday[6].Day.MaxtempC + " °C ";

                #endregion
            }
            catch
            {
                city.Text = "No results found.";
            }
        }
    }
}
