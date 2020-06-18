using WeatherStationApp.Subject;

namespace WeatherStationApp.Observers
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        float temperature;
        float humidity;
        float pressure;

        ISubject WeatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.WeatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            System.Console.WriteLine($"Current Conditions: {temperature}F degrees " +
                $"and Humidity is {humidity} and Pressure is {pressure}");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            Display();
        }
    }
}
