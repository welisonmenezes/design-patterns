namespace design_patterns.Patterns.Command
{
    class ReceiverB: IReceiver
    {
        public string DoSomething()
        {
            return "I am the Receiver B";
        }
    }   
}