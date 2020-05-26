using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;
class History
{
    private IList<State> states = new List<State>();

    public void push(State state)
    {
        this.states.Add(state);
    }

    public State pop()
    {
        int lastIndex = this.states.Count - 1;
        System.Console.WriteLine(lastIndex);
        State lastState = this.states.ElementAt(lastIndex);
        this.states.Remove(lastState);
        return lastState;
    }
}