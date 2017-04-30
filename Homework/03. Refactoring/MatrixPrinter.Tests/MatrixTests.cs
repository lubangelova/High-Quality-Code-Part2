using System;
using NUnit.Framework;

namespace MatrixPrinter.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void Matrix_ShouldThrowArgumentException_WhenInvalidRowPassed()
        {
            Matrix matrix = new Matrix(3, 3);
            Assert.Throws<ArgumentException>(() => matrix.Row = -5);
        }

        [Test]
        public void Matrix_ShouldThrowArgumentException_WhenInvalidColPassed()
        {
            Matrix matrix = new Matrix(3, 3);
            Assert.Throws<ArgumentException>(() => matrix.Col = -5);
        }

        [Test]
        public void FillMatrix_ShouldFillMatrixCorrectly_WhenValidValuePassed()
        {
            Matrix matrix = new Matrix(3, 3);
            matrix.FillMatrix();
            Assert.AreEqual(1, matrix.Body[0, 0]);
            Assert.AreEqual(2, matrix.Body[1, 1]);
            Assert.AreEqual(3, matrix.Body[2, 2]);
            Assert.AreEqual(4, matrix.Body[2, 1]);
            Assert.AreEqual(5, matrix.Body[2, 0]);
            Assert.AreEqual(6, matrix.Body[1, 0]);
            Assert.AreEqual(7, matrix.Body[0, 1]);
            Assert.AreEqual(8, matrix.Body[0, 2]);
            Assert.AreEqual(9, matrix.Body[1, 2]);
        }
    }
}
