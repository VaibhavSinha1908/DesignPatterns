namespace StarBuzzCoffeeMakerDecoratorPattern
{
    class EspressoBeverage : IBeverage
    {
        public double GetCost()
        {
            return 1.99;
        }

        public string GetDescription()
        {
            return "Espresso";
        }
    }
}
