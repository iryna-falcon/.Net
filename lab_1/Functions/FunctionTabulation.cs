using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1.Functions
{
    public class FunctionTabulation
    {
        public double[,] xy = new double[1000, 2];
        public int n = 0;

        private double f1(double x)
        {
            return 2 * x * Math.Exp(-x);
        }

        private double f2(double x)
        {
            return Math.Pow(x - 1, 3) + Math.Cos(Math.Pow(x, 3));
        }

        private double f3(double x)
        {
            return 2 * Math.Sqrt(Math.Pow(x, 3)) * Math.Sin(Math.Pow(x, 3));
        }

        public void Tabulation(double a, double xn = 8, double xk = 12.1, double h = 0.11)
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