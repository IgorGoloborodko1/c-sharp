using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Polynomial
    {
        private List<int> Numbers = new List<int>();
        public int Variable { get; set; }
        public int Length
        {
            get
            {
                return Numbers.Count;
            }
        }
        public int this[int degree]
        {
            get
            {
                return Numbers[degree];
            }
            set
            {
                Numbers[degree] = value;
            }
        }
        public Polynomial(int variable, List<int> numbers)
        {
            Variable = variable;
            Numbers = numbers;
        }
        public static Polynomial operator +(Polynomial polynomial, int num)
        {
            List<int> newList = polynomial.Numbers.Select(x => x + num).ToList();
            return new Polynomial(polynomial.Variable, newList);
        }
        public static Polynomial operator -(Polynomial polynomial, int num)
        {
            List<int> newList = polynomial.Numbers.Select(x => x - num).ToList();
            return new Polynomial(polynomial.Variable, newList);
        }
        public static Polynomial operator *(Polynomial polynomial, int num)
        {
            List<int> newList = polynomial.Numbers.Select(x => x * num).ToList();
            return new Polynomial(polynomial.Variable, newList);
        }
        //public string DemonstratePolynomial()
        //{  

        //}
    }
}
