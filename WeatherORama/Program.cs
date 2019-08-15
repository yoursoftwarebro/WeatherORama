using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherORama.DisplayElement;

namespace WeatherORama
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            SimpleForecastDisplay simpleForecast = new SimpleForecastDisplay(weatherData);
            WeatherStatisticsDisplay weatherStatistics = new WeatherStatisticsDisplay(weatherData);
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            weatherData.StartObtainingData();

        }
    }
}
