using System;

namespace lab_2
{
    public class Task2
    {
        private int a, b;
        public int A { get { return a; } set { a = value; } }
        public int B { get { return b; } set { b = value; } }

        public Task2() { }
        public Task2(int a) { this.a = a; }
        public Task2(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int CalculateSum()
        {
            if (a > b) throw new ArgumentOutOfRangeException("Початкове значення A має бути меншим за B");

            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0 && i % 6 == 2)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}