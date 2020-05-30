namespace design_patterns.Patterns.Template
{
    class ConcreteB : Temlate
    {
        protected override string doExecute(string text)
        {
            return "ConcreteB imprime: " + text;
        }
    }
}