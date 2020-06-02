namespace design_patterns.Patterns.UndoCommand
{
    class ConcreteCommand : IUndoCommand
    {
        private string prevContent;
        private Receiver receiver;
        private History history;

        public ConcreteCommand(Receiver receiver, History history)
        {
            this.receiver = receiver;
            this.history = history;
        }

        public void execute()
        {
            this.prevContent = receiver.Content;
            receiver.MakeTranformation();
            System.Console.WriteLine(this);
            history.push(this);
        }

        public void unexecute()
        {
            receiver.Content = this.prevContent;
        }
    }
}