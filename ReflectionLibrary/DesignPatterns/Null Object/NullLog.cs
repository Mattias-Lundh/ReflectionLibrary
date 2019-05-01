using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ReflectionLibrary.DesignPatterns.Null_Object
{
    public class NullLog : ILog
    {
        public void Info(string msg)
        {
            // comprehending exsistence
            WriteLine($"doing nothing, in fact this code [line 13 in NullLog] should be deleted, but then the demo would look empty");
        }

        public void Warn(string msg)
        {
            // doing nully things
        }
    }
}
