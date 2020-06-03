using System.Linq;
using System.Collections.Generic;

namespace design_patterns.Patterns.Observer
{
    class Subject
    {
        public IList<IObserver> observers = new List<IObserver>();

        public void addObserver(IObserver observer) 
        {
            this.observers.Add(observer);
        }

        public void removeObserver(IObserver observer) 
        {
            this.observers.Remove(observer);
        }

        public void notifyObserver(string param)
        {
            foreach (IObserver observer in this.observers)
            {
                observer.update(param);
            }
        }
    }
}