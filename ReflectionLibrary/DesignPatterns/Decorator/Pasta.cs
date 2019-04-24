using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace ReflectionLibrary.DesignPatterns.Decorator
{
    public class Pasta : RestaurantDish
    {
        public Pasta(string pastatype, string sauce)
        {
            this.pastatype = pastatype;
            this.sauce = sauce;
        }

        public string pastatype;
        public string sauce;
        public override void Display()
        {
            WriteLine($"Pasta");
            WriteLine($" PastaType : {this.pastatype}");
            WriteLine($" Sauce : {this.sauce}");
        }
    }
}
