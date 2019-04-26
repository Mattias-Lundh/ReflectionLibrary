using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.FlyWeight.Demo
{
    using ReflectionLibrary.Infrastructure;

    public class FlyweightDemo : IDemo, IDemoDescription
    {
        public string Title { get; set; } = "Flyweight";
        public void Run()
        {
            // TODO
        }

        public string Description { get; set; } = "A space optimization technique that lets us use less memory by storing externally the data associated with similar objects";
    }
}
