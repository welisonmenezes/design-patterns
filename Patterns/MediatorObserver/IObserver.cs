using System;
namespace design_patterns.Patterns.MediatorObserver
{
    public interface IObserver
    {
        Action callback {get; set;}
        void update();
    }
}