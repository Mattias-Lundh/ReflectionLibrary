using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ReflectionLibrary.DesignPatterns.ChainOfResponsibility
{
    public class Creature
    {
        public Creature(string name, int attack, int defence)
        {
            this.Name = name;
            this.Attack = attack;
            this.Defence = defence;
        }

        public string Name;
        public int Attack, Defence;

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Attack)}: {Attack}, {nameof(Defence)}: {Defence}";
        }
    }
}
