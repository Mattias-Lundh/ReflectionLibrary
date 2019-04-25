namespace ReflectionLibrary.DesignPatterns.Factory.Abstract_factory
{
    using System;

    internal class Tea : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine($"Gulp, that's some amazing tea right there!");
        }
    }
}