using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        const string apiKey = "2b6b6f3c49d169eafb17955138269bca";
        List<char> directions = new List<char> { 'á', 'ä', 'à', 'æ', 'â', 'å', 'ß', 'ã' };  //arrows in wingdings
        private double longitude = 0.810280;
        private double latitude = 51.346943;
        public Form1()
        {
            InitializeComponent();
        }

        IEnumerable<DateTime> GetNextFivedays()
        {
            for (int d=0;d<5;d++)
            {
                yield return DateTime.Now.AddDays(d);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {                       
                dateLabel.Font = new Font("Verdana", 12, FontStyle.Bold);
                dateLabel.Text = DateTime.Now.ToLongDateString();
        }
            
        //I would prefer to run this on a timer but I don't think the weather people would like that so it's a button
        private String getWeather(double longitude, double latitude)
        { 
            WebClient webClient = new WebClient();
            webClient.QueryString.Add("lat", latitude.ToString());
            webClient.QueryString.Add("lon", longitude.ToString());
            webClient.QueryString.Add("exclude", "hourly");
            webClient.QueryString.Add("appid", "2b6b6f3c49d169eafb17955138269bca");
            String weather = webClient.DownloadString("https://api.openweathermap.org/data/2.5/onecall");
            return weather;
        }

        private void updateWeather(Forecast currentForecast)
        {

            int temperature = (int)currentForecast.current.temp - 273;
            temperatureLabel.Font = new Font("Verdana", 12, FontStyle.Bold);
            if (temperature < 10)
                temperatureLabel.ForeColor = Color.Blue;
            else if (temperature > 25)
                temperatureLabel.ForeColor = Color.Red;
            else
                temperatureLabel.ForeColor = Color.Green;
            temperatureLabel.Text = $"{temperature}° C";

            windSpeedLabel.TextAlign = ContentAlignment.MiddleCenter;
            windSpeedLabel.Font = new Font("Verdana", 40, FontStyle.Bold);
            windSpeedLabel.Text = $"{currentForecast.current.wind_speed.ToString()} MPH";

            windDirLabel.TextAlign = ContentAlignment.MiddleCenter;
            windDirLabel.Font = new Font("Wingdings", 80, FontStyle.Bold);
            windDirLabel.Text = directions[currentForecast.current.wind_deg / 45].ToString();

            Bitmap wholeCloud = new Bitmap("Cloud.png");
            if (currentForecast.current.clouds > 0)
            {
                Rectangle srcRect = new Rectangle(0, 0, (int)(currentForecast.current.clouds / 100.00 * 400.00), 300);
                pbCloud.Image = wholeCloud.Clone(srcRect, wholeCloud.PixelFormat);
            }
            else
            { pbCloud.Image = null; }
                pbCloud.Update();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var weather = JObject.Parse(getWeather(longitude, latitude));
            Forecast currentForecast = weather.ToObject<Forecast>();
            updateWeather(currentForecast);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbLocation.Text)
            {
                case "Sandhurst":
                    longitude = 0.810280;
                    latitude = 51.346943;                    
                    break;
                case "Bahrain":
                    longitude = 50.544971;
                    latitude = 25.987599;
                    break;
                case "Greenland":                     
                    longitude = -42.082043;
                    latitude = 74.937045;
                    break;
                case "Australia":
                    longitude = 136.119338;
                    latitude = -24.027964;
                    break;
                default:
                    break;
            }
            lblLocation.Text = $"Longitude: {longitude } Latitude: {latitude}";
        }
    }
}
