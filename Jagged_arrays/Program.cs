using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[][] Array = new int[5][];
            for (int i = 0; i < Array.Length; i++)
                Array[i] = new int[random.Next(1, 10)];


            int[] sumArray = new int[Array.Length];

            for (int i = 0; i < Array.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < Array[i].Length; j++)
                {
                    Array[i][j] = random.Next(50);

                    sum += Array[i][j];
                    if (j == Array[i].Length - 1)
                    {
                        sumArray[i] = sum;
                    }

                    Console.Write("{0,4}", Array[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int minStr = 0;
            int maxStr = 0;

            int strMin = sumArray[0];
            int strMax = sumArray[0];
            for (int i = 0; i < sumArray.Length; i++)
            {
                if (strMin > sumArray[i])
                {
                    strMin = sumArray[i];
                   minStr = i;
                }
                if (strMax < sumArray[i])
                {
                    strMax = sumArray[i];
                    maxStr = i;
                }
            }
            Console.WriteLine($"Min {minStr}, Max {maxStr}");
            Console.WriteLine("------------------------------------------------");
            int dopIter = 0;
            bool Q = false;
            bool W = false;
            for (int i = 0; i < Array.Length; i++)
            {
                if (i == maxStr && W == false)
                {
                    dopIter = i;
                    i = minStr;
                    Q = true;
                    W = true;
                }
                if (i == minStr && W ==false)
                {
                    dopIter = i;
                    i = maxStr;
                    Q = true;
                    W = true;
                }
                for (int j = 0; j < Array[i].Length; j++)
                {
                    Console.Write("{0,4}", Array[i][j]);
                }
                if (Q == true)
                {
                    i = dopIter;
                    Q = false;
                    W = false;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}
