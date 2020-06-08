namespace design_patterns.Patterns.Mediator
{
    public class ConcreteControlC : Control
    {
        public string Value;

        public ConcreteControlC(IMediator owner) : base(owner)
        { }

    }
}