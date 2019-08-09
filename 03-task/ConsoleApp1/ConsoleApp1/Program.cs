using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum SortDirection
    {
        Ascending,
        Descending
    }
    class Program
    {
        public static int[] arr1 = { 1, 66, 6, 63, 2, 6, 7, 8, 9, 22 };
        public static int[] arr2 = { 5, 4, 3, 2, 1};

        //task-1.1 sort an array ascending/descending
        public static int[] SortArr(int[] arr, SortDirection direction)
        {
            int swap;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (direction == SortDirection.Ascending)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            swap = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = swap;
                        }
                    }
                    else if (direction == SortDirection.Descending)
                    {
                        if (arr[j] < arr[j + 1])
                        {
                            swap = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = swap;
                        }
                    }
                }
            }

            return arr;
        }

        //task-1.2 check if arr is sorted ascending/descending
        public static bool checkIfArrIsSorted (int[] arr, SortDirection direction)
        {
            if (direction == SortDirection.Ascending)
            {
                for (int k = 0; k < arr.Length - 1; k++)
                {
                    if (arr[k] > arr[k + 1])
                    {
                        return false;
                    }
                }
            }
            else if (direction == SortDirection.Descending)
            {
                for (int k = 0; k < arr.Length - 1; k++)
                {
                    if (arr[k] < arr[k + 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //Task-2.1 arithmetic progression multiplication
        public static int ArithmeticProgression(int firstElement, int step, int lastElement)
        {
            if (lastElement == firstElement)
            {
                return firstElement;
            }
            else
            {
                return lastElement * ArithmeticProgression(firstElement, step, lastElement - step);

            }
        }

        //Task-2.2 geometric progression multiplication
        public static double GeometricProgression(double firstElement, double step, double limit)
        {
            if (firstElement <= limit)
            {
                return 1;
            }
            else
            {
                return firstElement * GeometricProgression(firstElement / step, step, limit);
            }
        }
            static void Main(string[] args)
        {
            int[] resArr1 = SortArr(arr1, SortDirection.Descending);
            bool resArr2 = checkIfArrIsSorted(arr2, SortDirection.Ascending);
            int ArithRes = ArithmeticProgression(2, 2, 10);
            double GeomRes =  GeometricProgression(100, 2, 7);
        }
    }
}
