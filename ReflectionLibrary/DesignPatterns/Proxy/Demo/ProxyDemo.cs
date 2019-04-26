using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Proxy.Demo
{
    using ReflectionLibrary.Infrastructure;

    public class ProxyDemo : IDemo, IDemoDescription
    {
        public string Title { get; set; } = "Proxy";
        public void Run()
        {
            var creature = new Creature();
            creature.Agility = 10;
            creature.Agility = 10;
        }

        public string Description { get; set; } = $"A class that functions as an interface to a particular resource. That resource may be remote, expensive to construct, or may require logging or some other added functionality";
    }
}
