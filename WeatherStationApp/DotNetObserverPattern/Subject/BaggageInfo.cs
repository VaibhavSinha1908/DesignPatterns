namespace DotNetObserverPattern
{
    public class BaggageInfo
    {
        public int FlightNumber { get; set; }
        public string From { get; set; }

        public int Carousel { get; set; }

        public BaggageInfo(int flight, string from, int carousel)
        {
            FlightNumber = flight;
            From = from;
            Carousel = carousel;
        }


    }
}
