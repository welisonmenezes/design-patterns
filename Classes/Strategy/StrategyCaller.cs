namespace design_patterns.Classes.Strategy
{
    class StrategyCaller
    {
        public string showStrategy(IStrategy concrete)
        {
            return concrete.printOut();
        }
    }
}