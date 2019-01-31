using Largest_prime_factor;
using System;

namespace Summation_of_primes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrimesSummator.GetSumOfPrimes(2000000));
        }
    }
    class PrimesSummator
    {
        public static long GetSumOfPrimes(int to)
        {
            long sum = 0;
            for(int i = 0; i < to; i++)
            {
                if(PrimeFactorCalculator.IsPrime(i))
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
