using ReflectionLibrary.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using ReflectionLibrary.DesignPatterns.Adapter;
using MoreLinq;

namespace ReflectionLibrary.DesignPatterns.Adapter.Demo
{
    public class AdapterDemo : IDemo, IDemoDescription
    {
        public AdapterDemo()
        {
            this.Title = "Adapter";
        }
        public string Title { get; set; }

        public void Run()
        {
            var vectorObjects = new List<VectorObject>
            {
                new VectorRectangle(1,1,10,10),
                new VectorRectangle(3,3,6,6)
            };

            foreach (var vecorObject in vectorObjects)
            {
                foreach (var line in vecorObject)
                {
                    var adapter = new LineToPointAdapter(line);
                    adapter.ForEach(DrawPoint);
                }
            }

        }

        private void DrawPoint(Point p)
        {
            Console.Write(".");
        }

        public string Description { get; set; } = "A construct which adapts an existing interface X to conform to a required interface Y";
    }
}
