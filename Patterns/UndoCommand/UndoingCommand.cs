namespace design_patterns.Patterns.UndoCommand
{
    class UndoingCommand: ICommand
    {
        private History history;

        public UndoingCommand(Receiver receiver, History history)
        {
            this.history = history;
        }

        public void execute()
        {
            if (this.history.getSize() > 0)
            {
                this.history.pop().unexecute();
            }
        }
    }
}