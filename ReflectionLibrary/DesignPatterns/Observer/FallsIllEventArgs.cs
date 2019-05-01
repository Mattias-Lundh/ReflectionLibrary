using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Observer
{
    public class FallsIllEventArgs : EventArgs
    {
        public FallsIllEventArgs(string address)
        {
            this.Address = address;
        }
        public string Address;
    }
}
