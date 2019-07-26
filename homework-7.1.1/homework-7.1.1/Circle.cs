using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_7._1._1
{
    class Circle : Shape
    {
        private double _radius;
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }
        public Circle(string name):
            base(name)
        { }
        public override double GetArea()
        {
            return (Math.PI) * (Math.Pow(Radius, 2));
        }    
    }
}
