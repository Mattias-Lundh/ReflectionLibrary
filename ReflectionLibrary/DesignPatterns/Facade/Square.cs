using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ReflectionLibrary.DesignPatterns.Facade
{
    public class Square : IShape
    {
        public void Draw()
        {
            WriteLine("Drawing a Square");
        }
    }
}
