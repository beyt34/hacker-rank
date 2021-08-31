using Xunit;

namespace HackerRank.Day04
{
    public class PersonTests
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(10)]
        [InlineData(16)]
        [InlineData(18)]
        public void Test(int initialAge)
        {
            var person = new Person(initialAge);
            person.amIOld();
            for (var j = 0; j < 3; j++)
            {
                person.yearPasses();
            }
            person.amIOld();
        }
    }
}