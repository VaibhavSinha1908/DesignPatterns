namespace StarBuzzCoffeeMakerDecoratorPattern.Condiments
{
    public class SteamedMilk : ICondimentDecorator
    {
        public SteamedMilk(IBeverage beverage)
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
            return Beverage.GetDescription() + ", Steamed Milk";
        }
    }
}
