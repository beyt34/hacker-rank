using System;
using Xunit;

namespace HackerRank.Day03
{
    // Day 3: Intro to Conditional Statements
    // https://www.hackerrank.com/challenges/30-conditional-statements/problem
    public static class ConquerConditionals
    {
        public static void Calculate(int n)
        {
            if (n % 2 == 1)
            {
                Console.WriteLine("Weird");
            }
            else switch (n)
            {
                case >= 2 and <= 5:
                    Console.WriteLine("Not Weird");
                    break;
                case >= 6 and <= 20:
                    Console.WriteLine("Weird");
                    break;
                case > 20:
                    Console.WriteLine("Not Weird");
                    break;
                default:
                    Console.WriteLine("Not Weird");
                    break;
            }
        }
    }
    public class ConquerConditionalsTests
    {
        [Theory]
        [InlineData(3)]
        [InlineData(24)]
        public void Test(int n)
        {
            ConquerConditionals.Calculate(n);
        }
    }
}