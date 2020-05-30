namespace design_patterns.Patterns.State
{
    class ConcreteB : IState
    {
        public string MouseDown()
        {
            return "ContreteB MouseDown";
        }

        public string MouseUp()
        {
            return "ContreteB MouseUp";
        }
    }
}