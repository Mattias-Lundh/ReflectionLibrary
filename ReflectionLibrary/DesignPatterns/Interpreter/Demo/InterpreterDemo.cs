namespace ReflectionLibrary.DesignPatterns.Interpreter.Demo
{
    using System;

    using ReflectionLibrary.DesignPatterns.Interpreter.Lexing;
    using ReflectionLibrary.DesignPatterns.Interpreter.Parsing;
    using ReflectionLibrary.Infrastructure;

    public class InterpreterDemo : IDemo
    {
        public InterpreterDemo()
        {
            this.Title = "Interpreter";
        }

        public string Title { get; set; }

        public void Run()
        {
            Console.WriteLine($"***     INTERPERETER DEMO       ***");
            string input = "(13+4)-( 12+1)";
            var tokens = Lexer.Lex(input);
            Console.WriteLine(string.Join("\t", tokens));
            var parsed = Parser.Parse(tokens);
            Console.WriteLine($"{input} = {parsed.Value}");
        }
    }
}