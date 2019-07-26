using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals =
            {
                new Deer("Dambo"),
                new Deer("Martin"),
                new Hare("Bunny"),
                new Hare("Monroe"),
                new Wolf("Goofy"),
                new Fox("Mykyta")
            };
            var numberOfPredators = animals.Where(x => x is Herbivorous).Count();
            var numberOfHerbivorous = animals.Where(x => x is Predator).Count();
        }
    }
}
