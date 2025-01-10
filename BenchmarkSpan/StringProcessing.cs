using BenchmarkDotNet.Attributes;

namespace BenchmarkSpan
{
    [MemoryDiagnoser]
    public class StringProcessing
    {
        private const string OriginalString = "Bem vindos ao Canal do Daniel Jesus!";

        [Benchmark]
        public void ExtractNumbers()
        {
            var subString = OriginalString.Substring(7, 5);
        }

        [Benchmark]
        public void ExtractNumbersWithSpan()
        {
            var subString = OriginalString.AsSpan().Slice(7, 5);

        }

    }
}
