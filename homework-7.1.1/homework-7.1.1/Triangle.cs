using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_7._1._1
{
    class Triangle : Shape
    {
        private double _base;
        private double _heigth;
        public double Base
        {
            get
            {
                return _base;
            }
            set
            {
                _base = value;
            }
        }
        public double Heigth
        {
            get
            {
                return _heigth;
            }
            set
            {
                _heigth = value;
            }
        }
        public Triangle (string name):
            base (name)
        { }
        public override double GetArea()
        {
            return (Base * Heigth) / 2;
        }
    }
}
