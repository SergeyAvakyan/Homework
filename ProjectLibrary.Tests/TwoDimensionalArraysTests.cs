using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace ProjectLibrary.Tests
{
    class TwoDimensionalArraysTests
    {
        [TestCase(1, 0)]
        [TestCase(2, 1)]
        [TestCase(3, 1)]

        public void GetMinElementTwoDimensionalArray_WhenDoubleArrayPassed_ShouldMinElementDoubleArray(int mockNumber, int expected)
        {
            int[,] array = DoubleArrayMock.GetMock(mockNumber);

            int actual = TwoDimensionalArrays.GetMinElementTwoDimensionalArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 9)]
        [TestCase(2, 7)]
        [TestCase(3, 9)]

        public void GetMaxElementTwoDimensionalArray_WhenDoubleArrayPassed_ShouldMaxElementDoubleArray(int mockNumber, int expected)
        {
            int[,] array = DoubleArrayMock.GetMock(mockNumber);

            int actual = TwoDimensionalArrays.GetMaxElementTwoDimensionalArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 2, 0 })]
        [TestCase(2, new int[] { 2, 0 })]
        [TestCase(3, new int[] { 2, 2 })]

        public void GetMinIndexElementTwoDimensionalArray_WhenDoubleArrayPassed_ShouldMinIndexDoubleArray(int mockNumber, int[] expected)
        {
            int[,] array = DoubleArrayMock.GetMock(mockNumber);

            int[] actual = TwoDimensionalArrays.GetMinIndexElementTwoDimensionalArray(array);

            Assert.AreEqual(expected, actual);
        }
    
    [TestCase(1, new int[] { 2, 2 })]
    [TestCase(2, new int[] { 1, 0 })]
    [TestCase(3, new int[] { 1, 1 })]

    public void GetMaxIndexElementTwoDimensionalArray_WhenDoubleArrayPassed_ShouldMaxIndexDoubleArray(int mockNumber, int[] expected)
    {
        int[,] array = DoubleArrayMock.GetMock(mockNumber);

        int[] actual = TwoDimensionalArrays.GetMaxIndexElementTwoDimensionalArray(array);

        Assert.AreEqual(expected, actual);
    }

        [TestCase(1, 2)]
        [TestCase(2, 4)]
        [TestCase(3, 2)]

        public void GetNumberArrayElementsLargerAllNeighbors__WhenDoubleArrayPassed_ShouldNumberArrayElementsLargerAllNeighbors(int mockNumber, int expected)
        {
            int[,] array = DoubleArrayMock.GetMock(mockNumber);

            int actual = TwoDimensionalArrays.GetNumberArrayElementsLargerAllNeighbors(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]

        public void GetDisplayArrayMainDiagonalWhenDoubleArrayPassed_ShouldDisplayArrayMainDiagonal(int mockNumber, int mockExpected)
        {
            int[,] array = DoubleArrayMock.GetMock(mockNumber);
            int[,] expected = DoubleArrayMock.GetMockResult(mockExpected);

            int[,] actual = TwoDimensionalArrays.GetDisplayArrayMainDiagonal(array);

            Assert.AreEqual(expected, actual);
        }
    }

public static class DoubleArrayMock
    {
        public static int[,] GetMock(int number)
        {
            int[,] result = new int[0, 0];
            switch (number)
            {
                case 1:
                    result = new int[,]
                    {
                        {3,2,1 },
                        {6,5,4 },
                        {0,2,9 }
                    };
                    break;

                case 2:
                    result = new int[,]
                    {
                        {3,6,4 },
                        {7,2,6 },
                        {1,3,2 }
                    };
                    break;

                case 3:
                    result = new int[,]
                    {
                        {4,5,6 },
                        {8,9,3 },
                        {3,2,1 }
                    };
                    break;

            }
            return result;
        }

        public static int[,] GetMockResult(int expected)
        {
            int[,] result = new int[0, 0];
            switch (expected)
            {
                case 1:
                    result = new int[,]
                    {
                        {3,6,0 },
                        {2,5,2 },
                        {1,4,9 }
                    };
                    break;

                case 2:
                    result = new int[,]
                    {
                        {3,7,1 },
                        {6,2,3 },
                        {4,6,2 }
                    };
                    break;

                case 3:
                    result = new int[,]
                    {
                        {4,8,3 },
                        {5,9,2 },
                        {6,3,1 }
                    };
                    break;

            }
            return result;
        }
    }
}
