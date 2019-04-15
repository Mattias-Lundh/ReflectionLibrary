using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using MoreLinq;
using System.Linq;
using System.Reflection;

namespace ReflectionLibrary.DesignPatterns.Singleton
{
    public class SingletonDatabase : IDatabase
    {
        private Dictionary<string, double> capitals;
        private SingletonDatabase() // private constructor
        {
            // MOTIVATION : this 'database' (capitals.txt) should only need to be read once beacuse reasons, good reasons!
            Console.WriteLine("Initializing database");
            capitals = File.ReadAllLines(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "DesignPatterns\\Singleton\\capitals.txt"))
                .Batch(2)
                .ToDictionary
                (
                list => list.ElementAt(0).Trim(), 
                List => double.Parse(List.ElementAt(1))
                );
        }

        public double GetPopulation(string name)
        {
            return capitals[name];
        }

        private static Lazy<SingletonDatabase> instance = 
            new Lazy<SingletonDatabase>(() => new SingletonDatabase());
        
        public static SingletonDatabase Instance => instance.Value; 
    }
}
