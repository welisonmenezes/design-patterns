namespace design_patterns.Patterns.Mediator
{
    public class ConcreteControlA : Control
    {
        public string Value;
        public ConcreteControlA(IMediator owner) : base(owner)
        { }

    }
}