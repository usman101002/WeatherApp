using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.OpenWeather
{
    internal class Main
    {
        private double _temp;
        public double Temp
        {
            get
            {
                return _temp;
            }
            set
            {
                _temp = value - 273.15; // перевод в цельсии
            }
        }

        private double _pressure;
        public double Pressure
        {
            get
            {
                return _pressure;
            }
            set
            {
                _pressure = value / 1.3332239; // перевод в милиметры ртутного столба
            }
        }


        private double _temp_min;
        public double Temp_min
        {
            get
            {
                return _temp_min;
            }
            set
            {
                _temp_min = value - 273.15; // перевод в цельсии
            }
        }

        private double _temp_max;
        public double Temp_max
        {
            get
            {
                return _temp_max;
            }
            set
            {
                _temp_max = value - 273.15; // перевод в цельсии
            }
        }

        private double _humidity;

        public double Humidity
        {
            get
            {
                return _humidity;
            }
            set
            {
                _humidity = value;
            }
        }


    }
}
