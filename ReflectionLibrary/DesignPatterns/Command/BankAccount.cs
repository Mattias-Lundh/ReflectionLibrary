using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Command
{
    public class BankAccount
    {
        private int balance;
        private int overdraftLimit = -500;

        public void Deposit(int amount)
        {
            this.balance += amount;
            Console.WriteLine($"deposited {amount} balance is now {this.balance}");
        }

        public void Withdraw(int amount)
        {
            if (this.balance - amount >= this.overdraftLimit)
            {
                this.balance -= amount;
                Console.WriteLine($"Withdrew ${amount} balance is now {this.balance}");
            }
        }

        public override string ToString()
        {
            return $"{nameof(this.balance)}: {this.balance}";
        }
    }
}
