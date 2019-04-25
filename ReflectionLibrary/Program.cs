﻿using System;

namespace ReflectionLibrary
{
    using System.Collections.Generic;
    using ReflectionLibrary.DesignPatterns.Adapter.Demo;
    using ReflectionLibrary.DesignPatterns.Bridge.Demo;
    using ReflectionLibrary.DesignPatterns.Command.Demo;
    using ReflectionLibrary.DesignPatterns.Composite.Demo;
    using ReflectionLibrary.DesignPatterns.Decorator.Demo;
    using ReflectionLibrary.DesignPatterns.Factory.Demo;
    using ReflectionLibrary.DesignPatterns.Mediator.Demo;
    using ReflectionLibrary.DesignPatterns.Singleton.Demo;
    using ReflectionLibrary.Infrastructure;

    class Program
    {
        static void Main(string[] args)
        {
            var demos = new List<IDemo>();
            demos.AddRange(new List<IDemo>
            {
                new SingletonDemo(),
                new AdapterDemo(),
                new CommandDemo(),
                new MediatorDemo(),
                new EventBrokerDemo(),
                new BridgeDemo(),
                new CompositeDemo(),
                new DecoratorDemo(),
                new FactoryMethodDemo(),
                new FactoryDemo(),
                new AbstractFactoryDemo()
            });

            var executor = new CodeExecutor(demos);
            executor.Execute();
        }
    }
}
