using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Singleton.Demo
{
    using ReflectionLibrary.Infrastructure;
    public class SingletonDemo : IDemo
    {
        public string Title { get; set; } = "Singleton";

        public void Run()
        {
            var database = SingletonDatabase.Instance;
            Console.WriteLine(database.GetPopulation("Seoul"));
        }
    }
}
