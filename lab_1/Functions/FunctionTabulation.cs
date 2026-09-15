using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1.Functions
{
    public class FunctionTabulation
    {
        public double[,] xy = new double[1000, 2];
        public int n = 0;

        private double f1(double x)
        {
            return Math.Pow(Math.Tan(x + 1), 2) / (Math.Pow(x, 4) + 2 * Math.Pow(x, 3) - x);
        }
        private double f2(double x)
        {
            return (2 * x + 2) / (Math.Tan(2 + x - 1) + 1);
        }
        private double f3(double x)
        {
            return Math.Pow(Math.Cos(x + 2), 2) / (Math.Pow(Math.E, -2 * x) + Math.Pow(3 * Math.Pow(x, 2) + 1, 1.0 / 4.0));
        }

        public void Tabulation(double xn = -1.9, double xk = 29.7, double h = 0.1, double a = 10)
        {
            n = 0;

            double x = xn;

            while (x <= (xk + h))
            {
                if (n >= 1000)
                {
                    break;
                }

                if (x <= 0)
                {
                    xy[n, 1] = f1(x);
                }
                else if (x > 0 && x <= a)
                {
                    xy[n, 1] = f2(x);
                }
                else
                {
                    xy[n, 1] = f3(x);
                }

                xy[n, 0] = x;

                x += h;
                n++;
            }
        }
    }
}
