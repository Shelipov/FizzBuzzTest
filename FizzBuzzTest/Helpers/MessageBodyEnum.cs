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
    }
}
