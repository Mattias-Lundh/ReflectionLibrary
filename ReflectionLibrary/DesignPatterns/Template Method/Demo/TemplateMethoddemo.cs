using ReflectionLibrary.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Template_Method.Demo
{
    public class TemplateMethodDemo : IDemo, IDemoDescription
    {
        public string Description { get; set; } = "Allows us to define the 'skeleton' of the algorithm, with concrete implementations defined in subclasses.";
        public string Title { get; set; } = "Template Method";

        public void Run()
        {
            var chess = new Chess();
            chess.Run();
        }
    }
}
