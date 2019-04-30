using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Iterator
{
    public class Node<T>
    {
        public Node(T value)
        {
            Value = value;
        }

        public Node(T value, Node<T> left, Node<T> right)
        {
            Value = value;
            Left = left;
            Right = right;
        }

        public T Value { get; set; }
        public Node<T> Left, Right;
        public Node<T> Parent;
    }
}
