using System;

namespace WeatherORama.DisplayElement
{
    public class SimpleForecastDisplay : IDisplayElement, IObserverMember
    {
        double _forecastTemp = 0;
        double _forecastHumidity = 0;
        double _forecastPressure = 0;
        ISubject _weatherData;

        public SimpleForecastDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(double temp, double humidity, double pressure)
        {
            _forecastTemp =
                #region Computation of Forecast Temp
                new Random().Next((int)temp - 5, (int)temp + 5);
                #endregion Computation of Forecast Temp
            _forecastHumidity =
                #region Computation of Forecast Humidity
                new Random().Next((int)humidity - 5, (int)humidity + 5);
                #endregion Computation of Forecast Humidity
            _forecastPressure = 
                #region Computation of Forecast Pressure
                new Random().Next((int)pressure - 5, (int)pressure + 5);
                #endregion Computation of Forecast Pressure

            Display();
        }

        public void Display()
        {
            Console.WriteLine("Simple Forecast Display Element");
            Console.WriteLine("Forecast for tomorrow");
            Console.WriteLine($"Temperature: {_forecastTemp} celsius.");
            Console.WriteLine($"Humidity: {_forecastHumidity} celsius.");
            Console.WriteLine($"Pressure: {_forecastPressure} celsius.\n");
        }
    }
}
