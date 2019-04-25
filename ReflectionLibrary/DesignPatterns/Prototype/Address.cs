namespace ReflectionLibrary.DesignPatterns.Prototype
{
    using System;

    public class Address
    {
        public Address()
        {
            
        }
        public Address(int streetNumber, string streetName)
        {
            this.StreetNumber = streetNumber;
            this.StreetName = streetName;
        }

        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
    }
}