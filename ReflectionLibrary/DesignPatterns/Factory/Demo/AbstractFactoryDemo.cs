using ReflectionLibrary.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Factory.Demo
{
    public class AbstractFactoryDemo : IDemo, IDemoDescription
    {
        public string Description { get; set; } = "A component responsible solely for the wholesale (not piecewise) creation of objects";
        public string Title { get; set; } = "Abstract Factory";

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
