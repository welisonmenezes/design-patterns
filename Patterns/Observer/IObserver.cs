namespace design_patterns.Patterns.Observer
{
    interface IObserver
    {
        void update(string param);
        string value { get; set; }
    }
}