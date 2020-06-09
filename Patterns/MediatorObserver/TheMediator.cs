namespace design_patterns.Patterns.MediatorObserver
{
    public class TheMediator
    {
        public ConcreteControlA concreteA;
        public ConcreteControlB concreteB;
        public ConcreteControlC concreteC;

        public TheMediator()
        {
            this.concreteA = new ConcreteControlA();
            this.concreteB = new ConcreteControlB();
            this.concreteC = new ConcreteControlC();

            Observer observerA = new Observer();
            observerA.callback = () => {
                this.concreteA.Value = "A changed by A";
                this.concreteB.Value = "B changed by A";
                this.concreteC.Value = "C changed by A";
            };
            this.concreteA.attach(observerA);

            Observer observerB = new Observer();
            observerB.callback = () => {
                this.concreteA.Value = "A changed by B";
                this.concreteB.Value = "B changed by B";
                this.concreteC.Value = "C changed by B";
            };
            this.concreteB.attach(observerB);

            Observer observerC = new Observer();
            observerC.callback = () => {
                this.concreteA.Value = "A changed by C";
                this.concreteB.Value = "B changed by C";
                this.concreteC.Value = "C changed by C";
            };
            this.concreteC.attach(observerC);
        }

        public void SetConcreteA()
        {
            this.concreteA.changeIt();
        }

        public void SetConcreteB()
        {
            this.concreteB.changeIt();
        }

        public void SetConcreteC()
        {
            this.concreteC.changeIt();
        }
    }
}