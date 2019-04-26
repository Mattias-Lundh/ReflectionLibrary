using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ReflectionLibrary.DesignPatterns.FlyWeight.Demo
{
    using ReflectionLibrary.Infrastructure;

    public class FlyweightDemo : IDemo, IDemoDescription
    {
        public string Title { get; set; } = "Flyweight";
        public void Run()
        {
            var formattedText = new FormattedText($"this is a brave new world");
            formattedText.Capitalize(10, 15);
            WriteLine($"normal formatter: {formattedText}");

            var betterFormattedText = new BetterFormattedText($"this is a brave new world");
            betterFormattedText.GetRange(10, 15).Capitalize = true;
            WriteLine($"better formatter: {betterFormattedText}");
        }

        public string Description { get; set; } = "A space optimization technique that lets us use less memory by storing externally the data associated with similar objects";
    }
}
