using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_palindrome_product
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PalindromeCalculator.GetLargestPalindrome());
        }
    }

    class PalindromeCalculator
    {
        private static bool IsPalindrome(int number)
        {
            return number.ToString().Equals(new string(number.ToString().Reverse().ToArray()));
        }

        private static List<int> GetPalindromes()
        {
            List<int> palindromes = new List<int>();
            for (int i = 100; i <= 999; i++)
            {
                for (int j = 100; j <= 999; j++)
                {
                    if(IsPalindrome(i*j))
                    {
                        palindromes.Add(i*j);
                    }
                }
            }
            return palindromes;
        }

        public static int GetLargestPalindrome()
        {
            return GetPalindromes().Max();
        }
    }
}
