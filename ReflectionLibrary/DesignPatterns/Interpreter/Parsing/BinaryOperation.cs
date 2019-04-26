using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Interpreter.Parsing
{
    public class BinaryOperation : IElement
    {
        public enum Type
        {
            Addition,
            Subtraction
        }

        public Type MyType;
        public IElement Left, Right;

        public int Value
        {
            get
            {
                switch (this.MyType)
                {
                    case Type.Addition:
                        return this.Left.Value + this.Right.Value;
                    case Type.Subtraction:
                        return this.Left.Value - this.Right.Value;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}