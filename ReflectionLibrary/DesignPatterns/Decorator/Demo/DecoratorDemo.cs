using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

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
            FreshSalad salad = new FreshSalad("ruccola", "parmesan", "vinaigrette");
            Pasta carbonara = new Pasta("penne", "cream");

            WriteLine($"preparing food");

            Avaliable saladAvaliable = new Avaliable(salad, 3);
            Avaliable carbonaraAvaliable = new Avaliable(carbonara, 4);

            saladAvaliable.Orderitem("John");
            saladAvaliable.Orderitem("Sally");
            saladAvaliable.Orderitem("Luke");

            carbonaraAvaliable.Orderitem($"Sam");
            carbonaraAvaliable.Orderitem($"Greggory");
            carbonaraAvaliable.Orderitem($"Laura");
            carbonaraAvaliable.Orderitem($"Min");
            carbonaraAvaliable.Orderitem($"Rand");

            saladAvaliable.Display();
            carbonaraAvaliable.Display();
        }
    }
}
