using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class DotProduct
    {
        public void ComputeDotProduct()
        {
            Console.WriteLine("Welcome to the Dot Product Calculator");
            Console.WriteLine("Please Enter How Many Deminsions");
            string deminsions = Console.ReadLine();
            Console.WriteLine("Please Enter How Many Arrays");
            string arrays = Console.ReadLine();
            int numArrays = int.Parse(arrays);
            int NumDeminsions = int.Parse(deminsions);
            int[,] array1 = new int[numArrays, NumDeminsions];
            //int[] array2 = new int[NumDeminsions];
            for (int i = 0; i < numArrays; i++)
            {
                for (int j = 0; j < NumDeminsions; j++)
                {
                    Console.WriteLine("Please Enter Element " + j + " of Array" + i);
                    string input = Console.ReadLine();
                    int input1 = int.Parse(input);
                    array1[i, j] = input1;
                }
            }

            int multiplyNum = 1;
            int scalar = 0;
            for (int i = 0; i < NumDeminsions; i++)
            {
                for (int j = 0; j < numArrays; j++)
                {
                    multiplyNum *= array1[j, i];
                }
                scalar += multiplyNum;
                multiplyNum = 1;
            }
            Console.WriteLine(scalar);
            Console.WriteLine("Hit Enter To Close");
            Console.Read();
            Environment.Exit(0);
        }
    }
}
