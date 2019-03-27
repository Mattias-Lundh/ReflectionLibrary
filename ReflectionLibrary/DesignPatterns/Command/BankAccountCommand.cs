using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Command
{
    public class BankAccountCommand : ICommand
    {
        private BankAccount account;

        public enum Action
        {
            Deposit, Withdraw
        }

        private Action action;
        private int amount;
        public void Call()
        {
            switch (this.action)
            {
                case Action.Deposit:
                    this.account.Deposit(this.amount);
                    break;
                case Action.Withdraw:
                    this.account.Withdraw(this.amount);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public BankAccountCommand(BankAccount account, Action action, int amount)
        {
            this.account = account;
            this.action = action;
            this.amount = amount;
        }
    }
}
