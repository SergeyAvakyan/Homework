using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLibrary
{
    public class Сycles
    {
        public static int GetADegreeB(int a, int b)
        {
            int c = a;

            for (int i = 1; i < b; i++)
            {
                c *= a;
            }

            return c;
        }

        public static int[] GetDividedByA(int a)
        {
            int[] array = new int[1000 / a];
            int j = 0;

            if (a == 0)
            {
                throw new DivideByZeroException("A should not be equal to 0");
            }

            for (int i = a; i <= 1000; i += a)
            {
                array[j] = i;
                ++j;
            }

            return array;
        }

        public static int GetSquareLessA(int a)
        {
            int count = 0;

            for (int i = 1; i < a; i++)
            {
                if ((i * i) < a)
                {
                    ++count;
                }
            }

            return count;
        }

        public static int GetGreatestDivisorA(int a)
        {
            int b = 0;

            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    b = i;
                }
            }

            return b;
        }

        public static int GetSumAllDividedBy7(int a, int b)
        {
            int c = 7;
            int sum = 0;

            for (int i = a; i < b; i++)
            {
                if (i % c == 0 && a < b)
                {
                    sum += i;
                }

            }

            return sum;
        }

        public static int GetFibonacciNumber(int n)
        {
            int a = 0;
            int b = 1;
            int tmp;

            for (int i = 1; i < n; i++)
            {
                tmp = a;
                a = b;
                b += tmp;
            }

            return b;
        }

        public static int GetGreatestDivisorEuclideanMethod(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            return a;
        }

        public static int GetNBinarySearch(int a)
        {
            int left = 0;
            int right = a;
            int middle = right;
            int result = 0;
            int cub = 0;

            while (cub != a)
            {
                cub = middle * middle * middle;
                if (a < cub)
                {
                    right = middle;
                }
                else if (a > cub)
                {
                    left = middle;
                }
                else if (a == cub)
                {
                    result = middle;
                    break;
                }

                middle = (left + right) / 2;
            }

            return result;
        }

        public static int GetNumberOfOddDigits(int a)
        {
            int notEven = 0;

            while (a != 0)
            {
                if (a % 2 != 0)
                {
                    notEven++;
                }
                a /= 10;
            }

            return notEven;
        }

        public static int GetMirrorNumberA(int a)
        {
            int resultNumber = 0;

            while (a != 0)
            {
                resultNumber += a % 10;
                resultNumber *= 10;
                a /= 10;
            }

            resultNumber /= 10;
            return resultNumber;
        }

       
        public static int[] GetNumbersSumOfEvenMore(int a)
        {
            int sumEven = 0;
            int sumNotEven = 0;
            int result;
            int count = 0;

            for (int i = 1; i < a; i++)
            {
                int temp = i;
                while (temp > 0)
                {
                    result = temp % 10;
                    if (result % 2 == 0)
                    {
                        sumEven += result;
                    }
                    else
                    {
                        sumNotEven += result;
                    }
                    temp /= 10;
                }
                if (sumEven > sumNotEven)
                {
                  ++count;
                }

                sumEven = 0;
                sumNotEven = 0;

            }
            int[] array=new int[count];
            int j = 0;
            for (int i = 1; i < a; i++)
            {
                int temp = i;
                while (temp > 0)
                {
                    result = temp % 10;
                    if (result % 2 == 0)
                    {
                        sumEven += result;
                    }
                    else
                    {
                        sumNotEven += result;
                    }
                    temp /= 10;
                }
                if (sumEven > sumNotEven)
                {
                    array[++j]=i;
                }

                sumEven = 0;
                sumNotEven = 0;
            }

            return array;
        }

        public static bool GetIdenticalDigitsNumbers(string a, string b)
        {
            bool ask = false;
            bool result = false;
            foreach (var item in a)
            {
                foreach (var item2 in b)
                {
                    if (item == item2)
                    {
                        ask = true;
                        break;
                    }

                }

            }
            if (ask)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
