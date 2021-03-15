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
        [TestCase(200, new int[] { 200, 400, 600, 800, 1000 })]
        [TestCase(500, new int[] { 500, 1000 })]

        public void GetDividedByA_WhenABPassed_ShouldDividedByA(int a, int[] expected)
        {
            int[] actual = Сycles.GetDividedByA(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 1)]
        [TestCase(10, 3)]
        [TestCase(17, 4)]
        [TestCase(1, 0)]
        public void GetSquareLessA_WhenABPassed_ShouldAmountOfNumberSquareLessA(int a, int expected)
        {
            int actual = Сycles.GetSquareLessA(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(50, 25)]
        [TestCase(100, 50)]
        [TestCase(150, 75)]
        [TestCase(10, 5)]
        public void GetGreatestDivisorA_WhenAPassed_ShouldGreatestDivisor(int a, int expected)
        {
            int actual = Сycles.GetGreatestDivisorA(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 10, 7)]
        [TestCase(1, 20, 21)]
        [TestCase(2, 23, 42)]
        public void GetSumAllDividedBy7_WhenAPassed_ShouldSumAllDividedBy7(int a, int b, int expected)
        {
            int actual = Сycles.GetSumAllDividedBy7(a, b);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(3, 2)]
        [TestCase(5, 5)]
        [TestCase(7, 13)]
        [TestCase(10, 55)]

        public void GetFibonacciNumber_WhenNPassed_ShouldFibonacciNumber(int n, int expected)
        {
            int actual = Сycles.GetFibonacciNumber(n);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(20, 10, 10)]
        [TestCase(100, 150, 50)]
        [TestCase(40, 10, 10)]
        [TestCase(20, 20, 20)]

        public void GetGreatestDivisorEuclideanMethod_WhenABPassed_ShouldGreatestDivisorEuclideanMethod(int a, int b, int expected)
        {
            int actual = Сycles.GetGreatestDivisorEuclideanMethod(a, b);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(8, 2)]
        [TestCase(729, 9)]
        [TestCase(216, 6)]
        [TestCase(64, 4)]
        public void GetNBinarySearch_WhenAPassed_ShouldNBinarySearch(int a, int expected)
        {
            int actual = Сycles.GetNBinarySearch(a);

            Assert.AreEqual(expected, actual);

        }
        [TestCase(125, 2)]
        [TestCase(422, 0)]
        [TestCase(379, 3)]
        [TestCase(7913, 4)]
        public void GetNumberOfOddDigits_WhenAPassed_ShouldNumberOfOddDigits(int a, int expected)
        {
            int actual = Сycles.GetNumberOfOddDigits(a);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(125, 521)]
        [TestCase(789, 987)]
        [TestCase(643, 346)]
        [TestCase(654321, 123456)]
        public void GetMirrorNumberA_WhenAPassed_ShouldMirrorNumberA(int a, int expected)
        {
            int actual = Сycles.GetMirrorNumberA(a);

            Assert.AreEqual(expected, actual);

        }
        [TestCase(10, new int[] { 2, 4, 6, 8 })]
        [TestCase(12, new int[] { 2, 4, 6, 8 })]
        [TestCase(20, new int[] { 2, 4, 6, 8, 12, 14, 16, 18 })]

        public void GetNumbersSumOfEvenMore_WhenAPassed_ShouldNumbersSumOfEvenMore(int a, int[] expected)
        {
            int[] actual = Сycles.GetNumbersSumOfEvenMore(a);

            Assert.AreEqual(expected, actual);

        }

        [TestCase("125", "521", true)]
        [TestCase("331", "189", true)]
        [TestCase("307", "518", false)]
        [TestCase("002", "734", false)]
        public void GetIdenticalDigitsNumbers_WhenABPassed_ShouldСonfirmationIdenticalDigitsNumbers(string a, string b, bool expected)
        {
            bool actual = Сycles.GetIdenticalDigitsNumbers(a, b);

            Assert.AreEqual(expected, actual);

        }
    }
}
