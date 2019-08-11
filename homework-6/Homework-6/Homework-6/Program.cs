using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = { { 2, 3, 4 }, { 1, 2, 10 }, { 3, 2, 5 } };
            int[,] matrix2 = { { 2, 3, 4 }, { 1, 2, 5 } };
            int[,] matrix3 = { { 2, 3, 4 }, { 1, 2, 3} };

            int [,] resMatrix = Matrix.MultiplyMatrices(matrix2, matrix3);

            for (int i = 0; i < resMatrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < resMatrix.GetUpperBound(1) + 1; j++)
                {
                    Console.WriteLine(resMatrix[i, j]);
                }
            }

            Console.ReadKey();
        }
    }
}
