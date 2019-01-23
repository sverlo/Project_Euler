using System;
using System.Collections.Generic;
using System.Linq;
using Largest_prime_factor;


namespace _10001st_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrimesCalculator.GetPrime(10001));
        }
    }

    class PrimesCalculator
    {
        public static int GetPrime(int primesNumber)
        {
            int number = 2;
            List<int> allPrimes = new List<int>();

            while (allPrimes.Count() != primesNumber)
            {
                if (PrimeFactorCalculator.IsPrime(number))
                {
                    allPrimes.Add(number);
                }
                number++;
            }

            return allPrimes.ElementAt(primesNumber - 1);
        }
    }
}
