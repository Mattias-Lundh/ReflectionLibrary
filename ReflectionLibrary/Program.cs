﻿using System;
using System.Collections.Generic;
using ReflectionLibrary.DesignPatterns.Adapter.Demo;
using ReflectionLibrary.DesignPatterns.Bridge.Demo;
using ReflectionLibrary.DesignPatterns.Builder.Demo;
using ReflectionLibrary.DesignPatterns.ChainOfResponsibility.Demo;
using ReflectionLibrary.DesignPatterns.Command.Demo;
using ReflectionLibrary.DesignPatterns.Composite.Demo;
using ReflectionLibrary.DesignPatterns.Decorator.Demo;
using ReflectionLibrary.DesignPatterns.Facade.Demo;
using ReflectionLibrary.DesignPatterns.Factory.Demo;
using ReflectionLibrary.DesignPatterns.FlyWeight.Demo;
using ReflectionLibrary.DesignPatterns.Interpreter.Demo;
using ReflectionLibrary.DesignPatterns.Iterator.Demo;
using ReflectionLibrary.DesignPatterns.Mediator.Demo;
using ReflectionLibrary.DesignPatterns.Memento.Demo;
using ReflectionLibrary.DesignPatterns.Null_Object.Demo;
using ReflectionLibrary.DesignPatterns.Observer.Demo;
using ReflectionLibrary.DesignPatterns.Prototype.Demo;
using ReflectionLibrary.DesignPatterns.Proxy.Demo;
using ReflectionLibrary.DesignPatterns.Singleton.Demo;
using ReflectionLibrary.DesignPatterns.State.Demo;
using ReflectionLibrary.DesignPatterns.Strategy.Demo;
using ReflectionLibrary.DesignPatterns.Template_Method.Demo;
using ReflectionLibrary.DesignPatterns.Visitor.Demo;
using ReflectionLibrary.Infrastructure;

namespace ReflectionLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var demos = new List<IDemo>();
            demos.AddRange(new List<IDemo>
            {
                new SingletonDemo(),
                new AdapterDemo(),
                new CommandDemo(),
                new MediatorDemo(),
                new EventBrokerDemo(),
                new BridgeDemo(),
                new CompositeDemo(),
                new DecoratorDemo(),
                new FactoryMethodDemo(),
                new FactoryDemo(),
                new AbstractFactoryDemo(),
                new PrototypeDemo(),
                new BuilderDemo(),
                new FacadeDemo(),
                new InterpreterDemo(),
                new FlyweightDemo(),
                new ProxyDemo(),
                new ChainOfResponsibilityDemo(),
                new IteratorDemo(),
                new MementoDemo(),
                new NullObjectDemo(),
                new ObserverDemo(),
                new StrategyDemo(),
                new TemplateMethodDemo(),
                new VsitorDemo(),
                new StateDemo() // This is an infinit loop, place it last

            });

            var executor = new CodeExecutor(demos);
            executor.Execute();
        }
    }
}
