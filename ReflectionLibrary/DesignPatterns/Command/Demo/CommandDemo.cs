using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Command.Demo
{
    using ReflectionLibrary.Infrastructure;

    public class CommandDemo : IDemo, IDemoDescription
    {
        public CommandDemo()
        {
            this.Title = "Command";
        }

        public string Title { get; set; }

        public void Run()
        {
            var bankAccount = new BankAccount();
            var commands = new List<BankAccountCommand>
            {
                new BankAccountCommand(bankAccount, BankAccountCommand.Action.Deposit, 100),
                new BankAccountCommand(bankAccount, BankAccountCommand.Action.Withdraw, 50)
            };
            Console.WriteLine(bankAccount);
            foreach (var c in commands)
            {
                c.Call();
            }

            Console.WriteLine(bankAccount);
        }

        public string Description { get; set; } = "An object which represents an instruction to perform a particular action. Contains all the information necessary for the action to be taken";
    }
}