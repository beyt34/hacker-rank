using Xunit;
using Xunit.Abstractions;

namespace HackerRank.UnitTests.Day02
{
    public class Day02Test
    {
        private readonly ITestOutputHelper _output;
        public Day02Test(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Test1()
        {
            const string inputFile = "Day02\\_input1.txt";
            const string outputFile = "Day02\\_output1.txt";
            using var readerWriter = new XUnitFileReaderWriter(_output, inputFile, outputFile);

            HackerRank.Day02.Program.Solve(readerWriter);
        }

        [Fact]
        public void Test2()
        {
            const string inputFile = "Day02\\_input2.txt";
            const string outputFile = "Day02\\_output2.txt";
            using var readerWriter = new XUnitFileReaderWriter(_output, inputFile, outputFile);

            HackerRank.Day02.Program.Solve(readerWriter);
        }
    }
}
