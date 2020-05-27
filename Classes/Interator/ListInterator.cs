using System.Linq;
namespace  design_patterns.Classes.Interator
{
    class ListInterator : IInterator<string>
    {
        private History history { get; }
        private int index { get; set; }

        public ListInterator(History history)
        {
            this.history = history;
            this.index = 0;
        }

        public string current()
        {
            try
            {
                return this.history.items.ElementAt(this.index);
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public bool hasNext()
        {
            return (this.index + 1 < this.history.items.Count);
        }

        public bool hasPrev()
        {
            return (this.index > 0);
        }

        public void next()
        {
            this.index++;
        }

        public void prev()
        {
            this.index--;
        }
    }
}