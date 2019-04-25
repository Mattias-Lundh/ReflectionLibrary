using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ReflectionLibrary.DesignPatterns.Composite.Demo
{
    using ReflectionLibrary.Infrastructure;

    public class CompositeDemo : IDemo, IDemoDescription
    {
        public CompositeDemo()
        {
            this.Title = "Composite";
        }
        public string Title { get; set; }
        public void Run()
        {
            var drawing = new GraphicObject{Name = "My Drawing"};
            drawing.Children.Add(new Square() { Color = "Red" });
            drawing.Children.Add(new Circle() { Color = "Yellow" });

            var group = new GraphicObject();
            group.Children.Add(new Circle { Color = "Blue"});
            group.Children.Add(new Square { Color = "Blue"});

            drawing.Children.Add(group);

            WriteLine(drawing);
        }

        public string Description { get; set; } = "A mechanism for treating individual (scalar) objects and compositions of objects in a uniform manner";
    }
}
