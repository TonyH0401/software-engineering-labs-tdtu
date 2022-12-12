using System;
using DemoLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoLibTests
{
   [TestClass]
   public class ComplexUnitTest
   {
      [TestMethod]
      public void TestMethod()
      {
         var complex = new Complex(1, 2);

         Assert.AreEqual(1, complex.Real);
         Assert.AreEqual(2, complex.Imaginary);
         Assert.AreEqual("1+2i", complex.ToString());
         Assert.AreEqual("1+2i", complex.ToString("S", null));
         Assert.AreEqual("(1, 2)", complex.ToString("P", null));
      }

      [TestMethod]
      public void Test_Multiply()
      {
         Assert.AreEqual(
            new Complex(0, 0),
            new Complex(1, 2) * new Complex(0, 0));

         Assert.AreEqual(
            new Complex(1, 2),
            new Complex(1, 2) * new Complex(1, 0));

         Assert.AreEqual(
            new Complex(-2, 1),
            new Complex(1, 2) * new Complex(0, 1));

         Assert.AreEqual(
            new Complex(-5, 10),
            new Complex(1, 2) * new Complex(3, 4));
      }

      [DataTestMethod]
      [DataRow(1, 2, 0, 0, 0, 0)]
      [DataRow(1, 2, 1, 0, 1, 2)]
      [DataRow(1, 2, 0, 1, -2, 1)]
      [DataRow(1, 2, 3, 4, -5, 10)]
      public void Test_Multiply_DataRow(double ar, double ai, double br, double bi, double er, double ei)
      {
         Assert.AreEqual(
            new Complex(er, ei),
            new Complex(ar, ai) * new Complex(br, bi));
      }

      public TestContext TestContext { get; set; }

      [DataTestMethod]
      [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                  @"|DataDirectory|\TestMultiplication.csv",
                  "TestMultiplication#csv",
                  DataAccessMethod.Sequential)]
      public void Test_Multiply_DataSource_CSV()
      {
         var ar = Convert.ToDouble(TestContext.DataRow["ar"]);
         var ai = Convert.ToDouble(TestContext.DataRow["ai"]);
         var br = Convert.ToDouble(TestContext.DataRow["br"]);
         var bi = Convert.ToDouble(TestContext.DataRow["bi"]);
         var er = Convert.ToDouble(TestContext.DataRow["er"]);
         var ei = Convert.ToDouble(TestContext.DataRow["ei"]);

         Assert.AreEqual(
            new Complex(er, ei),
            new Complex(ar, ai) * new Complex(br, bi));
      }

      [DataTestMethod]
      [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                  @"|DataDirectory|\TestMultiplication.xml",
                  "row",
                  DataAccessMethod.Sequential)]
      public void Test_Multiply_DataSource_XML()
      {
         var ar = Convert.ToDouble(TestContext.DataRow["ar"]);
         var ai = Convert.ToDouble(TestContext.DataRow["ai"]);
         var br = Convert.ToDouble(TestContext.DataRow["br"]);
         var bi = Convert.ToDouble(TestContext.DataRow["bi"]);
         var er = Convert.ToDouble(TestContext.DataRow["er"]);
         var ei = Convert.ToDouble(TestContext.DataRow["ei"]);

         Assert.AreEqual(
            new Complex(er, ei),
            new Complex(ar, ai) * new Complex(br, bi));
      }

      [DataTestMethod]
      [DataSource("System.Data.Odbc",
                  @"Dsn=Excel Files;DriverID=790;dbq=|DataDirectory|\TestMultiplication.xlsx",
                  "Multiply$",
                  DataAccessMethod.Sequential)]
      public void Test_Multiply_DataSource_Excel()
      {
         var ar = Convert.ToDouble(TestContext.DataRow[0]);
         var ai = Convert.ToDouble(TestContext.DataRow[1]);
         var br = Convert.ToDouble(TestContext.DataRow[2]);
         var bi = Convert.ToDouble(TestContext.DataRow[3]);
         var er = Convert.ToDouble(TestContext.DataRow[4]);
         var ei = Convert.ToDouble(TestContext.DataRow[5]);

         Assert.AreEqual(
            new Complex(er, ei),
            new Complex(ar, ai) * new Complex(br, bi));
      }

      [DataTestMethod]
      [DataSource("System.Data.SqlClient",
                  "Data Source=<servername>;Initial Catalog=ComplexTests;Integrated Security=True",
                  "Multiply",
                  DataAccessMethod.Sequential)]
      public void Test_Multiply_DataSource_SQL()
      {
         var ar = Convert.ToDouble(TestContext.DataRow["ar"]);
         var ai = Convert.ToDouble(TestContext.DataRow["ai"]);
         var br = Convert.ToDouble(TestContext.DataRow["br"]);
         var bi = Convert.ToDouble(TestContext.DataRow["bi"]);
         var er = Convert.ToDouble(TestContext.DataRow["er"]);
         var ei = Convert.ToDouble(TestContext.DataRow["ei"]);

         Assert.AreEqual(
            new Complex(er, ei),
            new Complex(ar, ai) * new Complex(br, bi));
      }

      // ----

      [DataTestMethod]
      [DataSource("CSVDataSource")]
      public void Test_Multiply_DataSource_CSV_AppSettings()
      {
         var ar = Convert.ToDouble(TestContext.DataRow["ar"]);
         var ai = Convert.ToDouble(TestContext.DataRow["ai"]);
         var br = Convert.ToDouble(TestContext.DataRow["br"]);
         var bi = Convert.ToDouble(TestContext.DataRow["bi"]);
         var er = Convert.ToDouble(TestContext.DataRow["er"]);
         var ei = Convert.ToDouble(TestContext.DataRow["ei"]);

         Assert.AreEqual(
            new Complex(er, ei),
            new Complex(ar, ai) * new Complex(br, bi));
      }

      [DataTestMethod]
      [DataSource("XMLDataSource")]
      public void Test_Multiply_DataSource_XML_AppSettings()
      {
         var ar = Convert.ToDouble(TestContext.DataRow["ar"]);
         var ai = Convert.ToDouble(TestContext.DataRow["ai"]);
         var br = Convert.ToDouble(TestContext.DataRow["br"]);
         var bi = Convert.ToDouble(TestContext.DataRow["bi"]);
         var er = Convert.ToDouble(TestContext.DataRow["er"]);
         var ei = Convert.ToDouble(TestContext.DataRow["ei"]);

         Assert.AreEqual(
            new Complex(er, ei),
            new Complex(ar, ai) * new Complex(br, bi));
      }

      [DataTestMethod]
      [DataSource("EXLDataSource")]
      public void Test_Multiply_DataSource_Excel_AppSettings()
      {
         var ar = Convert.ToDouble(TestContext.DataRow[0]);
         var ai = Convert.ToDouble(TestContext.DataRow[1]);
         var br = Convert.ToDouble(TestContext.DataRow[2]);
         var bi = Convert.ToDouble(TestContext.DataRow[3]);
         var er = Convert.ToDouble(TestContext.DataRow[4]);
         var ei = Convert.ToDouble(TestContext.DataRow[5]);

         Assert.AreEqual(
            new Complex(er, ei),
            new Complex(ar, ai) * new Complex(br, bi));
      }

      [DataTestMethod]
      [DataSource("SQLDataSource")]
      public void Test_Multiply_DataSource_SQL_AppSettings()
      {
         var ar = Convert.ToDouble(TestContext.DataRow["ar"]);
         var ai = Convert.ToDouble(TestContext.DataRow["ai"]);
         var br = Convert.ToDouble(TestContext.DataRow["br"]);
         var bi = Convert.ToDouble(TestContext.DataRow["bi"]);
         var er = Convert.ToDouble(TestContext.DataRow["er"]);
         var ei = Convert.ToDouble(TestContext.DataRow["ei"]);

         Assert.AreEqual(
            new Complex(er, ei),
            new Complex(ar, ai) * new Complex(br, bi));
      }
   }
}
