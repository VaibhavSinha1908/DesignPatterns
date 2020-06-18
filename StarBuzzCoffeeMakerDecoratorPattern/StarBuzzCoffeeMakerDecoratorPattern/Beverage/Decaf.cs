namespace StarBuzzCoffeeMakerDecoratorPattern.Beverage
{
    public class Decaf : IBeverage
    {
        public double GetCost()
        {
            return 1.05;
        }

        public string GetDescription()
        {
            return "Decaf";
        }
    }
}
