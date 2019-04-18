using System;

namespace ReflectionLibrary
{
    using System.Collections.Generic;
    using System.Linq;
    using ReflectionLibrary.DesignPatterns.Adapter.Demo;
    using ReflectionLibrary.DesignPatterns.Command.Demo;
    using ReflectionLibrary.DesignPatterns.Interpreter.Demo;
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
                new EventBrokerDemo()
            });

            var executor = new CodeExecutor(demos);
            executor.Execute();
        }
    }
}
