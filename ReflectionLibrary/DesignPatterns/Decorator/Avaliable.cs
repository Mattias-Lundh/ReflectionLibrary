using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ReflectionLibrary.DesignPatterns.Decorator
{
    public class Avaliable : DishDecorator
    {
        public Avaliable(RestaurantDish dish, int numAvaliable) : base(dish)
        {
            this.NumAvaliable = numAvaliable;
        }

        public int NumAvaliable { get; set; }
        protected List<string> customers = new List<string>();

        public void Orderitem(string name)
        {
            if(NumAvaliable > 0)
            {
                customers.Add(name);
                NumAvaliable--;
            }
            else
            {
                WriteLine($"not enough ingredients for {name}'s order!");
            }
        }

        public override void Display()
        {
            base.Display();

            foreach(var customer in customers)
            {
                WriteLine($"Ordered by {customer}");
            }
        }
    }
}
