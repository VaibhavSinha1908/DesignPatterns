namespace StarBuzzCoffeeMakerDecoratorPattern.Condiments
{
    public class Whip : ICondimentDecorator
    {
        public Whip(IBeverage beverage)
        {
            Beverage = beverage;
        }

        public IBeverage Beverage { get; }

        public double GetCost()
        {
            return Beverage.GetCost() + .10;
        }

        public string GetDescription()
        {
            return Beverage.GetDescription() + ", Whip";
        }
    }
}
