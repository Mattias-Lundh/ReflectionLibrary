using static System.Console;
namespace ReflectionLibrary.DesignPatterns.Factory.Demo.Abstract_factory
{
    internal class Tea : IHotDrink
    {
        public void Consume()
        {
            WriteLine($"Gulp, that's some amazing tea right there!");
        }
    }
}