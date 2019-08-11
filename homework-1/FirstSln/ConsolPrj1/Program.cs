using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolPrj1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("You are {0} {1}", name, surname);
            Console.WriteLine("It's a ConsolPrj1");
            Console.ReadLine();
        }
    }
}
