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
                    bool isIndex = true;
                    for (int di = -1; di <= 1; di++)
                    {
                        for (int dj = -1; dj <= 1; dj++)
                        {
                            if ((i + di) >= 0 && (i = di) < array.GetLength(0) && (j + dj) >= 0 && (j + dj) < array.GetLength(1) && !(di == 0 && dj == 0))
                            {
                                if (array[i, j] > array[i + di, j + dj])
                                {

                                }
                                else
                                {
                                    isIndex = false;
                                    break;
                                }
                            }
                        }
                    }
                    if (isIndex)
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
    


