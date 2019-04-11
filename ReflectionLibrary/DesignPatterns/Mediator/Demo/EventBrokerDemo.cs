using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Mediator.Demo
{
    using Autofac;

    using ReflectionLibrary.DesignPatterns.Mediator.EventBroker;
    using ReflectionLibrary.Infrastructure;

    public class EventBrokerDemo : IDemo
    {
        public EventBrokerDemo()
        {
            this.Title = "EventBroker";
        }
        public string Title { get; set; }
        public void Run()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<EventBroker>().SingleInstance();
            containerBuilder.RegisterType<FootballCoach>();
            containerBuilder.Register(
                (c, p) => new FootballPlayer(
                    c.Resolve<EventBroker>(),
                    p.Named<string>("name")));

            using (var c = containerBuilder.Build())
            {
                var coach = c.Resolve<FootballCoach>();
                var player1 = c.Resolve<FootballPlayer>(new NamedParameter("name", "John"));
                var player2 = c.Resolve<FootballPlayer>(new NamedParameter("name", "Chris"));

                player1.Score();
                player1.Score();
                player1.Score();

                player1.AssultReferee();
                player2.Score();
                
            }
        }
    }
}
