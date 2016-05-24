using System;

namespace StringInterpolation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car()
            {
                Mark = "BMW",
                Model = "X6",
            };

            // C# 5.0
            string oldStr = string.Format("I drive {0} {1}", car.Mark, car.Model);

            // C# 6.0
            string newStr = $"I drive {car.Mark} {car.Model}";

            Console.WriteLine(oldStr);
            Console.WriteLine("------------------");
            Console.WriteLine(newStr);
        }
    }
}
