using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Memento
{
    public class BankAccount
    {
        public BankAccount(int balance)
        {
            this.balance = balance;
        }
        private int balance;

        public Memento Deposit(int amount)
        {
            balance += amount;
            return new Memento(balance);
        }

        public void Restore(Memento token)
        {
            balance = token.Balance;
        }

        public override string ToString()
        {
            return $"{nameof(balance)}: {balance}";
        }
    }
}
