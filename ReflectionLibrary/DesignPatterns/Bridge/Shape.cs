using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Bridge
{
    public abstract class Shape
    {
        public Shape(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        protected IRenderer renderer;

        public abstract void Draw();
        public abstract void Resize(float factor);
    }
}
