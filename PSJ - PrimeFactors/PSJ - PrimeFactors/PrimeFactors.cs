using System;
using System.Collections.Generic;

namespace PSJ___PrimeFactors
{
    class PrimeFactors
    {
        public static List<Int32> Generate(Int32 number)
        {
            List<Int32> primes = new List<int> { 1 };
            var factor = 2;

            while (number > 1 && factor <= number)
            {
                while (number%factor == 0)
                {
                    number /= factor;
                    primes.Add(factor);
                }

                factor++;
            }

            return primes;
        }
    }
}
