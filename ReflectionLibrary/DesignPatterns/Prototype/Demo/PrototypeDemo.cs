using static System.Console;

namespace ReflectionLibrary.DesignPatterns.Prototype.Demo
{
    using System.Text;

    using ReflectionLibrary.Infrastructure;

    public class PrototypeDemo : IDemo, IDemoDescription
    {
        public string Title { get; set; } = "Prototype";
        public void Run()
        {
            var john = new Persson(new Address(12, $"Skånegatan"), "John");
            var jane = john.DeepCopyXml();

            jane.Name = "Jane";
            jane.Address.StreetNumber= 55;

            WriteLine(john);
            WriteLine(jane);
        }

        public string Description { get; set; } = $"A partially or fully initialized object that you copy (clone) and make use of";
    }
}