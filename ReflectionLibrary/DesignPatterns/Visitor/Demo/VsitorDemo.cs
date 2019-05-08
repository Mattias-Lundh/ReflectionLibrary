using ReflectionLibrary.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Visitor.Demo
{
    public class VsitorDemo : IDemo, IDemoDescription
    {
        public string Description { get; set; } = "A pattern where a component (visitor) is allowed to traverse the entire inheritance hierarchy. Implemented by propagating a single visit() method throughout the entire hierarchy.";
        public string Title { get; set; } = "Visitor";

        public void Run()
        {
            var e = new AdditionExpression(
                new DoubleExpression(1),
                new AdditionExpression(
                    new DoubleExpression(2),
                    new DoubleExpression(3)));
            var sb = new StringBuilder();
            e.Print(sb);
            Console.WriteLine(sb);
        }
    }
}
