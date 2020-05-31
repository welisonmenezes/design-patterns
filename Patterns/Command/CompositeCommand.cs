using System.Linq;
using System.Collections.Generic;

namespace design_patterns.Patterns.Command
{
    class CompositeCommand : ICommand
    {
        public IList<IReceiver> receivers = new List<IReceiver>();

        public void setReceiver(IReceiver receiver)
        {
            this.receivers.Add(receiver);
        }

        public void clearReceivers()
        {
            this.receivers.Clear();
        }

        public string execute()
        {
            string ret = "";
            foreach (IReceiver receiver in this.receivers)
            {
                ret += receiver.DoSomething() + " - ";
            }
            return ret;
        }
    }
}