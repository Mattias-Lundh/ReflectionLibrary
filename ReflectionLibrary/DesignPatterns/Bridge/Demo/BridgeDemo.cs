using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace ReflectionLibrary.DesignPatterns.Bridge.Demo
{
    using ReflectionLibrary.Infrastructure;

    public class BridgeDemo : IDemo
    {
        public BridgeDemo()
        {
            this.Title = "Bridge";
        }
        public string Title { get; set; }
        public void Run()
        {
            var cb = new ContainerBuilder();
            cb.RegisterType<VectorRenderer>().As<IRenderer>();
            cb.Register((c, p) => new Circle(c.Resolve<IRenderer>(), p.Positional<float>(0)));

            using (var c = cb.Build())
            {
                var circle = c.Resolve<Circle>(
                    new PositionalParameter(0, 4.0f)
                );

                circle.Draw();
                circle.Resize(0.5f);
                circle.Draw();
            }


        }
    }
}
