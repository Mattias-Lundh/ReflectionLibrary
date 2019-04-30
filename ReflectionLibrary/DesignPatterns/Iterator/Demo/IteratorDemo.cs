using ReflectionLibrary.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace ReflectionLibrary.DesignPatterns.Iterator.Demo
{
    public class IteratorDemo : IDemo, IDemoDescription
    {
        public string Description { get; set; } = "A method that facilitates the traversal of a data structure";
        public string Title { get; set; } = "Iterator";

        public void Run()
        {
            var root = new Node<int>(1, new Node<int>(2), new Node<int>(3));

            var tree = new BinaryTree<int>(root);
            WriteLine(string.Join(',', tree.InOrder.Select(x => x.Value)));
        }
    }
}
