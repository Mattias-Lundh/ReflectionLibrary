namespace Coding.Exercise
{
    using System.Collections.Generic;
    using System.Text;

    public class ExpressionProcessor
    {
        public Dictionary<char, int> Variables = new Dictionary<char, int>();

        public int Calculate(string expression)
        {
            // todo
            var lexedExpression = new List<Token>();
            for (int i = 0; i < expression.Length; i++)
            {
                switch (expression[i])
                {
                    case '+':
                        lexedExpression.Add(new Token(Token.Type.Plus, "+"));
                        break;
                    case '-':
                        lexedExpression.Add(new Token(Token.Type.Minus, "-"));
                        break;
                    default:
                        var sb = new StringBuilder(expression[i].ToString());
                        // is it an integer type?
                        if (char.IsDigit(expression[i]))
                        {
                            for (int j = i + 1; j < expression.Length; ++j)
                            {
                                if (char.IsDigit(expression[j]))
                                {
                                    sb.Append(expression[j]);
                                    ++i;
                                }
                                else
                                {
                                    lexedExpression.Add(new Token(Token.Type.Integer, sb.ToString()));
                                    break;
                                }
                            }
                        }
                        else
                        {
                            // if its not an integer then its a variable type
                            if (!char.IsDigit(expression[i + 1]) && expression[i + 1] != '+' && expression[i + 1] != '-')
                            {
                                // double alpha is invalid syntax, cancel operation and return 0;
                                return 0;
                            }
                            else
                            {
                                lexedExpression.Add(new Token(Token.Type.Variable, sb.ToString()));
                                break;
                            }
                        }

                        break;
                }
            }

            return 0;
        }
    }


    public class Token
    {
        public Token(Type myType, string text)
        {
            this.TType = myType;
            this.Text = text;
        }

        public enum Type
        {
            Integer,
            Variable,
            Plus,
            Minus
        }

        public Type TType;
        public string Text;
    }
}