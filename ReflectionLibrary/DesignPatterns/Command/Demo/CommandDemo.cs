using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Command.Demo
{
    using ReflectionLibrary.Infrastructure;

    public class CommandDemo : IDemo
    {
        public void Run()
        {
            var ba = new BankAccount();
            var commands = new List<BankAccountCommand>
            {
                new BankAccountCommand(ba, BankAccountCommand.Action.Deposit, 100),
                new BankAccountCommand(ba, BankAccountCommand.Action.Withdraw, 50)
            };
            Console.WriteLine(ba);
            foreach (var c in commands)
            {
                c.Call();
            }

            Console.WriteLine(ba);
            
        }
    }
}
