using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest.Helpers
{
    public static class DataAlgorithm
    {
        public static string Execute(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return MessageBodyEnum.FizzBuzz.GetValueAttribute();
            }
            else if (number % 3 == 0)
            {
                return MessageBodyEnum.Fizz.GetValueAttribute();
            }
            else if (number % 5 == 0)
            {
                return MessageBodyEnum.Buzz.GetValueAttribute();
            }
            return number.ToString();
        }
    }
}
