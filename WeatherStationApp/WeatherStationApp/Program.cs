using System;
using WeatherStationApp.Observers;
using WeatherStationApp.Subject;

namespace WeatherStationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initiating a weather station app.");

            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.4f);
            weatherData.SetMeasurements(78, 90, 29.4f);

        }
    }
}
