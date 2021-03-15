using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLibrary
{
   public class TwoDimensionalArrays
    {
        public static int GetMinElementTwoDimensionalArray(int[,] array)
        {
            int min = array[0, 0];

            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                        min = array[i, j];
                }
            }

            return min;
        }

        public static int GetMaxElementTwoDimensionalArray(int[,] array)
        {
            int max = array[0, 0];

            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                        max = array[i, j];
                }
            }

            return max;
        }



        public static int[] GetMinIndexElementTwoDimensionalArray(int[,] array)
        {
            int indexI = 0;
            int indexJ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[indexI, indexJ] > array[i, j])
                    {
                        indexI = i;
                        indexJ = j;
                    }
                }
            }

            return new int[] { indexI, indexJ };
        }

        public static int[] GetMaxIndexElementTwoDimensionalArray(int[,] array)
        {
            int indexI = 0;
            int indexJ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[indexI, indexJ] < array[i, j])
                    {
                        indexI = i;
                        indexJ = j;
                    }
                }
            }

            return new int[] { indexI, indexJ };
        }

        public static int GetNumberArrayElementsLargerAllNeighbors(int[,] array)
        {
            int count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i <= 0 || array[i, j] > array[i - 1, j])
                        && (i >= array.GetLength(0) - 1 || array[i + 1, j] < array[i, j])
                        && (j <= 0 || array[i, j - 1] < array[i, j])
                        && (j >= array.GetLength(1) - 1 || array[i, j + 1] < array[i, j]))

                    {
                        count++;
                    }
                }
            }
            return count;
        }
 
            public static int[,] GetDisplayArrayMainDiagonal(int[,] array)
            {
                int[,] array2 = new int[array.GetLength(1), array.GetLength(0)];

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array2[j, i] = array[i, j];
                    }
                }
                return array2;
            }
        }
}
    


