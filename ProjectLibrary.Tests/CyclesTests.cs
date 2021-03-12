using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace ProjectLibrary.Tests
{
    class CyclesTests
    {
        [TestCase(4, 2, 16)]
        [TestCase(2, 2, 4)]
        [TestCase(7, 3, 343)]
        [TestCase(8, 3, 512)]
        public void GetADegreeB_WhenABPassed_ShouldADegreeB(int a, int b, int expected)
        {
            int actual = Сycles.GetADegreeB(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(100, new int[] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 })]

        public void GetDividedByA_WhenABPassed_ShouldDividedByA(int a, int[] expected)
        {
            int[] actual = Сycles.GetDividedByA(a);

            Assert.AreEqual(expected, actual);
        }
    }
}
