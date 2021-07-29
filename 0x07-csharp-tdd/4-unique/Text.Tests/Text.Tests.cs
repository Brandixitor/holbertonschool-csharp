using NUnit.Framework;
using Text;

namespace Text.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestNull()
        {
            Assert.AreEqual(-1, Text.Str.UniqueChar(null));
        }
        [Test]
        public void TestFirstLetter()
        {
            Assert.AreEqual(0, Text.Str.UniqueChar("Hello"));
        }
        [Test]
        public void TestNotSameInTheLast()
        {
            Assert.AreEqual(6, Text.Str.UniqueChar("hhhrrrxyzrr"));
        }
        [Test]
        public void TestThirdLetter()
        {
            Assert.AreEqual(2, Text.Str.UniqueChar("llor"));
        }
        [Test]
        public void TestLastLetter()
        {
            Assert.AreEqual(7, Text.Str.UniqueChar("lllllllr"));
        }
        [Test]
        public void TestAllSame()
        {
            Assert.AreEqual(-1, Text.Str.UniqueChar("llllllll"));
        }
    }
}