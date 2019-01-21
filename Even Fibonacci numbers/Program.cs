using System;

namespace Even_Fibonacci_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FibonacciNumber.GetSumOfEvenNumbers(4000000));
        }
    }
    class FibonacciNumber
    {
        public static int GetSumOfEvenNumbers(int limit)
        {
            int sum = 0;
            int first = 0;
            int second = 1;
            int fibonacciNumber = 0;

            while (second <= limit)
            {
                fibonacciNumber = first + second;
                first = second;
                second = fibonacciNumber;

                if (fibonacciNumber % 2 == 0)
                {
                    sum += fibonacciNumber;
                }

                //Console.WriteLine(fibonacciNumber);
            }
            return sum;
        }
    }
}