using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAcct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcct.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        [TestMethod()]
        public void DebitTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void CreditTest()
        {
            //Assert.Fail();
        }

        [DataTestMethod]
        [DataRow(100, 10, 90)]
        [DataRow(50, 50, 0)]
        [DataRow(100, -10, 110)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreditTest_MV(double expected, double amount, double balance)
        {
            BankAccount ba = new BankAccount("Tester 1", balance);

            ba.Credit(amount);
            double act = ba.Balance;
            Assert.AreEqual(expected, act);
        }

    }
}