using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibPrj3;

namespace ConsolPrj2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 6;
            Console.WriteLine(Arithmetic.Add(a, b));
            Console.WriteLine(Arithmetic.Subtract(a, b));
            Console.WriteLine(Arithmetic.Multiply(a, b));
            Console.WriteLine(Arithmetic.Divide(a, b));
            Console.ReadLine();
        }
    }
}
