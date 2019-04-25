namespace ReflectionLibrary.DesignPatterns.Builder
{
    using System.Collections.Generic;
    using System.Text;

    public class HtmlElement
    {
        public HtmlElement()
        {
            
        }

        public HtmlElement(string name, string text)
        {
            this.Name = name;
            this.Text = text;
        }

        private string ToStringImpl(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', indentSize * indent);
            sb.AppendLine($"{i}<{this.Name}>");

            if (!string.IsNullOrWhiteSpace(this.Text))
            {
                sb.Append(new string(' ', indentSize * (indent + 1)));
                sb.AppendLine(this.Text);
            }

            foreach (var element in this.Elements)
            {
                sb.Append(element.ToStringImpl(indent + 1));
            }

            sb.AppendLine($"{i}</{this.Name}>");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.ToStringImpl(0);
        }

        public string Name, Text;
        public List<HtmlElement> Elements = new List<HtmlElement>();
        private const int indentSize = 2;

    }
}