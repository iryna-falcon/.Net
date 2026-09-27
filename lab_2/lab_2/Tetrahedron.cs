using System;

namespace lab_2
{
    public class Tetrahedron
    {
        private double a;
        public double A { get { return a; } set { a = value; } }

        public Tetrahedron() { }
        public Tetrahedron(double a) { this.a = a; }
        public Tetrahedron(double a, string dummyArg) { this.a = a; }

        public double CalculateVolume()
        {
            return (Math.Pow(a, 3) * Math.Sqrt(2)) / 12.0;
        }

        public double CalculateHeight()
        {
            return a * Math.Sqrt(2.0 / 3.0);
        }

        public double CalculateSurfaceArea()
        {
            return Math.Pow(a, 2) * Math.Sqrt(3);
        }
    }
}