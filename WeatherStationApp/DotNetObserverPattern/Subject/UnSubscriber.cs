using System;
using System.Collections.Generic;

namespace DotNetObserverPattern
{
    internal class UnSubscriber<TBaggageInfo> : IDisposable
    {
        private readonly List<IObserver<TBaggageInfo>> _observers;
        private readonly IObserver<TBaggageInfo> _observer;

        public UnSubscriber(List<IObserver<TBaggageInfo>> observers, IObserver<TBaggageInfo> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}