using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_7._1._2
{
    class Rectangle : IShape
    {
        public string Name { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public Rectangle(string name)
        {
            this.Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public double GetArea()
        {
            return Width * Length;
        }
    }
}
