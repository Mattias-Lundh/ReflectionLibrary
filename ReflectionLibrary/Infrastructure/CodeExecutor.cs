using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.Infrastructure
{
    public class CodeExecutor
    {
        private IEnumerable<IDemo> demos;

        public CodeExecutor(IEnumerable<IDemo> demos)
        {
            this.demos = demos;
        }

        public void Execute()
        {
            foreach (var demo in this.demos)
            {
                Console.WriteLine(demo.Title);
                demo.Run();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
