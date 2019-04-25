namespace ReflectionLibrary.DesignPatterns.Factory.Demo.Abstract_factory
{
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}