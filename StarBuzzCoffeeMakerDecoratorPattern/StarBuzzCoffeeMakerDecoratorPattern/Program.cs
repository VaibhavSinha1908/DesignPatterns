using StarBuzzCoffeeMakerDecoratorPattern.Beverage;
using StarBuzzCoffeeMakerDecoratorPattern.Condiments;
using System;

namespace StarBuzzCoffeeMakerDecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var houseBlend = new HouseBlend();

            var soy = new SoyMilk(houseBlend);
            var mocha = new Mocha(soy);
            var doubleMocha = new Mocha(mocha);

            var whip = new Whip(doubleMocha);

            Console.WriteLine($"The cost of {whip.GetDescription()} coffee is: {whip.GetCost()} ");

        }
    }
}
