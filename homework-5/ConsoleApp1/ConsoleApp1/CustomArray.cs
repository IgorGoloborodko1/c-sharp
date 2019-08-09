using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CustomArray
    {
        public int FirstElementIndex { get; }
        public int LastElementIndex { get; }
        public int Lenght { get { return Arr.Length; } }
        private readonly int[] Arr;

        public CustomArray(int[] arr, int startIndex)
        {
            FirstElementIndex = startIndex;
            LastElementIndex = (arr.Length - 1) + startIndex;
            Arr = arr;
        }
        public int this[int index]
        {
            get
            {
                return Arr[index - FirstElementIndex];
            }
            set
            {
                Arr[index - FirstElementIndex] = value;
            }
        }
    }
} 