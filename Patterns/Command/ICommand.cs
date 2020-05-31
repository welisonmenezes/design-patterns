namespace design_patterns.Patterns.Command
{
    interface ICommand
    {
        void setReceiver(IReceiver receiver);
        string execute();
    }
}