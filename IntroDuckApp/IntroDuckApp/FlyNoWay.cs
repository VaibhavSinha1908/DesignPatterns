using System;

namespace IntroDuckApp
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Oops no flying duck here!");
        }
    }
}
