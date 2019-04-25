namespace ReflectionLibrary.DesignPatterns.Builder
{
    public class HtmlBuilder
    {
        public HtmlBuilder(string rootName)
        {
            this.rootName = rootName;
            this.root.Name = rootName;
        }

        private readonly string rootName;
        HtmlElement root = new HtmlElement();

        public void AddChild(string childName, string childText)
        {
            var element = new HtmlElement(childName, childText);
            this.root.Elements.Add(element);
        }

        public override string ToString()
        {
            return this.root.ToString();
        }

        public void Clear()
        {
            this.root = new HtmlElement{Name = this.rootName};
        }
    }
}