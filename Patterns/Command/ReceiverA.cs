namespace design_patterns.Patterns.Command
{
    class ReceiverA: IReceiver
    {
        public string DoSomething()
        {
            return "I am the Receiver A";
        }
    }   
}