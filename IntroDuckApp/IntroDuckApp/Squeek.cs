namespace IntroDuckApp
{
    public class Squeek : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            System.Console.WriteLine("Squeek!");
        }
    }
}
