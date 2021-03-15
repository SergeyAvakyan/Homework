using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLibrary.Tests
{
    class BranchingTests
    {
        [TestCase(2, 1, 3)]
        [TestCase(1, 2, -1)]
        [TestCase(2, 2, 4)]
        public void CalculationAAndB_WhenABPassed_ShouldSumMultiplication(int a, int b, int expected)
        {
            int actual = Branching.CalculationAAndB(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 1, 1)]
        [TestCase(-1, 2, 2)]
        [TestCase(-2, -2, 3)]
        [TestCase(2, -2, 4)]
        public void GetQuarter_WhenABPassed_GetQuarter(int a, int b, int expected)
        {
            int actual = Branching.GetQuarter(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 5, 3, 3, 5, 10)]
        [TestCase(-1, 6, 2, -1, 2, 6)]
        [TestCase(-2, 8, 7, -2, 7, 8)]
        public void SortIncrease_WhenABCPassed_ShouldSortIncrease(int a, int b, int c, int expectedA, int expectedB, int expectedC)
        {
            Branching.SortIncrease(ref a, ref b, ref c);

            int actualA = a;
            int actualB = b;
            int actualC = c;

            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);
            Assert.AreEqual(expectedC, actualC);
        }

        [TestCase(6, 18, 7, new double[] { -0.459, -2.54 })]
        [TestCase(5, 30, 20, new double[] { -0.763, -5.236 })]
        [TestCase(5, 10, 5, new double[] { -1 })]
        public void GetRootsSquareEquation_WhenABCPassed_ShouldRootsSquareEquation(double a, double b, double c, double[] expected)
        {
            double[] actual = Branching.GetRootsSquareEquation(a, b, c);

            Assert.That(actual, Is.EqualTo(expected).Within(3));
        }

        [TestCase(0, 18, 7)]
        public void GetRootsSquareEquation_WhenABCPassed_ShouldDivideByZeroException(double a, double b, double c)
        {
            Assert.Throws<DivideByZeroException>(() => Branching.GetRootsSquareEquation(a, b, c));
        }

        [TestCase(10, "ten")]
        [TestCase(15, "fifteen")]
        [TestCase(25, "twenty five")]
        public void GetUppercaseNumbers_WhenAPassed_ShouldNumberInWords(int number, string expected)
        {
            string actual = Branching.GetUppercaseNumbers(number);

            Assert.AreEqual(expected, actual);
        }
    }
}
