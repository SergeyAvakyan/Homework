using NUnit.Framework;

namespace ProjectLibrary.Tests
{
    public class VariablesTests
    {

        [TestCase(1, 2, 2, 1)]
        [TestCase(5, 2, 2, 5)]
        [TestCase(20, 10, 10, 20)]
        public void Swap_WhenABPassed_ShouldSwapAToBAndBToA(int a, int b, int expectedA, int expectedB)
        {
            Variables.Swap(ref a, ref b);

            int actualA = a;
            int actualB = b;

            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);
        }

        [TestCase(4,2,-12)]
        [TestCase(2, 4, 13)]
        [TestCase(6, 2, -8.5)]
        public void GetEquation_WhenABPassed_ShouldEquation(int a, int b, double expected)
        {
            double actual = Variables.GetEquation(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 5, 2, 0)]
        [TestCase(20, 10, 2, 0)]
        [TestCase(8, 4, 2, 0)]
        public void GetDivisionAndRemainder_WhenABPassed_DivisionAndRemainderCD(int a, int b, int expectedC, int expectedD)
        {
            (int actualC, int actualD) = Variables.GetDivisionAndRemainder(a, b);

            Assert.AreEqual(expectedC, actualC);
            Assert.AreEqual(expectedD, actualD);
        }

        [TestCase(2,4,6,1)]
        [TestCase(4, 6, 2, -1)]
        [TestCase(3, 4, 5, 0.33)]
        
        public void GetSquareEquation_WhenABCPassed_SquareEquation(int a, int b, int c, double expected)
        {
            double actual = Variables.GetSquareEquation(a, b, c);

            Assert.AreEqual(expected,actual);
        }

        [TestCase(2, 1, 4, 3, 1, -1)]
        [TestCase(3, 1, 2, 4, -3, 10)]
        [TestCase(15, 10, 10, 5, 1, -5)]
        public void GetStraightEquation_WhenX1Y1X2Y2Passed_StraightEquationKB(int x1, int y1, int x2, int y2, double expectedK, double expectedB)
        {
            (double actualK, double actualB) = Variables.GetStraightEquation(x1, y1, x2, y2);

            Assert.AreEqual(expectedK, actualK);
            Assert.AreEqual(expectedB, actualB);

        }
        


    }
}
