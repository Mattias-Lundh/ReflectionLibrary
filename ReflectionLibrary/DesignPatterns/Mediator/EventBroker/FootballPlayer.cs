using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Mediator.EventBroker
{
    using System.Reactive.Linq;
    using System.Runtime.CompilerServices;

    public class FootballPlayer : Actor
    {
        public string Name { get; set; }
        public int GoalsScored { get; set; } = 0;
        public FootballPlayer(EventBroker broker, string name) : base(broker)
        {
            this.Name = name;
            broker.OfType<PlayerScoredEvent>()
                .Where(pe => pe.Name != this.Name)
                .Subscribe(
                    pe => { Console.WriteLine($"{name}: nicely done, {pe.Name}! its your {pe.GoalsScored} goal"); });

            broker.OfType<PlayerSentOffEvent>()
                .Where(pe => pe.Name != this.Name)
                .Subscribe(pe => Console.WriteLine($"{this.Name} see you in the lockers, {pe.Name}"));
        }
        public void Score()
        {
            this.GoalsScored++;
            this.broker.Publish(new PlayerScoredEvent{Name = this.Name, GoalsScored = this.GoalsScored});
        }

        public void AssultReferee()
        {
            this.broker.Publish(new PlayerSentOffEvent{Name = this.Name, Reason = "violence"});
        }
    }
}
