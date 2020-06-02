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
            history.push((IUndoCommand) this.MemberwiseClone());
        }

        public void unexecute()
        {
            receiver.Content = this.prevContent;
        }
    }
}