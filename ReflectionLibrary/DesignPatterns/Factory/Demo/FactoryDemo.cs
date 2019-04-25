using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ReflectionLibrary.DesignPatterns.Factory.Demo
{
    using ReflectionLibrary.Infrastructure;

    class FactoryDemo : IDemo, IDemoDescription
    {
        public string Title { get; set; } = "Factory";

        public void Run()
        {
            var point = PointFactory.NewPolarPoint(1.0, Math.PI / 2);
            WriteLine(point);
        }

        public string Description { get; set; } = "A component responsible solely for the wholesale (not piecewise) creation of objects";
    }
}