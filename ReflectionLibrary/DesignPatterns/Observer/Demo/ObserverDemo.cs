using ReflectionLibrary.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ReflectionLibrary.DesignPatterns.Observer.Demo
{
    public class ObserverDemo : IDemo, IDemoDescription
    {
        public string Description { get; set; } = $"An observer is an object that wishes to be informed about events happening in the system. The entity generating the events is an observable";
        public string Title { get; set; } = "Observer";

        public void Run()
        {
            var person = new Person();
            person.FallsIll += CallDoctor; // this event now listens
            person.CatchACold();  // this will envoke the event
            person.FallsIll -= CallDoctor;
            person.CatchACold(); // nothing happens, no one listens anymore.
        }

        private void CallDoctor(object sender, FallsIllEventArgs e)
        {
            WriteLine($"A doctor has been called to {e.Address}");
        }
    }
}
