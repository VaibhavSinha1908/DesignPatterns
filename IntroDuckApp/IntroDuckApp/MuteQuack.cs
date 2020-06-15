namespace IntroDuckApp
{
    public class MuteQuack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            System.Console.WriteLine("<<   Silence   >>");
        }
    }
}
