namespace StarBuzzCoffeeMakerDecoratorPattern.Condiments
{
    public class SoyMilk : ICondimentDecorator
    {
        public IBeverage Beverage { get; set; }

        public SoyMilk(IBeverage beverage)
        {
            Beverage = beverage;
        }
        public double GetCost()
        {
            return Beverage.GetCost() + 0.15;
        }

        public string GetDescription()
        {
            return Beverage.GetDescription() + ", Soy";
        }
    }
}
