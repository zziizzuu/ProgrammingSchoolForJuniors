using System;
using System.Collections.Generic;
using System.Linq;

namespace PSJ___PrimeFactors
{
    class Program
    {
        private const int NUMBER = 24;

        static void Main()
        {
            List<Int32> primeFactors = PrimeFactors.Generate(NUMBER);

            Console.Write(NUMBER + " = ");

            foreach (var factor in primeFactors)
            {
                if (factor == primeFactors.Last())
                {
                    Console.Write(factor);
                    continue;
                }
                Console.Write(factor + " * ");
            }

            Console.ReadKey();
        }
    }
}
