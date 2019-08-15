using System;
using System.Collections.Generic;

namespace WeatherORama
{
    public class WeatherData : ISubject
    {
        private List<IObserverMember> observers;
        private double temperature;
        private double humidity;
        private double pressure;

        public WeatherData()
        {
            observers = new List<IObserverMember>();
        }
        public void RegisterObserver(IObserverMember o)
        {
            if (!observers.Contains(o))
                observers.Add(o);
        }
        public void RemoveObserver(IObserverMember o)
        {
            if (observers.Contains(o))
                observers.Remove(o);
        }
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }            
        }        

        private void MeasurementChanged()
        {
            Console.WriteLine(">>State has changed, update the observers!");
            temperature = GetTemperature();
            humidity = GetHumidity();
            pressure = GetPressure();

            NotifyObservers();
        }

        public void StartObtainingData()
        {
            #region ObtainData
            MeasurementChanged();
            MeasurementChanged();
            MeasurementChanged();
            #endregion
        }

        private double GetPressure()
        {
            return new Random().Next(20, 25);
        }

        private double GetHumidity()
        {
            return new Random().Next(20, 25);
        }

        private double GetTemperature()
        {
            return new Random().Next(20, 25);
        }
    }
}
