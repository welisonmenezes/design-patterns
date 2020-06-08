namespace design_patterns.Patterns.Mediator
{
    public class Control
    {
        protected IMediator owner;
        
        public void ChangeId()
        {
            owner.Change(this);
        }

        public Control(IMediator owner)
        {
            this.owner = owner;
        }
    }
}