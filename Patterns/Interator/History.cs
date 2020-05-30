using System.Linq;
using System.Collections.Generic;

namespace design_patterns.Patterns.Interator
{
    class History
    {
        public List<string> items = new List<string>();

        public void push(string data)
        {
            this.items.Add(data);
        }

        public string pop()
        {
            if (this.getLast() != null)
            {
                this.items.Remove(this.getLast());
            }
            return this.getLast();
        }

        public IInterator<string> createInterator()
        {
            return new ListInterator(this);
        }

        private string getLast()
        {
            if (this.items.Count > 0)
            {
                int lastIndex = this.items.Count - 1;
                string lastState = this.items.ElementAt(lastIndex);
                return lastState;
            }
            else
            {
                return null;
            }
        }

    }
}