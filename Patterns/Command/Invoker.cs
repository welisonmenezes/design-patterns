namespace design_patterns.Patterns.Command
{
    class Invoker
    {
        private ICommand command;

        public void setCommand(ICommand command)
        {
            this.command = command;
        }

        public string Event() 
        {
            return this.command.execute();
        }
    }
}