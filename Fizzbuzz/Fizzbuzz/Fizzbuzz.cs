﻿using System;
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
            if (i < 1 || i > 100)
                return (T)(object)"Out of range";
            if (i % 3 == 0 && i % 5 == 0)
                return (T)(object)"Fizzbuzz";
            if (i % 3 == 0)
                return (T)(object)"Fizz";
            if (i % 5 == 0)
                return (T)(object)"Buzz";
            return (T)(object)i;
        }
    }
}
