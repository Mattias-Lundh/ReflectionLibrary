using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Interpreter.Parsing
{
    public class Integer : IElement
    {
        public Integer(int value)
        {
            this.Value = value;
        }
        public int Value { get; }
    }
}
