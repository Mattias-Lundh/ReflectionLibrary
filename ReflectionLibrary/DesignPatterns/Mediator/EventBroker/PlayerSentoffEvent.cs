using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Mediator.EventBroker
{
    public class PlayerSentOffEvent : PlayerEvent
    {
        public string Reason { get; set; }
    }
}
