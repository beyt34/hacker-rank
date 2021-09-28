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
            using var readerWriter = new XUnitFileReaderWriter(
                _output,
                "Day01\\_input.txt",
                "Day01\\_output.txt"
                );

            HackerRank.Day01.Program.Solve(readerWriter);
        }
    }
}
