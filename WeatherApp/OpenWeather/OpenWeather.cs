using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherApp.OpenWeather
{
    internal class OpenWeather
    {
        public Coord coord { get; set; }
        public Weather weather;

        [JsonProperty("base")]
        public string Base { get; set; }
        public Main main { get; set; }

        public double visibility;
        public Wind wind;
        public Clouds clouds { get; set; }

        public double dt { get; set; }
        public Sys sys;

        public int id { get; set; }
        public string name { get; set; }
        public double cod { get; set; }
    }
}
