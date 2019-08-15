using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherORama.DisplayElement
{
    public class WeatherStatisticsDisplay : IDisplayElement, IObserverMember
    {
        double _statTemp = 0;
        double _statHumidity = 0;
        double _statPressure = 0;
        ISubject _weatherData;

        public WeatherStatisticsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }
        public void Update(double temp, double humidity, double pressure)
        {
            _statTemp =
                #region Computation of Stat Temp
                new Random().Next((int)temp - 5, (int)temp + 5);
            #endregion 
            _statHumidity =
                #region Computation of Stat Humidity
                new Random().Next((int)humidity - 5, (int)humidity + 5);
            #endregion 
            _statPressure =
                #region Computation of Stat Pressure
                new Random().Next((int)pressure - 5, (int)pressure + 5);
            #endregion

            Display();
        }

        public void Display()
        {
            Console.WriteLine("Weather Statistics Display Element");
            Console.WriteLine("Statistics");
            Console.WriteLine($"Temperature: {_statTemp} celsius.");
            Console.WriteLine($"Humidity: {_statHumidity} celsius.");
            Console.WriteLine($"Pressure: {_statPressure} celsius.\n");
        }
    }
}
