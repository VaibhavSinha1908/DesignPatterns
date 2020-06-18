namespace StarBuzzCoffeeMakerDecoratorPattern
{
    public class Mocha : ICondimentDecorator
    {
        public IBeverage Beverage { get; }

        public Mocha(IBeverage beverage)
        {
            Beverage = beverage;
        }


        public double GetCost()
        {
            return Beverage.GetCost() + .20;
        }

        public string GetDescription()
        {
            return Beverage.GetDescription() + ", Mocha";
        }
    }
}