using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Mediator
{
    using System.Linq;

    public class ChatRoom
    {
        private List<Person> people = new List<Person>();

        public void Join(Person person)
        {
            this.people.Add(person);
            person.Room = this;
            string joinMsg = $"{person.Name} has joined the room";
            this.BroadcastMessage("room", joinMsg);
        }
        public void BroadcastMessage(string source, string message)
        {
            foreach(var person in this.people)
                if(person.Name != source)
                    person.Receive(source, message);
        }

        public void Message(string source, string destination, string message)
        {
            this.people.FirstOrDefault(p => p.Name == destination)
                ?.Receive(source, message);
        }
    }
}
