using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Decorator.Demo
{
    using ReflectionLibrary.Infrastructure;

    public class DecoratorDemo : IDemo
    {
        public DecoratorDemo()
        {
            this.Title = "Decorator";
        }
        public string Title { get; set; }
        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
