using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Mediator
{
    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public ChatRoom Room { get; set; }

        private List<string> chatLog = new List<string>();

        public void Say(string message)
        {
            this.Room.BroadcastMessage(this.Name, message);
        }

        public void PrivateMessage(string who, string message)
        {
            this.Room.Message(this.Name, who, message);
        }

        public void Receive(string sender, string message)
        {
            string s = $"{sender}: '{message}'";
            this.chatLog.Add(s);
            Console.WriteLine($"[{this.Name}'s chat session] {s}");
        }
    }
}
