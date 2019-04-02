using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Interpreter.Lexing
{
    public class Token
    {
        public enum Type
        {
            Integer, Plus, Minus, Lparen, Rparen
        }

        public Type MyType;
        public string Text;

        public Token(Type myType, string text)
        {
            this.MyType = myType;
            this.Text = text;
        }

        public override string ToString()
        {
            return $"`{this.Text}`";
        }
    }
}
