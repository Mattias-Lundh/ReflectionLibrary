using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Memento
{
    public class Memento
    {
        public Memento(int balance)
        {
            Balance = balance;
        }
        public int Balance { get; }
    }
}
