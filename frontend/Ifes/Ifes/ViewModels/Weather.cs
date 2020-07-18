﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels
{
    public class Weather
    {
        public string Location { get; private set; }
        public DateTime DateTime { get; private set; }
        public int Temperature { get; private set; }
        // probability of precipitation
        public double Precipitation { get; private set; }
        public double WindSpeed { get; private set; }

        public Weather(string location, DateTime dateTime, int temperature, double precipitation, double windSpeed)
        {
            Location = location;
            DateTime = dateTime;
            Temperature = temperature;
            Precipitation = precipitation;
            WindSpeed = windSpeed;
        }
    }
}
