using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [Test, TestCaseSource("DivideCases")]
        public void Test1(int x, int y, int z)
        {
            int temp = Calc.Plus(x, y);
            Assert.AreEqual(z,temp);
        }
        static object[] DivideCases =
        {
            new object[]{12,8,20},
            new object[]{11,11,22},
            new object[]{40,10,51},
            new object[]{10,10,20},
        };
        [Test, TestCaseSource("DivideCases1")]
        public void Test2(int x, int y, int z)
        {
            int temp = Calc.Minus(x, y);
            Assert.AreEqual(z, temp);
        }
        static object[] DivideCases1 =
        {
            new object[]{30,30,0},
            new object[]{11,11,0},
            new object[]{40,10,30},
            new object[]{3,10,-7},
        };
        [Test, TestCaseSource("DivideCases2")]
        public void Test3(int x, int y, int z)
        {
            int temp = Calc.Mult(x, y);
            Assert.AreEqual(z, temp);
        }
        static object[] DivideCases2 =
        {
            new object[]{3,3,9},
            new object[]{22,0,0},
            new object[]{11,1,11},
            new object[]{20,0,20},
        };
        [Test, TestCaseSource("DivideCases3")]
        public void Test4(int x, int y, int z)
        {
            int temp = Calc.Div(x, y);
            Assert.AreEqual(z, temp);
        }
        static object[] DivideCases3 =
        {
            new object[]{30,30,1},
            new object[]{4,0,0},
            new object[]{4,0,null},
            new object[]{9,-3,-3},
        };
    }
}