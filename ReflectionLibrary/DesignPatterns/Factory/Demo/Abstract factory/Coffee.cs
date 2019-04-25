using static System.Console;
namespace ReflectionLibrary.DesignPatterns.Factory.Demo.Abstract_factory
{
    internal class Coffee : IHotDrink
    {
        public void Consume()
        {
            WriteLine($"sip sip, coffee time!");
        }
    }
}