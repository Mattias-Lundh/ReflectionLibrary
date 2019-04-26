using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.dotMemoryUnit;
using static System.Console;

namespace ReflectionLibrary.DesignPatterns.FlyWeight
{
    using System.Linq;

    using NUnit.Framework;

    [TestFixture]
    public class Tester
    {
        [Test]
        public void TestUser()
        {
            var firstnames = Enumerable.Range(0, 100).Select(_ => this.RandomString());
            var lastnames = Enumerable.Range(0, 100).Select(_ => this.RandomString());

            var users = new List<User>();

            foreach (var firstname in firstnames)
                foreach (var lastname in lastnames)
                    users.Add(new User($"{firstname} {lastname}"));

            this.ForceGC();

            dotMemory.Check(
                memory => { WriteLine(memory.SizeInBytes); });
        }

        private void ForceGC()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private string RandomString()
        {
            Random rand = new Random();
            return new string(
                Enumerable.Range(0,10)
                    .Select(i => (char)('a' + rand.Next(26)))
                    .ToArray());

        }
    }
}
