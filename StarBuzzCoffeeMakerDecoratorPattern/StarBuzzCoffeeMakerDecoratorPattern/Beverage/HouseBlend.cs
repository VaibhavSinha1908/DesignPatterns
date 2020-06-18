namespace StarBuzzCoffeeMakerDecoratorPattern.Beverage
{
    public class HouseBlend : IBeverage
    {
        public double GetCost()
        {
            return .89;
        }

        public string GetDescription()
        {
            return "House Blend";
        }
    }
}
