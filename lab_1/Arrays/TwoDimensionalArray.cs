using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1.Arrays
{
    public class TwoDimensionalArray
    {
        public bool error = false;
        private int[,] Array;

        public TwoDimensionalArray()
        {
            Array = new int[XLength, YLength];
            generate();
        }
        public TwoDimensionalArray(int xLength, int yLength)
        {
            XLength = xLength;
            YLength = yLength;
            Array = new int[XLength, YLength];
            generate();
        }

        public int XLength { get; set; } = 10;
        public int YLength { get; set; } = 12;
        public int this[int x, int y]
        {
            get
            {
                if (x < 0 || x >= XLength || y < 0 || y >= YLength)
                {
                    error = true;
                    return 0;
                }
                error = false;
                return Array[x, y];
            }
            set
            {
                if (x < 0 || x >= XLength || y < 0 || y >= YLength)
                {
                    error = true;
                    return;
                }
                error = false;
                Array[x, y] = value;
            }
        }

        void generate()
        {
            for(int i = 0; i < XLength; i++)
            {
                for (int j = 0; j < YLength; j++)
                {
                    Array[i, j] = i + 2 * j;
                }
            }
        }
    }
}
