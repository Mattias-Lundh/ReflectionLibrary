namespace ReflectionLibrary.DesignPatterns.Factory.Abstract_factory
{
    using System;

    internal class CoffeeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"grinding beans, adding filter, filling filter, pouring {amount} ml water, waiting for drip, enjoy!");
            return new Coffee();
        }
    }
}