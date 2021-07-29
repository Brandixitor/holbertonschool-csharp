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
            Assert.AreEqual(0, Text.Str.CamelCase(null));
        }
        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, Text.Str.CamelCase("Hello"));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(2, Text.Str.CamelCase("Hello World"));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(3, Text.Str.CamelCase("Hello my Friend Hello"));
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual(1, Text.Str.CamelCase("Hello"));
        }
        [Test]
        public void Test5(){
            Assert.AreEqual(1, Text.Str.CamelCase("123"));
        }
        [Test]
        public void Test6(){
            Assert.AreEqual(2, Text.Str.CamelCase("123 Hi"));
        }
        [Test]
        public void Test7(){
            Assert.AreEqual(1, Text.Str.CamelCase("123 123"));
        }
        [Test]
        public void Test8(){
            Assert.AreEqual(0, Text.Str.CamelCase(""));
        }
        [Test]
        public void Test9(){
            Assert.AreEqual(1, Text.Str.CamelCase("lol lol lol lol"));
        }
        [Test]
        public void Test10(){
            Assert.AreEqual(7, Text.Str.CamelCase("Test My Words Please, How It Works"));
        }
        [Test]
        public void Test11(){
            Assert.AreEqual(3, Text.Str.CamelCase(" TeST"));
        }
        [Test]
        public void Test12(){
            Assert.AreEqual(1, Text.Str.CamelCase("          Test"));
        }
        [Test]
        public void Test13(){
            Assert.AreEqual(2, Text.Str.CamelCase("Test m f Friend"));
        }
        [Test]
        public void Test14(){
            Assert.AreEqual(5, Text.Str.CamelCase("helloWorldIAmHere"));
        }
    }
}