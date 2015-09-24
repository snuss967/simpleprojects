using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class CrossProduct
    {
     
              
        public void ComputeCrossProduct()
        {
            bool permissionToContinue = true;
            while (permissionToContinue)
            {
                // Here we compute the cross product
                //First we print to the user the steps that we want him to take
                Console.WriteLine("Welcome To The Cross Product Calculator");
                Console.WriteLine("This calculator will calculate the cross product of two vectors in R3 for you");
                //this array has vector num then axis num
                float[,] vectors = new float[2, 3];
                for (int i = 0; i < 2; i++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.WriteLine("Please Enter Component " + (k + 1) + " of Vector " + (i + 1));
                        string tempInput = Console.ReadLine();
                        vectors[i, k] = float.Parse(tempInput);
                    }
                }

                // we have our arrays established we will now compute the cross product
                // we create a vector for our cross product it is represented by the array
                float[] crossArrayResult = new float[3];
                // we now compute the x value for the cross product 0 is the index for x axis
                crossArrayResult[0] = ((vectors[0, 1] * vectors[1, 2]) - (vectors[0, 2] * vectors[1, 1]));
                crossArrayResult[1] = ((vectors[0, 2] * vectors[1, 0]) - (vectors[0, 0] * vectors[1, 2]));
                crossArrayResult[2] = ((vectors[0, 0] * vectors[1, 1]) - (vectors[0, 1] * vectors[1, 0]));
                Console.WriteLine("Your Resultant Cross Product is (" + crossArrayResult[0] + "," + crossArrayResult[1] + "," + crossArrayResult[2] + ")");
                Console.WriteLine("Enter Yes For Done No For Continue");
                string continueYN = Console.ReadLine();

                if (continueYN == "Yes")
                {
                    permissionToContinue = false;
                    Environment.Exit(0);
                }
                else if (continueYN == "No")
                {
                    permissionToContinue = true;
                }
                else
                {
                    Console.WriteLine("You have entered an invalid input the program is quiting in order not to crash");
                    Environment.Exit(0);
                }
            }
        }
    }
}
