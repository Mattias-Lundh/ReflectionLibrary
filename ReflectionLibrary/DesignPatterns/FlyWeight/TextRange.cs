namespace ReflectionLibrary.DesignPatterns.FlyWeight
{
    using Autofac;

    public class TextRange
    {
        public int Start, End;
        public bool Capitalize, Bold, Italic;

        public bool Covers(int position)
        {
            return position >= this.Start && position <= this.End;
        }
    }
}