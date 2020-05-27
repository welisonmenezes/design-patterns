namespace design_patterns.Classes.Memento
{
    class State
    {
        private readonly string content;

        public State(string content)
        {
            this.content = content;
        }

        public string getContent()
        {
            return this.content;
        }
    }
}