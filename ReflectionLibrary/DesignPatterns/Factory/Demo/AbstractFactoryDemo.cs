using ReflectionLibrary.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Factory.Demo
{
    using ReflectionLibrary.DesignPatterns.Factory.Abstract_factory;

    public class AbstractFactoryDemo : IDemo, IDemoDescription
    {
        public string Description { get; set; } = "Provide an interface for creating families of related or dependant objects without specifying th";
        public string Title { get; set; } = "Abstract Factory";

        public void Run()
        {
            var machine = new HotDrinkMachine();
            var drink = machine.MakeDrink(HotDrinkMachine.AvaliableDrink.Coffee, 5);

            drink.Consume();
        }
    }
}
