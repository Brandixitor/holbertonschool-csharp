using NUnit.Framework;
using MyMath;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(0, MyMath.Operations.Max(new List<int>()));
        }
        [Test]
        public void Test2()
        {
            List<int> myList = new List<int>() { 1, 2, 5, 10, 50 };
            Assert.AreEqual(50, MyMath.Operations.Max(myList));
        }
        [Test]
        public void Test3()
        {
            List<int> myList = new List<int>() { -100, -50, -1 };
            Assert.AreEqual(-1, MyMath.Operations.Max(myList));
        }
        [Test]
        public void Test4()
        {
            List<int> myList = new List<int>() { 1 };
            Assert.AreEqual(1, MyMath.Operations.Max(myList));
        }
        [Test]
        public void Test5()
        {
            List<int> myList = new List<int>() { -1, 0 };
            Assert.AreEqual(0, MyMath.Operations.Max(myList));
        }
        [Test]
        public void Test6()
        {
            Assert.AreEqual(0, MyMath.Operations.Max(null));
        }
    }
}