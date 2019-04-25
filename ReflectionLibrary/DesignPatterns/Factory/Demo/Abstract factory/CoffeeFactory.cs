using static System.Console;
namespace ReflectionLibrary.DesignPatterns.Factory.Demo.Abstract_factory
{
    internal class CoffeeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            WriteLine($"grinding beans, adding filter, filling filter, pouring {amount} ml water, waiting for drip, enjoy!");
            return new Coffee();
        }
    }
}