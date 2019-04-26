namespace ReflectionLibrary.DesignPatterns.Proxy
{
    public class Creature
    {
        private Property<int> agility = new Property<int>();
        public Property<int> Agility
        {
            get => this.agility.Value;
            set => this.agility.Value = value; 
        }
    }
}