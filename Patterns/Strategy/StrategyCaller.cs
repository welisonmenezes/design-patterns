namespace design_patterns.Patterns.Strategy
{
    class StrategyCaller
    {
        public string showStrategy(IStrategy concrete)
        {
            return concrete.printOut();
        }
    }
}