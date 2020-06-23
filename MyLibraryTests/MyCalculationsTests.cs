using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;

namespace MyLibraryTests
{
    [TestClass]
    public class MyCalculationsTests
    {
        [TestMethod]
        public void Add_PositiveNumbers_ResultPositive()
        {
            var a = 10;
            var b = 20;

            var result = MyCalculations.Add(a, b);

            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void Add_PositiveAndNegativeNumbers_ResultPositive()
        {
            var a = 10;
            var b = -20;

            var result = MyCalculations.Add(a, b);

            Assert.IsTrue(result > 0);
        }

    }
}
