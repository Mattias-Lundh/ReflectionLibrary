using System;
using System.Collections.Generic;
using System.Text;



namespace ReflectionLibrary.DesignPatterns.Decorator
{
    public abstract class DishDecorator : RestaurantDish
    {
        public DishDecorator(RestaurantDish dish)
        {
            this.dish = dish;
        }

        private RestaurantDish dish;

        public override void Display()
        {
            dish.Display();
        }
    }
}
