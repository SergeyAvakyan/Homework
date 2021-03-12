using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLibrary
{
    public class OneDimensionalArrays
    {
        public static int GetMinElementArray(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }

        public static int GetMaxElementArray(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }

            }
            return max;
        }

        public static int GetMinIndexElementArray(int[] array)
        {
            int min = array[0];
            int minIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }

        public static int GetMaxIndexElementArray(int[] array)
        {
            int max = array[0];
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

       public static int GetSumOfArrayElementsWithOddIndices(int[] array)
        {
            int sumNotEven = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sumNotEven += array[i];
                }

            }
            return sumNotEven;
        }

       public static int[] GetReverseArray(int[] array)
        {
            {
                int[] result = new int[array.Length];
                int j = 0;
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    result[j] = array[i];
                    j++;
                }
                return result;
            }
        }

        public static int GetNumberOfOddElementsArray(int[] array)
        {
            int notEven = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    notEven++;
                }
            }
            return notEven;
        }
public static int[] GetSwapHalfArray(int[] array)
        {
            int count1 = 0;
            int count2 = array.Length / 2;
            int[] result = new int[array.Length];
            int j = 0;

            while (count1 < array.Length / 2)
            {
                int temp = array[count1];
                array[count1] = array[count2];
                array[count2] = temp;

                count1++;
                count2++;
            }

            for (int i = 0; i < array.Length; i++)
            {
                result[j] = array[i];
                j++;
            }
            return result;
        }

        public static int[] GetBubbleSortAscending(int[] array)
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;

                if (min > array[i])
                {
                    min = array[i];
                }

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                int temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }

            return array;
        }

        public static int[] GetSortByInsertsDescending(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;

                while (j > 0 && array[j] > array[j - 1])
                {
                    int temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;

                    j--;
                }
            }
            return array;
        }
    }
    }
