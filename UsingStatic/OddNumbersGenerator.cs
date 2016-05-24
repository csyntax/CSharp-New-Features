using System.Collections.Generic;
using static System.Linq.Enumerable;

namespace UsingStatic
{
    public class OddNumbersGenerator
    {
        public IEnumerable<int> GetOddNumbersBetween(int min, int max)
        {
            var range = Range(min, max);

            var odd = range.Where(i => i % 2 == 1);

            return odd;
        }
    }
}
