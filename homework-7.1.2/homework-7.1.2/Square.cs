using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_7._1._2
{
    class Square : Rectangle, IShape
    {
        public double Side { get; set; }
        public Square(string name) :
            base(name)
        { }
        public new double GetArea()
        {
            return Side * Side;
        }
    }
}
