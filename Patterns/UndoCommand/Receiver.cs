namespace design_patterns.Patterns.UndoCommand
{
    class Receiver
    {
        private string content;

        public string Content { get => content; set => content = value; }

        public void MakeTranformation()
        {
            this.Content = "<p>" + this.content + "</p>";
        }
    }
}