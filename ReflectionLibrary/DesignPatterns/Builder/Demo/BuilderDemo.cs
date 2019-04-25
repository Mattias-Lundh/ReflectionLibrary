
using static System.Console;
namespace ReflectionLibrary.DesignPatterns.Builder.Demo
{
    using ReflectionLibrary.Infrastructure;

    public class BuilderDemo : IDemo, IDemoDescription
    {
        public string Title { get; set; } = "Builder";
        public void Run()
        {
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello");
            builder.AddChild("li", "world");
            WriteLine(builder.ToString());
        }

        public string Description { get; set; } = $"When piecewise object construction in complicated, provide an API for doing it succinctly.";
    }
}