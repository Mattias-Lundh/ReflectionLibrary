using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Factory
{
    public static class PointFactory
    {
        public static Point NewPolarPoint(double roh, double theta)
        {
            return new Point(roh * Math.Cos(theta), roh * Math.Sin(theta));
        }
        public static Point NewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }
    }
}
