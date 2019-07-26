using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_7._1._2
{
    class Triangle : IShape
    {
        public string Name { get; set; }
        public double Base { get; set; }
        public double Heigth { get; set; }
        public Triangle(string name)
        {
            this.Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public double GetArea()
        {
            return (Base * Heigth) / 2;
        }
    }
}
