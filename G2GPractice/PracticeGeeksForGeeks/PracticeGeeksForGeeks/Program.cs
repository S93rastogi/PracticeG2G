using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeGeeksForGeeks
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfTest = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            for (var i = 1; i <= numberOfTest; i++)
            {
                var elementsOfAp = Console.ReadLine() ?? throw new ArgumentNullException();
                var firstElement = int.Parse(elementsOfAp.Split(' ')[0]);
                var secondElement = int.Parse(elementsOfAp.Split(' ')[1]);
                var diffenenceOfAp = secondElement - firstElement;
                var nthTerm = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                var nthTermValue = firstElement + (nthTerm - 1) * diffenenceOfAp;
                Console.WriteLine(nthTermValue);
            }

        }
    }
}
