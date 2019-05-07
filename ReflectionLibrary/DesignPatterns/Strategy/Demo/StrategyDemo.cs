using ReflectionLibrary.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ReflectionLibrary.DesignPatterns.Strategy.Demo
{
    public class StrategyDemo : IDemo, IDemoDescription
    {
        public string Description { get; set; } = "Enables the exact behaviour of a sytem to be selected either at run-time (dynamic) or compile-time (static) [synonym: policy]";
        public string Title { get; set; } = "Strategy";

        public void Run()
        {
            var tp = new TextProcessor();
            tp.SetOutputFormat(OutputFormat.MarkDown);
            tp.AppendList(new[] { "foo", "bar", "baz" });
            WriteLine(tp);

            tp.Clear();

            tp.SetOutputFormat(OutputFormat.Html);
            tp.AppendList(new[] { "foo", "bar", "baz" });
            WriteLine(tp);

        }
    }
}
