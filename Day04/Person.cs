using System;
using Xunit;

namespace HackerRank.Day04
{
    // Day 4: Class vs. Instance
    // https://www.hackerrank.com/challenges/30-class-vs-instance/problem
    public class Person
    {
        private int _age;

        public Person(int initialAge)
        {
            if (initialAge < 0)
            {
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
            else
            {
                _age = initialAge;
            }
        }

        public void AmIOld()
        {
            if (_age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (_age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }
        }

        public void YearPasses()
        {
            _age++;
        }
    }

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
            person.AmIOld();
            for (var j = 0; j < 3; j++)
            {
                person.YearPasses();
            }
            person.AmIOld();
        }
    }
}