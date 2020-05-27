namespace design_patterns.Classes.State
{
    class ConcreteA : IState
    {
        public string MouseDown()
        {
            return "ContreteA MouseDown";
        }

        public string MouseUp()
        {
            return "ContreteA MouseUp";
        }
    }
}