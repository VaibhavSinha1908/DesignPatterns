using System;

namespace IntroDuckApp
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Time to fly with wings.");
        }
    }
}
