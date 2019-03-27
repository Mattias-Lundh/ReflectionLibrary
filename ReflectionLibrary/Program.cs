using System;

namespace ReflectionLibrary
{
    using System.Collections.Generic;
    using System.Linq;

    using ReflectionLibrary.DesignPatterns.Command.Demo;
    using ReflectionLibrary.Infrastructure;

    class Program
    {
        static void Main(string[] args)
        {
            var executor = new CodeExecutor(new List<IDemo> { new CommandDemo() });
            executor.Execute();
        }
    }
}
