using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ClassLibrary2
{
    [TestFixture]
    public class Test
    {
        private static double result;
        [Test]
        public void TestOneAdd()
        {
            result = Class1.Add(2, 3);
            Assert.AreEqual(5, result);

            result = Class1.Add(0, 1);
            Assert.AreEqual(1, result);

            result = Class1.Add(0, -1);
            Assert.AreEqual(-1, result);

            result = Class1.Add(-5, -1);
            Assert.AreEqual(-6, result);

            result = Class1.Add(99, -99);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestMinus()
        {
            result = Class1.Minus(5, 3);
            Assert.AreEqual(2, result);

            result = Class1.Minus(0, 1);
            Assert.AreEqual(-1, result);

            result = Class1.Minus(0, -1);
            Assert.AreEqual(1, result);

            result = Class1.Minus(1, -1);
            Assert.AreEqual(2, result);

            result = Class1.Minus(-99, -99);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void TestMultiply()
        {
            result = Class1.Multiply(2, 3);
            Assert.AreEqual(6, result);

            result = Class1.Multiply(0, 1);
            Assert.AreEqual(0, result);

            result = Class1.Multiply(0, -1);
            Assert.AreEqual(0, result);

            result = Class1.Multiply(-5, -1);
            Assert.AreEqual(5, result);

            result = Class1.Multiply(2, -5);
            Assert.AreEqual(-10, result);
        }
        [Test]
        public void TestDivide()
        {
            result = Class1.Divide(3, 3);
            Assert.AreEqual(1, result);

            result = Class1.Divide(99999, 1);
            Assert.AreEqual(99999, result);

            result = Class1.Divide(999, -1);
            Assert.AreEqual(-999, result);

            result = Class1.Divide(-999, -999);
            Assert.AreEqual(1, result);

            result = Class1.Divide(0, -2);
            Assert.AreEqual(0, result);
        }

    }
}
