using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyLibrary.Tests
{
    [TestClass]
    public class Class1Tests
    {
        [TestMethod]
        public void Square_Test()
        {

            // arrange
            double My_value = 2;
            double expected = 12.56;

            // act
            Class1 s = new Class1();
            double actual = s.square(My_value);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Triangle_Test()
        {
            // arrange
            double A = 4;
            double B = 3;
            double C = 5;
            double expected = 6;

            // act 
            Class1 d = new Class1();
            double actual = d.Triangle(A, B, C);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
