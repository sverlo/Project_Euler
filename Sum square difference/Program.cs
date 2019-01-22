using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_square_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumSquareDifferenceCalculator.GetDifference(1, 100));
        }
    }
    class SumSquareDifferenceCalculator
    {
        private static int GetTheSumOfTheSquares(int from, int to)
        {
            int sum = 0;

            for (int i = from; i <= to; i++)
            {
                sum += (int)Math.Pow(i, 2);
            }

            return sum;
        }

        private static int GetTheSquareOfTheSum(int from, int to)
        {
            int square = 0;

            for (int i = from; i <= to; i++)
            {
                square += i;
            }

            return (int)Math.Pow(square, 2);
        }

        public static int GetDifference(int from, int to)
        {
            return GetTheSquareOfTheSum(from, to) - GetTheSumOfTheSquares(from, to);
        }
    }
}
