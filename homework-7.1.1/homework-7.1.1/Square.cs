using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_7._1._1
{
    class Square : Rectangle
    {
        private double _side;
        public double Side
        {
            get
            {
                return _side;
            }
            set
            {
                _side = value;
            }
        }
        public Square(string name):
            base(name)
        { }
        public override double GetArea()
        {
            return Side * Side;
        }
    }
}
