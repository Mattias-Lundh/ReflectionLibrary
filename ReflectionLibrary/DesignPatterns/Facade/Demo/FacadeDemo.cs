namespace ReflectionLibrary.DesignPatterns.Facade.Demo
{
    using ReflectionLibrary.Infrastructure;

    public class FacadeDemo : IDemo, IDemoDescription
    {
        public string Title { get; set; } = "Facade";
        public void Run()
        {
            var shapeFacade = new ShapeFacade();
            shapeFacade.DrawShapes();
        }

        public string Description { get; set; } = "Provides a simple, easy to understand/user interface over a large and sophisticated body of code";
    }
}