using System;
using System.Diagnostics;
using HackerRank.Helper;

namespace HackerRank.Day01
{
    public class Program
    {
        public static void Solve(IReaderWriter readerWriter)
        {
            var i = 4;
            var d = 4.0;
            var s = "HackerRank ";

            // Read and save an integer, double, and String to your variables.
            var ii = readerWriter.ReadLineToInt();
            var dd = readerWriter.ReadLineToDouble();
            var ss = readerWriter.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + ii);

            // Print the sum of the double variables on a new line.
            Console.WriteLine((d + dd).ToString("N1"));

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + ss);
        }

        public static void Main(string[] args)
        {
            IReaderWriter readerWriter = null;
            try
            {
                if (Debugger.IsAttached)
                {
                    readerWriter = new TestFileReaderWriter();
                }
                else
                {
                    // console output
                    readerWriter = new ConsoleReaderWriter();
                }

                Solve(readerWriter);

                if (Debugger.IsAttached)
                {
                    Console.WriteLine("Finished!");
                    //Console.ReadKey();
                }
            }
            finally
            {
                readerWriter?.Dispose();
            }
        }
    }
}
