namespace StarBuzzCoffeeMakerDecoratorPattern.Beverage
{
    public class DarkRoast : IBeverage
    {
        public double GetCost()
        {
            return .99;
        }

        public string GetDescription()
        {
            return "Dark Roast";
        }
    }
}
