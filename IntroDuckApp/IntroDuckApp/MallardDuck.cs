namespace IntroDuckApp
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            System.Console.WriteLine("I'm a real Mallard Duck.");

        }
    }
}
