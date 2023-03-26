using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab6;
using System.Diagnostics.CodeAnalysis;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMatrixLenght()
        {
            double[,] matrix = new double[5, 5];
            var square_matrix = new Square_Matrix(5, 5);

            Assert.AreEqual(matrix.Length, square_matrix.Lenght());
        }
        [TestMethod]
        public void TestMatrixPlus()
        {
            double mult_matrix = 1;
            double[,] matrix = new double[5, 5]
            {
                {1, 2, 3, 4, 5 },
                {1, 2, 3, 4, 5 },
                {1, 2, 3, 4, 5 },
                {1, 2, 3, 4, 5 },
                {1, 2, 3, 4, 5 }
            };
            var square_matrix = new Square_Matrix(matrix);
            
            for(var i = 0; i < 5; i++)
            {
                mult_matrix *= matrix[i, i];
            }
            Assert.AreEqual(mult_matrix, square_matrix.Multi_Matrix(0));
        }
    }
}
