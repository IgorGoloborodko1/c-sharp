using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    public static class Matrix
    {
        public static int[,] AddMatrices(int[,] firstMatrix, int[,] secondMatrix)
        {
            if ((firstMatrix.GetUpperBound(0) + 1) != (secondMatrix.GetUpperBound(0) + 1)) throw new Exception("Matrices first dimensions are not equal!");
            if ((firstMatrix.GetUpperBound(1) + 1) != (secondMatrix.GetUpperBound(1) + 1)) throw new Exception("Matrices second dimensions are not equal!");
            int[,] resultMatrix = new int[firstMatrix.GetUpperBound(0) + 1, firstMatrix.GetUpperBound(1) + 1];
            try
            {
                for (int i = 0; i < firstMatrix.GetUpperBound(0) + 1; i++)
                {
                    for (int j = 0; j < firstMatrix.GetUpperBound(1) + 1; j++)
                    {
                        resultMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
                    }
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"{e.Message}");
            }
            return resultMatrix;
        }

        public static int[,] SubstractMatrices(int[,] firstMatrix, int[,] secondMatrix)
        {
            if ((firstMatrix.GetUpperBound(0) + 1) != (secondMatrix.GetUpperBound(0) + 1)) throw new Exception("Matrices first dimensions are not equal!");
            if ((firstMatrix.GetUpperBound(1) + 1) != (secondMatrix.GetUpperBound(1) + 1)) throw new Exception("Matrices second dimensions are not equal!");
            int[,] resultMatrix = new int[firstMatrix.GetUpperBound(0) + 1, firstMatrix.GetUpperBound(1) + 1];
            try
            {
                for (int i = 0; i < firstMatrix.GetUpperBound(0) + 1; i++)
                {
                    for (int j = 0; j < firstMatrix.GetUpperBound(1) + 1; j++)
                    {
                        resultMatrix[i, j] = firstMatrix[i, j] - secondMatrix[i, j];
                    }
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"{e.Message}");
            }
            return resultMatrix;
        }

        public static int[,] MultiplyMatrices(int[,] firstMatrix, int[,] secondMatrix)
        {
            if ((firstMatrix.GetUpperBound(0) + 1) != (secondMatrix.GetUpperBound(0) + 1)) throw new Exception("Matrices first dimensions are not equal!");
            if ((firstMatrix.GetUpperBound(1) + 1) != (secondMatrix.GetUpperBound(1) + 1)) throw new Exception("Matrices second dimensions are not equal!");
            int[,] resultMatrix = new int[firstMatrix.GetUpperBound(0) + 1, firstMatrix.GetUpperBound(1) + 1];
            try
            {
                for (int i = 0; i < firstMatrix.GetUpperBound(0) + 1; i++)
                {
                    for (int j = 0; j < firstMatrix.GetUpperBound(1) + 1; j++)
                    {
                        resultMatrix[i, j] = firstMatrix[i, j] * secondMatrix[i, j];
                    }
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"{e.Message}");
            }
            return resultMatrix;
        }
    }
}
