namespace ReflectionLibrary.DesignPatterns.Prototype
{
    using System;

    public class Persson
    {
        public Persson()
        {
            
        }
        public Persson(Address address, string name)
        {
            this.Address = address;
            this.Name = name;
        }
        public Address Address { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{this.Name} lives at {this.Address.StreetNumber} {this.Address.StreetName}";
        }
    }
}