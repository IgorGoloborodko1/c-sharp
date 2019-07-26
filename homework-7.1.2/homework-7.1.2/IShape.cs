using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_7._1._2
{
    interface IShape
    {
        string Name { get; set; }
        string GetName();
        double GetArea();
    }
}
