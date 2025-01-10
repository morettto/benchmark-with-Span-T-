using BenchmarkDotNet.Attributes;

namespace BenchmarkSpan
{
    [MemoryDiagnoser]
    public class ArrayOperations
    {
        private static readonly int[] Array = new int[1000000];

        [Benchmark]
        public void FillArray()
        {
            for (var i = 0; i < Array.Length; i++)
            {
                Array[i] += 11;
            }
        }

        [Benchmark]
        public void FillArrayWithSpan()
        {
            var span = new Span<int>(Array);
            span.Fill(11);
        }

    }
}
