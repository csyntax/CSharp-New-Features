using System.Linq;
using static System.Console;

namespace UsingStatic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OddNumbersGenerator oddNumbersGenerator = new OddNumbersGenerator();

            oddNumbersGenerator
                .GetOddNumbersBetween(1, 10)
                .ToList()
                .ForEach(WriteLine);
        }
    }
}
