using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest.Models
{
    public static class GetTestData
    {
        public static IEnumerable<int> GetTestData1(int count)
        {
            return Enumerable.Range(0, count);
        }

        public static IEnumerable<string> GetTestData2()
        {
            return new string[]
            {
                "V422R651",
                "V422R395",
                "V422R682",
                "V402R673",
                "V422R651",
                "V422R650",
                "V402R651",
            };
        }
    }
}
