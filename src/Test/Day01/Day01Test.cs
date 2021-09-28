using Xunit;
using Xunit.Abstractions;

namespace HackerRank.UnitTests.Day01
{
    public class Day01Test
    {
        private readonly ITestOutputHelper _output;
        public Day01Test(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Test1()
        {
            const string inputFile = "Day01\\_input.txt";
            const string outputFile = "Day01\\_output.txt";
            using var readerWriter = new XUnitFileReaderWriter(_output, inputFile, outputFile);

            HackerRank.Day01.Program.Solve(readerWriter);
        }
    }
}
