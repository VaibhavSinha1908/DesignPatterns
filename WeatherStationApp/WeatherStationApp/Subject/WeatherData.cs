using System.Collections.Generic;
using WeatherStationApp.Observers;

namespace WeatherStationApp.Subject
{
    public class WeatherData : ISubject
    {
        List<IObserver> observers;
        float temperature;
        float humidity;
        float pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            observers.ForEach(x => x.Update(temperature, humidity, pressure));
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void MeasurementChanged()
        {
            this.NotifyObservers();
        }

        public void SetMeasurements(float newTemperature, float newHumidity, float newPressure)
        {
            this.temperature = newTemperature;
            this.pressure = newPressure;
            this.humidity = newHumidity;

            this.MeasurementChanged();
        }
    }
}
