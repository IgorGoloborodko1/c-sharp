using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //task-1.1 sort an array accending
        public int[] arrToBeSorted = { 1, 66, 6, 63, 2, 6, 7, 8, 9, 22 };
        public void SortArr(int[] arr)
        {
            int swap;
            for (int i = 0; i < arr.Length; i++)

                for (int j = 0; j < arr.Length - i - 1; j++)
                {

                    if (arr[j] > arr[j + 1])
                    {
                        swap = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = swap;
                    }

                }
        }

        //task-1.2 check if arr is sorted
        int[] arrToBeChecked = { 1, 4, 6, 6, 9, 10, 11};
        public bool checkIfArrisSorted (int[] arr)
        {
            for (int k = 0; k < arr.Length; k++)
            {
                if (arr[k] > arr[k+1])
                {
                    return false;
                } 
            }
            return true;
        }

        //task-2.1 multiplied elements
        public int returnMultipliedElements (int firstElement, int lastElement, int step)
        {
            int result = 0;
            int multiplyBy = 0;
            for ( int i = firstElement; i <= lastElement; i += step)
            {
                result = multiplyBy * (firstElement + step);
                multiplyBy++;
            }
            return result;
        }
        static void Main(string[] args)
        {
        }
    }
}
