using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest.Helpers
{
    public static class DataAlgorithm
    {
        public static string ExecuteFirstTask(int number)
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

        public static string ExecuteLastTask(int number)
        {
            if (number % 6 == 0)
            {
                return MessageBodyEnum.FizzBuzz.GetValueAttribute();
            }
            else if (number % 4 == 0)
            {
                return MessageBodyEnum.Buzz.GetValueAttribute();
            }
            else if (number % 2 == 0)
            {
                return MessageBodyEnum.Fizz.GetValueAttribute();
            }
            return number.ToString();
        }

        public static int Execute(string number)
        {
            if (number.IndexOf("0")>0 && number.IndexOf("1")>0)
            {
                return int.Parse(MessageBodyEnum.NumberMultipleForSix.GetValueAttribute());
            }
            else if (number.IndexOf("0") > 0)
            {
                return int.Parse(MessageBodyEnum.NumberMultipleForTwo.GetValueAttribute());
            }
            else if (number.IndexOf("1") > 0)
            {
                return int.Parse(MessageBodyEnum.NumberMultipleForFour.GetValueAttribute());
            }
            return 0;
        }
    }
}
