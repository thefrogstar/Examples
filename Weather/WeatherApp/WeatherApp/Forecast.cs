using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{

    class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    class Current
    {
        public double temp { get; set; }
        public int clouds { get; set; }
        public double wind_speed { get; set; }
        public int wind_deg { get; set; }
        public List<Weather> weather { get; set; }  //This is not being used, just here to demonstrate deserializing a collection
    }
    class Forecast
    {
       public Current current { get; set; }
    }
}
