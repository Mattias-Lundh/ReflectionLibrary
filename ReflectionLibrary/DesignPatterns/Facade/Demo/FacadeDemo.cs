namespace ReflectionLibrary.DesignPatterns.Facade.Demo
{
    using ReflectionLibrary.Infrastructure;

    public class FacadeDemo : IDemo, IDemoDescription
    {
        public string Title { get; set; } = "Facade";
        public void Run()
        {
            throw new System.NotImplementedException();
        }

        public string Description { get; set; } = "Provides a simple, easy to understand/user interface over a large and sophisticated body of code";
    }
}