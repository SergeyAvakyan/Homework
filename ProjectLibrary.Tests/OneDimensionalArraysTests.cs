using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace ProjectLibrary.Tests
{
    class OneDimensionalArraysTests
    {

        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 12)]
        public void GetMinElementArray_WhenArrayPassed_ShouldMinElement(int mockNumber, int expected)
        {
            int[] array = OneDimensionalArraysMock.GetMock(mockNumber);

            int actual = OneDimensionalArrays.GetMinElementArray(array);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(1, 15)]
        [TestCase(2, 36)]
        [TestCase(3, 98)]

        public void GetMaxElementArray_WhenArrayPassed_ShouldMaxElement(int mockNumber, int expected)
        {
            int[] array = OneDimensionalArraysMock.GetMock(mockNumber);

            int actual = OneDimensionalArrays.GetMaxElementArray(array);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(1, 0)]
        [TestCase(2, 6)]
        [TestCase(3, 1)]

        public void GetMinIndexElementArray_WhenArrayPassed_ShouldMinIndex(int mockNumber, int expected)
        {
            int[] array = OneDimensionalArraysMock.GetMock(mockNumber);

            int actual = OneDimensionalArrays.GetMinIndexElementArray(array);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(1, 7)]
        [TestCase(2, 7)]
        [TestCase(3, 7)]

        public void GetMaxIndexElementArray_WhenArrayPassed_ShouldMinIndex(int mockNumber, int expected)
        {
            int[] array = OneDimensionalArraysMock.GetMock(mockNumber);

            int actual = OneDimensionalArrays.GetMaxIndexElementArray(array);

            Assert.AreEqual(expected, actual);

        }



        public static class OneDimensionalArraysMock
        {
            public static int[] GetMock(int number)
            {
                int[] result = new int[0];
                switch (number)
                {
                    case 1:
                        result = new int[] { 2, 5, 6, 7, 10, 8, 9, 15 };
                        break;
                    case 2:
                        result = new int[] { 8, 10, 5, 6, 9, 16, 3, 36 };
                        break;
                    case 3:
                        result = new int[] { 14, 12, 54, 87, 36, 58, 21, 98 };
                        break;
                }
                return result;
            }
        }
    }
}
