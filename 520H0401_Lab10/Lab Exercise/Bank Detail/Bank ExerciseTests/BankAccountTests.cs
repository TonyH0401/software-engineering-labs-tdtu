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
        public void CreditTest()
        {
            //Assert.Fail();
        }

        [DataTestMethod]
        [DataRow(100, -10, 110)]
        [DataRow(100, -2000, 0)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreditTest_Exception(double expected, double amount, double balance)
        {
            BankAccount ba = new BankAccount("Tester 1", balance);

            ba.Credit(amount);

            double act = ba.Balance;
            Assert.AreEqual(expected, act);
        }

        [DataTestMethod]
        [DataRow(50, 50, 0)]
        [DataRow(100, 10, 90)]
        public void CreditTest_MV(double expected, double amount, double balance)
        {
            BankAccount ba = new BankAccount("Tester 1", balance);

            ba.Credit(amount);

            double act = ba.Balance;
            Assert.AreEqual(expected, act);
        }

        [TestMethod()]
        public void DebitTest()
        {

        }

        [DataTestMethod]
        [DataRow(100, 1000, 110)]
        [DataRow(100, -2000, 0)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DeditTest_Exception(double expected, double amount, double balance)
        {
            BankAccount ba = new BankAccount("Tester 1", balance);

            ba.Debit(amount);

            double act = ba.Balance;
            Assert.AreEqual(expected, act);
        }

        [DataTestMethod]
        [DataRow(10, 90, 100)]
        [DataRow(0, 50, 50)]
        [DataRow(100, 100, 200)]
        public void DebitTest_MV(double expected, double amount, double balance)
        {
            BankAccount ba = new BankAccount("Tester 1", balance);

            ba.Debit(amount);

            double act = ba.Balance;
            Assert.AreEqual(expected, act);
        }
    }
}