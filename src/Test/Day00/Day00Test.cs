using Xunit;
using Xunit.Abstractions;

namespace HackerRank.UnitTests.Day00
{
    public class Day00Test
    {
        private readonly ITestOutputHelper _output;
        public Day00Test(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Test1()
        {
            using var readerWriter = new XUnitFileReaderWriter(
                _output,
                "Day00\\_input.txt",
                "Day00\\_output.txt"
                );

            HackerRank.Day00.Program.Solve(readerWriter);
        }
    }
}
