using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_7._1._2
{
    class Circle : IShape
    {
        public string Name { get; set; }
        public double Radius { get; set; }

        public Circle(string name)
        {
            this.Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public double GetArea()
        {
            return (Math.PI) * (Math.Pow(Radius, 2));
        }
    }
}
