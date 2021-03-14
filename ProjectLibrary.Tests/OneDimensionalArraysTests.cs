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

        [TestCase(1, 36)]
        [TestCase(2, 17)]
        [TestCase(3, 108)]

        public void GetSumOfArrayElementsWithOddIndice_WhenArrayPassed_ShouldSumOfArrayElementsWithOddIndice(int mockNumber, int expected)
        {
            int[] array = OneDimensionalArraysMock.GetMock(mockNumber);

            int actual = OneDimensionalArrays.GetSumOfArrayElementsWithOddIndices(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 15, 9, 8, 10, 7, 6, 5, 2 })]
        [TestCase(2, new int[] { 36, 3, 16, 9, 6, 5, 10, 8 })]
        [TestCase(3, new int[] { 98, 21, 58, 36, 87, 54, 12, 14 })]

        public void GetReverseArray_WhenArrayPassed_ShouldReverseArray(int mockNumber, int[] expected)
        {
            int[] array = OneDimensionalArraysMock.GetMock(mockNumber);

            int[] actual = OneDimensionalArrays.GetReverseArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 4)]
        [TestCase(2, 3)]
        [TestCase(3, 2)]

        public void GetNumberOfOddElementsArray_WhenArrayPassed_ShouldNumberOfOddElementsArray(int mockNumber, int expected)
        {
            int[] array = OneDimensionalArraysMock.GetMock(mockNumber);

            int actual = OneDimensionalArrays.GetNumberOfOddElementsArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 10, 8, 9, 15, 2, 5, 6, 7 })]
        [TestCase(2, new int[] { 9, 16, 3, 36, 8, 10, 5, 6 })]
        [TestCase(3, new int[] { 36, 58, 21, 98, 14, 12, 54, 87 })]
        public void GetSwapHalfArray_WhenArrayPassed_ShouldSwapHalfArray(int mockNumber, int[] expected)
        {
            int[] array = OneDimensionalArraysMock.GetMock(mockNumber);

            int[] actual = OneDimensionalArrays.GetSwapHalfArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 2, 5, 6, 7, 8, 9, 10, 15 })]
        [TestCase(2, new int[] { 3, 5, 6, 8, 9, 10, 16, 36 })]
        [TestCase(3, new int[] { 12, 14, 21, 36, 54, 58, 87, 98 })]
        public void GetBubbleSortAscending_WhenArrayPassed_ShouldBubbleSortAscending(int mockNumber, int[] expected)
        {
            int[] array = OneDimensionalArraysMock.GetMock(mockNumber);

            int[] actual = OneDimensionalArrays.GetBubbleSortAscending(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 15, 10, 9, 8, 7, 6, 5, 2 })]
        [TestCase(2, new int[] { 36, 16, 10, 9, 8, 6, 5, 3 })]
        [TestCase(3, new int[] { 98, 87, 58, 54, 36, 21, 14, 12 })]


        public void GetSortByInsertsDescending_WhenArrayPassed_ShouldSortByInsertsDescending(int mockNumber, int[] expected)
        {
            int[] array = OneDimensionalArraysMock.GetMock(mockNumber);

            int[] actual = OneDimensionalArrays.GetSortByInsertsDescending(array);

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
