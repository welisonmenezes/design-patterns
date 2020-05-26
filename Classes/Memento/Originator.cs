class Originator
{
    private string content { get; set; }

    public State createState()
    {
        return new State(this.content);
    }

    public void restore(State state)
    {
        content = state.getContent();
    }

    public string getContent()
    {
        return this.content;
    }

    public void setContent(string content)
    {
        this.content = content;
    }
}