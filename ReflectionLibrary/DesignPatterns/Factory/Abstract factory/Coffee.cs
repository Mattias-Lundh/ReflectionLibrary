namespace ReflectionLibrary.DesignPatterns.Factory.Abstract_factory
{
    using System;

    internal class Coffee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine($"sip sip, coffee time!");
        }
    }
}