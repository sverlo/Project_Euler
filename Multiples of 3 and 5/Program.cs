using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static int GetSum(int a, int b, int c)
        {
            int sum = 0;
            for (int i = 0; i < c; i++)
            {
                if ((i % a == 0) || (i % b == 0))
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
