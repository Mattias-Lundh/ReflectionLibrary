using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ReflectionLibrary.DesignPatterns.ChainOfResponsibility
{
    public class IncreaseDefenceModifier : CreatureModifier
    {
        public IncreaseDefenceModifier(Creature creature) : base(creature)
        {
        }

        public override void Handle()
        {
            WriteLine($"Increasing {creature.Name}'s Defence");
            creature.Defence += 3;
            base.Handle();
        }
    }
}
