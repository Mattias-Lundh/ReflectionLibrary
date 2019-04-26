using ReflectionLibrary.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ReflectionLibrary.DesignPatterns.ChainOfResponsibility.Demo
{
    class ChainOfResponsibilityDemo : IDemo, IDemoDescription
    {
        public string Description { get; set; } = "A chain of components who all get a chance to process a command or a query, optionally having default preocessing implementation and an ability to terminate the process chain";
        public string Title { get; set; } = "Chain of responsibility";

        public void Run()
        {
            var goblin = new Creature("goblin", 2, 2);
            WriteLine(goblin);

            var root = new CreatureModifier(goblin);
            //breaks chain of responcibility
            //root.Add(new NoBonusesModifier(goblin));
            root.Add(new DoubleAttackModifier(goblin));
            root.Add(new IncreaseDefenceModifier(goblin));
            root.Handle();

            WriteLine(goblin);
        }
    }
}
