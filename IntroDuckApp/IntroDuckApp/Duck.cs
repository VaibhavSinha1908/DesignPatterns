namespace IntroDuckApp
{
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;

        public Duck()
        {

        }

        public abstract void Display();


        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void Swim()
        {
            System.Console.WriteLine("All ducks can swim, even the decoys.");
        }

        public void setFlyingBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void setQuackingBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
}
