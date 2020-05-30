namespace design_patterns.Patterns.Template
{
    abstract class Temlate
    {
        private DoSomething doer;
        private string tmplString;

        public string execute()
        {
            this.doer = new DoSomething();
            tmplString = doer.justdoit();

            return doExecute(tmplString);
        }

        protected abstract string doExecute(string text);
    }
}