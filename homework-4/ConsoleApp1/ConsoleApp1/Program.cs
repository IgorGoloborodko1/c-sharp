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
            Square square10cm = new Square(7);
            square10cm.findArea();
            square10cm.findPerimeter();

            ArithmeticsProgression progressionInstance = new ArithmeticsProgression(1, 1);
            progressionInstance.averageOfElements(5);
        }
    }
}
