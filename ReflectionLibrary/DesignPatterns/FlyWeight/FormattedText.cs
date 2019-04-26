using MoreLinq;
namespace ReflectionLibrary.DesignPatterns.FlyWeight
{
    using System.Linq;
    using System.Text;

    public class FormattedText
    {
        public FormattedText(string plainText)
        {
            this.plainText = plainText;
            this.capitalize = new bool[plainText.Length];
        }

        private readonly string plainText;
        private bool[] capitalize;

        public void Capitalize(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                this.capitalize[i] = true;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (var i = 0; i < this.plainText.Length; i++)
            {
                var c = this.plainText[i];
                    sb.Append(this.capitalize[i] ? char.ToUpper(c) : c);
            }

            return sb.ToString();
        }
    }
}