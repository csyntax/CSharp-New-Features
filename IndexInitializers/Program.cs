using System;
using System.Collections.Generic;

namespace IndexInitializers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // C# 5.0
            Dictionary<int, string> numbersOldWay = new Dictionary<int, string>()
            {
               { 7, "Seven" },
               { 9, "Nine" },
               { 13, "Thirteen" },
            };

            // C# 6.0
            Dictionary<int, string> numbers = new Dictionary<int, string>()
            {
                [7] = "Seven",
                [9] = "Nine",
                [13] = "Thirteen",
            };

            foreach(var number in numbersOldWay)
            {
                Console.WriteLine("{0} => {1}", number.Key, number.Value);
            }

            Console.WriteLine("---------------------------");

            foreach (var number in numbers)
            {
                Console.WriteLine("{0} => {1}", number.Key, number.Value);
            }

            Console.WriteLine("---------------------------");

            Dictionary<string, string> technologies = new Dictionary<string, string>()
            {
                ["C#"] = "The programming language",
                [".NET"] = "The development platform",
            };

            foreach(var technology in technologies)
            {
                Console.WriteLine("{0} => {1}", technology.Key, technology.Value);
            }
        }
    }
}
