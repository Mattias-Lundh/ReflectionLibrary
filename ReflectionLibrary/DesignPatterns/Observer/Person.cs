using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Observer
{
    public class Person
    {
        public event EventHandler<FallsIllEventArgs> FallsIll;
        public void CatchACold()
        {
            FallsIll?.Invoke(this, new FallsIllEventArgs("12 Skånegatan"));
        }
    }
}
