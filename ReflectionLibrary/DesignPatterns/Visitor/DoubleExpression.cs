using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Visitor
{
    public class DoubleExpression : Expression
    {
        public DoubleExpression(double value)
        {
            this.value = value;
        }
        private double value;

        public override void Print(StringBuilder sb)
        {
            sb.Append(value);
        }
    }
}
