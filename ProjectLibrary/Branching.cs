using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLibrary
{
  public class Branching
    {
        public static int CalculationAAndB(int a, int b)
        {
            int result;
            if (a > b)
            {
                result = a + b;
            }
            else if (a < b)
            {
                result = a - b;
            }
            else
            {
                result = (a * b);
            }

            return result;
        }

        public static int GetQuarter(int x, int y)
        {
            int result = 0;
            if (x > 0 && y > 0)
            {
                result = 1;
            }
            if (x < 0 && y > 0)
            {
                result = 2;
            }
            if (x < 0 && y < 0)
            {
                result = 3;
            }
            if (x > 0 && y < 0)
            {
                result = 4;
            }

            return result;
        }

        public static void SortIncrease(ref int a, ref int b, ref int c)
        {
            int t;
            if (a > b)
            {
                t = a;
                a = b;
                b = t;
            }

            if (a > c)
            {
                t = a;
                a = c;
                c = t;
            }

            if (b > c)
            {
                t = b;
                b = c;
                c = t;
            }
        }

        public static double[] GetRootsSquareEquation(double a, double b, double c)
        {
            if (a == 0)
            {

                throw new DivideByZeroException("a=0");
            }

            double d = b * b - (4 * a * c);
            double[] result;

            if (d > 0)
            {
                result = new[]
                {
                    (-b + Math.Sqrt(d)) / (2 * a),
                    (-b - Math.Sqrt(d)) / (2 * a)
                };
            }
            else if (d == 0)
            {
                result = new[] { -b / (2 * a) };
            }
            else
            {
                result = new double[] { };
            }

            return result;
        }

        public static string GetUppercaseNumbers(int number)
        {
            string result = string.Empty;
            string[] units = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] elevenToNineteen = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number.ToString().Length == 1)
            {
                result = units[number % 10];
            }
            else if (number >= 11 && number <= 19)
            {
                result = elevenToNineteen[number % 10 - 1];
            }
            else if (number % 10 == 0)
            {
                result = tens[number / 10 - 1];
            }
            else
            {
                result = tens[number / 10 - 1] + " " + units[number % 10];
            }

            return result;

        }
    }
}
