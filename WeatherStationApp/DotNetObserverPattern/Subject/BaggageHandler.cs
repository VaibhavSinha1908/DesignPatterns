using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetObserverPattern
{
    public class BaggageHandler : IObservable<BaggageInfo>
    {
        public BaggageHandler()
        {
            Observers = new List<IObserver<BaggageInfo>>();
            Flights = new List<BaggageInfo>();
        }

        private List<IObserver<BaggageInfo>> Observers { get; }
        private List<BaggageInfo> Flights { get; }


        public IDisposable Subscribe(IObserver<BaggageInfo> observer)
        {
            if (!Observers.Contains(observer))
            {
                Observers.Add(observer);
                //Provide Observer with existing data.
                foreach (var flight in Flights) observer.OnNext(flight);
            }

            return new UnSubscriber<BaggageInfo>(Observers, observer);
        }

        public void BaggageStatus(int flightNo)
        {
            BaggageStatus(flightNo, string.Empty, 0);
        }

        public void BaggageStatus(int flightNo, string from, int carousel)
        {
            var info = new BaggageInfo(flightNo, from, carousel);

            if (carousel > 0 && !Flights.Contains(info))
            {
                //New flight details; Add to the flights list.
                Flights.Add(info);

                //Inform observers about this change.
                Observers.ForEach(x => x.OnNext(info));
            }
            else if (carousel == 0)
            {
                var flightsToRemove = new List<BaggageInfo>();
                //The baggage has been already claimed.
                foreach (var flight in Flights.Where(x => x.FlightNumber == info.FlightNumber))
                {
                    flightsToRemove.Add(flight);
                    Observers.ForEach(x => x.OnNext(info));
                }

                //Remove the Checked out Flights from the List.
                foreach (var flightToRemove in flightsToRemove) Flights.Remove(flightToRemove);

                flightsToRemove.Clear();
            }
        }

        public void LastBaggageClaimed()
        {
            Observers.ForEach(x => x.OnCompleted());

            Observers.Clear();
        }
    }
}