using Microsoft.VisualStudio.TestTools.UnitTesting;
using ex5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        [TestMethod()]
        public void SumTest()
        {
            Assert.IsTrue(ArrayCalcs.Sum(new double[] { 5, 5 }) == 10);
        }

        [TestMethod()]
        public void AverageTest()
        {
            Assert.IsTrue(ArrayCalcs.Average(new double[] { 5, 10, 15 }) == 10);
        }

        [TestMethod()]
        public void MinTest()
        {
            Assert.IsTrue(ArrayCalcs.Min(new double[] { 5, 500, 5000 }) == 5);
        }

        [TestMethod()]
        public void MaxTest()
        {
            Assert.IsTrue(ArrayCalcs.Max(new double[] { -5, 0, 5 }) == 5);
        }
    }
}