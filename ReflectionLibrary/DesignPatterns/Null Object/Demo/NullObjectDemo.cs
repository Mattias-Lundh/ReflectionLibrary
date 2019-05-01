using ReflectionLibrary.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace ReflectionLibrary.DesignPatterns.Null_Object.Demo
{
    public class NullObjectDemo : IDemo, IDemoDescription
    {
        public string Description { get; set; } = "A no-operation object that conforms to the required interface, satsfying a dependancy requirement of some other object";
        public string Title { get; set; } = "Null object";

        public void Run()
        {
            var cb = new ContainerBuilder();
            cb.RegisterType<BankAccount>();
            cb.RegisterType<NullLog>().As<ILog>();

            using (var c = cb.Build())
            {
                var ba = c.Resolve<BankAccount>();
                ba.Deposit(100);
            }
        }
    }
}
