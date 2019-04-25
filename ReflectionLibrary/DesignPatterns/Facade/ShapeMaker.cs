using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Facade
{
    public class ShapeMaker
    {
        public ShapeMaker()
        {
            this.rectangle = new Rectangle();
            this.square = new Square();
            this.circle = new Circle();
        }

        public void DrawCircle()
        {
            circle.Draw();
        }

        public void DrawRectangle()
        {
            rectangle.Draw();
        }

        public void DrawSquare()
        {
            square.Draw();
        }

        private IShape rectangle;
        private IShape square;
        private IShape circle;
    }
}
