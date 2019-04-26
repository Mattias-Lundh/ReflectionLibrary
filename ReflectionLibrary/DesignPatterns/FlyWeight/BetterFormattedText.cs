namespace ReflectionLibrary.DesignPatterns.FlyWeight
{
    using System.Collections.Generic;
    using System.Data;
    using System.Text;

    public class BetterFormattedText
    {
        public BetterFormattedText(string plainText)
        {
            this.plainText = plainText;
        }

        private string plainText;
        private List<TextRange> formatting = new List<TextRange>();

        public TextRange GetRange(int start, int end)
        {
            var range = new TextRange{Start = start, End = end};
            this.formatting.Add(range);
            return range;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (var i = 0; i < this.plainText.Length; i++)
            {
                var c = this.plainText[i];
                foreach (var range in this.formatting)
                {
                    if (range.Covers(i) && range.Capitalize)
                    {
                        c = char.ToUpper(c);
                    }
                }
                sb.Append(c);
            }

            return sb.ToString();
        }
    }
}