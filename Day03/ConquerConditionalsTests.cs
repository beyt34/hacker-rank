using Xunit;

namespace HackerRank.Day03
{
    public class ConquerConditionalsTests
    {
        [Fact]
        public void Sample_01()
        {
            var actual = "Weird";
            var n = 3;

            var expected = ConquerConditionals.Calculate(n);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Sample_02()
        {
            var actual = "Not Weird";
            var n = 24;

            var expected = ConquerConditionals.Calculate(n);
            Assert.Equal(expected, actual);
        }
    }
}