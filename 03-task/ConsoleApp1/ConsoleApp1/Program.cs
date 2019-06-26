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
            int[] arrToBeSorted = { 1, 66, 6, 63, 2, 6, 7, 8, 9, 22 };
            static void SortArr(int[] arr)
            {
                int swap;
                int[] newArr = { };
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
        }
    }
}
