using NUnit.Framework;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using MyMath;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
   

        [Test]
        public void TestCase1(){
            int[,] test = new int[,] { { 2, 4 }, { 6, 8 }, { 10, 12 }, { 24, 40 } };
            Assert.IsNull(MyMath.Matrix.Divide(test, 0));
        }
        [Test]
        public void TestCase2(){
            int[,] test = new int[,] { { 2, 4 }, { 6, 8 }, { 10, 12 }, { 24, 40 } };
            Assert.AreEqual(new int[,] {{1, 2}, {3, 4}, {5, 6}, {12, 20}}, MyMath.Matrix.Divide(test, 2));
        }
        [Test]
        public void TestCase3(){
            Assert.IsNull(MyMath.Matrix.Divide(null, 2));
        }
    }
}