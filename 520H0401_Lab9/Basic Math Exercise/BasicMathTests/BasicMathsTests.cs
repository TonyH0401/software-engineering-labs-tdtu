using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMath.Tests
{
    [TestClass()]
    public class BasicMathsTests
    {
        [TestMethod()]
        public void AddTest()
        {
            BasicMaths bm = new BasicMaths();
            double act = bm.Add(10, 10);
            Assert.AreEqual(20, act);
        }
        [TestMethod]
        public void SubstractTest()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Substract(10, 10);
            Assert.AreEqual(res, 0);
        }
        [TestMethod]
        public void DivideTest()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Divide(10, 5);
            Assert.AreEqual(res, 2);
        }
        [TestMethod]
        public void MultiplyTest()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Multiply(10, 10);
            Assert.AreEqual(res, 100);
        }
        [DataTestMethod]
        [DataRow(5,5,10)]
        [DataRow(10,5,15)]
        public void AddTest_MV(int a, int b, int expected)
        {
            BasicMaths bm = new BasicMaths();
            double act = bm.Add(a, b);
            Assert.AreEqual(expected, act);
        }
        [DataTestMethod]
        [DataRow(5, 5, 0)]
        [DataRow(10, 5, 5)]
        public void SubstractTest_MV(int a, int b, int expected)
        {
            BasicMaths bm = new BasicMaths();
            double act = bm.Substract(a, b);
            Assert.AreEqual(expected, act);
        }
    }
}