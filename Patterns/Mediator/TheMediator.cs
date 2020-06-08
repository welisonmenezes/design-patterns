namespace design_patterns.Patterns.Mediator
{
    public class TheMediator : IMediator
    {
        public ConcreteControlA concreteA;
        public ConcreteControlB concreteB;
        public ConcreteControlC concreteC;

        public TheMediator()
        {
            this.concreteA = new ConcreteControlA(this);
            this.concreteB = new ConcreteControlB(this);
            this.concreteC = new ConcreteControlC(this);
        }
        
        public void Change(Control control)
        {
            System.Console.WriteLine(control.ToString());
            if (control == this.concreteA) 
            {
                this.concreteA.Value = "A changed by A";
                this.concreteB.Value = "B changed by A";
                this.concreteC.Value = "C changed by A";
            }
            else if (control == this.concreteB)
            {
                this.concreteA.Value = "A changed by B";
                this.concreteB.Value = "B changed by B";
                this.concreteC.Value = "C changed by B";
            }
            else if (control == this.concreteC)
            {
                this.concreteA.Value = "A changed by C";
                this.concreteB.Value = "B changed by C";
                this.concreteC.Value = "C changed by C";
            }
        }

        public void SetConcreteA()
        {
            this.concreteA.ChangeId();
        }

        public void SetConcreteB()
        {
            this.concreteB.ChangeId();
        }

        public void SetConcreteC()
        {
            this.concreteC.ChangeId();
        }
    }
}