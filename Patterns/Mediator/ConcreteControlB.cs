namespace design_patterns.Patterns.Mediator
{
    public class ConcreteControlB : Control
    {
        public string Value;

        public ConcreteControlB(IMediator owner) : base(owner)
        { }

    }
}