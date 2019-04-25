using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Facade
{
    public class ShapeFacade
    {
        public ShapeFacade()
        {
            this.shapemaker = new ShapeMaker();
                
        }

        private ShapeMaker shapemaker;

        public void DrawShapes()
        {
            shapemaker.DrawCircle();
            shapemaker.DrawRectangle();
            shapemaker.DrawSquare();
        }
    }
}
