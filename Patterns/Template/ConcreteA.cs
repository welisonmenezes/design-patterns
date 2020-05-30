namespace design_patterns.Patterns.Template
{
    class ConcreteA : Temlate
    {
        protected override string doExecute(string text)
        {
            return "ConcreteA imprime: " + text;
        }
    }
}