using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Bridge
{
    public class Circle : Shape
    {
        public Circle(IRenderer renderer, float radius) : base(renderer)
        {
            this.radius = radius;
        }

        private float radius;

        public override void Draw()
        {
            this.renderer.RenderCircle(this.radius);
        }

        public override void Resize(float factor)
        {
            this.radius *= factor;
        }
    }
}
