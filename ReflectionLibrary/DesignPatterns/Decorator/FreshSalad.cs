using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace ReflectionLibrary.DesignPatterns.Decorator
{
    public class FreshSalad : RestaurantDish
    {
        public FreshSalad(string greens, string cheese, string dressing)
        {
            this.greens = greens;
            this.cheese = cheese;
            this.dressing = dressing;
        }
        private string greens;
        private string cheese;
        private string dressing;

        public override void Display()
        {
            WriteLine("FreshSalad");
            WriteLine($" Greens : {this.greens}");
            WriteLine($" Cheese : {this.cheese}");
            WriteLine($" Dressing : {this.dressing}");
        }
    }
}
