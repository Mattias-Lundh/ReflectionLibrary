using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;


namespace ReflectionLibrary.DesignPatterns.Null_Object
{
    public class BankAccount
    {
        public BankAccount(ILog log)
        {
            this.log = log;
        }
        private ILog log;
        private int balance;

        public void Deposit(int amount)
        {
            this.balance += amount;
            log.Info($"deposited {amount}, balance is now {balance}");
        }
    }
}
