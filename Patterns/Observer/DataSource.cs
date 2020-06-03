namespace design_patterns.Patterns.Observer
{
    class DataSource : Subject
    {
        private string value;

        public string Value
        {
            get { return this.value; }
            set {
                this.value = value;
                notifyObserver(this.value);
            }
        }
    }
}