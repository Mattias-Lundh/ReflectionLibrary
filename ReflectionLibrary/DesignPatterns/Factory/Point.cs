using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Factory
{
    public class Point
    {
        public static Point NewPolarPoint(double roh, double theta)
        {
            return new Point(roh * Math.Cos(theta), roh * Math.Sin(theta));
        }
        public static Point NewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }
        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        private double x, y;

        public override string ToString()
        {
            return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
        }
    }
}
