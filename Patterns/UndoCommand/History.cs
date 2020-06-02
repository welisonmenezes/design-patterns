using System.Linq;
using System.Collections.Generic;

namespace design_patterns.Patterns.UndoCommand
{
    class History
    {
        public Queue<IUndoCommand> commands = new Queue<IUndoCommand>();

        public void push(IUndoCommand command)
        {
            this.commands.Enqueue(command);
        }

        public IUndoCommand pop()
        {
            IUndoCommand  last = this.commands.Peek();
            this.commands.Dequeue();
            return last;
        }

        public int getSize()
        {
            return this.commands.Count;
        }
    }
}