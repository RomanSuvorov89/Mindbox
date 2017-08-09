using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleMindBox;

namespace TriangleTest
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void WrongLength()
        {
            TriangleClass T = new TriangleClass(-1, 2, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TriangleNotRight()
        {
            TriangleClass T = new TriangleClass(1, 2, 3);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotTriangle()
        {
            TriangleClass T = new TriangleClass(12, 2, 2);
        }
        [TestMethod]
        public void TriangleRightCorrect()
        {
            TriangleClass T = new TriangleClass(3, 4, 5);
        }
        [TestMethod]
        public void SquareTest()
        {
            TriangleClass T = new TriangleClass(5, 4, 3);
            double CorrectResult = 3 * 4 / 2;
            double square = T.Square();
            Assert.AreEqual(CorrectResult, square);
        }
    }
}
