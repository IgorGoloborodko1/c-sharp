using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_7._1._1
{
    abstract class Shape
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public Shape(string name)
        {
            this.Name = name;
        }
        public string GetName()
        {
            return this.Name;
        }
        public abstract double GetArea();
    }
}
