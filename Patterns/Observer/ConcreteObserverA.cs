namespace design_patterns.Patterns.Observer
{
    class ConcreteObserverA : IObserver
    {
        public string value { get; set; }
        public void update(string param)
        {
            this.value = "ConcreteObserveA received: " + param;
        }
    }
}