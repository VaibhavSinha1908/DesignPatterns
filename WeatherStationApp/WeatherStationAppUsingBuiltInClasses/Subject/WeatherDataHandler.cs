using System;
using System.Collections.Generic;
using System.Linq;

namespace WeatherStationAppUsingBuiltInClasses.Subject
{
    class WeatherDataHandler : IObservable<WeatherData>
    {
        WeatherData weatherData;
        List<IObserver<WeatherData>> Observers;

        public WeatherDataHandler()
        {
            weatherData = new WeatherData();
        }
        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (!Observers.Select(x => x == observer).Any())
            {
                Observers.Add(observer);
                observer.OnNext(weatherData);
            }
            return new Unsubscriber<WeatherData>();
        }
    }
}
