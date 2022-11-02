using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldApp.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp.Web.Tests
{
    [TestClass()]
    public class MathOperationsTests
    {
        [TestMethod()]
        public void AddTest()
        {
            MathOperations bm = new MathOperations();
            double res = bm.Add(10, 10);
            Assert.AreEqual(res, 20);

        }

        [TestMethod()]
        public void SubtractTest()
        {
            MathOperations bm = new MathOperations();
            double res = bm.Subtract(10, 10);
            Assert.AreEqual(res, 0);
        }

        [TestMethod()]
        public void DivideTest()
        {
            MathOperations bm = new MathOperations();
            double res = bm.Divide(10, 5);
            Assert.AreEqual(res, 2);

        }

        [TestMethod()]
        public void MultiplyTest()
        {
            MathOperations bm = new MathOperations();
            double res = bm.Multiply(10, 5);
            Assert.AreEqual(res, 50);
        }
    }
}