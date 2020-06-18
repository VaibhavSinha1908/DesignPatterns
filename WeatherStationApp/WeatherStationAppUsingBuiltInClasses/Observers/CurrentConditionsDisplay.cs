using System;
using WeatherStationAppUsingBuiltInClasses.Subject;

namespace WeatherStationAppUsingBuiltInClasses.Observers
{
    public class CurrentConditionsDisplay : IObserver<WeatherData>
    {
        float temperature;
        float humidity;
        float pressure;

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(WeatherData value)
        {
            throw new NotImplementedException();
        }
    }
}
