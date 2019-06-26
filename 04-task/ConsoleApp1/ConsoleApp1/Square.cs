using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Square
    {
        public int side;
        public Square (int side)
        {
            this.side = side;
        }
        public int findPerimeter()
        {
            return side * 4;
        }
        public int findArea()
        {
            return side * side;
        }
    }
}
