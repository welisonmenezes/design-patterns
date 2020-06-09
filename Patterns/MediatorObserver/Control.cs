using System.Collections.Generic;
namespace design_patterns.Patterns.MediatorObserver
{
    public abstract class Control
    {
        private List<IObserver> observers = new List<IObserver>();
        
        public void attach(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void notifyObservers()
        {
            foreach (IObserver observer in this.observers)
            {
                observer.update();
            }
        }

        public void changeIt()
        {
            this.notifyObservers();
        }
    }
}