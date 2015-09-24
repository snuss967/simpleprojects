using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class QuadraticFormula
    {
        public void ComputeQuadraticFormula()
        {
            // Computes the quadratic formula 
            Console.WriteLine("Welcome To The Quadratic Forumla Calculator");
            Console.WriteLine("In This Calculator only numbers will be accepted");
            Console.WriteLine("Please Be Aware That If You Do Not Enter a Proper Quadratic You Will Be Given Not A Number");
            Console.WriteLine("In the Format a= x^2 b= x c = constant please enter A ");
            string inputA = Console.ReadLine();
            double parsedA = double.Parse(inputA);
            Console.WriteLine("Please Enter B");
            string inputB = Console.ReadLine();
            double parsedB = double.Parse(inputB);
            Console.WriteLine("Please Enter C");
            string inputC = Console.ReadLine();
            double parsedC = double.Parse(inputC);
            double addedTotal = 0;
            double subtractedTotal = 0;
            addedTotal = (((-1 * parsedB) + Math.Sqrt((Math.Pow(parsedB, 2) - 4 * parsedA * parsedC))) / (2 * parsedA));
            Console.WriteLine("Total 1 = " + addedTotal);
            subtractedTotal = (((-1 * parsedB) - Math.Sqrt((Math.Pow(parsedB, 2) - 4 * parsedA * parsedC))) / (2 * parsedA));
            Console.WriteLine("       Total 2 = " + subtractedTotal);
            Console.WriteLine("Hit Enter To Close");
            Console.Read();
            Environment.Exit(0);
        }
    }
}
