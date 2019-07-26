using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_7._2
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public Animal(string name)
        {
            this.Name = name;
        }
    }
}
