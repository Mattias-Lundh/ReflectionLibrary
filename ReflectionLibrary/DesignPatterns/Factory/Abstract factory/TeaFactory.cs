namespace ReflectionLibrary.DesignPatterns.Factory.Abstract_factory
{
    using System;

    internal class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"+1 tea bag, boil water, pour {amount} ml water, enjoy!");
            return new Tea();
        }
    }
}