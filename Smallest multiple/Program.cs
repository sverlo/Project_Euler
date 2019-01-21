using Largest_prime_factor;
using System;
using System.Collections.Generic;

namespace Smallest_multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SmallestMultipleCalculator.GetSmallestMultiple(1, 20));
        }
    }

    class SmallestMultipleCalculator
    {
        public static int GetSmallestMultiple(int from, int to)
        {
            List<int> uniquePrimes = new List<int>();
            int res = 1;

            for (int i = from; i <= to; i++)
            {
                foreach (int prime in PrimeFactorCalculator.GetPrimes(i))
                {
                    if (!uniquePrimes.Contains(prime))
                    {
                        uniquePrimes.Add(prime);
                    }
                }
            }
            foreach (int prime in uniquePrimes)
            {
                res *= (int)Math.Pow(prime, (int)Math.Floor(Math.Log(to, prime)));
            }
            return res;
        }
    }
}