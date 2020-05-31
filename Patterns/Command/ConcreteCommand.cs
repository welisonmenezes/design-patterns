namespace design_patterns.Patterns.Command
{
    class ConcreteCommand : ICommand
    {
        IReceiver receiver;

        public void setReceiver(IReceiver receiver)
        {
            this.receiver = receiver; 
        }

        public string execute()
        {
            return this.receiver.DoSomething();
        }
    }
}