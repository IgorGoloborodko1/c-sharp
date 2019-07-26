using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_7._1._1
{
    class Rectangle : Shape
    {
        private double _width;
        private double _length;
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }
        public Rectangle (string name):
            base(name)
        { }
        public override double GetArea()
        {
            return Width * Length;
        }
    }
}
