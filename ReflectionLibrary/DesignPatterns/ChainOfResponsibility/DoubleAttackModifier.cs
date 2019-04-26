using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ReflectionLibrary.DesignPatterns.ChainOfResponsibility
{
    public class DoubleAttackModifier : CreatureModifier
    {
        public DoubleAttackModifier(Creature creature) : base(creature)
        {

        }

        public override void Handle()
        {
            WriteLine($"Doubling {creature.Name}'s Attack");
            creature.Attack *= 2;
            base.Handle();
        }
    }
}
