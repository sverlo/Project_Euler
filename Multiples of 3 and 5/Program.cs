using System;

namespace Multiples_of_3_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AdderOfMultiples.GetSum(3, 5, 1000));
        }
    }

    class AdderOfMultiples
    {
        public static int GetSum(int firstNumber, int secondNumber, int limit)
        {
            int sum = 0;
            for (int i = 0; i < limit; i++)
            {
                if ((i % firstNumber == 0) || (i % secondNumber == 0))
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
