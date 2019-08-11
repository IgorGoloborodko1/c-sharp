using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            //Task 1.1 average
            int accumulator1 = 0;
            int i = 0;
            while (i < arr1.Length)
            {
                accumulator1 += arr1[i];
                i++;
            }
            int arrAverage = accumulator1 / arr1.Length;

            //Task 1.2 sum of even numbers without if/else
            int sumOfEvenNumbers = 0;
            for (int iter = 0; iter < arr1.Length; iter += 2)
            {
                sumOfEvenNumbers += arr1[iter];
            }

            //Task 1.3 sum of even numbers with if/else
            int sumOfEvenNumbers2 = 0;
            for (int j = 0; j < arr1.Length; j++)
            {
                if (arr1[j] % 2 == 0)
                {
                    sumOfEvenNumbers2 += arr1[j];
                }
            }

            //task 2.1  change fist to last in an array
            int[] newArr = { 3, 4, 9, 6, 7, 8, 9 };
            for (int incr = 0; incr < newArr.Length / 2; incr++)
            {
                int arrFistHalfNum = newArr[incr];
                newArr[incr] = newArr[newArr.Length - incr - 1];
                newArr[newArr.Length - incr - 1] = arrFistHalfNum;
               
            }

            //Task 2.2 max value entries
            int[] newarr2 = { 3, 21, 2, 9, 6, 20, 21 };
            int acc = 0;
            int difference = 0;
            for (int increment = 0; increment < newarr2.Length; increment++)
            {
                if (acc < newarr2[increment])
                {
                    acc = newarr2[increment];
                }
                else if (acc == newarr2[increment])
                {
                    difference = Array.LastIndexOf(newarr2, acc) - Array.IndexOf(newarr2, acc);
                }
            }

            //task 3 two dimensiola array diagonal
            int[,] twoDimenciomalArr =
                {
                    { 2, 4, 5, 6 },
                    { 5, 7, 7, 9 },
                    { 2, 4, 5, 6 },
                    { 2, 4, 5, 6 }
                };
            for (int k = 0; k < twoDimenciomalArr.GetLength(0); k++)
            {
                for (int l = 0; l < twoDimenciomalArr.GetLength(1); l++)
                {
                    if (k < l)
                    {
                        twoDimenciomalArr[k, l] = 1;
                    }
                    else if (k > l)
                    {
                        twoDimenciomalArr[k, l] = 0;
                    }
                }
            }
        }
    }
}
