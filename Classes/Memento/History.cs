using System.Linq;
using System.Collections.Generic;

namespace design_patterns.Classes.Memento
{
    class History
    {
        public IList<State> states = new List<State>();

        public void push(State state)
        {
            this.states.Add(state);
        }

        public State pop()
        {
            if (this.getLast() != null)
            {
                this.states.Remove(this.getLast());
            }
            return this.getLast();
        }

        private State getLast()
        {
            if (this.states.Count > 0)
            {
                int lastIndex = this.states.Count - 1;
                State lastState = this.states.ElementAt(lastIndex);
                return lastState;
            }
            else
            {
                return null;
            }
        }
    }
}