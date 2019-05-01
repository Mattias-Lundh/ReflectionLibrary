using ReflectionLibrary.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ReflectionLibrary.DesignPatterns.Memento.Demo
{
    public class MementoDemo : IDemo, IDemoDescription
    {
        public string Description { get; set; } = "A token/handle representing the system state. Lets us roll back to the state when the toke was generated. May or may not directly expose state information";
        public string Title { get; set; } = "Memento";

        public void Run()
        {
            var account = new BankAccount(100);

            var token = account.Deposit(10);
            WriteLine($"{account} -after first deposit [token collected]");

            account.Deposit(50);
            account.Deposit(50);
            WriteLine($"{account} -after more deposits");

            account.Restore(token);
            WriteLine($"{account} -after restore");



        }
    }
}
