using BenchmarkDotNet.Attributes;

namespace Dotnet8Bench
{
    public class ArrayBenchmark
    {
        private int[] arr1 = [1, 2, 3];
        private int[] arr2 = [1, 2, 3];

        [Benchmark]
        public int[] Concat()
        {
            return arr1.Concat(arr2).ToArray();
        }

        [Benchmark]
        public int[] ConcatWithSpread()
        {
            return [.. arr1, .. arr2];
        }
    }
}
