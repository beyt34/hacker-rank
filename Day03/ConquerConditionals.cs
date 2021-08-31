namespace HackerRank.Day03
{
    // Day 3: Intro to Conditional Statements
    // https://www.hackerrank.com/challenges/30-conditional-statements/problem
    public static class ConquerConditionals
    {
        public static string Calculate(int n)
        {
            if (n % 2 == 1)
            {
             
                return "Weird";
            }

            if (n >= 2 && n <= 5)
            {
                return "Not Weird";
            }

            if (n >= 6 && n <= 20)
            {
                return "Weird";
            }

            if (n > 20)
            {
                return "Not Weird";
            }

            return "Not Weird";
        }
    }
}