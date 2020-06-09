using System;
namespace design_patterns.Patterns.MediatorObserver
{
    public class Observer : IObserver
    {
        public Action callback { get; set; }

        public void update() {
            callback();
        }
    }
}