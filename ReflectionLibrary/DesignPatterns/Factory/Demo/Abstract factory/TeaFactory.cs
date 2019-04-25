using static System.Console;
namespace ReflectionLibrary.DesignPatterns.Factory.Demo.Abstract_factory
{
    internal class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            WriteLine($"+1 tea bag, boil water, pour {amount} ml water, enjoy!");
            return new Tea();
        }
    }
}