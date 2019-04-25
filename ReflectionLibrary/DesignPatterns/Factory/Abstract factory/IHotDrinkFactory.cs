namespace ReflectionLibrary.DesignPatterns.Factory.Abstract_factory
{
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}