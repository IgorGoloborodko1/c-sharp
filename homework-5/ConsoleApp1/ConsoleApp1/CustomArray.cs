using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CustomArray
    {
        public int[] Arr { get;}
        public int StartIndex { get;}
        public int LastIndex
        {
            get
            {
                return StartIndex + (Arr.Length - 1);
            }
        }
        public int Length
        {
            get
            {
                return Arr.Length;
            }
        }
        
        public int this[int index]
        {
            get
            {
                return Arr[index];
            }
            set
            {
                Arr[index] = StartIndex;
            }
        }
        public CustomArray(int[] arr, int startIndex)
        {
            Arr = arr;
            StartIndex = startIndex;
        }
    }
} 