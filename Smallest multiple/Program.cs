using Largest_prime_factor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Smallest_multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SmallestMultipleCalculator.GetLeastCommonMultiple(8, 8));
            //Console.WriteLine(SmallestMultipleCalculator.GetSmallestMultipleOfTheSequence(1, 20));
        }
    }

    class SmallestMultipleCalculator
    {
        public static int GetSmallestMultipleOfTheSequence(int from, int to)
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

        public static int GetLeastCommonMultiple(int firstNumber, int secondNumber)
        {
            return firstNumber / PrimeFactorCalculator.GetGreatestCommonDivisor(firstNumber, secondNumber) * secondNumber;
        }
    }
}