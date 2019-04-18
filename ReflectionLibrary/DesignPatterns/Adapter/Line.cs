using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Adapter
{
    public class Line
    {
        public Line(Point start, Point end)
        {
            Start = start;
            End = end;

        }
        public Point Start { get; set; }
        public Point End { get; set; }
    }
}
