using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ReflectionLibrary.DesignPatterns.ChainOfResponsibility
{
    public class CreatureModifier
    {
        public CreatureModifier(Creature creature)
        {
            this.creature = creature;
        }

        protected Creature creature;
        protected CreatureModifier next;

        public void Add(CreatureModifier cm)
        {
            if (next != null) next.Add(cm);
            else next = cm;
        }

        public virtual void Handle() => next?.Handle();
    }
}
