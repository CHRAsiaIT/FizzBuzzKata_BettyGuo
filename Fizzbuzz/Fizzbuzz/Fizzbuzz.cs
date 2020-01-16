using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    public class Fizzbuzz
    {
        public static T Result<T>(int i)
        {
            if (i % 3 == 0)
                return (T)(object)"Fizz";
            if (i == 5)
                return (T)(object)"Buzz";
            return (T)(object)i;
        }
    }
}
