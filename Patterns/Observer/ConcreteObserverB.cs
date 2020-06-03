namespace design_patterns.Patterns.Observer
{
    class ConcreteObserverB : IObserver
    {
        public string value { get; set; }
        public void update(string param)
        {
            this.value = "ConcreteObserveB received: " + param;
        }
    }
}