using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Mediator.EventBroker
{
    public class PlayerScoredEvent : PlayerEvent
    {
        public int GoalsScored { get; set; }
    }
}
