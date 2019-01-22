using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_prime_factor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrimeFactorCalculator.GetTheLargestPrime(600851475143));
        }
    }
    public class PrimeFactorCalculator
    {
        private static bool IsPrime(long number)
        {
            if (number <= 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            if (number % 2 == 0)
            {
                return false;
            }

            long temp = (long)Math.Floor(Math.Sqrt(number));
            for (int i = 3; i <= temp; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static List<int> GetPrimes(long number)
        {
            List<int> primes = new List<int>();
            for (int i = 2; i <= number; i++)
            {
                if (IsPrime(i) && (number % i == 0))
                {
                    number /= i;
                    primes.Add(i);

                    while (number % i == 0)
                    {
                        number /= i;
                        primes.Add(i);
                    }
                }
            }
            return primes;
        }

        public static int GetTheLargestPrime(long number)
        {
            return GetPrimes(number).Max();
        }

        public static int GetGreatestCommonDivisor(int firstNumber, int secondNumber)
        {
            if (firstNumber == 0)
            {
                return secondNumber;
            }
            while (secondNumber != 0)
            {
                if (firstNumber > secondNumber)
                {
                    firstNumber -= secondNumber;
                }
                else
                {
                    secondNumber -= firstNumber;
                }
            }
            return firstNumber;
        }
    }
}
