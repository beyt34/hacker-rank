using System;

namespace HackerRank.Day04
{
    // Day 4: Class vs. Instance
    // https://www.hackerrank.com/challenges/30-class-vs-instance/problem
    public class Person
    {
        public int age;

        public Person(int initialAge)
        {
            if (initialAge < 0)
            {
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
            else
            {
                age = initialAge;
            }
        }

        public void amIOld()
        {
            if (age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }
        }

        public void yearPasses()
        {
            age++;
        }
    }
}