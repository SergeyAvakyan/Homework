using System;

namespace ProjectLibrary
{
    public class Variables
    {
        public static double GetEquation(int a, int b)
        {
            if ((b - a) != 0)
            {
                return (double)(5 * a + b * b) / (b - a);
            }

            throw new DivideByZeroException("B should not be equal to A");
        }

        public static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        public static (int c, int d) GetDivisionAndRemainder(int a, int b)
        {
            int c = a / b;
            int d = a % b;
            return (c, d);
        }

        public static double GetSquareEquation(int a, int b, int c)
        {
            if (a != 0)
            {
                double result = Math.Round((double)(c - b) / a, 2);
                return result;
            }

            throw new DivideByZeroException("A=0");
        }

        public static (double k, double b) GetStraightEquation(int x1, int y1, int x2, int y2)
        {
            if (x1 == x2 && (x1 - x2 == 0))
            {
                throw new DivideByZeroException("x1-x2=0");
            }

            double k = Math.Round((double)((y1 - y2) / (x1 - x2)), 2);
            double b = Math.Round(y2 - k * x2, 2);

            return (k, b);
        }
    }
}
