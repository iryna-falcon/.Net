using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1.Arrays
{
    public class OneDimensionalArray
    {
        public bool error = false;
        private int[] Array;
       

        public OneDimensionalArray()
        {
            Array = new int[Length];
        }
        public OneDimensionalArray(int[] a)
        {
            Array = a;
        }
        public OneDimensionalArray(int length)
        {
            Length = length;
            Array = new int[Length];
            Random rand = new Random();
            for(int i = 0; i < Length; i++)
            {
                Array[i] = rand.Next(100, 201);
            }
        }

        public int Length { get; set; }
        public int this[int i]
        {
            get
            {
                if (i >= 0 && i < Length)
                {
                    return Array[i];
                }
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if (i >= 0 && i < Length && value >= 100 && value <= 200)
                {
                    Array[i] = value;
                }
                else
                {
                    error = true;
                }
            }
        }
        public int Sum
        {
            get
            {
                int sum = 0;
                foreach(int i in Array)
                {
                    if (i % 2 == 0)
                    {
                        sum += i;
                    }
                }
                return sum;
            }
        }
    }
}
