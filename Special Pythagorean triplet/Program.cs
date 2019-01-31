using System;

namespace Special_Pythagorean_triplet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PythagoreanNumberCalculator.GetProductOfTheSidesOfTriangle(1000));
        }
    }

    class PythagoreanNumberCalculator
    {
        private static bool IsPythagoreanTriangle(int a, int b, int c)
        {
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
            {
                return true;
            }
            return false;
        }

        public static int GetProductOfTheSidesOfTriangle(int sumOfTheSidesOfTriangle)
        {
            int c = 0;
            for (int a = 1; a < sumOfTheSidesOfTriangle; a++)
            {
                for (int b = a; b < sumOfTheSidesOfTriangle - a; b++)
                {
                    c = sumOfTheSidesOfTriangle - a - b;
                    if(IsPythagoreanTriangle(a,b,c))
                    {
                        return a * b * c;
                    }
                }
            }
            return 0;
        }
    }
}
