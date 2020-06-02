using System.Linq;
using System.Collections.Generic;

namespace design_patterns.Patterns.UndoCommand
{
    class History
    {
        public IList<IUndoCommand> commands = new List<IUndoCommand>();

        public void push(IUndoCommand command)
        {
            this.commands.Add(command);
        }

        public IUndoCommand pop()
        {
            int lastIndex = this.commands.Count -1;
            IUndoCommand  lastElement = this.commands[lastIndex];
            this.commands.RemoveAt(lastIndex);
            return lastElement;
        }

        public int getSize()
        {
            return this.commands.Count;
        }
    }
}