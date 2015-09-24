
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        /*
        This program was created as a destresser from homework and more serious coding projects, I wanted to build an application like this in order to check my homework.
        I have a lot more I need to do to clean it up. Especially split each class into several different methods as well as add more comprehensive validation of inputs and many other functions. 
        I also plan to creat a GUI using windows forms at some point but,
        As I said before I have no intent in creating this program other than for pure enterntainment. Thus best coding practices have not been utilized in many places.
        */
        static void Main(string[] args)
        {
            DotProduct dot = new DotProduct();
            QuadraticFormula quad = new QuadraticFormula();
            CrossProduct cross = new CrossProduct();
            bool success = false;
            while (!success)
            {

                Console.WriteLine("Welcome to The Phyiscs Calculator");
                Console.WriteLine("Please Enter D for Dot Product, Enter Q For Quadratic Formula, \nor Enter C for Cross Product");
                string input = Console.ReadLine();
                if (input == "D")
                {
                    dot.ComputeDotProduct();
                    success = true;
                }
                else if (input == "Q")
                {
                    quad.ComputeQuadraticFormula();
                    success = true;
                }
                else if (input == "C")
                {
                    cross.ComputeCrossProduct();
                    success = true;
                }
                else
                {
                    Console.WriteLine("You entered an accurate input, Hit Enter To Run Again");
                    Console.ReadLine();
                    success = false;
                }
            }
        }
    }
}
