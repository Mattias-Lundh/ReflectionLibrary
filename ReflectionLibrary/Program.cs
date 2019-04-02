using System;

namespace ReflectionLibrary
{
    using System.Collections.Generic;
    using System.Linq;

    using ReflectionLibrary.DesignPatterns.Command.Demo;
    using ReflectionLibrary.DesignPatterns.Interpreter.Demo;
    using ReflectionLibrary.Infrastructure;

    class Program
    {
        static void Main(string[] args)
        {
            var demos = new List<IDemo>();
            demos.AddRange(new List<IDemo>
            {
                new CommandDemo(),
                new InterpreterDemo()
            });

            var executor = new CodeExecutor(demos);
            executor.Execute();
        }
    }
}
