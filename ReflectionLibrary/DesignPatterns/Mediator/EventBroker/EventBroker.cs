using System;
using System.Collections.Generic;
using System.Text;
namespace ReflectionLibrary.DesignPatterns.Mediator.EventBroker
{
    using System.Reactive.Subjects;

    public class EventBroker : IObservable<PlayerEvent>
    {
        private Subject<PlayerEvent> subscriptions { get; set; } = new Subject<PlayerEvent>();

        public IDisposable Subscribe(IObserver<PlayerEvent> observer)
        {
            return subscriptions.Subscribe(observer);
        }

        public void Publish(PlayerEvent playerEvent)
        {
            subscriptions.OnNext(playerEvent);
        }
    }
}
