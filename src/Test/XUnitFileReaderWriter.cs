using HackerRank.Helper;
using Xunit.Abstractions;

namespace HackerRank.UnitTests
{
    public class XUnitFileReaderWriter : TestFileReaderWriter
    {
        private readonly ITestOutputHelper _output;

        public XUnitFileReaderWriter(ITestOutputHelper output, string inputFile = "_input.txt", string outputFile = "_output.txt")
            : base(inputFile, outputFile)
        {
            _output = output;
        }

        public override void WriteLine()
        {
            _output.WriteLine(_currentLine.ToString());
            if (_myOutputReader != null)
            {
                CheckCurrentLine();
                _currentLine.Clear();
            }
            _currentLineNumber++;
        }
    }
}