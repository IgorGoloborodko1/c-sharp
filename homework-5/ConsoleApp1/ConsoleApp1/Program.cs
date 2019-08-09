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
            int[] arr = { 127, 2005, 11, 3000, 1300 };
            CustomArray myArray = new CustomArray(arr, 11);
            int firstElement = myArray[11];
            int arrLength = myArray.Lenght;
            int firstElementIndex = myArray.FirstElementIndex;
            int lastElementIndex = myArray.LastElementIndex;

            Console.WriteLine($"First element is: {firstElement}\nArray length is: {arrLength}\nFirst and last indexes are: {firstElementIndex} and {lastElementIndex}");
            Console.ReadKey();
        }
    }
}
