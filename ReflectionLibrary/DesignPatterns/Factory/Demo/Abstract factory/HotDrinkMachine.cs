namespace ReflectionLibrary.DesignPatterns.Factory.Demo.Abstract_factory
{
    using System;
    using System.Collections.Generic;

    public class HotDrinkMachine
    {
        public HotDrinkMachine()
        {
            foreach (AvaliableDrink drink in Enum.GetValues(typeof(AvaliableDrink)))
            {
                var factory = (IHotDrinkFactory) Activator.CreateInstance(
                    Type.GetType("ReflectionLibrary.DesignPatterns.Factory.Demo.Abstract_factory." + Enum.GetName(typeof(AvaliableDrink), drink) + "Factory")
                    );
                this.factories.Add(drink, factory);
            }
        }
        public enum AvaliableDrink
        {
            Coffee, Tea
        }

        private Dictionary<AvaliableDrink, IHotDrinkFactory> factories = 
            new Dictionary<AvaliableDrink, IHotDrinkFactory>();

        public IHotDrink MakeDrink(AvaliableDrink drink, int amount)
        {
            return this.factories[drink].Prepare(amount);
        }
    }
}