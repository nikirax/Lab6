using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Square_Matrix
    {
        private double[,] matrix { get; set; }
        public int Lenght() { return matrix.Length; }
        public double getValue(int pos_y, int pos_x)
        {
            return matrix[pos_y, pos_x];
        }
        public void setValue(int pos_y, int pos_x, double value)
        {
            matrix[pos_y, pos_x] = value;
        }
        public Square_Matrix(int y, int x) { this.matrix = new double[y, x]; }
        public Square_Matrix(double[,] matrix)
        {
            this.matrix = matrix;
        }
        public double Multi_Matrix(params int[] items)
        {
            if (items.Length < 1)
            {
                return Plus_Matrix();
            }
            else if (items.Length > 1)
            {
                return 0.0;
            }
            else
            {
                if (items[0] < 0)
                {
                    return Mult(Math.Abs(items[0]), 0);
                }
                else if (items[0] > 0)
                {
                    return Mult(0, items[0]);
                }
                else
                {
                    return Mult(0, 0);
                }
            }
        }
        private double Plus_Matrix()
        {
            double sum = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;
        }
        private double Mult(int i, int j)
        {
            bool main = i == 0 && j == 0 ? true : false;
            double mult = 1;
            for (; i < matrix.GetLength(0); i++)
            {
                if (main)
                {
                    mult *= matrix[i, i];
                    continue;
                }
                mult *= matrix[i, j];
            }
            return mult;
        }
    }
}
