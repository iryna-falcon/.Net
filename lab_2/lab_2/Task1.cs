using System;

namespace lab_2
{
    public class Task1
    {
        private int a, b, c;

        public int A { get { return a; } set { a = value; } }
        public int B { get { return b; } set { b = value; } }
        public int C { get { return c; } set { c = value; } }

        public Task1() { }

        public Task1(int a) { this.a = a; }

        public Task1(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int CountGreaterThanThree()
        {
            int count = 0;
            if (a > 3) count++;
            if (b > 3) count++;
            if (c > 3) count++;
            return count;
        }
    }
}