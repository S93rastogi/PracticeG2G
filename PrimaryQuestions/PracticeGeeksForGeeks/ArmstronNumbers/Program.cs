using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArmstronNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var noOfTestCases = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < noOfTestCases; i++)
            {
                var number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(IsArmstrong(number) ? "Yes" : "No");
            }
        }

        private static bool IsArmstrong(int number)
        {
            var sum = 0.0;
            for (var i = number; i > 0; i = i / 10)
            {
                sum += Math.Pow(i % 10, 3);
            }
            return Math.Abs(sum - number) < .000001;
        }
    }
}
