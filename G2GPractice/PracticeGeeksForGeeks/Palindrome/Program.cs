using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            var noOfTestCases = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < noOfTestCases; i++)
            {
                var number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(IsSumOfDigitPalindrome(number) ? "YES" : "NO");
            }
        }

        private static bool IsSumOfDigitPalindrome(int number)
        {
            var sumOfDigits = 0;
            for (var i = number; i > 0; i = i / 10)
            {
                sumOfDigits += (i % 10);
            }

            return IsPalindrome(sumOfDigits);
        }

        private static bool IsPalindrome(int number)
        {
            return (number.ToString() == Reverse(number.ToString()));
        }

        private static string Reverse(string toReverese)
        {
            var charArray = toReverese.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
