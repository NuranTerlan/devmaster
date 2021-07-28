using System;
using System.Collections.Generic;
using System.Linq;

namespace Observer
{
    public class DataSource
    {
        public List<int> Values { get; private set; } = new List<int>();
        private readonly List<IObserver> _observers;

        public DataSource()
        {
        }
        
        public DataSource(List<IObserver> observers)
        {
            _observers = observers;
        }

        public void AddValue(int value)
        {
            Values.Add(value);
            Console.WriteLine($"New value added to the ${nameof(DataSource)}: {value}");
            NotifyObservers();
        }

        public void AttachObserver(IObserver newObs)
        {
            _observers.Add(newObs);
        }

        public void DetachObserver(IObserver removingObs)
        {
            _observers.Remove(removingObs);
        }

        public void NotifyObservers()
        {
            _observers.ToList().ForEach((o) => o.Reload(Values));
        }
    }
}