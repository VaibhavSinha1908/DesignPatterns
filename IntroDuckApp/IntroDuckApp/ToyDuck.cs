namespace IntroDuckApp
{
    public class ToyDuck : Duck
    {

        public ToyDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }


        public override void Display()
        {
            System.Console.WriteLine("I am the best Toy Duck");
        }
    }
}
