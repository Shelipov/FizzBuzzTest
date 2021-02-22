using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest.Helpers
{
    public enum MessageBodyEnum
    {
        [Value("FizzBuzz")]
        FizzBuzz,

        [Value("Fizz")]
        Fizz,

        [Value("Buzz")]
        Buzz,

        [Value("6")]
        NumberMultipleForSix,

        [Value("4")]
        NumberMultipleForFour,

        [Value("2")]
        NumberMultipleForTwo
    }
}
