using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Composite
{
    public class GraphicObject
    {
        public virtual string Name { get; set; } = "Group";
        public string Color;
        private Lazy<List<GraphicObject>> children = new Lazy<List<GraphicObject>>();
        public List<GraphicObject> Children => this.children.Value;

        private void Print(StringBuilder sb, int depth)
        {
            sb.Append(new string('*', depth))
                .Append(string.IsNullOrWhiteSpace(this.Color) ? string.Empty : $"{this.Color}")
                .AppendLine(this.Name);

            foreach (var child in this.Children)
            {
                child.Print(sb, depth+1);
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            this.Print(sb, 0);
            return sb.ToString();
        }
    }
}
