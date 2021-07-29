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
        public void StringIsNull()
        {
            Assert.IsFalse(Text.Str.IsPalindrome(null));
        }
        [Test]
        public void EmptyString()
        {
            Assert.IsTrue(Text.Str.IsPalindrome(""));
        }
        [Test]
        public void ContainsRacecar()
        {
            Assert.IsTrue(Text.Str.IsPalindrome("Racecar"));
        }
        [Test]
        public void ContainsOneCharacter()
        {
            Assert.IsTrue(Text.Str.IsPalindrome("r"));
        }
        [Test]
        public void ContainsLevel()
        {
            Assert.IsTrue(Text.Str.IsPalindrome("level"));
        }
        [Test]
        public void ContainsHbExample()
        {
            Assert.IsTrue(Text.Str.IsPalindrome("A man, a plan, a canal: Panama"));
        }
    }
}