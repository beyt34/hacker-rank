using System;
using System.Diagnostics;
using HackerRank.Helper;

namespace HackerRank.Day00
{
    public class Program
    {
        public static void Solve(IReaderWriter readerWriter)
        {
            // Declare a variable named 'inputString' to hold our input.
            // Read a full line of input from stdin (cin) and save it to our variable, input_string.
            var inputString = readerWriter.ReadLine();
            
            // Print a string literal saying "Hello, World." to stdout using cout.
            Console.WriteLine("Hello, World.");

            // Write a line of code here that prints the contents of input_string to stdout.
            Console.WriteLine(inputString);
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
