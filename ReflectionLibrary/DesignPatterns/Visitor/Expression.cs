using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Visitor
{
    public abstract class Expression
    {
        public abstract void Print(StringBuilder sb);
    }
}
