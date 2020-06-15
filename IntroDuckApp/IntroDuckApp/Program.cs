using System;

namespace IntroDuckApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting the Duck simulation....");

            MallardDuck mallardDuck = new MallardDuck();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();


            Console.WriteLine("Introducing new Duck...");
            ToyDuck toyDuck = new ToyDuck();
            toyDuck.PerformFly();
            toyDuck.PerformQuack();
            toyDuck.setFlyingBehavior(new FlyingWithRockets());
            toyDuck.PerformFly();

            Console.WriteLine("Simulation Ends!");

        }
    }
}
