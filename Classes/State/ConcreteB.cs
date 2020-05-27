namespace design_patterns.Classes.State
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