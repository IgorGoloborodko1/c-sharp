using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArithmeticsProgression
    {
        public int firstElement;
        public int step;
        public ArithmeticsProgression (int firstElement, int step)
        {
            this.firstElement = firstElement;
            this.step = step;
        }
        public int sumOfElements (int lastElementIndex)
        {
            int sum = 0;
            for (int i = 0; i < lastElementIndex; i++)
            {
                sum = sum + firstElement;
                firstElement = firstElement + step;
            }
            return sum;
        }
        public int averageOfElements (int lastElementIndex)
        {
        int sum = 0;
        for (int i = 0; i < lastElementIndex; i++)
        {
            sum = sum + firstElement;
            firstElement = firstElement + step;
        }
        return sum / lastElementIndex;

    }
        public int findLastElementValue (int lastElementIndex)
        {
            return firstElement + (lastElementIndex - 1) * step;
        }

    }
}
