using ReflectionLibrary.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ReflectionLibrary.DesignPatterns.Factory.Demo
{
    public class FactoryMethodDemo : IDemo, IDemoDescription
    {
        public string Description { get; set; } = "A component responsible solely for the wholesale (not piecewise) creation of objects";
        public string Title { get; set; } = "FactoryMethod";

        public void Run()
        {
            var myPoint = Point.NewCartesianPoint(2, 3);
            WriteLine(myPoint);
        }
    }
}
