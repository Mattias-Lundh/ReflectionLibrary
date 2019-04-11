using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Mediator.EventBroker
{
    public class Actor
    {
        public Actor(EventBroker broker)
        {
            this.broker = broker;
        }
        public string Name { get; set; }
        protected EventBroker broker { get; set; }
    }
}
