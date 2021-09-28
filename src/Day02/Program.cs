using System;
using System.Diagnostics;
using HackerRank.Helper;

namespace HackerRank.Day02
{
    public static class Program
    {
        private static int Result(double mealCost, int tipPercent, int taxPercent)
        {
            var total = Convert.ToInt32(
                mealCost +
                (mealCost * tipPercent / 100) +
                (mealCost * taxPercent / 100)
            );

            return total;
        }

        public static void Solve(IReaderWriter readerWriter)
        {
            var mealCost = readerWriter.ReadLineToDouble();
            var tipPercent = readerWriter.ReadLineToInt();
            var taxPercent = readerWriter.ReadLineToInt();

            var total = Result(mealCost, tipPercent, taxPercent);
            readerWriter.WriteLine(total);
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
