using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Mediator.Demo
{
    using ReflectionLibrary.Infrastructure;

    public class MediatorDemo : IDemo
    {
        public MediatorDemo()
        {
            this.Title = "Mediator";
        }
        public string Title { get; set; }

        public void Run()
        {
            Console.WriteLine($"***     MEDIATOR DEMO       ***");
            var room = new ChatRoom();

            var john = new Person("John");
            var jane =  new Person("Jane");

            room.Join(john);
            room.Join(jane);

            john.Say("hello");
            jane.Say("oh! hello John");

            var simon = new Person("Simon");
            room.Join(simon);

            jane.PrivateMessage("Simon", "glad you could join us simon");

        }
    }
}
