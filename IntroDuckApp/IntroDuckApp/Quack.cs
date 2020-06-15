namespace IntroDuckApp
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            System.Console.WriteLine("Quack!");
        }
    }
}
