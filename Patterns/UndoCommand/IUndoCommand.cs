namespace design_patterns.Patterns.UndoCommand
{
    interface IUndoCommand : ICommand
    {
        void unexecute();
    }
}