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
            Console.WriteLine(myArray[0]);
            Console.ReadKey();
        }
    }
}
