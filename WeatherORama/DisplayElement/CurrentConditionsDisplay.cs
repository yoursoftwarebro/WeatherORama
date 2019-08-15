using System;

namespace WeatherORama.DisplayElement
{
    public class CurrentConditionsDisplay : IDisplayElement, IObserverMember
    {
        double _currentTemp = 0;
        double _currentHumidity = 0;
        double _currentPressure = 0;
        ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }
        public void Update(double temp, double humidity, double pressure)
        {
            _currentTemp =
                #region Computation of Current Temp
                temp;
            #endregion 
            _currentHumidity =
                #region Computation of Current Humidity
                humidity;
            #endregion 
            _currentPressure =
                #region Computation of Current Pressure
                pressure;
            #endregion 

            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current Conditions Display Element");
            Console.WriteLine($"Temperature: {_currentTemp} celsius.");
            Console.WriteLine($"Humidity: {_currentHumidity} celsius.");
            Console.WriteLine($"Pressure: {_currentPressure} celsius.\n");
        }
    }
}
